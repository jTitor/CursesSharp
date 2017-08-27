#region Copyright 2009 Robert Konklewski
/*
 * CursesSharp
 * 
 * Copyright 2009 Robert Konklewski
 * 
 * This library is free software; you can redistribute it and/or modify it
 * under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation; either version 3 of the License, or (at your
 * option) any later version.
 *
 * This library is distributed in the hope that it will be useful, but WITHOUT
 * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
 * FITNESS FOR A PARTICULAR PURPOSE.  See the GNU Lesser General Public
 * License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * www.gnu.org/licenses/>.
 * 
 */
#endregion

using System;

namespace CursesSharp.Internal
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    internal class InternalException : CursesException
    {
        /// <summary>
        /// 
        /// </summary>
        internal InternalException()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        internal InternalException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        internal InternalException(string message, Exception inner)
            : base(message, inner)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="result"></param>
        /// <param name="fname"></param>
        internal static void Verify(int result, string fname)
        {
            if (result == -1)
                throw new InternalException(fname + "() returned ERR");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="result"></param>
        /// <param name="fname"></param>
        internal static void Verify(IntPtr result, string fname)
        {
            if (result == IntPtr.Zero)
                throw new InternalException(fname + "() returned NULL");
        }
    }
}
