// File generated by attrgen

#pragma warning disable 1591

namespace CursesSharp
{
	// Character attributes
	public static class Attrs
	{
		public const uint NORMAL = 0x00000000U;
		public const uint ALTCHARSET = 0x00200000U;
		public const uint BLINK = 0x08000000U;
		public const uint BOLD = 0x10000000U;
		public const uint DIM = 0x80000000U;
		public const uint INVIS = 0x01000000U;
		public const uint PROTECT = 0x02c00000U;
		public const uint REVERSE = 0x04000000U;
		public const uint STANDOUT = 0x14000000U;
		public const uint UNDERLINE = 0x02000000U;
		// Attribute masks
		public const uint ATTRIBUTES = 0xffe00000U;
		public const uint CHARTEXT = 0x001fffffU;
		public const uint COLOR = 0x00000000U;
	}

	// Line drawing characters
	public static class Acs
	{
		public const uint BLOCK = 0x00200074U;
		public const uint BOARD = 0x0020002bU;
		public const uint BTEE = 0x0020005dU;
		public const uint BULLET = 0x00200068U;
		public const uint CKBOARD = 0x0020006bU;
		public const uint DARROW = 0x00200023U;
		public const uint DEGREE = 0x00200077U;
		public const uint DIAMOND = 0x0020006aU;
		public const uint GEQUAL = 0x00200076U;
		public const uint HLINE = 0x0020005fU;
		public const uint LANTERN = 0x0020007aU;
		public const uint LARROW = 0x00200021U;
		public const uint LEQUAL = 0x00200075U;
		public const uint LLCORNER = 0x00200059U;
		public const uint LRCORNER = 0x00200056U;
		public const uint LTEE = 0x0020005bU;
		public const uint NEQUAL = 0x00200025U;
		public const uint PI = 0x00200024U;
		public const uint PLMINUS = 0x00200078U;
		public const uint PLUS = 0x0020005aU;
		public const uint RARROW = 0x00200020U;
		public const uint RTEE = 0x0020005cU;
		public const uint S1 = 0x0020006cU;
		public const uint S3 = 0x0020006dU;
		public const uint S7 = 0x0020006eU;
		public const uint S9 = 0x0020006fU;
		public const uint STERLING = 0x0020007eU;
		public const uint TTEE = 0x0020005eU;
		public const uint UARROW = 0x00200022U;
		public const uint ULCORNER = 0x00200058U;
		public const uint URCORNER = 0x00200057U;
		public const uint VLINE = 0x00200060U;
	}

	// Colors
	public static class Colors
	{
		public const short BLACK = 0x0;
		public const short BLUE = 0x1;
		public const short GREEN = 0x2;
		public const short CYAN = 0x3;
		public const short RED = 0x4;
		public const short MAGENTA = 0x5;
		public const short YELLOW = 0x6;
		public const short WHITE = 0x7;
	}

	// Keys
	public static class Keys
	{
		public const int BREAK = 0xec01;
		public const int DOWN = 0xec02;
		public const int UP = 0xec03;
		public const int LEFT = 0xec04;
		public const int RIGHT = 0xec05;
		public const int HOME = 0xec06;
		public const int BACKSPACE = 0xec07;
		public const int F0 = 0xec08;
		public const int DL = 0xec48;
		public const int IL = 0xec49;
		public const int DC = 0xec4a;
		public const int IC = 0xec4b;
		public const int EIC = 0xec4c;
		public const int CLEAR = 0xec4d;
		public const int EOS = 0xec4e;
		public const int EOL = 0xec4f;
		public const int SF = 0xec50;
		public const int SR = 0xec51;
		public const int NPAGE = 0xec52;
		public const int PPAGE = 0xec53;
		public const int STAB = 0xec54;
		public const int CTAB = 0xec55;
		public const int CATAB = 0xec56;
		public const int ENTER = 0xec57;
		public const int SRESET = 0xec58;
		public const int RESET = 0xec59;
		public const int PRINT = 0xec5a;
		public const int LL = 0xec5b;
		public const int A1 = 0xecc1;
		public const int A3 = 0xecc3;
		public const int B2 = 0xecc5;
		public const int C1 = 0xecc7;
		public const int C3 = 0xecc9;
		public const int BTAB = 0xec5f;
		public const int BEG = 0xec60;
		public const int CANCEL = 0xec61;
		public const int CLOSE = 0xec62;
		public const int COMMAND = 0xec63;
		public const int COPY = 0xec64;
		public const int CREATE = 0xec65;
		public const int END = 0xec66;
		public const int EXIT = 0xec67;
		public const int FIND = 0xec68;
		public const int HELP = 0xec69;
		public const int MARK = 0xec6a;
		public const int MESSAGE = 0xec6b;
		public const int MOUSE = 0xed1b;
		public const int MOVE = 0xec6c;
		public const int NEXT = 0xec6d;
		public const int OPEN = 0xec6e;
		public const int OPTIONS = 0xec6f;
		public const int PREVIOUS = 0xec70;
		public const int REDO = 0xec71;
		public const int REFERENCE = 0xec72;
		public const int REFRESH = 0xec73;
		public const int REPLACE = 0xec74;
		public const int RESIZE = 0xed22;
		public const int RESTART = 0xec75;
		public const int RESUME = 0xec76;
		public const int SAVE = 0xec77;
		public const int SBEG = 0xec78;
		public const int SCANCEL = 0xec79;
		public const int SCOMMAND = 0xec7a;
		public const int SCOPY = 0xec7b;
		public const int SCREATE = 0xec7c;
		public const int SDC = 0xec7d;
		public const int SDL = 0xec7e;
		public const int SELECT = 0xec7f;
		public const int SEND = 0xec80;
		public const int SEOL = 0xec81;
		public const int SEXIT = 0xec82;
		public const int SFIND = 0xec83;
		public const int SHELP = 0xec5d;
		public const int SHOME = 0xec84;
		public const int SIC = 0xec85;
		public const int SLEFT = 0xec87;
		public const int SMESSAGE = 0xec88;
		public const int SMOVE = 0xec89;
		public const int SNEXT = 0xec8a;
		public const int SOPTIONS = 0xec8b;
		public const int SPREVIOUS = 0xec8c;
		public const int SPRINT = 0xec8d;
		public const int SREDO = 0xec8e;
		public const int SREPLACE = 0xec8f;
		public const int SRIGHT = 0xec90;
		public const int SRSUME = 0xec91;
		public const int SSAVE = 0xec92;
		public const int SSUSPEND = 0xec93;
		public const int SUNDO = 0xec94;
		public const int SUSPEND = 0xec95;
		public const int UNDO = 0xec96;

		public static int KEY_F(int n)
		{
			return Keys.F0 + n;
		}

		public const int MIN = 0xec01;
		public const int MAX = 0xed88;
	}

	// Mouse event masks
	[System.FlagsAttribute]
	public enum MouseState : uint
	{
		BUTTON1_PRESSED = 0x00000002U,
		BUTTON1_RELEASED = 0x00000001U,
		BUTTON1_CLICKED = 0x00000004U,
		BUTTON1_DOUBLE_CLICKED = 0x00000008U,
		BUTTON1_TRIPLE_CLICKED = 0x00000010U,
		BUTTON2_PRESSED = 0x00000040U,
		BUTTON2_RELEASED = 0x00000020U,
		BUTTON2_CLICKED = 0x00000080U,
		BUTTON2_DOUBLE_CLICKED = 0x00000100U,
		BUTTON2_TRIPLE_CLICKED = 0x00000200U,
		BUTTON3_PRESSED = 0x00000800U,
		BUTTON3_RELEASED = 0x00000400U,
		BUTTON3_CLICKED = 0x00001000U,
		BUTTON3_DOUBLE_CLICKED = 0x00002000U,
		BUTTON3_TRIPLE_CLICKED = 0x00004000U,
		BUTTON4_PRESSED = 0x00010000U,
		BUTTON4_RELEASED = 0x00008000U,
		BUTTON4_CLICKED = 0x00020000U,
		BUTTON4_DOUBLE_CLICKED = 0x00040000U,
		BUTTON4_TRIPLE_CLICKED = 0x00080000U,
		BUTTON_SHIFT = 0x04000000U,
		BUTTON_CTRL = 0x08000000U,
		BUTTON_ALT = 0x10000000U,
		ALL_MOUSE_EVENTS = 0x1fffffffU,
		REPORT_MOUSE_POSITION = 0x20000000U
	}
}
