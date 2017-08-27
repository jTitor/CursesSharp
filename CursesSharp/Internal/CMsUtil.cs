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
        internal static string unctrl(uint c)
        {
            IntPtr ret = NativeMethods.WRAP_unctrl(c);
            InternalException.Verify(ret, "unctrl");
            return Marshal.PtrToStringAnsi(ret);
        }

        internal static void filter()
        {
            NativeMethods.WRAP_filter();
        }

        internal static void use_env(bool x)
        {
            NativeMethods.WRAP_use_env(x);
        }

        internal static void delay_output(int ms)
        {
            int ret = NativeMethods.WRAP_delay_output(ms);
            InternalException.Verify(ret, "delay_output");
        }

        internal static void sendsigtstp()
        {
            NativeMethods.WRAP_sendsigtstp();
        }
    }

    internal static partial class NativeMethods
    {
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void WRAP_sendsigtstp();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr WRAP_unctrl(uint c);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void WRAP_filter();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void WRAP_use_env(Boolean x);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_delay_output(int ms);
    }
}
