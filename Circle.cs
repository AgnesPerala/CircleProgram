using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleProgram;

public class Circle 
{
    // privte vairbles for only access in the Circle class 
    private float _pi = 3.141f; 
    private int _radius;

    public Circle(int radius) // konstruktor to make the object with an input parameter
    {
        _radius = radius;
    }
    public float GetCircleArea() // method for logic to calculate area
    {
        return _radius * _radius * _pi;
    }
    public float GetCircleCircumference() // method for logic to calculate circumference
    {
        return _radius * 2 * _pi;
    }
}

