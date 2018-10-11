using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;

namespace D7.ModeledKnowledge.Infrastructure.Formula
{
    public class Result
    {
        public Result()
        {
        }

        public object Value { get; set; }
        public List<string> Messages { get; set; }
    }

    public class ExpressionCalculator : ExpressionBaseVisitor<Result>, IDisposable
    {
        public ExpressionCalculator()
        {
            Initalize();
        }

        public virtual void Initalize()
        {
            VariableProvider = new VariableProvider();
            OperatorProvider = new OperatorProvider();
        }

        public virtual void UnInitalize() { }

        public IVariableProvider VariableProvider { get; set; }

        public IFunctionProvider FunctionProvider { get; set; }

        public IOperatorProvider OperatorProvider { get; set; }

        public Result Evaluate(string formula)
        {
            var stream = new AntlrInputStream(formula);
            var lexer = new ExpressionLexer(stream);
            var tokens = new CommonTokenStream(lexer);
            var parser = new ExpressionParser(tokens);
            var tree = parser.program();

            Result result = Visit(tree);

            return result;
        }

        public override Result VisitOr([NotNull] ExpressionParser.OrContext context)
        {
            Result a = Visit(context.orexpr());

            Result b = Visit(context.andexpr());

            return new Result
            {
                Value = Convert.ToBoolean(a.Value) || Convert.ToBoolean(b.Value)
            };
        }

        public override Result VisitParenthesisANDExpr([NotNull] ExpressionParser.ParenthesisANDExprContext context)
        {
            return Visit(context.bexpr());
        }

        public override Result VisitAnd([NotNull] ExpressionParser.AndContext context)
        {
            Result a = Visit(context.andexpr());

            Result b = Visit(context.bexpr());

            object rlt = Convert.ToBoolean(a.Value) && Convert.ToBoolean(b.Value);

            return new Result
            {
                Value = rlt
            };
        }

        public override Result VisitEqual([NotNull] ExpressionParser.EqualContext context)
        {
            Result a = Visit(context.bexpr());

            Result b = Visit(context.expression());

            object rlt;

            switch(context.op.Type)
            {
                case ExpressionParser.EQUALS:
                    rlt = a.Value.Equals(b.Value);
                    break;
                case ExpressionParser.NOT_EQUALS:
                    rlt = !a.Value.Equals(b.Value);
                    break;
                case ExpressionParser.GTE:
                    rlt = OperatorProvider.BinaryExecute("op_GreaterThanOrEqual", a.Value, b.Value);
                    break;
                case ExpressionParser.GT:
                    rlt = OperatorProvider.BinaryExecute("op_GreaterThan", a.Value, b.Value);
                    break;
                case ExpressionParser.LTE:
                    rlt = OperatorProvider.BinaryExecute("op_LessThanOrEqual", a.Value, b.Value);
                    break;
                default:
                    rlt = OperatorProvider.BinaryExecute("op_LessThanOrEqual", a.Value, b.Value); ;
                    break;
            }

            return new Result
            {
                Value = rlt
            };
        }

        public override Result VisitAdd([NotNull] ExpressionParser.AddContext context)
        {
            Result a = Visit(context.expression());

            Result b = Visit(context.term());

            object rlt = 0;

            if (context.op.Type == ExpressionParser.PLUS)
                rlt = OperatorProvider.BinaryExecute("op_Addition", a.Value, b.Value);
            else
                rlt = OperatorProvider.BinaryExecute("op_Substraction", a.Value, b.Value);

            return new Result
            {
                Value = rlt
            };
        }

        public override Result VisitMult([NotNull] ExpressionParser.MultContext context)
        {
            Result a = Visit(context.term());

            Result b = Visit(context.unary());

            object rlt;

            if (context.op.Type == ExpressionParser.MULT)
                rlt = OperatorProvider.BinaryExecute("op_Multiply", a.Value, b.Value);
            else
                rlt = OperatorProvider.BinaryExecute("op_Division", a.Value, b.Value);

            return new Result
            {
                Value = rlt
            };
        }

        public override Result VisitPlus([NotNull] ExpressionParser.PlusContext context)
        {
            if (context.op != null)
            {
                if (context.op.Type == ExpressionParser.MINUS)
                {
                    Result a = Visit(context.factor());
                    object rlt = OperatorProvider.UnaryExecute("op_UnaryNegation", a.Value); ;

                    return new Result { Value = rlt };
                }
            }

            return Visit(context.factor());
        }

        public override Result VisitFloat([NotNull] ExpressionParser.FloatContext context)
        {
            return new Result { Value = decimal.Parse(context.GetText()) };
        }

        public override Result VisitInt([NotNull] ExpressionParser.IntContext context)
        {
            return new Result { Value = decimal.Parse(context.GetText()) };
        }

        public override Result VisitVariable([NotNull] ExpressionParser.VariableContext context)
        {
            return new Result { Value = VariableProvider[context.GetText()] };
        }

        public override Result VisitParameter([NotNull] ExpressionParser.ParameterContext context)
        {
            ExpressionParser.OrexprContext cxt = context.orexpr();

            Result tmp = null;

            if (cxt!=null)
                tmp = Visit(cxt);

            return new Result { Value = new object[] { tmp == null ? null : tmp.Value } };
        }

        public override Result VisitParameterList([NotNull] ExpressionParser.ParameterListContext context)
        {
            Result a = Visit(context.arguments());

            Result b = Visit(context.orexpr());

            List<object> list = new List<object>();

            list.AddRange(a.Value as object[]);

            list.Add(b.Value);

            return new Result { Value = list.ToArray() };
        }

        public override Result VisitMethod([NotNull] ExpressionParser.MethodContext context)
        {
            Result tmp = Visit(context.arguments());
            object obj = FunctionProvider.Invoke(context.ID().GetText(), tmp.Value as object[]);

            return new Result { Value = obj };
        }

        public override Result VisitString([NotNull] ExpressionParser.StringContext context)
        {
            string tmp = context.GetText();
            tmp = tmp.TrimStart(new char[] { '\"', '\'' });
            tmp = tmp.TrimEnd(new char[] { '\"', '\'' });

            return new Result { Value = tmp };
        }

        public override Result VisitAssign([NotNull] ExpressionParser.AssignContext context)
        {
            Result tmp = Visit(context.statement());

            VariableProvider[context.ID().GetText()] = tmp.Value;
            return tmp;
        }

        public void Dispose()
        {
            UnInitalize();
        }
    }
}
