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
        internal static int wgetch(IntPtr win)
        {
            return NativeMethods.WRAP_wgetch(win);
        }

        internal static int mvwgetch(IntPtr win, int y, int x)
        {
            return NativeMethods.WRAP_mvwgetch(win, y, x);
        }

        internal static void ungetch(int ch)
        {
            int ret = NativeMethods.WRAP_ungetch(ch);
            InternalException.Verify(ret, "ungetch");
        }

        internal static void flushinp()
        {
            int ret = NativeMethods.WRAP_flushinp();
            InternalException.Verify(ret, "flushinp");
        }
    }

    internal static partial class NativeMethods
    {
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        internal static extern int WRAP_wgetch(IntPtr win);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        internal static extern int WRAP_mvwgetch(IntPtr win, int y, int x);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        internal static extern int WRAP_ungetch(int ch);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_flushinp();
    }
}
