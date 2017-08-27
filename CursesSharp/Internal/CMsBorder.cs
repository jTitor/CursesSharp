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
        internal static void wborder(IntPtr win, uint ls, uint rs, uint ts, uint bs, uint tl, uint tr, uint bl, uint br)
        {
            int ret = NativeMethods.WRAP_wborder(win, ls, rs, ts, bs, tl, tr, bl, br);
            InternalException.Verify(ret, "wborder");
        }

        internal static void box(IntPtr win, uint verch, uint horch)
        {
            int ret = NativeMethods.WRAP_box(win, verch, horch);
            InternalException.Verify(ret, "box");
        }

        internal static void whline(IntPtr win, uint ch, int n)
        {
            int ret = NativeMethods.WRAP_whline(win, ch, n);
            InternalException.Verify(ret, "whline");
        }

        internal static void wvline(IntPtr win, uint ch, int n)
        {
            int ret = NativeMethods.WRAP_wvline(win, ch, n);
            InternalException.Verify(ret, "wvline");
        }

        internal static void mvwhline(IntPtr win, int y, int x, uint ch, int n)
        {
            int ret = NativeMethods.WRAP_mvwhline(win, y, x, ch, n);
            InternalException.Verify(ret, "mvwhline");
        }

        internal static void mvwvline(IntPtr win, int y, int x, uint ch, int n)
        {
            int ret = NativeMethods.WRAP_mvwvline(win, y, x, ch, n);
            InternalException.Verify(ret, "mvwvline");
        }
    }

    internal static partial class NativeMethods
    {
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_wborder(IntPtr win, uint ls, uint rs, uint ts, uint bs, uint tl, uint tr, uint bl, uint br);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_box(IntPtr win, uint verch, uint horch);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_whline(IntPtr win, uint ch, int n);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_wvline(IntPtr win, uint ch, int n);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_mvwhline(IntPtr win, int y, int x, uint ch, int n);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_mvwvline(IntPtr win, int y, int x, uint ch, int n);
    }
}
