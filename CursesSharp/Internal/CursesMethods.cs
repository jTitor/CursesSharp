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
using System.Text;
using System.Runtime.InteropServices;

namespace CursesSharp.Internal
{
    internal static partial class CursesMethods
    {
        internal static int LINES()
        {
            return NativeMethods.WRAP_LINES();
        }

        internal static int COLS()
        {
            return NativeMethods.WRAP_COLS();
        }

        internal static int COLORS()
        {
            return NativeMethods.WRAP_COLORS();
        }

        internal static int COLOR_PAIRS()
        {
            return NativeMethods.WRAP_COLOR_PAIRS();
        }

        internal static int TABSIZE()
        {
            return NativeMethods.WRAP_TABSIZE();
        }
    }

    internal static partial class NativeMethods
    {
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_LINES();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_COLS();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_COLORS();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_COLOR_PAIRS();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_TABSIZE();
    }
}
