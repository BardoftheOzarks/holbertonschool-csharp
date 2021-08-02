using System;
using System.Collections.Generic;

/// <summary>Host class to test an object</summary>
class Obj
{
    /// <summary>Tests if an object is or inherits from Array</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj is Array)
            return true;
        return false;
    }
}