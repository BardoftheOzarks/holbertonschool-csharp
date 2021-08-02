using System;
using System.Collections.Generic;

/// <summary>Host class to test an object</summary>
class Obj
{
    /// <summary>Tests if an object is an int</summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is int)
            return true;
        return false;
    }
}