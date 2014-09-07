﻿// ---------------------------------------------------------------------------------------
// <copyright file="TapEventArgs.cs" company="SharpBlade">
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

using System;
using System.Diagnostics.CodeAnalysis;

using SharpBlade.Annotations;

namespace SharpBlade.Events
{
    /// <summary>
    /// Gesture event generated by Razer API when the user
    /// has released their fingers from the touchpad.
    /// </summary>
    public class TapEventArgs : EventArgs
    {
        /// <summary>
        /// X-coordinate of the touch point.
        /// </summary>
        private readonly ushort _x;

        /// <summary>
        /// Y-coordinate of the touch point.
        /// </summary>
        private readonly ushort _y;

        /// <summary>
        /// Initializes a new instance of the <see cref="TapEventArgs" /> class.
        /// </summary>
        /// <param name="x">X position of tap.</param>
        /// <param name="y">Y position of tap.</param>
        internal TapEventArgs(ushort x, ushort y)
        {
            _x = x;
            _y = y;
        }

        /// <summary>
        /// Gets the X-coordinate of the touch point.
        /// </summary>
        [CLSCompliant(false)]
        [PublicAPI]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "X",
            Justification = "The naming is acceptable for this simple property.")]
        public ushort X
        {
            get { return _x; }
        }

        /// <summary>
        /// Gets the Y-coordinate of the touch point.
        /// </summary>
        [CLSCompliant(false)]
        [PublicAPI]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Y",
            Justification = "The naming is acceptable for this simple property.")]
        public ushort Y
        {
            get { return _y; }
        }
    }
}
