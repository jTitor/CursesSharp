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
WRAP_LINES(void)
{
	return LINES;
}

WRAP_API int
WRAP_COLS(void)
{
	return COLS;
}

WRAP_API void
WRAP_get_dims(int *lines, int *cols)
{
	*lines = LINES;
	*cols = COLS;
}

WRAP_API int
WRAP_COLORS(void)
{
	return COLORS;
}

WRAP_API int
WRAP_COLOR_PAIRS(void)
{
	return COLOR_PAIRS;
}

WRAP_API int
WRAP_TABSIZE(void)
{
	return TABSIZE;
}
