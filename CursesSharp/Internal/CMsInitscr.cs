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
using System.Runtime.InteropServices;

namespace CursesSharp.Internal
{
    internal static partial class CursesMethods
    {
        internal static IntPtr initscr()
        {
            IntPtr ret = NativeMethods.WRAP_initscr();
            InternalException.Verify(ret, "initscr");
            return ret;
        }

        internal static void endwin()
        {
            int ret = NativeMethods.WRAP_endwin();
            InternalException.Verify(ret, "endwin");
        }

        internal static bool isendwin()
        {
            return NativeMethods.WRAP_isendwin();
        }

        internal static void resize_term(int nlines, int ncols)
        {
            int ret = NativeMethods.WRAP_resize_term(nlines, ncols);
            InternalException.Verify(ret, "resize_term");
        }
    }

    internal static partial class NativeMethods
    {
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr WRAP_initscr();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_endwin();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Boolean WRAP_isendwin();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_resize_term(int nlines, int ncols);
    }
}
