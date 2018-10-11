//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Expression.g4 by ANTLR 4.7.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace D7.ModeledKnowledge.Infrastructure.Formula {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IExpressionListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public partial class ExpressionBaseListener : IExpressionListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>Assign</c>
	/// labeled alternative in <see cref="ExpressionParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssign([NotNull] ExpressionParser.AssignContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Assign</c>
	/// labeled alternative in <see cref="ExpressionParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssign([NotNull] ExpressionParser.AssignContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ParenthesisProgram</c>
	/// labeled alternative in <see cref="ExpressionParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParenthesisProgram([NotNull] ExpressionParser.ParenthesisProgramContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenthesisProgram</c>
	/// labeled alternative in <see cref="ExpressionParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParenthesisProgram([NotNull] ExpressionParser.ParenthesisProgramContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressionParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] ExpressionParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressionParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] ExpressionParser.StatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Or</c>
	/// labeled alternative in <see cref="ExpressionParser.orexpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOr([NotNull] ExpressionParser.OrContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Or</c>
	/// labeled alternative in <see cref="ExpressionParser.orexpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOr([NotNull] ExpressionParser.OrContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ParenthesisORExpr</c>
	/// labeled alternative in <see cref="ExpressionParser.orexpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParenthesisORExpr([NotNull] ExpressionParser.ParenthesisORExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenthesisORExpr</c>
	/// labeled alternative in <see cref="ExpressionParser.orexpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParenthesisORExpr([NotNull] ExpressionParser.ParenthesisORExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>And</c>
	/// labeled alternative in <see cref="ExpressionParser.andexpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnd([NotNull] ExpressionParser.AndContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>And</c>
	/// labeled alternative in <see cref="ExpressionParser.andexpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnd([NotNull] ExpressionParser.AndContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ParenthesisANDExpr</c>
	/// labeled alternative in <see cref="ExpressionParser.andexpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParenthesisANDExpr([NotNull] ExpressionParser.ParenthesisANDExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenthesisANDExpr</c>
	/// labeled alternative in <see cref="ExpressionParser.andexpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParenthesisANDExpr([NotNull] ExpressionParser.ParenthesisANDExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Equal</c>
	/// labeled alternative in <see cref="ExpressionParser.bexpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEqual([NotNull] ExpressionParser.EqualContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Equal</c>
	/// labeled alternative in <see cref="ExpressionParser.bexpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEqual([NotNull] ExpressionParser.EqualContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ParenthesisBExpr</c>
	/// labeled alternative in <see cref="ExpressionParser.bexpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParenthesisBExpr([NotNull] ExpressionParser.ParenthesisBExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenthesisBExpr</c>
	/// labeled alternative in <see cref="ExpressionParser.bexpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParenthesisBExpr([NotNull] ExpressionParser.ParenthesisBExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Add</c>
	/// labeled alternative in <see cref="ExpressionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdd([NotNull] ExpressionParser.AddContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Add</c>
	/// labeled alternative in <see cref="ExpressionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdd([NotNull] ExpressionParser.AddContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ParenthesisExpr</c>
	/// labeled alternative in <see cref="ExpressionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParenthesisExpr([NotNull] ExpressionParser.ParenthesisExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenthesisExpr</c>
	/// labeled alternative in <see cref="ExpressionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParenthesisExpr([NotNull] ExpressionParser.ParenthesisExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Mult</c>
	/// labeled alternative in <see cref="ExpressionParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMult([NotNull] ExpressionParser.MultContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Mult</c>
	/// labeled alternative in <see cref="ExpressionParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMult([NotNull] ExpressionParser.MultContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ParenthesisTerm</c>
	/// labeled alternative in <see cref="ExpressionParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParenthesisTerm([NotNull] ExpressionParser.ParenthesisTermContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenthesisTerm</c>
	/// labeled alternative in <see cref="ExpressionParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParenthesisTerm([NotNull] ExpressionParser.ParenthesisTermContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Plus</c>
	/// labeled alternative in <see cref="ExpressionParser.unary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPlus([NotNull] ExpressionParser.PlusContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Plus</c>
	/// labeled alternative in <see cref="ExpressionParser.unary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPlus([NotNull] ExpressionParser.PlusContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressionParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFactor([NotNull] ExpressionParser.FactorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressionParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFactor([NotNull] ExpressionParser.FactorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressionParser.value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterValue([NotNull] ExpressionParser.ValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressionParser.value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitValue([NotNull] ExpressionParser.ValueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Parameter</c>
	/// labeled alternative in <see cref="ExpressionParser.arguments"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameter([NotNull] ExpressionParser.ParameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Parameter</c>
	/// labeled alternative in <see cref="ExpressionParser.arguments"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameter([NotNull] ExpressionParser.ParameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ParameterList</c>
	/// labeled alternative in <see cref="ExpressionParser.arguments"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameterList([NotNull] ExpressionParser.ParameterListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ParameterList</c>
	/// labeled alternative in <see cref="ExpressionParser.arguments"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameterList([NotNull] ExpressionParser.ParameterListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Variable</c>
	/// labeled alternative in <see cref="ExpressionParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariable([NotNull] ExpressionParser.VariableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Variable</c>
	/// labeled alternative in <see cref="ExpressionParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariable([NotNull] ExpressionParser.VariableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Method</c>
	/// labeled alternative in <see cref="ExpressionParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethod([NotNull] ExpressionParser.MethodContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Method</c>
	/// labeled alternative in <see cref="ExpressionParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethod([NotNull] ExpressionParser.MethodContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Int</c>
	/// labeled alternative in <see cref="ExpressionParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInt([NotNull] ExpressionParser.IntContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Int</c>
	/// labeled alternative in <see cref="ExpressionParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInt([NotNull] ExpressionParser.IntContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Float</c>
	/// labeled alternative in <see cref="ExpressionParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFloat([NotNull] ExpressionParser.FloatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Float</c>
	/// labeled alternative in <see cref="ExpressionParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFloat([NotNull] ExpressionParser.FloatContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>String</c>
	/// labeled alternative in <see cref="ExpressionParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterString([NotNull] ExpressionParser.StringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>String</c>
	/// labeled alternative in <see cref="ExpressionParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitString([NotNull] ExpressionParser.StringContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>OrExpr</c>
	/// labeled alternative in <see cref="ExpressionParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrExpr([NotNull] ExpressionParser.OrExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>OrExpr</c>
	/// labeled alternative in <see cref="ExpressionParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrExpr([NotNull] ExpressionParser.OrExprContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace D7.ModeledKnowledgeINFRA.Expression
