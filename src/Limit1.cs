using System;
using UnityEngine;

public class Limit1 : ILimit
{
    private int _limitID;

    public Limit1(int limitID)
    {
        _limitID = limitID;
    }

    public int getLimitID()
    {
        return _limitID;
    }

    public bool IsLimitConfirm(ILimitFuncitonContext context)
    {
        Debug.Log("Call script Limit1");
        return true;
    }       
}

