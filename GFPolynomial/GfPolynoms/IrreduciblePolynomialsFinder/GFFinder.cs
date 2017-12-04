using System;
using System.Collections.Generic;
using System.Linq;
using GFPolynoms.GaloisFields;
using NameOfFix;

namespace IrreduciblePolynomialsFinder
{
    /// <summary>
    /// Irreducible polynomial finder based on brute force
    /// </summary>
    public class GFFinder : IIrreduciblePolynomialsFinder
    {
        private static int[] GetCoeffs(int degree)
        {
            switch (degree)
            {
                case 2:
                    {
                        //x^2 + x + 1 (0x7)
                        //111
                        return new int[] { 1, 1, 1 };
                    }
                    break;
                case 3:
                    {
                        //x^3 + x^2 + 1 (0xD)
                        //1101
                        return new int[] { 1, 1, 0, 1 };
                    }
                    break;
                case 4:
                    {
                        //x^4 + x^2 + 1 (0x15)
                        //10101
                        return new int[] { 1, 0, 1, 0, 1 };
                    }
                    break;
                case 5:
                    {
                        //x^5 + x^4 + x^3 + x^2 + 1 (0x3D)
                        //111101
                        return new int[] { 1, 1, 1, 1, 0, 1 };
                    }
                    break;
                case 6:
                    {
                        //x^6 + x^5 + x^4 + x^2 + 1 (0x75)
                        //1110101
                        return new int[] { 1, 1, 1, 0, 1, 0, 1 };
                    }
                    break;
                case 7:
                    {
                        //x^7 + x^6 + x^5 + x^3 + x^2 + 1 (0xED)
                        //11101101
                        return new int[] { 1, 0, 0, 0, 1, 1, 1, 0, 1 };
                    }
                    break;
                case 8:
                    {
                        //x^8 + x^4 + x^3 + x^2 + 1 (0x11D)
                        //100011101
                        return new int[] { 1, 0, 0, 0, 1, 1, 1, 0, 1 };
                    }
                    break;
                default:
                    {
                        throw new ArgumentException("degree must be in range 2-8");
                    }
            }
        }

        /// <summary>
        /// Method for creation initialization polynomial for brute force search
        /// </summary>
        /// <param name="field">Polynomial field</param>
        /// <param name="degree">Polynomial degree</param>
        private static GFPolynoms.Polynomial GenerateTemplateGFPolynomial(GaloisField field, int degree)
        {
            int[] coeffs = GetCoeffs(degree);
            var templatePolynomial = new GFPolynoms.Polynomial(field, coeffs);
            return templatePolynomial;
        }

        /// <summary>
        /// Method for finding irreducible polynomial degree <paramref name="degree"/> with coefficients from field with order <paramref name="fieldOrder"/>
        /// </summary>
        /// <param name="fieldOrder">Field order from which irreducible polynomials coefficients come</param>
        /// <param name="degree">Irreducible polynomial degree</param>
        /// <returns>Irreducible polynomial with specified properties</returns>
        public GFPolynoms.Polynomial Find(int fieldOrder, int degree)
        {
            if (degree < 2)
                throw new ArgumentException(NameOfExtension.nameof(() => degree));

            var field = new PrimeOrderField(fieldOrder);
            var result = GenerateTemplateGFPolynomial(field, degree);

            return result;
        }
    }
}