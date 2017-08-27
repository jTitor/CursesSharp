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
        internal static uint COLOR_PAIR(int n)
        {
            return NativeMethods.WRAP_COLOR_PAIR(n);
        }

        internal static short PAIR_NUMBER(uint n)
        {
            return NativeMethods.WRAP_PAIR_NUMBER(n);
        }

        internal static void start_color()
        {
            int ret = NativeMethods.WRAP_start_color();
            InternalException.Verify(ret, "start_color");
        }

        internal static void init_pair(short color, short fg, short bg)
        {
            int ret = NativeMethods.WRAP_init_pair(color, fg, bg);
            InternalException.Verify(ret, "init_pair");
        }

        internal static void init_color(short color, short red, short green, short blue)
        {
            int ret = NativeMethods.WRAP_init_color(color, red, green, blue);
            InternalException.Verify(ret, "init_color");
        }

        internal static void color_content(short color, out short red, out short green, out short blue)
        {
            int ret = NativeMethods.WRAP_color_content(color, out red, out green, out blue);
            InternalException.Verify(ret, "color_content");
        }

        internal static void pair_content(short pair, out short fg, out short bg)
        {
            int ret = NativeMethods.WRAP_pair_content(pair, out fg, out bg);
            InternalException.Verify(ret, "pair_content");
        }

        internal static bool has_colors()
        {
            return NativeMethods.WRAP_has_colors();
        }

        internal static bool can_change_color()
        {
            return NativeMethods.WRAP_can_change_color();
        }

        internal static void assume_default_colors(int f, int b)
        {
            int ret = NativeMethods.WRAP_assume_default_colors(f, b);
            InternalException.Verify(ret, "assume_default_colors");
        }

        internal static void use_default_colors()
        {
            int ret = NativeMethods.WRAP_use_default_colors();
            InternalException.Verify(ret, "use_default_colors");
        }
    }

    internal static partial class NativeMethods
    {
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint WRAP_COLOR_PAIR(int n);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern short WRAP_PAIR_NUMBER(uint n);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_start_color();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_init_pair(short color, short fg, short bg);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_init_color(short color, short red, short green, short blue);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_color_content(short color, out short red, out short green, out short blue);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_pair_content(short pair, out short fg, out short bg);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Boolean WRAP_has_colors();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Boolean WRAP_can_change_color();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_assume_default_colors(int f, int b);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_use_default_colors();
    }
}
