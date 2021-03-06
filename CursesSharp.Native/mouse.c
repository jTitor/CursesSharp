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


#ifdef HAVE_CURSES_MOUSE

struct WrapMEvent 
{
	int id;
	int x;
	int y;
	int z;
	unsigned int bstate;
};

STATIC_ASSERT(sizeof(struct WrapMEvent) == 20);

WRAP_API int
WRAP_has_mouse(void)
{
#if defined(HAVE_HAS_MOUSE)
	return (int)has_mouse();
#else
	return 1;
#endif
}

WRAP_API int 
WRAP_getmouse(struct WrapMEvent *WRAP_mevent)
{
	//MEVENT mevent;
	int ret = getmouse();
	if (ret != ERR)
	{
		//WRAP_mevent->id = mevent.id;
		//WRAP_mevent->x = mevent.x;
		//WRAP_mevent->y = mevent.y;
		//WRAP_mevent->z = mevent.z;
		//WRAP_mevent->bstate = (unsigned int)mevent.bstate;
	}
	return ret;
}

WRAP_API int 
WRAP_ungetmouse(struct WrapMEvent *WRAP_mevent)
{
	MEVENT mevent;
	mevent.id = (short)WRAP_mevent->id;
	mevent.x = (int)WRAP_mevent->x;
	mevent.y = (int)WRAP_mevent->y;
	mevent.z = (int)WRAP_mevent->z;
	mevent.bstate = (mmask_t)WRAP_mevent->bstate;
	return ungetmouse(&mevent);
}

WRAP_API unsigned int
WRAP_mousemask(unsigned int mask, unsigned int *oldmask)
{
	return (unsigned int)mousemask((mmask_t)mask, (mmask_t*)oldmask);
}

WRAP_API int
WRAP_wenclose(WINDOW *win, int y, int x)
{
	return wenclose(win, y, x);
}

WRAP_API int
WRAP_wmouse_trafo(WINDOW *win, int *y, int *x, int to_screen)
{
	return wmouse_trafo(win, y, x, (bool)to_screen);
}

WRAP_API int 
WRAP_mouseinterval(int wait)
{
	return mouseinterval(wait);
}

#endif
