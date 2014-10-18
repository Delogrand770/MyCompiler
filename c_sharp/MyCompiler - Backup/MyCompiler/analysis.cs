/* This file was generated by SableCC (http://www.sablecc.org/). */

using System;
using System.Collections;
using comp5210.node;

namespace comp5210.analysis {


public interface Analysis : Switch
{
    Object GetIn(Node node);
    void SetIn(Node node, Object inobj);
    Object GetOut(Node node);
    void SetOut(Node node, Object outobj);

    void CaseStart(Start node);
    void CaseAFred(AFred node);

    void CaseTIf(TIf node);
    void CaseTElse(TElse node);
    void CaseTWhile(TWhile node);
    void CaseTMethod(TMethod node);
    void CaseTReturn(TReturn node);
    void CaseTConstant(TConstant node);
    void CaseTVariable(TVariable node);
    void CaseTWhitespace(TWhitespace node);
    void CaseTComment(TComment node);
    void CaseTInteger(TInteger node);
    void CaseTFloat(TFloat node);
    void CaseTString(TString node);
    void CaseTAdd(TAdd node);
    void CaseTSubtract(TSubtract node);
    void CaseTMultiply(TMultiply node);
    void CaseTDivide(TDivide node);
    void CaseTAnd(TAnd node);
    void CaseTOr(TOr node);
    void CaseTNot(TNot node);
    void CaseTEquals(TEquals node);
    void CaseTCompareEquals(TCompareEquals node);
    void CaseTGreaterEquals(TGreaterEquals node);
    void CaseTLesserEquals(TLesserEquals node);
    void CaseTGreaterThan(TGreaterThan node);
    void CaseTLessThan(TLessThan node);
    void CaseTLparen(TLparen node);
    void CaseTRparen(TRparen node);
    void CaseTLbrace(TLbrace node);
    void CaseTRbrace(TRbrace node);
    void CaseTLbracket(TLbracket node);
    void CaseTRbracket(TRbracket node);
    void CaseTSemicolon(TSemicolon node);
    void CaseTColon(TColon node);
    void CaseTPeriod(TPeriod node);
    void CaseTComma(TComma node);
    void CaseTUnderscore(TUnderscore node);
    void CaseTDoublequote(TDoublequote node);
    void CaseTLetters(TLetters node);
    void CaseEOF(EOF node);
}


public class AnalysisAdapter : Analysis
{
    private Hashtable inhash;
    private Hashtable outhash;

    public virtual Object GetIn(Node node)
    {
        if(inhash == null)
        {
            return null;
        }

        return inhash[node];
    }

    public virtual void SetIn(Node node, Object inobj)
    {
        if(this.inhash == null)
        {
            this.inhash = new Hashtable(1);
        }

        if(inobj != null)
        {
            this.inhash[node] = inobj;
        }
        else
        {
            this.inhash.Remove(node);
        }
    }
    public virtual Object GetOut(Node node)
    {
        if(outhash == null)
        {
            return null;
        }

        return outhash[node];
    }

    public virtual void SetOut(Node node, Object outobj)
    {
        if(this.outhash == null)
        {
            this.outhash = new Hashtable(1);
        }

        if(outobj != null)
        {
            this.outhash[node] = outobj;
        }
        else
        {
            this.outhash.Remove(node);
        }
    }
    public virtual void CaseStart(Start node)
    {
        DefaultCase(node);
    }

    public virtual void CaseAFred(AFred node)
    {
        DefaultCase(node);
    }

    public virtual void CaseTIf(TIf node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTElse(TElse node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTWhile(TWhile node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTMethod(TMethod node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTReturn(TReturn node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTConstant(TConstant node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTVariable(TVariable node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTWhitespace(TWhitespace node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTComment(TComment node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTInteger(TInteger node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTFloat(TFloat node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTString(TString node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTAdd(TAdd node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTSubtract(TSubtract node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTMultiply(TMultiply node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTDivide(TDivide node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTAnd(TAnd node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTOr(TOr node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTNot(TNot node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTEquals(TEquals node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTCompareEquals(TCompareEquals node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTGreaterEquals(TGreaterEquals node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTLesserEquals(TLesserEquals node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTGreaterThan(TGreaterThan node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTLessThan(TLessThan node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTLparen(TLparen node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTRparen(TRparen node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTLbrace(TLbrace node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTRbrace(TRbrace node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTLbracket(TLbracket node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTRbracket(TRbracket node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTSemicolon(TSemicolon node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTColon(TColon node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTPeriod(TPeriod node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTComma(TComma node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTUnderscore(TUnderscore node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTDoublequote(TDoublequote node)
    {
        DefaultCase(node);
    }
    public virtual void CaseTLetters(TLetters node)
    {
        DefaultCase(node);
    }

    public virtual void CaseEOF(EOF node)
    {
        DefaultCase(node);
    }

    public virtual void DefaultCase(Node node)
    {
    }
}


public class DepthFirstAdapter : AnalysisAdapter
{
    public virtual void InStart(Start node)
    {
        DefaultIn(node);
    }

    public virtual void OutStart(Start node)
    {
        DefaultOut(node);
    }

    public virtual void DefaultIn(Node node)
    {
    }

    public virtual void DefaultOut(Node node)
    {
    }

    public override void CaseStart(Start node)
    {
        InStart(node);
        node.GetPFred().Apply(this);
        node.GetEOF().Apply(this);
        OutStart(node);
    }

    public virtual void InAFred(AFred node)
    {
        DefaultIn(node);
    }

    public virtual void OutAFred(AFred node)
    {
        DefaultOut(node);
    }

    public override void CaseAFred(AFred node)
    {
        InAFred(node);
        if(node.GetPeriod() != null)
        {
            node.GetPeriod().Apply(this);
        }
        OutAFred(node);
    }
}


public class ReversedDepthFirstAdapter : AnalysisAdapter
{
    public virtual void InStart(Start node)
    {
        DefaultIn(node);
    }

    public virtual void OutStart(Start node)
    {
        DefaultOut(node);
    }

    public virtual void DefaultIn(Node node)
    {
    }

    public virtual void DefaultOut(Node node)
    {
    }

    public override void CaseStart(Start node)
    {
        InStart(node);
        node.GetEOF().Apply(this);
        node.GetPFred().Apply(this);
        OutStart(node);
    }

    public virtual void InAFred(AFred node)
    {
        DefaultIn(node);
    }

    public virtual void OutAFred(AFred node)
    {
        DefaultOut(node);
    }

    public override void CaseAFred(AFred node)
    {
        InAFred(node);
        if(node.GetPeriod() != null)
        {
            node.GetPeriod().Apply(this);
        }
        OutAFred(node);
    }
}
} // namespace comp5210.analysis