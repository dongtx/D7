using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Text;
using Antlr4.Runtime.Misc;
using System.IO;

namespace D7.ModeledKnowledge.Infrastructure.Formula
{
    public delegate void SyntaxError(object owner, int line, int charPositionInLine, string msg);

    public class ErrorListener: BaseErrorListener
    {
        public object Owner;

        public event SyntaxError ErrorOutput;

        public override void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            base.SyntaxError(output, recognizer, offendingSymbol, line, charPositionInLine, msg, e);

            if(ErrorOutput!=null)
                ErrorOutput(Owner, line, charPositionInLine, msg);
        }
    }

    public delegate void VisitVariable(string name);

    public delegate void VisitFunc(string name, string[] arguments);

    public class Traveler<E>: ExpressionBaseVisitor<Result>
    {
        public E Owner { get; set; }

        public event SyntaxError ErrorOutput;

        public event VisitVariable OnVariable;

        public event VisitFunc OnFunc;

        internal Result Execute(string formula, out IParseTree tree)
        {
            ErrorListener listener = new ErrorListener();
            listener.Owner = Owner;
            listener.ErrorOutput += ErrorOutput;

            var stream = new AntlrInputStream(formula);
            var lexer = new ExpressionLexer(stream);
            var tokens = new CommonTokenStream(lexer);
            var parser = new ExpressionParser(tokens);
            parser.AddErrorListener(listener);

            tree = parser.program();

            return Visit(tree);
        }

        public void Execute(string formula)
        {
            IParseTree tree;
            Execute(formula, out tree);
        }

        public override Result VisitVariable([NotNull] ExpressionParser.VariableContext context)
        {
            if(OnVariable!=null)
                OnVariable(context.GetText());

            return base.VisitVariable(context);
        }

        public override Result VisitParameter([NotNull] ExpressionParser.ParameterContext context)
        {
            Visit(context.orexpr());

            string tmp = context.GetText();
            tmp = tmp.TrimStart(new char[] { '\"', '\'' });
            tmp = tmp.TrimEnd(new char[] { '\"', '\'' });

            return new Result { Value = new string[] { tmp } };
        }

        public override Result VisitParameterList([NotNull] ExpressionParser.ParameterListContext context)
        {
            Result a = Visit(context.arguments());

            List<string> list = new List<string>();

            list.AddRange(a.Value as string[]);

            string tmp = context.orexpr().GetText();
            tmp = tmp.TrimStart(new char[] { '\"', '\'' });
            tmp = tmp.TrimEnd(new char[] { '\"', '\'' });

            list.Add(tmp);

            Visit(context.orexpr());

            return new Result { Value = list.ToArray() };
        }

        public override Result VisitMethod([NotNull] ExpressionParser.MethodContext context)
        {
            Result tmp = Visit(context.arguments());
            
            if(OnFunc!=null)
                OnFunc(context.ID().GetText(), tmp.Value as string[]);

            return base.VisitMethod(context);
        }

    };
}
