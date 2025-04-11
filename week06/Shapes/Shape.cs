using System;

public abstract class Shapes
{
    private string _name;
    private string _color;

    public Shapes(string color)
    {
        _color =  color;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetColor()
    {
        return _color;
    }

    public abstract double GetArea();

}