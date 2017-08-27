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
        internal static void clearok(IntPtr win, bool bf)
        {
            int ret = NativeMethods.WRAP_clearok(win, bf);
            InternalException.Verify(ret, "clearok");
        }

        internal static void idlok(IntPtr win, bool bf)
        {
            int ret = NativeMethods.WRAP_idlok(win, bf);
            InternalException.Verify(ret, "idlok");
        }

        internal static void idcok(IntPtr win, bool bf)
        {
            NativeMethods.WRAP_idcok(win, bf);
        }

        internal static void immedok(IntPtr win, bool bf)
        {
            NativeMethods.WRAP_immedok(win, bf);
        }

        internal static void leaveok(IntPtr win, bool bf)
        {
            int ret = NativeMethods.WRAP_leaveok(win, bf);
            InternalException.Verify(ret, "leaveok");
        }

        internal static void wsetscrreg(IntPtr win, int top, int bot)
        {
            int ret = NativeMethods.WRAP_wsetscrreg(win, top, bot);
            InternalException.Verify(ret, "wsetscrreg");
        }

        internal static void scrollok(IntPtr win, bool bf)
        {
            int ret = NativeMethods.WRAP_scrollok(win, bf);
            InternalException.Verify(ret, "scrollok");
        }
    }

    internal static partial class NativeMethods
    {
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_clearok(IntPtr win, Boolean bf);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_idlok(IntPtr win, Boolean bf);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void WRAP_idcok(IntPtr win, Boolean bf);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void WRAP_immedok(IntPtr win, Boolean bf);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_leaveok(IntPtr win, Boolean bf);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_wsetscrreg(IntPtr win, int top, int bot);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_scrollok(IntPtr win, Boolean bf);
    }
}
