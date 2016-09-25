//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.3.1-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Calculator.g4 by ANTLR 4.5.3.1-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Dangl.Calculator.Generated {

#pragma warning disable 0419
#pragma warning disable 3021
#pragma warning disable 1574
#pragma warning disable 1591
#pragma warning disable 1658
#pragma warning disable 1584
#pragma warning disable 0108

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ICalculatorVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3.1-SNAPSHOT")]
[System.CLSCompliant(false)]
public partial class CalculatorBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, ICalculatorVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>UnaryPlus</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitUnaryPlus([NotNull] CalculatorParser.UnaryPlusContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Mod</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMod([NotNull] CalculatorParser.ModContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Roundk</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRoundk([NotNull] CalculatorParser.RoundkContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Euler</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEuler([NotNull] CalculatorParser.EulerContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Abs</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAbs([NotNull] CalculatorParser.AbsContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Eex</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEex([NotNull] CalculatorParser.EexContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>MulDiv</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMulDiv([NotNull] CalculatorParser.MulDivContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Exp</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExp([NotNull] CalculatorParser.ExpContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Exponent</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExponent([NotNull] CalculatorParser.ExponentContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Log</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLog([NotNull] CalculatorParser.LogContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Trunc</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTrunc([NotNull] CalculatorParser.TruncContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Tanh</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTanh([NotNull] CalculatorParser.TanhContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Deg</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDeg([NotNull] CalculatorParser.DegContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Sqrt</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSqrt([NotNull] CalculatorParser.SqrtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Arctan2</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitArctan2([NotNull] CalculatorParser.Arctan2Context context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Tan</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTan([NotNull] CalculatorParser.TanContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Arccos</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitArccos([NotNull] CalculatorParser.ArccosContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Number</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNumber([NotNull] CalculatorParser.NumberContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Arccot</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitArccot([NotNull] CalculatorParser.ArccotContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AddSub</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAddSub([NotNull] CalculatorParser.AddSubContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Rad</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRad([NotNull] CalculatorParser.RadContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Round</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRound([NotNull] CalculatorParser.RoundContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Sinh</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSinh([NotNull] CalculatorParser.SinhContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Ln</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLn([NotNull] CalculatorParser.LnContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Pi</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPi([NotNull] CalculatorParser.PiContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Whole</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitWhole([NotNull] CalculatorParser.WholeContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Unary</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitUnary([NotNull] CalculatorParser.UnaryContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Floor</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFloor([NotNull] CalculatorParser.FloorContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Sin</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSin([NotNull] CalculatorParser.SinContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Ceil</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCeil([NotNull] CalculatorParser.CeilContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Sqr</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSqr([NotNull] CalculatorParser.SqrContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Cos</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCos([NotNull] CalculatorParser.CosContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>SqRoot</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSqRoot([NotNull] CalculatorParser.SqRootContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Arcsin</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitArcsin([NotNull] CalculatorParser.ArcsinContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Cosh</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCosh([NotNull] CalculatorParser.CoshContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Parenthesis</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitParenthesis([NotNull] CalculatorParser.ParenthesisContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Pow</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPow([NotNull] CalculatorParser.PowContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Cot</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCot([NotNull] CalculatorParser.CotContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>NegExponent</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNegExponent([NotNull] CalculatorParser.NegExponentContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Arctan</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitArctan([NotNull] CalculatorParser.ArctanContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="CalculatorParser.calculator"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCalculator([NotNull] CalculatorParser.CalculatorContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="CalculatorParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpression([NotNull] CalculatorParser.ExpressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="CalculatorParser.compileUnit"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCompileUnit([NotNull] CalculatorParser.CompileUnitContext context) { return VisitChildren(context); }
}
} // namespace Dangl.Calculator.Generated
