﻿using System;

public class ComplexNumber
{
    public double Real { get; private set; }

    public double Imaginary { get; private set; }

    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public override string ToString()
    {
        return string.Format("({0} {1} {2}i)",
            Real, (Imaginary < 0 ? "-" : "+"), Math.Abs(Imaginary));
    }

    // Overload the addition operator
    public static ComplexNumber operator +(ComplexNumber x, ComplexNumber y)
    {
        return new ComplexNumber(x.Real + y.Real, x.Imaginary + y.Imaginary);
    }

    public static ComplexNumber operator -(ComplexNumber x, ComplexNumber y)
    {
        return new ComplexNumber(x.Real - y.Real, x.Imaginary - y.Imaginary);
    }

    public static ComplexNumber operator *(ComplexNumber x, ComplexNumber y)
    {
        return new ComplexNumber(
            x.Real * y.Real - x.Imaginary * y.Imaginary,
            x.Real * y.Imaginary + y.Real * x.Imaginary);
    }
}
