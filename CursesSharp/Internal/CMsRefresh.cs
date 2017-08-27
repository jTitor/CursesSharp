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
        internal static void wrefresh(IntPtr win)
        {
            int ret = NativeMethods.WRAP_wrefresh(win);
            InternalException.Verify(ret, "wrefresh");
        }

        internal static void wnoutrefresh(IntPtr win)
        {
            int ret = NativeMethods.WRAP_wnoutrefresh(win);
            InternalException.Verify(ret, "wnoutrefresh");
        }

        internal static void doupdate()
        {
            int ret = NativeMethods.WRAP_doupdate();
            InternalException.Verify(ret, "doupdate");
        }

        internal static void redrawwin(IntPtr win)
        {
            int ret = NativeMethods.WRAP_redrawwin(win);
            InternalException.Verify(ret, "redrawwin");
        }

        internal static void wredrawln(IntPtr win, int beg_line, int num_lines)
        {
            int ret = NativeMethods.WRAP_wredrawln(win, beg_line, num_lines);
            InternalException.Verify(ret, "wredrawln");
        }
    }

    internal static partial class NativeMethods
    {
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_wrefresh(IntPtr win);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_wnoutrefresh(IntPtr win);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_doupdate();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_redrawwin(IntPtr win);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_wredrawln(IntPtr win, int beg_line, int num_lines);
    }
}
