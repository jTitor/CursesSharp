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
using System.Text;

namespace CursesSharp.Internal
{
    internal static partial class CursesMethods
    {
        internal static void wgetnstr(IntPtr win, StringBuilder str, int n)
        {
            int ret = NativeMethods.WRAP_wgetnstr(win, str, n);
            InternalException.Verify(ret, "wgetnstr");
        }

        internal static void mvwgetnstr(IntPtr win, int y, int x, StringBuilder str, int n)
        {
            int ret = NativeMethods.WRAP_mvwgetnstr(win, y, x, str, n);
            InternalException.Verify(ret, "mvwgetnstr");
        }
    }

    internal static partial class NativeMethods
    {
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        internal static extern int WRAP_wgetnstr(IntPtr win, StringBuilder str, int n);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        internal static extern int WRAP_mvwgetnstr(IntPtr win, int y, int x, StringBuilder str, int n);
    }
}
