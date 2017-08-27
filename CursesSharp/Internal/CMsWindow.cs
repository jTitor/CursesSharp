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
        internal static IntPtr stdscr()
        {
            IntPtr ret = NativeMethods.WRAP_stdscr();
            InternalException.Verify(ret, "stdscr");
            return ret;
        }

        internal static IntPtr curscr()
        {
            IntPtr ret = NativeMethods.WRAP_curscr();
            InternalException.Verify(ret, "curscr");
            return ret;
        }

        internal static IntPtr newscr()
        {
            IntPtr ret = NativeMethods.WRAP_newscr();
            InternalException.Verify(ret, "newscr");
            return ret;
        }

        internal static IntPtr newwin(int nlines, int ncols, int begy, int begx)
        {
            IntPtr ret = NativeMethods.WRAP_newwin(nlines, ncols, begy, begx);
            InternalException.Verify(ret, "newwin");
            return ret;
        }

        internal static IntPtr derwin(IntPtr orig, int nlines, int ncols, int begy, int begx)
        {
            IntPtr ret = NativeMethods.WRAP_derwin(orig, nlines, ncols, begy, begx);
            InternalException.Verify(ret, "derwin");
            return ret;
        }

        internal static IntPtr subwin(IntPtr orig, int nlines, int ncols, int begy, int begx)
        {
            IntPtr ret = NativeMethods.WRAP_subwin(orig, nlines, ncols, begy, begx);
            InternalException.Verify(ret, "subwin");
            return ret;
        }

        internal static IntPtr dupwin(IntPtr win)
        {
            IntPtr ret = NativeMethods.WRAP_dupwin(win);
            InternalException.Verify(ret, "dupwin");
            return ret;
        }

        internal static void delwin(IntPtr win)
        {
            int ret = NativeMethods.WRAP_delwin(win);
            InternalException.Verify(ret, "delwin");
        }

        internal static void mvwin(IntPtr win, int y, int x)
        {
            int ret = NativeMethods.WRAP_mvwin(win, y, x);
            InternalException.Verify(ret, "mvwin");
        }

        internal static void mvderwin(IntPtr win, int pary, int parx)
        {
            int ret = NativeMethods.WRAP_mvderwin(win, pary, parx);
            InternalException.Verify(ret, "mvderwin");
        }

        internal static void syncok(IntPtr win, bool bf)
        {
            int ret = NativeMethods.WRAP_syncok(win, bf);
            InternalException.Verify(ret, "syncok");
        }

        internal static void wsyncup(IntPtr win)
        {
            NativeMethods.WRAP_wsyncup(win);
        }

        internal static void wcursyncup(IntPtr win)
        {
            NativeMethods.WRAP_wcursyncup(win);
        }

        internal static void wsyncdown(IntPtr win)
        {
            NativeMethods.WRAP_wsyncdown(win);
        }
    }

    internal static partial class NativeMethods
    {
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr WRAP_stdscr();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr WRAP_curscr();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr WRAP_newscr();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr WRAP_newwin(int nlines, int ncols, int begy, int begx);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr WRAP_derwin(IntPtr orig, int nlines, int ncols, int begy, int begx);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr WRAP_subwin(IntPtr orig, int nlines, int ncols, int begy, int begx);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr WRAP_dupwin(IntPtr win);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_delwin(IntPtr win);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_mvwin(IntPtr win, int y, int x);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_mvderwin(IntPtr win, int pary, int parx);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_syncok(IntPtr win, Boolean bf);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void WRAP_wsyncup(IntPtr win);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void WRAP_wcursyncup(IntPtr win);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void WRAP_wsyncdown(IntPtr win);
    }
}
