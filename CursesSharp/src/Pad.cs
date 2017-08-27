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
using CursesSharp.Internal;

namespace CursesSharp
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class Pad : WindowBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nlines"></param>
        /// <param name="ncols"></param>
        public Pad(int nlines, int ncols)
        {
            this.Handle = CursesMethods.newpad(nlines, ncols);
        }

        private Pad(IntPtr winptr, bool ownsPtr)
            : base(winptr, ownsPtr)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ch"></param>
        public override void EchoChar(char ch)
        {
            CursesMethods.pechochar(this.Handle, (byte)ch);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ch"></param>
        public override void EchoChar(uint ch)
        {
            CursesMethods.pechochar(this.Handle, ch);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="py"></param>
        /// <param name="px"></param>
        /// <param name="sy1"></param>
        /// <param name="sx1"></param>
        /// <param name="sy2"></param>
        /// <param name="sx2"></param>
        public void Refresh(int py, int px, int sy1, int sx1, int sy2, int sx2)
        {
            CursesMethods.prefresh(this.Handle, py, px, sy1, sx1, sy2, sx2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="py"></param>
        /// <param name="px"></param>
        /// <param name="sy1"></param>
        /// <param name="sx1"></param>
        /// <param name="sy2"></param>
        /// <param name="sx2"></param>
        public void NoOutRefresh(int py, int px, int sy1, int sx1, int sy2, int sx2)
        {
            CursesMethods.pnoutrefresh(this.Handle, py, px, sy1, sx1, sy2, sx2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nlines"></param>
        /// <param name="ncols"></param>
        /// <param name="begy"></param>
        /// <param name="begx"></param>
        /// <returns></returns>
        public Pad SubPad(int nlines, int ncols, int begy, int begx)
        {
            IntPtr newptr = CursesMethods.subpad(this.Handle, nlines, ncols, begy, begx);
            return new Pad(newptr, true);
        }
    }
}
