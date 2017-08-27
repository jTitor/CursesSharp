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
        internal static void slk_init(int fmt)
        {
            int ret = NativeMethods.WRAP_slk_init(fmt);
            InternalException.Verify(ret, "slk_init");
        }

        internal static void slk_refresh()
        {
            int ret = NativeMethods.WRAP_slk_refresh();
            InternalException.Verify(ret, "slk_refresh");
        }

        internal static void slk_noutrefresh()
        {
            int ret = NativeMethods.WRAP_slk_noutrefresh();
            InternalException.Verify(ret, "slk_noutrefresh");
        }

        internal static string slk_label(int labnum)
        {
            IntPtr ret = NativeMethods.WRAP_slk_label(labnum);
            InternalException.Verify(ret, "slk_label");
            return Marshal.PtrToStringAnsi(ret);
        }

        internal static void slk_clear()
        {
            int ret = NativeMethods.WRAP_slk_clear();
            InternalException.Verify(ret, "slk_clear");
        }

        internal static void slk_restore()
        {
            int ret = NativeMethods.WRAP_slk_restore();
            InternalException.Verify(ret, "slk_restore");
        }

        internal static void slk_touch()
        {
            int ret = NativeMethods.WRAP_slk_touch();
            InternalException.Verify(ret, "slk_touch");
        }

        internal static void slk_attron(uint attrs)
        {
            int ret = NativeMethods.WRAP_slk_attron(attrs);
            InternalException.Verify(ret, "slk_attron");
        }

        internal static void slk_attrset(uint attrs)
        {
            int ret = NativeMethods.WRAP_slk_attrset(attrs);
            InternalException.Verify(ret, "slk_attrset");
        }

        internal static void slk_attroff(uint attrs)
        {
            int ret = NativeMethods.WRAP_slk_attroff(attrs);
            InternalException.Verify(ret, "slk_attroff");
        }

        internal static void slk_color(short color_pair)
        {
            int ret = NativeMethods.WRAP_slk_color(color_pair);
            InternalException.Verify(ret, "slk_color");
        }

        internal static void slk_set(int labnum, string label, int justify)        
        {
            int ret = NativeMethods.WRAP_slk_set(labnum, label, label.Length, justify);
            InternalException.Verify(ret, "slk_set");
        }
    }

    internal static partial class NativeMethods
    {
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_slk_init(int fmt);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_slk_refresh();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_slk_noutrefresh();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr WRAP_slk_label(int labnum);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_slk_clear();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_slk_restore();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_slk_touch();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_slk_attron(uint attrs);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_slk_attrset(uint attrs);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_slk_attroff(uint attrs);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_slk_color(short color_pair);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        internal static extern int WRAP_slk_set(int labnum, String label, int labellen, int justify);
    }
}
