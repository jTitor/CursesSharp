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
#if HAVE_CURSES_PANEL
    internal static partial class CursesMethods
    {
        internal static IntPtr new_panel(IntPtr win)
        {
            IntPtr ret = NativeMethods.WRAP_new_panel(win);
            InternalException.Verify(ret, "new_panel");
            return ret;
        }

        internal static void bottom_panel(IntPtr pan)
        {
            int ret = NativeMethods.WRAP_bottom_panel(pan);
            InternalException.Verify(ret, "bottom_panel");
        }

        internal static void top_panel(IntPtr pan)
        {
            int ret = NativeMethods.WRAP_top_panel(pan);
            InternalException.Verify(ret, "top_panel");
        }

        internal static void show_panel(IntPtr pan)
        {
            int ret = NativeMethods.WRAP_show_panel(pan);
            InternalException.Verify(ret, "show_panel");
        }

        internal static void update_panels()
        {
            NativeMethods.WRAP_update_panels();
        }

        internal static void hide_panel(IntPtr pan)
        {
            int ret = NativeMethods.WRAP_hide_panel(pan);
            InternalException.Verify(ret, "hide_panel");
        }

        internal static IntPtr panel_window(IntPtr pan)
        {
            IntPtr ret = NativeMethods.WRAP_panel_window(pan);
            InternalException.Verify(ret, "panel_window");
            return ret;
        }

        internal static void replace_panel(IntPtr pan, IntPtr win)
        {
            int ret = NativeMethods.WRAP_replace_panel(pan, win);
            InternalException.Verify(ret, "replace_panel");
        }

        internal static void move_panel(IntPtr pan, int starty, int startx)
        {
            int ret = NativeMethods.WRAP_move_panel(pan, starty, startx);
            InternalException.Verify(ret, "move_panel");
        }

        internal static bool panel_hidden(IntPtr pan)
        {
            int ret = NativeMethods.WRAP_panel_hidden(pan);
            InternalException.Verify(ret, "panel_hidden");
            return (ret != 0);
        }

        internal static IntPtr panel_above(IntPtr pan)
        {
            return NativeMethods.WRAP_panel_above(pan);
        }

        internal static IntPtr panel_below(IntPtr pan)
        {
            return NativeMethods.WRAP_panel_below(pan);
        }

        internal static void del_panel(IntPtr pan)
        {
            int ret = NativeMethods.WRAP_del_panel(pan);
            InternalException.Verify(ret, "del_panel");
        }
    }

    internal static partial class NativeMethods
    {
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr WRAP_new_panel(IntPtr win);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_bottom_panel(IntPtr pan);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_top_panel(IntPtr pan);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_show_panel(IntPtr pan);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void WRAP_update_panels();
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_hide_panel(IntPtr pan);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr WRAP_panel_window(IntPtr pan);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_replace_panel(IntPtr pan, IntPtr win);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_move_panel(IntPtr pan, int starty, int startx);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_panel_hidden(IntPtr pan);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr WRAP_panel_above(IntPtr pan);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr WRAP_panel_below(IntPtr pan);
        [DllImport("CursesSharp.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WRAP_del_panel(IntPtr pan);
    }
#endif
}
