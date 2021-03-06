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
#include "unicode.h"
#include <errno.h>


WRAP_API int 
WRAP_slk_init(int fmt)
{
	return slk_init(fmt);
}

WRAP_API int 
WRAP_slk_set(int labnum, uchar2 *label, int labellen, int justify)
{
#if defined(CURSES_WIDE) && SIZEOF_WCHAR_T == 2
	return slk_wset(labnum, label, justify);
#elif defined(CURSES_WIDE)
	wchar_t stackbuf[BUFFER_SIZE];
	xbuffer xinput, xoutput;
	int ret;

	xbuf_init_uc(&xinput, label, labellen, XBUF_FILL);
	xbuf_init_wc(&xoutput, stackbuf, BUFFER_SIZE, XBUF_EXPANDABLE);

	ret = unicode_to_wchar(&xinput, &xoutput);
	if (ret < 0)
		goto do_exit;
	ret = xbuf_tzero_wc(&xoutput);
	if (ret < 0)
		goto do_exit;
	ret = slk_wset(labnum, xbuf_data_wc(&xoutput), justify);
do_exit:
	xbuf_free(&xoutput);
	return ret;
#else
	char stackbuf[BUFFER_SIZE];
	xbuffer xinput, xoutput;
	int ret;

	xbuf_init_uc(&xinput, label, labellen, XBUF_FILL);
	xbuf_init(&xoutput, stackbuf, BUFFER_SIZE, XBUF_EXPANDABLE);

	ret = unicode_to_char(&xinput, &xoutput);
	if (ret < 0)
		goto do_exit;
	ret = xbuf_tzero(&xoutput);
	if (ret < 0)
		goto do_exit;
	ret = slkset(labnum, xbuf_data(&xoutput), justify);
do_exit:
	xbuf_free(&xoutput);
	return ret;
#endif
}

WRAP_API int 
WRAP_slk_refresh(void)
{
	return slk_refresh();
}

WRAP_API int 
WRAP_slk_noutrefresh(void)
{
	return slk_noutrefresh();
}

WRAP_API const char *
WRAP_slk_label(int labnum)
{
	return slk_label(labnum);
}

WRAP_API int 
WRAP_slk_clear(void)
{
	return slk_clear();
}

WRAP_API int 
WRAP_slk_restore(void)
{
	return slk_restore();
}

WRAP_API int 
WRAP_slk_touch(void)
{
	return slk_touch();
}

WRAP_API int 
WRAP_slk_attron(unsigned int attrs)
{
	return slk_attron(attrs);
}

WRAP_API int 
WRAP_slk_attrset(unsigned int attrs)
{
	return slk_attrset(attrs);
}

WRAP_API int 
WRAP_slk_attroff(unsigned int attrs)
{
	return slk_attroff(attrs);
}

WRAP_API int 
WRAP_slk_color(short color_pair)
{
	return slk_color(color_pair);
}

