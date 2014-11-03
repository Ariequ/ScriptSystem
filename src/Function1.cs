using UnityEngine;
using System;

public class Function1 : IFunction
{
    private int _functionID;

    public Function1(int functionID)
    {
        _functionID = functionID;
    }

    public int getLimitID()
    {
        return _functionID;
    }

    public void Execute(ILimitFuncitonContext context, Action<int,ILimitFuncitonContext> callBack)
    {
        Debug.Log("script function exctue");
        callBack(1, context);
    }
}

