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
        internal static int baudrate()
        {
            int ret = NativeMethods.WRAP_baudrate();
            InternalException.Verify(ret, "baudrate");
            return ret;
        }

        internal static char erasechar()
        {
            return NativeMethods.WRAP_erasechar();
        }

        internal static char killchar()
        {
            return NativeMethods.WRAP_killchar();
        }

        internal static uint termattrs()
        {
            return NativeMethods.WRAP_termattrs();
        }

        internal static bool has_ic()
        {
            return NativeMethods.WRAP_has_ic();
        }

        internal static bool has_il()
        {
            return NativeMethods.WRAP_has_il();
        }

        internal static string termname()
        {
            IntPtr ret = NativeMethods.WRAP_termname();
            InternalException.Verify(ret, "termname");
            return Marshal.PtrToStringAnsi(ret);
        }

        internal static string longname()
        {
            IntPtr ret = NativeMethods.WRAP_longname();
            InternalException.Verify(ret, "longname");
            return Marshal.PtrToStringAnsi(ret);
        }
    }

    internal static partial class NativeMethods
    {
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_baudrate();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        internal static extern char WRAP_erasechar();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        internal static extern char WRAP_killchar();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint WRAP_termattrs();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Boolean WRAP_has_ic();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Boolean WRAP_has_il();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr WRAP_termname();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr WRAP_longname();
    }
}
