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
        internal static void wattroff(IntPtr win, uint attrs)
        {
            int ret = NativeMethods.WRAP_wattroff(win, attrs);
            InternalException.Verify(ret, "wattroff");
        }

        internal static void wattron(IntPtr win, uint attrs)
        {
            int ret = NativeMethods.WRAP_wattron(win, attrs);
            InternalException.Verify(ret, "wattron");
        }

        internal static void wattrset(IntPtr win, uint attrs)
        {
            int ret = NativeMethods.WRAP_wattrset(win, attrs);
            InternalException.Verify(ret, "wattrset");
        }

        internal static void wstandend(IntPtr win)
        {
            int ret = NativeMethods.WRAP_wstandend(win);
            InternalException.Verify(ret, "wstandend");
        }

        internal static void wstandout(IntPtr win)
        {
            int ret = NativeMethods.WRAP_wstandout(win);
            InternalException.Verify(ret, "wstandout");
        }

        internal static void wcolor_set(IntPtr win, short color_pair)
        {
            int ret = NativeMethods.WRAP_wcolor_set(win, color_pair);
            InternalException.Verify(ret, "wcolor_set");
        }

        internal static void wattr_get(IntPtr win, out uint attrs, out short color_pair)
        {
            int ret = NativeMethods.WRAP_wattr_get(win, out attrs, out color_pair);
            InternalException.Verify(ret, "wattr_get");
        }

        internal static void wchgat(IntPtr win, int n, uint attr, short color)
        {
            int ret = NativeMethods.WRAP_wchgat(win, n, attr, color);
            InternalException.Verify(ret, "wchgat");
        }

        internal static void mvwchgat(IntPtr win, int y, int x, int n, uint attr, short color)
        {
            int ret = NativeMethods.WRAP_mvwchgat(win, y, x, n, attr, color);
            InternalException.Verify(ret, "mvwchgat");
        }
    }

    internal static partial class NativeMethods
    {
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_wattroff(IntPtr win, uint attrs);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_wattron(IntPtr win, uint attrs);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_wattrset(IntPtr win, uint attrs);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_wstandend(IntPtr win);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_wstandout(IntPtr win);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_wcolor_set(IntPtr win, short color_pair);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_wattr_get(IntPtr win, out uint attrs, out short color_pair);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_wchgat(IntPtr win, int n, uint attr, short color);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_mvwchgat(IntPtr win, int y, int x, int n, uint attr, short color);
    }
}
