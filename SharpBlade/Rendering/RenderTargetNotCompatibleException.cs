﻿// ---------------------------------------------------------------------------------------
// <copyright file="RenderTargetNotCompatibleException.cs" company="SharpBlade">
//     Copyright © 2013-2014 by Adam Hellberg and Brandon Scott.
//
//     Permission is hereby granted, free of charge, to any person obtaining a copy of
//     this software and associated documentation files (the "Software"), to deal in
//     the Software without restriction, including without limitation the rights to
//     use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
//     of the Software, and to permit persons to whom the Software is furnished to do
//     so, subject to the following conditions:
//
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
//
//     THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//     IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//     AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
//     WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
//     CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
//     Disclaimer: SharpBlade is in no way affiliated with Razer and/or any of
//     its employees and/or licensors. Adam Hellberg and/or Brandon Scott do not
//     take responsibility for any harm caused, direct or indirect, to any Razer
//     peripherals via the use of SharpBlade.
//
//     "Razer" is a trademark of Razer USA Ltd.
// </copyright>
// ---------------------------------------------------------------------------------------

namespace SharpBlade.Rendering
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.Serialization;

    /// <summary>
    /// Thrown when an attempt is made to call <see cref="RenderTarget.Set{T}" />
    /// with a <see cref="Renderer{T}" /> that is not compatible.
    /// </summary>
    [Serializable]
    [SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors",
        Justification = "ctor() and ctor(string) is already implemented via default params.")]
    public class RenderTargetNotCompatibleException : SwitchbladeException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenderTargetNotCompatibleException" /> class.
        /// </summary>
        /// <param name="message">Message associated with the exception.</param>
        /// <param name="innerException">Inner exception object.</param>
        [SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors",
            Justification = "This exception is never instantiated outside of internal SharpBlade code.")]
        internal RenderTargetNotCompatibleException(string message = null, Exception innerException = null)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderTargetNotCompatibleException" /> class
        /// from serialization data.
        /// </summary>
        /// <param name="info">Serialization info object.</param>
        /// <param name="context">Streaming context.</param>
        protected RenderTargetNotCompatibleException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
