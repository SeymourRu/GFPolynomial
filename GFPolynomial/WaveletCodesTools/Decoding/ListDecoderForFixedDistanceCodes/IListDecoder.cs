﻿using System;
using GFPolynoms;

namespace WaveletCodesTools.Decoding.ListDecoderForFixedDistanceCodes
{
    /// <summary>
    /// Contract for wavelet code list decoder
    /// </summary>
    public interface IListDecoder
    {
        /// <summary>
        /// Method for performing list decoding of the wavelet code codeword
        /// </summary>
        /// <param name="n">Codeword length</param>
        /// <param name="k">Information word length</param>
        /// <param name="d">Code distance</param>
        /// <param name="generatingPolynomial">Generating polynomial of the wavelet code</param>
        /// <param name="decodedCodeword">Recived codeword for decoding</param>
        /// <param name="minCorrectValuesCount">Minimum number of valid values</param>
        /// <returns>Decoding result</returns>
        Polynomial[] Decode(int n, int k, int d, Polynomial generatingPolynomial,
            Tuple<FieldElement, FieldElement>[] decodedCodeword, int minCorrectValuesCount);
    }
}