/* This file was generated by SableCC (http://www.sablecc.org/). */

package org.sablecc.sablecc.xss2.node;

import java.util.*;
import org.sablecc.sablecc.xss2.analysis.*;

public final class APathXpathExpr extends PXpathExpr
{
    private final LinkedList _xpath_path_elem_ = new TypedLinkedList(new XpathPathElem_Cast());

    public APathXpathExpr ()
    {
    }

    public APathXpathExpr (
            List _xpath_path_elem_
    )
    {
        this._xpath_path_elem_.clear();
        this._xpath_path_elem_.addAll(_xpath_path_elem_);
    }

    public Object clone()
    {
        return new APathXpathExpr (
            cloneList (_xpath_path_elem_)
        );
    }

    public void apply(Switch sw)
    {
        ((Analysis) sw).caseAPathXpathExpr(this);
    }

    public LinkedList getXpathPathElem ()
    {
        return _xpath_path_elem_;
    }

    public void setXpathPathElem (List list)
    {
        _xpath_path_elem_.clear();
        _xpath_path_elem_.addAll(list);
    }

    public String toString()
    {
        return ""
            + toString (_xpath_path_elem_)
        ;
    }

    void removeChild(Node child)
    {
        if ( _xpath_path_elem_.remove(child))
        {
            return;
        }
    }

    void replaceChild(Node oldChild, Node newChild)
    {
        for(ListIterator i = _xpath_path_elem_.listIterator(); i.hasNext();)
        {
            if(i.next() == oldChild)
            {
                if(newChild != null)
                {
                    i.set(newChild);
                    oldChild.parent(null);
                    return;
                }

                i.remove();
                oldChild.parent(null);
                return;
            }
        }
    }

    private class XpathPathElem_Cast implements Cast
    {
        public Object cast(Object o)
        {
            PXpathPathElem node = (PXpathPathElem) o;

            if((node.parent() != null) &&
                (node.parent() != APathXpathExpr.this))
            {
                node.parent().removeChild(node);
            }

            if((node.parent() == null) ||
                (node.parent() != APathXpathExpr.this))
            {
                node.parent(APathXpathExpr.this);
            }

            return node;
        }
    }
}
