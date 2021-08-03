﻿using System;

/// <summary>Parent class for shapes</summary>
class Shape
{
    /// <summary>Apparently these shapes have no area</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>It's a rectangle!</summary>
class Rectangle : Shape
{
    private int width;
    private int height;
    /// <summary>Gets and sets the private field width</summary>
    public int Width
    {
        get => width;
        set
        {
            if (value >= 0)
                width = value;
            else
                throw new ArgumentException("Width must be greater than or equal to 0");
        }
    }
    /// <summary>Gets and sets the private field height</summary>
    public int Height
    {
        get => height;
        set
        {
            if (value >= 0)
                height = value;
            else
                throw new ArgumentException("Height must be greater than or equal to 0");
        }
    }
    /// <summary>Overrides the parent class method</summary>
    public override int Area()
    {
        return width * height;
    }
    public override string ToString()
    {
        return $"[{this.GetType()}] {width} / {height}";
    }
}

/// <summary>A square is a type of rectangle</summary>
class Square : Rectangle
{
    private int size;
    /// <summary>Get and sets the private fields size, width, and height</summary>
    public int Size
    {
        get => size;
        set
        {
            if (value >= 0)
            {
                size = value;
                Width = value;
                Height = value;
            }
            else
                throw new ArgumentException("Size must be greater than or equal to 0");
        }
    }
}