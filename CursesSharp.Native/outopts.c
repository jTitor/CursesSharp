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


WRAP_API int
WRAP_clearok(WINDOW *win, int bf)
{
	return clearok(win, (bool)bf);
}

WRAP_API int
WRAP_idlok(WINDOW *win, int bf)
{
	return idlok(win, (bool)bf);
}

WRAP_API void
WRAP_idcok(WINDOW *win, int bf)
{
	idcok(win, (bool)bf);
}

WRAP_API void
WRAP_immedok(WINDOW *win, int bf)
{
	immedok(win, (bool)bf);
}

WRAP_API int
WRAP_leaveok(WINDOW *win, int bf)
{
	return leaveok(win, (bool)bf);
}

WRAP_API int
WRAP_wsetscrreg(WINDOW *win, int top, int bot)
{
	return wsetscrreg(win, top, bot);
}

WRAP_API int
WRAP_scrollok(WINDOW *win, int bf)
{
	return scrollok(win, (bool)bf);
}
