using System;

/// <summary>Parent class for shapes</summary>
class Shape
{
    /// <summary>Apparently these shapes have no area</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}