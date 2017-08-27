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
        internal static void wdeleteln(IntPtr win)
        {
            int ret = NativeMethods.WRAP_wdeleteln(win);
            InternalException.Verify(ret, "wdeleteln");
        }

        internal static void winsdelln(IntPtr win, int n)
        {
            int ret = NativeMethods.WRAP_winsdelln(win, n);
            InternalException.Verify(ret, "winsdelln");
        }

        internal static void winsertln(IntPtr win)
        {
            int ret = NativeMethods.WRAP_winsertln(win);
            InternalException.Verify(ret, "winsertln");
        }
    }

    internal static partial class NativeMethods
    {
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_wdeleteln(IntPtr win);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_winsdelln(IntPtr win, int n);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_winsertln(IntPtr win);
    }
}
