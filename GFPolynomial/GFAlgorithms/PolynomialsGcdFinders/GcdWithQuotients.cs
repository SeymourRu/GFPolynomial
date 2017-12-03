using System;
using GFPolynoms;
using NameOfFix;

namespace GFAlgorithms.PolynomialsGcdFinder
{
    /// <summary>
    /// Class for storing the greatest common divisor and quotients which were calculated during the process
    /// </summary>
    public class GcdWithQuotients
    {
        /// <summary>
        /// Greatest common divisor
        /// </summary>
        public Polynomial Gcd { get; private set; }

        /// <summary>
        /// Calculated quotients
        /// </summary>
        public Polynomial[] Quotients { get; private set; }

        /// <summary>
        /// Constructor for creating oject with greates common divisor calculation results
        /// </summary>
        /// <param name="gcd">Greates common divisor</param>
        /// <param name="quotients">Calculated quotients</param>
        public GcdWithQuotients(Polynomial gcd, Polynomial[] quotients)
        {
            if(gcd == null)
                throw new ArgumentNullException(NameOfExtension.nameof(() => gcd));
            if(quotients == null)
                throw new ArgumentNullException(NameOfExtension.nameof(() => quotients));

            Gcd = gcd;
            Quotients = quotients;
        }
    }
}