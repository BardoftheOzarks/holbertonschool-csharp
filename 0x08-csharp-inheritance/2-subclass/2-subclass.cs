using System;
using System.Collections.Generic;

/// <summary>Host class to test an object</summary>
class Obj
{
    /// <summary>Determines if an derivedType inherits but is not an instance of baseType</summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
            return true;
        return false;
    }
}