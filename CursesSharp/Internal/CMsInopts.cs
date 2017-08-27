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
        internal static void cbreak()
        {
            int ret = NativeMethods.WRAP_cbreak();
            InternalException.Verify(ret, "cbreak");
        }

        internal static void nocbreak()
        {
            int ret = NativeMethods.WRAP_nocbreak();
            InternalException.Verify(ret, "nocbreak");
        }

        internal static void echo()
        {
            int ret = NativeMethods.WRAP_echo();
            InternalException.Verify(ret, "echo");
        }

        internal static void noecho()
        {
            int ret = NativeMethods.WRAP_noecho();
            InternalException.Verify(ret, "noecho");
        }

        internal static void halfdelay(int tenths)
        {
            int ret = NativeMethods.WRAP_halfdelay(tenths);
            InternalException.Verify(ret, "halfdelay");
        }

        internal static void intrflush(IntPtr win, Boolean bf)
        {
            int ret = NativeMethods.WRAP_intrflush(win, bf);
            InternalException.Verify(ret, "intrflush");
        }

        internal static void keypad(IntPtr win, Boolean bf)
        {
            int ret = NativeMethods.WRAP_keypad(win, bf);
            InternalException.Verify(ret, "keypad");
        }

        internal static void meta(IntPtr win, Boolean bf)
        {
            int ret = NativeMethods.WRAP_meta(win, bf);
            InternalException.Verify(ret, "meta");
        }

        internal static void nl()
        {
            int ret = NativeMethods.WRAP_nl();
            InternalException.Verify(ret, "nl");
        }

        internal static void nonl()
        {
            int ret = NativeMethods.WRAP_nonl();
            InternalException.Verify(ret, "nonl");
        }

        internal static void nodelay(IntPtr win, Boolean bf)
        {
            int ret = NativeMethods.WRAP_nodelay(win, bf);
            InternalException.Verify(ret, "nodelay");
        }

        internal static void raw()
        {
            int ret = NativeMethods.WRAP_raw();
            InternalException.Verify(ret, "raw");
        }

        internal static void noraw()
        {
            int ret = NativeMethods.WRAP_noraw();
            InternalException.Verify(ret, "noraw");
        }

        internal static void qiflush()
        {
            NativeMethods.WRAP_qiflush();
        }

        internal static void noqiflush()
        {
            NativeMethods.WRAP_noqiflush();
        }

        internal static void notimeout(IntPtr win, Boolean bf)
        {
            int ret = NativeMethods.WRAP_notimeout(win, bf);
            InternalException.Verify(ret, "notimeout");
        }

        internal static void wtimeout(IntPtr win, int delay)
        {
            NativeMethods.WRAP_wtimeout(win, delay);
        }
    }

    internal static partial class NativeMethods
    {
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_cbreak();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_nocbreak();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_echo();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_noecho();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_halfdelay(int tenths);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_intrflush(IntPtr win, Boolean bf);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_keypad(IntPtr win, Boolean bf);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_meta(IntPtr win, Boolean bf);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_nl();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_nonl();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_nodelay(IntPtr win, Boolean bf);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_raw();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_noraw();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void WRAP_qiflush();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void WRAP_noqiflush();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_notimeout(IntPtr win, Boolean bf);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void WRAP_wtimeout(IntPtr win, int delay);
    }
}
