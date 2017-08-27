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
        internal static uint getbkgd(IntPtr win)
        {
            return NativeMethods.WRAP_getbkgd(win);
        }

        internal static void wbkgd(IntPtr win, uint ch)
        {
            int ret = NativeMethods.WRAP_wbkgd(win, ch);
            InternalException.Verify(ret, "wbkgd");
        }

        internal static void wbkgdset(IntPtr win, uint ch)
        {
            NativeMethods.WRAP_wbkgdset(win, ch);
        }
    }

    internal static partial class NativeMethods
    {
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint WRAP_getbkgd(IntPtr win);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_wbkgd(IntPtr win, uint ch);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void WRAP_wbkgdset(IntPtr win, uint ch);
    }
}
