using System;

namespace RsCodesTools.ListDecoder.GsDecoderDependencies.InterpolationPolynomialBuilder
{
    /// <summary>
    /// Exception for indicating only existence of zero interpolation polynomial 
    /// </summary>
    public class NonTrivialPolynomialNotFoundException : InvalidOperationException
    {
    }
}