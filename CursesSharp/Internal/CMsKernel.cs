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
    internal delegate int RipOffLineFunInt(IntPtr win, int cols);

    internal static partial class CursesMethods
    {
        internal static void def_prog_mode()
        {
            int ret = NativeMethods.WRAP_def_prog_mode();
            InternalException.Verify(ret, "def_prog_mode");
        }

        internal static void def_shell_mode()
        {
            int ret = NativeMethods.WRAP_def_shell_mode();
            InternalException.Verify(ret, "def_shell_mode");
        }

        internal static void reset_prog_mode()
        {
            int ret = NativeMethods.WRAP_reset_prog_mode();
            InternalException.Verify(ret, "reset_prog_mode");
        }

        internal static void reset_shell_mode()
        {
            int ret = NativeMethods.WRAP_reset_shell_mode();
            InternalException.Verify(ret, "reset_shell_mode");
        }

        internal static void resetty()
        {
            int ret = NativeMethods.WRAP_resetty();
            InternalException.Verify(ret, "resetty");
        }

        internal static void savetty()
        {
            int ret = NativeMethods.WRAP_savetty();
            InternalException.Verify(ret, "savetty");
        }

        internal static void getsyx(out int y, out int x)
        {
            NativeMethods.WRAP_getsyx(out y, out x);
        }

        internal static void setsyx(int y, int x)
        {
            NativeMethods.WRAP_setsyx(y, x);
        }

        internal static void ripoffline(int line, RipOffLineFunInt init)
        {
            int ret = NativeMethods.WRAP_ripoffline(line, init);
            InternalException.Verify(ret, "ripoffline");
        }

        internal static void napms(int ms)
        {
            int ret = NativeMethods.WRAP_napms(ms);
            InternalException.Verify(ret, "napms");
        }

        internal static int curs_set(int visibility)
        {
            return NativeMethods.WRAP_curs_set(visibility);
        }
    }

    internal static partial class NativeMethods
    {
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_def_prog_mode();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_def_shell_mode();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_reset_prog_mode();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_reset_shell_mode();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_resetty();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_savetty();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void WRAP_getsyx(out int y, out int x);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void WRAP_setsyx(int y, int x);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_ripoffline(int line, RipOffLineFunInt init);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_napms(int ms);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_curs_set(int visibility);
    }
}
