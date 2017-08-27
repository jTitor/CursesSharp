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
#if HAVE_CURSES_MOUSE
    [StructLayout(LayoutKind.Sequential)]
    internal struct WrapMEvent
    {
        internal int id;
        internal int x;
        internal int y;
        internal int z;
        internal uint bstate;
    };

    internal static partial class CursesMethods
    {
        internal static bool has_mouse()
        {
            return NativeMethods.WRAP_has_mouse();
        }

        internal static void getmouse(out WrapMEvent mevent)
        {
            int ret = NativeMethods.WRAP_getmouse(out mevent);
            InternalException.Verify(ret, "getmouse");
        }

        internal static void ungetmouse(ref WrapMEvent mevent)
        {
            int ret = NativeMethods.WRAP_ungetmouse(ref mevent);
            InternalException.Verify(ret, "ungetmouse");
        }

        internal static uint mousemask(uint mask, out uint oldmask)
        {
            return NativeMethods.WRAP_mousemask(mask, out oldmask);
        }

        internal static bool wenclose(IntPtr win, int y, int x)
        {
            return NativeMethods.WRAP_wenclose(win, y, x);
        }

        internal static bool wmouse_trafo(IntPtr win, ref int y, ref int x, bool to_screen)
        {
            return NativeMethods.WRAP_wmouse_trafo(win, ref y, ref x, to_screen);
        }

        internal static int mouseinterval(int wait)
        {
            return NativeMethods.WRAP_mouseinterval(wait);
        }
    }

    internal static partial class NativeMethods
    {
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Boolean WRAP_has_mouse();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_getmouse(out WrapMEvent WRAP_mevent);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_ungetmouse(ref WrapMEvent WRAP_mevent);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint WRAP_mousemask(uint mask, out uint oldmask);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Boolean WRAP_wenclose(IntPtr win, int y, int x);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Boolean WRAP_wmouse_trafo(IntPtr win, ref int y, ref int x, Boolean to_screen);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_mouseinterval(int wait);
    }
#endif
}
