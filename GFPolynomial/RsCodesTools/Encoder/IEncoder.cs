using System;
using GFPolynoms;

namespace RsCodesTools.Encoder
{
    /// <summary>
    /// Contract for the Reed-Solomon code encoder
    /// </summary>
    public interface IEncoder
    {
        /// <summary>
        /// Method for computing Reed-Solomon code's codeword for information polynomial <paramref name="informationPolynomial"/>
        /// </summary>
        /// <param name="n">Codeword length</param>
        /// <param name="informationPolynomial">Information polynomial</param>
        /// <returns>Computed codeword</returns>
        Tuple<FieldElement, FieldElement>[] Encode(int n, Polynomial informationPolynomial);
    }
}