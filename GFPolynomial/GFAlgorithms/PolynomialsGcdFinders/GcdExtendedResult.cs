using System;
using GFPolynoms;
using NameOfFix;

namespace GFAlgorithms.PolynomialsGcdFinder
{
    /// <summary>
    /// Class for storing the greatest common divisor coefficients x and y such that a*x+b*y=gcd(a,b)
    /// </summary>
    public class GcdExtendedResult
    {
        public Polynomial X { get; set; }

        public Polynomial Y { get; set; }

        public Polynomial Gcd { get; private set; }

        /// <summary>
        /// Constructor for creating oject for storing greatest common divisor <paramref name="gcd"/> and coefficients x and y such that a*<paramref name="x"/>+b*<paramref name="y"/> = <paramref name="gcd"/>
        /// </summary>
        public GcdExtendedResult(Polynomial x, Polynomial y, Polynomial gcd)
        {
            if (x == null)
                throw new ArgumentNullException(NameOfExtension.nameof(() => x));
            if (y == null)
                throw new ArgumentNullException(NameOfExtension.nameof(() => y));
            if (gcd == null)
                throw new ArgumentNullException(NameOfExtension.nameof(() => gcd));

            X = x;
            Y = y;
            Gcd = gcd;
        }
    }
}