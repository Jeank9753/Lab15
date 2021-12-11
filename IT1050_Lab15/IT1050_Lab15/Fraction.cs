using System;
using System.Collections.Generic;
using System.Text;

namespace IT1050_Lab15
{
    class Fraction
    {
        int numerator;
        int denominator;

        public Fraction(int numerator, int denominator)
        {

        }

        public void Multiply(int numerator, int denominator)
        {
            this.numerator = this.numerator * numerator;
            this.denominator = this.denominator * denominator;
        }

        public void Multiply(int wholeNumber)
        {
            this.numerator = this.numerator * wholeNumber;
        }

        public void Multiply(Fraction fraction)
        {
            this.numerator = this.numerator * fraction.numerator;
            this.denominator = this.denominator * fraction.denominator;
        }

        public void Divide(int numerator, int denominator)
        {

        }

        public void Divide(int wholeNumber)
        {
            
        }

        public void Divide(Fraction fraction)
        {

        }

        public void Add(int numerator, int denominator)
        {

        }

        public void Add(int wholeNumber)
        {

        }

        public void Add(Fraction fraction)
        {

        }

        public void Subtract(int numerator, int denominator)
        {

        }

        public void Subtract(int wholeNumber)
        {

        }

        public void Subtract(Fraction fraction)
        {

        }

        public string DisplayFraction()
        {

        }
    }
}
