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

#include "wrapper.h"


WRAP_API WINDOW *
WRAP_stdscr()
{
	return stdscr;
}

WRAP_API WINDOW *
WRAP_curscr()
{
	return curscr;
}

/*
WRAP_API WINDOW *
WRAP_newscr()
{
	return newscr;
}
 */

WRAP_API WINDOW *
WRAP_newwin(int nlines, int ncols, int begy, int begx)
{
	return newwin(nlines, ncols, begy, begx);
}

WRAP_API WINDOW *
WRAP_derwin(WINDOW* orig, int nlines, int ncols, int begy, int begx)
{
	return derwin(orig, nlines, ncols, begy, begx);
}

WRAP_API WINDOW *
WRAP_subwin(WINDOW* orig, int nlines, int ncols, int begy, int begx)
{
	return subwin(orig, nlines, ncols, begy, begx);
}

WRAP_API WINDOW *
WRAP_dupwin(WINDOW *win)
{
	return dupwin(win);
}

WRAP_API int
WRAP_delwin(WINDOW *win)
{
	return delwin(win);
}

WRAP_API int
WRAP_mvwin(WINDOW *win, int y, int x)
{
	return mvwin(win, y, x);
}

WRAP_API int
WRAP_mvderwin(WINDOW *win, int pary, int parx)
{
	return mvderwin(win, pary, parx);
}

WRAP_API int
WRAP_syncok(WINDOW *win, int bf)
{
	return syncok(win, (bool)bf);
}

WRAP_API void
WRAP_wsyncup(WINDOW *win)
{
	wsyncup(win);
}

WRAP_API void
WRAP_wcursyncup(WINDOW *win)
{
	wcursyncup(win);
}

WRAP_API void
WRAP_wsyncdown(WINDOW *win)
{
	wsyncdown(win);
}

