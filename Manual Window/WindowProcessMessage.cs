﻿namespace ManualWindow
{
    public enum WindowProcessMessage : uint
    {
        WM_NULL = 0,
        /// <summary>
        /// WM_CREATE<br/>
        /// extra1: -<br/>
        /// extra2: A pointer to CREATESTRUCT struct: <see cref="https://learn.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-createstructa">[LINK]</see><br/>
        /// return: 0
        /// </summary>
        ON_CREATE = 1,
        /// <summary>
        /// WM_DESTROY<br/>
        /// extra1: -<br/>
        /// extra2: -<br/>
        /// return: 0
        /// </summary>
        ON_BEING_DESTROYED = 2,
        /// <summary>
        /// WM_MOVE<br/>
        /// extra1: -<br/>
        /// extra2: The position of the top left corner of the client area. The lower 16 bits is the x position and the upper 16 bits is the y position.<br/>
        /// return: 0
        /// </summary>
        WINDOW_MOVED = 3,
        /// <summary>
        /// WM_SIZE<br/>
        /// extra1: A number, that coresponds to a value in the WindowResizeType enum.<br/>
        /// extra2: The new size of the client area. The lower 16 bits is the width and the upper 16 bits is the height.<br/>
        /// return: 0
        /// </summary>
        WINDOW_SIZE_CHANGED = 5,
        /// <summary>
        /// WM_ACTIVATE<br/>
        /// extra1: The lower 16 bits of the value maps to a value in WindowActivatedLowerHalf. If the upper 16 bits are not 0, the window is minimized.<br/>
        /// extra2: If WindowActivatedLowerHalf is DEACTIVATED, it's a pointer to the activatig window, otherwise it's to the deactivating one. The pointer can be null.<br/>
        /// return: 0
        /// </summary>
        ACTIVATE_DEACTIVEATE = 6,
        /// <summary>
        /// WM_SETFOCUS<br/>
        /// extra1: A handle to the window that has lost the keyboard focus. Can be null.<br/>
        /// extra2: -<br/>
        /// return: 0
        /// </summary>
        AFTER_KEYBOARD_FOCUS_GAINED = 7,
        /// <summary>
        /// WM_KILLFOCUS<br/>
        /// extra1: A handle to the window that receives the keyboard focus. Can be null.<br/>
        /// extra2: -<br/>
        /// return: 0
        /// </summary>
        BEFORE_KEYBOARD_FOCUS_LOST = 8,
        WM_ENABLE = 10,
        WM_SETREDRAW = 11,
        WM_SETTEXT = 12,
        /// <summary>
        /// WM_GETTEXT<br/>
        /// extra1: The maximum number of characters to be copied, including the terminating null character.<br/>
        /// extra2: A pointer to the buffer that is to receive the text.<br/>
        /// return: The number of characters copied, not including the terminating null character.
        /// </summary>
        COPY_TEXT_TO_BUFFER = 13,
        WM_GETTEXTLENGTH = 14,
        /// <summary>
        /// WM_PAINT<br/>
        /// extra1: -<br/>
        /// extra2: -<br/>
        /// return: 0
        /// </summary>
        PAINT_WINDOW_REQUEST = 15,
        /// <summary>
        /// WM_CLOSE<br/>
        /// extra1: -<br/>
        /// extra2: -<br/>
        /// return: 0
        /// </summary>
        SHOULD_TERMINATE = 16,
        WM_QUERYENDSESSION = 17,
        WM_QUIT = 18,
        WM_QUERYOPEN = 19,
        /// <summary>
        /// WM_ERASEBKGND<br/>
        /// extra1: A handle to the device context.<br/>
        /// extra2: -<br/>
        /// return: nonzero if the application erases the background.
        /// </summary>
        BACKGROUND_ERASE_NEEDED = 20,
        WM_SYSCOLORCHANGE = 21,
        WM_ENDSESSION = 22,
        /// <summary>
        /// WM_SHOWWINDOW<br/>
        /// extra1: true if the window is being shown, false if it's being hidden.<br/>
        /// extra2: A number, that coresponds to a number in the WindowShowHideReason enum.<br/>
        /// return: 0
        /// </summary>
        WINDOW_SHOWN_OR_HIDE = 24,
        WM_CTLCOLOR = 25,
        WM_WININICHANGE = 26,
        WM_DEVMODECHANGE = 27,
        /// <summary>
        /// WM_ACTIVATEAPP<br/>
        /// extra1: true if the window is being activated, false if it's being deactivated.<br/>
        /// extra2: If this window is being activated, it's the id of the thread that owns the window that is being deactivated, and vice versa.<br/>
        /// return: 0
        /// </summary>
        BEFORE_ACTIVATE_DEACTIVATE = 28,
        WM_FONTCHANGE = 29,
        WM_TIMECHANGE = 30,
        WM_CANCELMODE = 31,
        /// <summary>
        /// WM_SETCURSOR<br/>
        /// extra1: A handle to the window that contains the cursor.<br/>
        /// extra2: The lower half is a value from the CursorPosWindowPart enum. The upper part is the code of the message that triggered this event, or 0.<br/>
        /// return: Whether to halt further processing.
        /// </summary>
        CURSOR_MOVE = 32,
        /// <summary>
        /// WM_MOUSEACTIVATE<br/>
        /// extra1: A handle to the top-level parent window of the window being activated.<br/>
        /// extra2: The lower half is a value from the CursorPosWindowPart enum. The upper half is the ID of the mouse message.<br/>
        /// return: A value from the InactiveWindowMouseActionReturnValue enum.
        /// </summary>
        MOUSE_KEY_PRESSED_IN_INACTIVE_WINDOW = 33,
        WM_CHILDACTIVATE = 34,
        WM_QUEUESYNC = 35,
        /// <summary>
        /// WM_GETMINMAXINFO<br/>
        /// extra1: -<br/>
        /// extra2: A pointer to MINMAXINFO struct: <see cref="https://learn.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-minmaxinfo">[LINK]</see><br/>
        /// return: 0 to continue creation, -1 to abort.
        /// </summary>
        BEFORE_SIZE_OR_POSITION_CHANGE = 36,
        WM_PAINTICON = 38,
        WM_ICONERASEBKGND = 39,
        WM_NEXTDLGCTL = 40,
        WM_SPOOLERSTATUS = 42,
        WM_DRAWITEM = 43,
        WM_MEASUREITEM = 44,
        WM_DELETEITEM = 45,
        WM_VKEYTOITEM = 46,
        WM_CHARTOITEM = 47,
        WM_SETFONT = 48,
        WM_GETFONT = 49,
        WM_SETHOTKEY = 50,
        WM_GETHOTKEY = 51,
        WM_QUERYDRAGICON = 55,
        WM_COMPAREITEM = 57,
        WM_GETOBJECT = 61,
        WM_COMPACTING = 65,
        WM_COMMNOTIFY = 68,
        /// <summary>
        /// WM_WINDOWPOSCHANGING<br/>
        /// extra1: -<br/>
        /// extra2: A pointer to a WINDOWPOS struct: <see cref="https://learn.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-windowpos">[LINK]</see><br/>
        /// return: 0
        /// </summary>
        BEFORE_WINDOW_POS_CHANGE = 70,
        /// <summary>
        /// WM_WINDOWPOSCHANGED<br/>
        /// extra1: -<br/>
        /// extra2: A pointer to a WINDOWPOS struct: <see cref="https://learn.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-windowpos">[LINK]</see><br/>
        /// return: 0
        /// </summary>
        WINDOW_POS_CHANGED = 71,
        WM_POWER = 72,
        WM_COPYGLOBALDATA = 73,
        WM_COPYDATA = 74,
        WM_CANCELJOURNAL = 75,
        WM_NOTIFY = 78,
        WM_INPUTLANGCHANGEREQUEST = 80,
        WM_INPUTLANGCHANGE = 81,
        WM_TCARD = 82,
        WM_HELP = 83,
        WM_USERCHANGED = 84,
        WM_NOTIFYFORMAT = 85,
        /// <summary>
        /// WM_CONTEXTMENU<br/>
        /// extra1: A handle to the window in which the user requested the context menu.<br/>
        /// extra2: The lower half is the x-coordinate, the upper half is the y-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area. If the values are -1, the event was not rased by right clicking with the mouse.<br/>
        /// return: 0
        /// </summary>
        CONTEXT_MENU_REQUESTED = 123,
        WM_STYLECHANGING = 124,
        WM_STYLECHANGED = 125,
        WM_DISPLAYCHANGE = 126,
        /// <summary>
        /// WM_GETICON<br/>
        /// extra1: The type of the icon. The values map to the values of the WindowIconType enum.<br/>
        /// extra2: The DPI of the icon being retrieved.<br/>
        /// return: A handle to the large or small icon (HICON), depending on the value of extra1.
        /// </summary>
        GET_ICON = 127,
        WM_SETICON = 128,
        /// <summary>
        /// WM_NCCREATE<br/>
        /// extra1: -<br/>
        /// extra2: A pointer to CREATESTRUCT struct: <see cref="https://learn.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-createstructa">[LINK]</see><br/>
        /// return: true to continue creation, false to abort.
        /// </summary>
        BEFORE_WINDOW_CREATED = 129,
        /// <summary>
        /// WM_NCDESTROY<br/>
        /// extra1: -<br/>
        /// extra2: -<br/>
        /// return: 0
        /// </summary>
        ON_NONCLIENT_BEING_DESTROYED = 130,
        /// <summary>
        /// WM_NCCALCSIZE<br/>
        /// extra1: If true, it specifies that the application should indicate which part of the client area contains valid information. The system copies the valid information to the specified area within the new client area.<br/>
        /// extra2: If extra1 is true, a pointer to NCCALCSIZE_PARAMS struct: <see cref="https://learn.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-nccalcsize_params">[LINK]</see>.
        /// If extra1 is false, a pointer to RECT struct <see cref="https://learn.microsoft.com/en-us/windows/win32/api/windef/ns-windef-rect">[LINK]</see><br/>
        /// return: If extra1 is false: 0. If it's true and 0 is returned, the old window size/position is kept. If not, refer to <see cref="https://learn.microsoft.com/en-us/windows/win32/winmsg/wm-nccalcsize">[LINK]</see>
        /// </summary>
        CALCULATE_SIZE_AND_POSITION = 131,
        /// <summary>
        /// WM_NCHITTEST<br/>
        /// extra1: -<br/>
        /// extra2: The lower half is the x-coordinate, the upper half is the y-coordinate of the cursor. The coordinate is relative to the upper-left corner of the screen.<br/>
        /// return: One of the values from the WindowPart enum.
        /// </summary>
        SCREEN_POS_TO_WINDOW_PART = 132,
        /// <summary>
        /// WM_NCPAINT<br/>
        /// extra1: A handle to the update region of the window. The update region is clipped to the window frame.<br/>
        /// extra2: -<br/>
        /// return: 0
        /// </summary>
        FRAME_PAINT_NEEDED = 133,
        /// <summary>
        /// WM_NCACTIVATE<br/>
        /// extra1: true or false, depending on if the title bar or icon is activated or deactivated.<br/>
        /// extra2: If a visual style is active, it's unuse. Otherwise it's a pointer. If the value of this pointer is set to -1, the default window processor doesn't repaint the non-client area.<br/>
        /// return: If extra1 is false, return true to continue or false to prevent the change. If extra1 is true, it's ignored.
        /// </summary>
        NONCLIENT_ACTIVATE_DEACTIVEATE = 134,
        WM_GETDLGCODE = 135,
        /// <summary>
        /// WM_SYNCPAINT<br/>
        /// extra1: -<br/>
        /// extra2: -<br/>
        /// return: 0
        /// </summary>
        SYNC_WINDOW_PAINT = 136,
        WM_MOUSEQUERY = 155,

        /// <summary>
        /// WM_NCMOUSEMOVE<br/>
        /// extra1: A value from the CursorPosWindowPart enum.<br/>
        /// extra2: A POINTS structure that contains the x and y coordinates of the cursor. The coordinates are relative to the upper-left corner of the screen.<br/>
        /// return: 0
        /// </summary>
        NONCLIENT_MOUSE_MOVE = 160,
        /// <summary>
        /// WM_NCLBUTTONDOWN<br/>
        /// extra1: A value from the CursorPosWindowPart enum.<br/>
        /// extra2: A POINTS structure that contains the x and y coordinates of the cursor. The coordinates are relative to the upper-left corner of the screen.<br/>
        /// return: 0
        /// </summary>
        NONCLIENT_LEFT_BUTTON_DOWN = 161,
        /// <summary>
        /// WM_NCLBUTTONUP<br/>
        /// extra1: A value from the CursorPosWindowPart enum.<br/>
        /// extra2: A POINTS structure that contains the x and y coordinates of the cursor. The coordinates are relative to the upper-left corner of the screen.<br/>
        /// return: 0
        /// </summary>
        NONCLIENT_LEFT_BUTTON_UP = 162,
        /// <summary>
        /// WM_NCLBUTTONDBLCLK<br/>
        /// extra1: A value from the CursorPosWindowPart enum.<br/>
        /// extra2: A POINTS structure that contains the x and y coordinates of the cursor. The coordinates are relative to the upper-left corner of the screen.<br/>
        /// return: 0
        /// </summary>
        NONCLIENT_LEFT_BUTTON_DOUBLE_CLICK = 163,
        /// <summary>
        /// WM_NCRBUTTONDOWN<br/>
        /// extra1: A value from the CursorPosWindowPart enum.<br/>
        /// extra2: A POINTS structure that contains the x and y coordinates of the cursor. The coordinates are relative to the upper-left corner of the screen.<br/>
        /// return: 0
        /// </summary>
        NONCLIENT_RIGHT_BUTTON_DOWN = 164,
        /// <summary>
        /// WM_NCRBUTTONUP<br/>
        /// extra1: A value from the CursorPosWindowPart enum.<br/>
        /// extra2: A POINTS structure that contains the x and y coordinates of the cursor. The coordinates are relative to the upper-left corner of the screen.<br/>
        /// return: 0
        /// </summary>
        NONCLIENT_RIGHT_BUTTON_UP = 165,
        /// <summary>
        /// WM_NCRBUTTONDBLCLK<br/>
        /// extra1: A value from the CursorPosWindowPart enum.<br/>
        /// extra2: A POINTS structure that contains the x and y coordinates of the cursor. The coordinates are relative to the upper-left corner of the screen.<br/>
        /// return: 0
        /// </summary>
        NONCLIENT_RIGHT_BUTTON_DOUBLE_CLICK = 166,
        /// <summary>
        /// WM_NCMBUTTONDOWN<br/>
        /// extra1: A value from the CursorPosWindowPart enum.<br/>
        /// extra2: A POINTS structure that contains the x and y coordinates of the cursor. The coordinates are relative to the upper-left corner of the screen.<br/>
        /// return: 0
        /// </summary>
        NONCLIENT_MIDDLE_BUTTON_DOWN = 167,
        /// <summary>
        /// WM_NCMBUTTONUP<br/>
        /// extra1: A value from the CursorPosWindowPart enum.<br/>
        /// extra2: A POINTS structure that contains the x and y coordinates of the cursor. The coordinates are relative to the upper-left corner of the screen.<br/>
        /// return: 0
        /// </summary>
        NONCLIENT_MIDDLE_BUTTON_UP = 168,
        /// <summary>
        /// WM_NCMBUTTONDBLCLK<br/>
        /// extra1: A value from the CursorPosWindowPart enum.<br/>
        /// extra2: A POINTS structure that contains the x and y coordinates of the cursor. The coordinates are relative to the upper-left corner of the screen.<br/>
        /// return: 0
        /// </summary>
        NONCLIENT_MIDDLE_BUTTON_DOUBLE_CLICK = 169,
        WM_NCXBUTTONDOWN = 171,
        WM_NCXBUTTONUP = 172,
        WM_NCXBUTTONDBLCLK = 173,
        EM_GETSEL = 176,
        EM_SETSEL = 177,
        EM_GETRECT = 178,
        EM_SETRECT = 179,
        EM_SETRECTNP = 180,
        EM_SCROLL = 181,
        EM_LINESCROLL = 182,
        EM_SCROLLCARET = 183,
        EM_GETMODIFY = 185,
        EM_SETMODIFY = 187,
        EM_GETLINECOUNT = 188,
        EM_LINEINDEX = 189,
        EM_SETHANDLE = 190,
        EM_GETHANDLE = 191,
        EM_GETTHUMB = 192,
        EM_LINELENGTH = 193,
        EM_REPLACESEL = 194,
        EM_SETFONT = 195,
        EM_GETLINE = 196,
        EM_LIMITTEXT = 197,
        EM_SETLIMITTEXT = 197,
        EM_CANUNDO = 198,
        EM_UNDO = 199,
        EM_FMTLINES = 200,
        EM_LINEFROMCHAR = 201,
        EM_SETWORDBREAK = 202,
        EM_SETTABSTOPS = 203,
        EM_SETPASSWORDCHAR = 204,
        EM_EMPTYUNDOBUFFER = 205,
        EM_GETFIRSTVISIBLELINE = 206,
        EM_SETREADONLY = 207,
        EM_SETWORDBREAKPROC = 209,
        EM_GETWORDBREAKPROC = 209,
        EM_GETPASSWORDCHAR = 210,
        EM_SETMARGINS = 211,
        EM_GETMARGINS = 212,
        EM_GETLIMITTEXT = 213,
        EM_POSFROMCHAR = 214,
        EM_CHARFROMPOS = 215,
        EM_SETIMESTATUS = 216,
        EM_GETIMESTATUS = 217,
        SBM_SETPOS = 224,
        SBM_GETPOS = 225,
        SBM_SETRANGE = 226,
        SBM_GETRANGE = 227,
        SBM_ENABLE_ARROWS = 228,
        SBM_SETRANGEREDRAW = 230,
        SBM_SETSCROLLINFO = 233,
        SBM_GETSCROLLINFO = 234,
        SBM_GETSCROLLBARINFO = 235,
        BM_GETCHECK = 240,
        BM_SETCHECK = 241,
        BM_GETSTATE = 242,
        BM_SETSTATE = 243,
        BM_SETSTYLE = 244,
        BM_CLICK = 245,
        BM_GETIMAGE = 246,
        BM_SETIMAGE = 247,
        BM_SETDONTCLICK = 248,
        WM_INPUT = 255,
        // symbolic constant
        //WM_KEYFIRST = 256,
        /// <summary>
        /// WM_KEYDOWN<br/>
        /// extra1: A value from the VirtualKeyCode enum.<br/>
        /// extra2: The repeat count, scan code, extended-key flag, context code, previous key-state flag, and transition-state flag.<br/>
        /// return: 0
        /// </summary>
        KEY_DOWN = 256,
        /// <summary>
        /// WM_KEYUP<br/>
        /// extra1: A value from the VirtualKeyCode enum.<br/>
        /// extra2: The repeat count, scan code, extended-key flag, context code, previous key-state flag, and transition-state flag.<br/>
        /// return: 0
        /// </summary>
        KEY_UP = 257,
        WM_CHAR = 258,
        WM_DEADCHAR = 259,
        WM_SYSKEYDOWN = 260,
        WM_SYSKEYUP = 261,
        WM_SYSCHAR = 262,
        WM_SYSDEADCHAR = 263,
        // symbolic constant
        //WM_KEYLAST = 264,
        WM_UNICHAR_OR_WM_KEYLAST = 265,
        WM_WNT_CONVERTREQUESTEX = 265,
        WM_CONVERTREQUEST = 266,
        WM_CONVERTRESULT = 267,
        WM_INTERIM = 268,
        WM_IME_STARTCOMPOSITION = 269,
        WM_IME_ENDCOMPOSITION = 270,
        WM_IME_COMPOSITION = 271,
        WM_IME_KEYLAST = 271,
        WM_INITDIALOG = 272,
        WM_COMMAND = 273,
        /// <summary>
        /// WM_SYSCOMMAND<br/>
        /// extra1: A value from the SystemCommand enum.<br/>
        /// extra2: The lower half is the x-coordinate, the upper half is the y-coordinate of the cursor. The coordinate is relative to the upper-left corner of the screen. Or sometimes not?<br/>
        /// return: 0
        /// </summary>
        WINDOW_MENU_COMMAND = 274,
        WM_TIMER = 275,
        WM_HSCROLL = 276,
        WM_VSCROLL = 277,
        WM_INITMENU = 278,
        WM_INITMENUPOPUP = 279,
        WM_SYSTIMER = 280,
        WM_MENUSELECT = 287,
        WM_MENUCHAR = 288,
        WM_ENTERIDLE = 289,
        WM_MENURBUTTONUP = 290,
        WM_MENUDRAG = 291,
        WM_MENUGETOBJECT = 292,
        WM_UNINITMENUPOPUP = 293,
        WM_MENUCOMMAND = 294,
        WM_CHANGEUISTATE = 295,
        WM_UPDATEUISTATE = 296,
        WM_QUERYUISTATE = 297,
        WM_LBTRACKPOINT = 305,
        WM_CTLCOLORMSGBOX = 306,
        WM_CTLCOLOREDIT = 307,
        WM_CTLCOLORLISTBOX = 308,
        WM_CTLCOLORBTN = 309,
        WM_CTLCOLORDLG = 310,
        WM_CTLCOLORSCROLLBAR = 311,
        WM_CTLCOLORSTATIC = 312,
        CB_GETEDITSEL = 320,
        CB_LIMITTEXT = 321,
        CB_SETEDITSEL = 322,
        CB_ADDSTRING = 323,
        CB_DELETESTRING = 324,
        CB_DIR = 325,
        CB_GETCOUNT = 326,
        CB_GETCURSEL = 327,
        CB_GETLBTEXT = 328,
        CB_GETLBTEXTLEN = 329,
        CB_INSERTSTRING = 330,
        CB_RESETCONTENT = 331,
        CB_FINDSTRING = 332,
        CB_SELECTSTRING = 333,
        CB_SETCURSEL = 334,
        CB_SHOWDROPDOWN = 335,
        CB_GETITEMDATA = 336,
        CB_SETITEMDATA = 337,
        CB_GETDROPPEDCONTROLRECT = 338,
        CB_SETITEMHEIGHT = 339,
        CB_GETITEMHEIGHT = 340,
        CB_SETEXTENDEDUI = 341,
        CB_GETEXTENDEDUI = 342,
        CB_GETDROPPEDSTATE = 343,
        CB_FINDSTRINGEXACT = 344,
        CB_SETLOCALE = 345,
        CB_GETLOCALE = 346,
        CB_GETTOPINDEX = 347,
        CB_SETTOPINDEX = 348,
        CB_GETHORIZONTALEXTENT = 349,
        CB_SETHORIZONTALEXTENT = 350,
        CB_GETDROPPEDWIDTH = 351,
        CB_SETDROPPEDWIDTH = 352,
        CB_INITSTORAGE = 353,
        CB_MULTIPLEADDSTRING = 355,
        CB_GETCOMBOBOXINFO = 356,
        CB_MSGMAX = 357,
        // symbolic constant
        //WM_MOUSEFIRST = 512,
        /// <summary>
        /// WM_MOUSEMOVE<br/>
        /// extra1: A combination of values from the MouseVirtualKey enum.<br/>
        /// extra2: The lower half is the x-coordinate, the upper half is the y-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area.<br/>
        /// return: 0
        /// </summary>
        MOUSE_MOVE = 512,
        /// <summary>
        /// WM_LBUTTONDOWN<br/>
        /// extra1: A combination of values from the MouseVirtualKey enum.<br/>
        /// extra2: The lower half is the x-coordinate, the upper half is the y-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area.<br/>
        /// return: 0
        /// </summary>
        MOUSE_LEFT_BUTTON_DOWN = 513,
        /// <summary>
        /// WM_LBUTTONUP<br/>
        /// extra1: A combination of values from the MouseVirtualKey enum.<br/>
        /// extra2: The lower half is the x-coordinate, the upper half is the y-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area.<br/>
        /// return: 0
        /// </summary>
        MOUSE_LEFT_BUTTON_UP = 514,
        /// <summary>
        /// WM_LBUTTONDBLCLK<br/>
        /// extra1: A combination of values from the MouseVirtualKey enum.<br/>
        /// extra2: The lower half is the x-coordinate, the upper half is the y-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area.<br/>
        /// return: 0
        /// </summary>
        MOUSE_LEFT_BUTTON_DOUBLE_CLICK = 515,
        /// <summary>
        /// WM_RBUTTONDOWN<br/>
        /// extra1: A combination of values from the MouseVirtualKey enum.<br/>
        /// extra2: The lower half is the x-coordinate, the upper half is the y-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area.<br/>
        /// return: 0
        /// </summary>
        MOUSE_RIGHT_BUTTON_DOWN = 516,
        /// <summary>
        /// WM_RBUTTONUP<br/>
        /// extra1: A combination of values from the MouseVirtualKey enum.<br/>
        /// extra2: The lower half is the x-coordinate, the upper half is the y-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area.<br/>
        /// return: 0
        /// </summary>
        MOUSE_RIGHT_BUTTON_UP = 517,
        /// <summary>
        /// WM_RBUTTONDBLCLK<br/>
        /// extra1: A combination of values from the MouseVirtualKey enum.<br/>
        /// extra2: The lower half is the x-coordinate, the upper half is the y-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area.<br/>
        /// return: 0
        /// </summary>
        MOUSE_RIGHT_BUTTON_DOUBLE_CLICK = 518,
        /// <summary>
        /// WM_MBUTTONDOWN<br/>
        /// extra1: A combination of values from the MouseVirtualKey enum.<br/>
        /// extra2: The lower half is the x-coordinate, the upper half is the y-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area.<br/>
        /// return: 0
        /// </summary>
        MOUSE_MIDDLE_BUTTON_DOWN = 519,
        /// <summary>
        /// WM_MBUTTONUP<br/>
        /// extra1: A combination of values from the MouseVirtualKey enum.<br/>
        /// extra2: The lower half is the x-coordinate, the upper half is the y-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area.<br/>
        /// return: 0
        /// </summary>
        MOUSE_MIDDLE_BUTTON_UP = 520,
        /// <summary>
        /// WM_MBUTTONDBLCLK<br/>
        /// extra1: A combination of values from the MouseVirtualKey enum.<br/>
        /// extra2: The lower half is the x-coordinate, the upper half is the y-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area.<br/>
        /// return: 0
        /// </summary>
        MOUSE_MIDDLE_BUTTON_DOUBLE_CLICK = 521,
        // symbolic constant
        //WM_MOUSELAST = 521,
        /// <summary>
        /// WM_MOUSEWHEEL<br/>
        /// extra1: The lower half is a combination of values from MouseVirtualKey enum. The upper half is the distance the wheel rotated multiplied by WHEEL_DELTA(120). Positive values for scrollin up, negative for scrolling down.<br/>
        /// extra2: The lower half is the x-coordinate, the upper half is the y-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area.<br/>
        /// return: 0
        /// </summary>
        MOUSE_WHEEL_SCROLL = 522,
        /// <summary>
        /// WM_XBUTTONDOWN<br/>
        /// extra1: The lower half is a combination of values from MouseVirtualKey enum. The upper half is whitch x button was pressed (1 for X button 1, 2 for X button 2).<br/>
        /// extra2: The lower half is the x-coordinate, the upper half is the y-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area.<br/>
        /// return: true
        /// </summary>
        X_BUTTON_DOWN = 523,
        /// <summary>
        /// WM_XBUTTONUP<br/>
        /// extra1: The lower half is a combination of values from MouseVirtualKey enum. The upper half is whitch x button was pressed (1 for X button 1, 2 for X button 2).<br/>
        /// extra2: The lower half is the x-coordinate, the upper half is the y-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area.<br/>
        /// return: true
        /// </summary>
        X_BUTTON_UP = 524,
        /// <summary>
        /// WM_XBUTTONDBLCLK<br/>
        /// extra1: The lower half is a combination of values from MouseVirtualKey enum. The upper half is whitch x button was pressed (1 for X button 1, 2 for X button 2).<br/>
        /// extra2: The lower half is the x-coordinate, the upper half is the y-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area.<br/>
        /// return: true
        /// </summary>
        X_BUTTON_DOUBLE_CLICK = 525,
        WM_MOUSEHWHEEL = 526,
        WM_PARENTNOTIFY = 528,
        WM_ENTERMENULOOP = 529,
        WM_EXITMENULOOP = 530,
        WM_NEXTMENU = 531,
        /// <summary>
        /// WM_SIZING<br/>
        /// extra1: The edge of the window that is being sized. A value from the WindowSizingEdge enum.<br/>
        /// extra2: A pointer to a RECT structure with the current position of the window, in screen coordinates.<br/>
        /// return: true
        /// </summary>
        WINDOW_SIZING = 532,
        /// <summary>
        /// WM_CAPTURECHANGED<br/>
        /// extra1: -<br/>
        /// extra2: A handle to the window gaining the mouse capture.<br/>
        /// return: 0
        /// </summary>
        MOUSE_CAPTURE_LOST = 533,
        /// <summary>
        /// WM_MOVING<br/>
        /// extra1: -<br/>
        /// extra2: A pointer to a RECT structure with the current position of the window, in screen coordinates.<br/>
        /// return: true
        /// </summary>
        WINDOW_MOVING = 534,
        WM_POWERBROADCAST = 536,
        WM_DEVICECHANGE = 537,
        WM_MDICREATE = 544,
        WM_MDIDESTROY = 545,
        WM_MDIACTIVATE = 546,
        WM_MDIRESTORE = 547,
        WM_MDINEXT = 548,
        WM_MDIMAXIMIZE = 549,
        WM_MDITILE = 550,
        WM_MDICASCADE = 551,
        WM_MDIICONARRANGE = 552,
        WM_MDIGETACTIVE = 553,
        WM_MDISETMENU = 560,
        /// <summary>
        /// WM_ENTERSIZEMOVE<br/>
        /// extra1: -<br/>
        /// extra2: -<br/>
        /// return: 0
        /// </summary>
        ENTER_SIZING_OR_MOVING_MODE = 561,
        /// <summary>
        /// WM_EXITSIZEMOVE<br/>
        /// extra1: -<br/>
        /// extra2: -<br/>
        /// return: 0
        /// </summary>
        EXIT_SIZING_OR_MOVING_MODE = 562,
        WM_DROPFILES = 563,
        WM_MDIREFRESHMENU = 564,
        WM_POINTERDEVICECHANGE = 568,
        WM_POINTERDEVICEINRANGE = 569,
        WM_POINTERDEVICEOUTOFRANGE = 570,
        WM_POINTERUPDATE = 581,
        WM_POINTERDOWN = 582,
        WM_POINTERUP = 583,
        WM_POINTERENTER = 585,
        WM_POINTERLEAVE = 586,
        WM_POINTERACTIVATE = 587,
        WM_POINTERCAPTURECHANGED = 588,

        WM_IME_REPORT = 640,
        /// <summary>
        /// WM_IME_SETCONTEXT<br/>
        /// extra1: true if the window is active, and false otherwise.<br/>
        /// extra2: The display options. The value is a composite of the values in the WindowActivateDeactivateDisplayOptionsPart enum.<br/>
        /// return: Use the value returned by DefWindowProc or ImmIsUIMessage.
        /// </summary>
        IME_ACTIVATE_DEACTIVATE = 641,
        /// <summary>
        /// WM_IME_NOTIFY<br/>
        /// extra1: The IME command type. The values map to the values of the IMENotifyCommand enum.<br/>
        /// extra2: Depends on the command type from extra1. <see cref="https://learn.microsoft.com/en-us/windows/win32/intl/wm-ime-notify">[LINK]</see><br/>
        /// return: Depends on the command type from extra1, but ALL commands seem to have no return value.
        /// </summary>
        IME_NOTIFY = 642,
        WM_IME_CONTROL = 643,
        WM_IME_COMPOSITIONFULL = 644,
        WM_IME_SELECT = 645,
        WM_IME_CHAR = 646,
        WM_IME_REQUEST = 648,
        WM_IME_KEYDOWN = 656,
        WM_IME_KEYUP = 657,
        WM_NCMOUSEHOVER = 672,
        WM_MOUSEHOVER = 673,
        /// <summary>
        /// WM_NCMOUSELEAVE<br/>
        /// extra1: -<br/>
        /// extra2: -<br/>
        /// return: 0
        /// </summary>
        MOUSE_LEAVE_NONCLIENT_AREA = 674,
        WM_MOUSELEAVE = 675,

        WM_TABLET_DEFBASE = 704,
        //WM_TABLET_MAXOFFSET = 0x20,
        WM_TABLET_ADDED = WM_TABLET_DEFBASE + 8,
        WM_TABLET_DELETED = WM_TABLET_DEFBASE + 9,
        WM_TABLET_FLICK = WM_TABLET_DEFBASE + 11,
        WM_TABLET_QUERYSYSTEMGESTURESTATUS = WM_TABLET_DEFBASE + 12,

        WM_DPICHANGED = 736,
        WM_DPICHANGED_BEFOREPARENT = 738,
        WM_DPICHANGED_AFTERPARENT = 739,

        WM_CUT = 768,
        WM_COPY = 769,
        WM_PASTE = 770,
        WM_CLEAR = 771,
        WM_UNDO = 772,
        WM_RENDERFORMAT = 773,
        WM_RENDERALLFORMATS = 774,
        WM_DESTROYCLIPBOARD = 775,
        WM_DRAWCLIPBOARD = 776,
        WM_PAINTCLIPBOARD = 777,
        WM_VSCROLLCLIPBOARD = 778,
        /// <summary>
        /// WM_SIZECLIPBOARD<br/>
        /// extra1: a handle to the clipboard viewer window.<br/>
        /// extra2: a pointer to RECT struct <see cref="https://learn.microsoft.com/en-us/windows/win32/api/windef/ns-windef-rect">[LINK]</see><br/>
        /// return: 0
        /// </summary>
        CLIPBOARD_SIZE_CHANGED = 779,
        WM_ASKCBFORMATNAME = 780,
        WM_CHANGECBCHAIN = 781,
        WM_HSCROLLCLIPBOARD = 782,
        WM_QUERYNEWPALETTE = 783,
        WM_PALETTEISCHANGING = 784,
        WM_PALETTECHANGED = 785,
        WM_HOTKEY = 786,
        WM_WTSSESSION_CHANGE = 689,
        WM_PRINT = 791,
        WM_PRINTCLIENT = 792,
        WM_APPCOMMAND = 793,
        WM_THEMECHANGED = 794,

        WM_DWMCOMPOSITIONCHANGED = 798,
        /// <summary>
        /// WM_DWMNCRENDERINGCHANGED<br/>
        /// extra1: whether DWM rendering is enabled for the non-client area of the window.<br/>
        /// extra2: -<br/>
        /// return: 0
        /// </summary>
        NONCLIENT_AREA_RENDERING_POLICY_CHANGED = 799,
        WM_DWMCOLORIZATIONCOLORCHANGED = 800,
        WM_DWMWINDOWMAXIMIZEDCHANGE = 801,

        #region Windows 7
        WM_DWMSENDICONICTHUMBNAIL = 803,
        WM_DWMSENDICONICLIVEPREVIEWBITMAP = 806,
        #endregion

        WM_HANDHELDFIRST = 856,
        WM_HANDHELDLAST = 863,
        WM_AFXFIRST = 864,
        WM_AFXLAST = 895,
        WM_PENWINFIRST = 896,
        WM_RCRESULT = 897,
        WM_HOOKRCRESULT = 898,
        WM_GLOBALRCCHANGE = 899,
        WM_PENMISCINFO = 899,
        WM_SKB = 900,
        WM_HEDITCTL = 901,
        WM_PENCTL = 901,
        WM_PENMISC = 902,
        WM_CTLINIT = 903,
        WM_PENEVENT = 904,
        WM_PENWINLAST = 911,
        DDM_SETFMT = 1024,
        DM_GETDEFID = 1024,
        NIN_SELECT = 1024,
        TBM_GETPOS = 1024,
        WM_PSD_PAGESETUPDLG = 1024,
        WM_USER = 1024,
        CBEM_INSERTITEMA = 1025,
        DDM_DRAW = 1025,
        DM_SETDEFID = 1025,
        HKM_SETHOTKEY = 1025,
        PBM_SETRANGE = 1025,
        RB_INSERTBANDA = 1025,
        SB_SETTEXTA = 1025,
        TB_ENABLEBUTTON = 1025,
        TBM_GETRANGEMIN = 1025,
        TTM_ACTIVATE = 1025,
        WM_CHOOSEFONT_GETLOGFONT = 1025,
        WM_PSD_FULLPAGERECT = 1025,
        CBEM_SETIMAGELIST = 1026,
        DDM_CLOSE = 1026,
        DM_REPOSITION = 1026,
        HKM_GETHOTKEY = 1026,
        PBM_SETPOS = 1026,
        RB_DELETEBAND = 1026,
        SB_GETTEXTA = 1026,
        TB_CHECKBUTTON = 1026,
        TBM_GETRANGEMAX = 1026,
        WM_PSD_MINMARGINRECT = 1026,
        CBEM_GETIMAGELIST = 1027,
        DDM_BEGIN = 1027,
        HKM_SETRULES = 1027,
        PBM_DELTAPOS = 1027,
        RB_GETBARINFO = 1027,
        SB_GETTEXTLENGTHA = 1027,
        TBM_GETTIC = 1027,
        TB_PRESSBUTTON = 1027,
        TTM_SETDELAYTIME = 1027,
        WM_PSD_MARGINRECT = 1027,
        CBEM_GETITEMA = 1028,
        DDM_END = 1028,
        PBM_SETSTEP = 1028,
        RB_SETBARINFO = 1028,
        SB_SETPARTS = 1028,
        TB_HIDEBUTTON = 1028,
        TBM_SETTIC = 1028,
        TTM_ADDTOOLA = 1028,
        WM_PSD_GREEKTEXTRECT = 1028,
        CBEM_SETITEMA = 1029,
        PBM_STEPIT = 1029,
        TB_INDETERMINATE = 1029,
        TBM_SETPOS = 1029,
        TTM_DELTOOLA = 1029,
        WM_PSD_ENVSTAMPRECT = 1029,
        CBEM_GETCOMBOCONTROL = 1030,
        PBM_SETRANGE32 = 1030,
        RB_SETBANDINFOA = 1030,
        SB_GETPARTS = 1030,
        TB_MARKBUTTON = 1030,
        TBM_SETRANGE = 1030,
        TTM_NEWTOOLRECTA = 1030,
        WM_PSD_YAFULLPAGERECT = 1030,
        CBEM_GETEDITCONTROL = 1031,
        PBM_GETRANGE = 1031,
        RB_SETPARENT = 1031,
        SB_GETBORDERS = 1031,
        TBM_SETRANGEMIN = 1031,
        TTM_RELAYEVENT = 1031,
        CBEM_SETEXSTYLE = 1032,
        PBM_GETPOS = 1032,
        RB_HITTEST = 1032,
        SB_SETMINHEIGHT = 1032,
        TBM_SETRANGEMAX = 1032,
        TTM_GETTOOLINFOA = 1032,
        CBEM_GETEXSTYLE = 1033,
        CBEM_GETEXTENDEDSTYLE = 1033,
        PBM_SETBARCOLOR = 1033,
        RB_GETRECT = 1033,
        SB_SIMPLE = 1033,
        TB_ISBUTTONENABLED = 1033,
        TBM_CLEARTICS = 1033,
        TTM_SETTOOLINFOA = 1033,
        CBEM_HASEDITCHANGED = 1034,
        RB_INSERTBANDW = 1034,
        SB_GETRECT = 1034,
        TB_ISBUTTONCHECKED = 1034,
        TBM_SETSEL = 1034,
        TTM_HITTESTA = 1034,
        WIZ_QUERYNUMPAGES = 1034,
        CBEM_INSERTITEMW = 1035,
        RB_SETBANDINFOW = 1035,
        SB_SETTEXTW = 1035,
        TB_ISBUTTONPRESSED = 1035,
        TBM_SETSELSTART = 1035,
        TTM_GETTEXTA = 1035,
        WIZ_NEXT = 1035,
        CBEM_SETITEMW = 1036,
        RB_GETBANDCOUNT = 1036,
        SB_GETTEXTLENGTHW = 1036,
        TB_ISBUTTONHIDDEN = 1036,
        TBM_SETSELEND = 1036,
        TTM_UPDATETIPTEXTA = 1036,
        WIZ_PREV = 1036,
        CBEM_GETITEMW = 1037,
        RB_GETROWCOUNT = 1037,
        SB_GETTEXTW = 1037,
        TB_ISBUTTONINDETERMINATE = 1037,
        TTM_GETTOOLCOUNT = 1037,
        CBEM_SETEXTENDEDSTYLE = 1038,
        RB_GETROWHEIGHT = 1038,
        SB_ISSIMPLE = 1038,
        TB_ISBUTTONHIGHLIGHTED = 1038,
        TBM_GETPTICS = 1038,
        TTM_ENUMTOOLSA = 1038,
        SB_SETICON = 1039,
        TBM_GETTICPOS = 1039,
        TTM_GETCURRENTTOOLA = 1039,
        RB_IDTOINDEX = 1040,
        SB_SETTIPTEXTA = 1040,
        TBM_GETNUMTICS = 1040,
        TTM_WINDOWFROMPOINT = 1040,
        RB_GETTOOLTIPS = 1041,
        SB_SETTIPTEXTW = 1041,
        TBM_GETSELSTART = 1041,
        TB_SETSTATE = 1041,
        TTM_TRACKACTIVATE = 1041,
        RB_SETTOOLTIPS = 1042,
        SB_GETTIPTEXTA = 1042,
        TB_GETSTATE = 1042,
        TBM_GETSELEND = 1042,
        TTM_TRACKPOSITION = 1042,
        RB_SETBKCOLOR = 1043,
        SB_GETTIPTEXTW = 1043,
        TB_ADDBITMAP = 1043,
        TBM_CLEARSEL = 1043,
        TTM_SETTIPBKCOLOR = 1043,
        RB_GETBKCOLOR = 1044,
        SB_GETICON = 1044,
        TB_ADDBUTTONSA = 1044,
        TBM_SETTICFREQ = 1044,
        TTM_SETTIPTEXTCOLOR = 1044,
        RB_SETTEXTCOLOR = 1045,
        TB_INSERTBUTTONA = 1045,
        TBM_SETPAGESIZE = 1045,
        TTM_GETDELAYTIME = 1045,
        RB_GETTEXTCOLOR = 1046,
        TB_DELETEBUTTON = 1046,
        TBM_GETPAGESIZE = 1046,
        TTM_GETTIPBKCOLOR = 1046,
        RB_SIZETORECT = 1047,
        TB_GETBUTTON = 1047,
        TBM_SETLINESIZE = 1047,
        TTM_GETTIPTEXTCOLOR = 1047,
        RB_BEGINDRAG = 1048,
        TB_BUTTONCOUNT = 1048,
        TBM_GETLINESIZE = 1048,
        TTM_SETMAXTIPWIDTH = 1048,
        RB_ENDDRAG = 1049,
        TB_COMMANDTOINDEX = 1049,
        TBM_GETTHUMBRECT = 1049,
        TTM_GETMAXTIPWIDTH = 1049,
        RB_DRAGMOVE = 1050,
        TBM_GETCHANNELRECT = 1050,
        TB_SAVERESTOREA = 1050,
        TTM_SETMARGIN = 1050,
        RB_GETBARHEIGHT = 1051,
        TB_CUSTOMIZE = 1051,
        TBM_SETTHUMBLENGTH = 1051,
        TTM_GETMARGIN = 1051,
        RB_GETBANDINFOW = 1052,
        TB_ADDSTRINGA = 1052,
        TBM_GETTHUMBLENGTH = 1052,
        TTM_POP = 1052,
        RB_GETBANDINFOA = 1053,
        TB_GETITEMRECT = 1053,
        TBM_SETTOOLTIPS = 1053,
        TTM_UPDATE = 1053,
        RB_MINIMIZEBAND = 1054,
        TB_BUTTONSTRUCTSIZE = 1054,
        TBM_GETTOOLTIPS = 1054,
        TTM_GETBUBBLESIZE = 1054,
        RB_MAXIMIZEBAND = 1055,
        TBM_SETTIPSIDE = 1055,
        TB_SETBUTTONSIZE = 1055,
        TTM_ADJUSTRECT = 1055,
        TBM_SETBUDDY = 1056,
        TB_SETBITMAPSIZE = 1056,
        TTM_SETTITLEA = 1056,
        MSG_FTS_JUMP_VA = 1057,
        TB_AUTOSIZE = 1057,
        TBM_GETBUDDY = 1057,
        TTM_SETTITLEW = 1057,
        RB_GETBANDBORDERS = 1058,
        MSG_FTS_JUMP_QWORD = 1059,
        RB_SHOWBAND = 1059,
        TB_GETTOOLTIPS = 1059,
        MSG_REINDEX_REQUEST = 1060,
        TB_SETTOOLTIPS = 1060,
        MSG_FTS_WHERE_IS_IT = 1061,
        RB_SETPALETTE = 1061,
        TB_SETPARENT = 1061,
        RB_GETPALETTE = 1062,
        RB_MOVEBAND = 1063,
        TB_SETROWS = 1063,
        TB_GETROWS = 1064,
        TB_GETBITMAPFLAGS = 1065,
        TB_SETCMDID = 1066,
        RB_PUSHCHEVRON = 1067,
        TB_CHANGEBITMAP = 1067,
        TB_GETBITMAP = 1068,
        MSG_GET_DEFFONT = 1069,
        TB_GETBUTTONTEXTA = 1069,
        TB_REPLACEBITMAP = 1070,
        TB_SETINDENT = 1071,
        TB_SETIMAGELIST = 1072,
        TB_GETIMAGELIST = 1073,
        TB_LOADIMAGES = 1074,
        EM_CANPASTE = 1074,
        TTM_ADDTOOLW = 1074,
        EM_DISPLAYBAND = 1075,
        TB_GETRECT = 1075,
        TTM_DELTOOLW = 1075,
        EM_EXGETSEL = 1076,
        TB_SETHOTIMAGELIST = 1076,
        TTM_NEWTOOLRECTW = 1076,
        EM_EXLIMITTEXT = 1077,
        TB_GETHOTIMAGELIST = 1077,
        TTM_GETTOOLINFOW = 1077,
        EM_EXLINEFROMCHAR = 1078,
        TB_SETDISABLEDIMAGELIST = 1078,
        TTM_SETTOOLINFOW = 1078,
        EM_EXSETSEL = 1079,
        TB_GETDISABLEDIMAGELIST = 1079,
        TTM_HITTESTW = 1079,
        EM_FINDTEXT = 1080,
        TB_SETSTYLE = 1080,
        TTM_GETTEXTW = 1080,
        EM_FORMATRANGE = 1081,
        TB_GETSTYLE = 1081,
        TTM_UPDATETIPTEXTW = 1081,
        EM_GETCHARFORMAT = 1082,
        TB_GETBUTTONSIZE = 1082,
        TTM_ENUMTOOLSW = 1082,
        EM_GETEVENTMASK = 1083,
        TB_SETBUTTONWIDTH = 1083,
        TTM_GETCURRENTTOOLW = 1083,
        EM_GETOLEINTERFACE = 1084,
        TB_SETMAXTEXTROWS = 1084,
        EM_GETPARAFORMAT = 1085,
        TB_GETTEXTROWS = 1085,
        EM_GETSELTEXT = 1086,
        TB_GETOBJECT = 1086,
        EM_HIDESELECTION = 1087,
        TB_GETBUTTONINFOW = 1087,
        EM_PASTESPECIAL = 1088,
        TB_SETBUTTONINFOW = 1088,
        EM_REQUESTRESIZE = 1089,
        TB_GETBUTTONINFOA = 1089,
        EM_SELECTIONTYPE = 1090,
        TB_SETBUTTONINFOA = 1090,
        EM_SETBKGNDCOLOR = 1091,
        TB_INSERTBUTTONW = 1091,
        EM_SETCHARFORMAT = 1092,
        TB_ADDBUTTONSW = 1092,
        EM_SETEVENTMASK = 1093,
        TB_HITTEST = 1093,
        EM_SETOLECALLBACK = 1094,
        TB_SETDRAWTEXTFLAGS = 1094,
        EM_SETPARAFORMAT = 1095,
        TB_GETHOTITEM = 1095,
        EM_SETTARGETDEVICE = 1096,
        TB_SETHOTITEM = 1096,
        EM_STREAMIN = 1097,
        TB_SETANCHORHIGHLIGHT = 1097,
        EM_STREAMOUT = 1098,
        TB_GETANCHORHIGHLIGHT = 1098,
        EM_GETTEXTRANGE = 1099,
        TB_GETBUTTONTEXTW = 1099,
        EM_FINDWORDBREAK = 1100,
        TB_SAVERESTOREW = 1100,
        EM_SETOPTIONS = 1101,
        TB_ADDSTRINGW = 1101,
        EM_GETOPTIONS = 1102,
        TB_MAPACCELERATORA = 1102,
        EM_FINDTEXTEX = 1103,
        TB_GETINSERTMARK = 1103,
        EM_GETWORDBREAKPROCEX = 1104,
        TB_SETINSERTMARK = 1104,
        EM_SETWORDBREAKPROCEX = 1105,
        TB_INSERTMARKHITTEST = 1105,
        EM_SETUNDOLIMIT = 1106,
        TB_MOVEBUTTON = 1106,
        TB_GETMAXSIZE = 1107,
        EM_REDO = 1108,
        TB_SETEXTENDEDSTYLE = 1108,
        EM_CANREDO = 1109,
        TB_GETEXTENDEDSTYLE = 1109,
        EM_GETUNDONAME = 1110,
        TB_GETPADDING = 1110,
        EM_GETREDONAME = 1111,
        TB_SETPADDING = 1111,
        EM_STOPGROUPTYPING = 1112,
        TB_SETINSERTMARKCOLOR = 1112,
        EM_SETTEXTMODE = 1113,
        TB_GETINSERTMARKCOLOR = 1113,
        EM_GETTEXTMODE = 1114,
        TB_MAPACCELERATORW = 1114,
        EM_AUTOURLDETECT = 1115,
        TB_GETSTRINGW = 1115,
        EM_GETAUTOURLDETECT = 1116,
        TB_GETSTRINGA = 1116,
        EM_SETPALETTE = 1117,
        EM_GETTEXTEX = 1118,
        EM_GETTEXTLENGTHEX = 1119,
        EM_SHOWSCROLLBAR = 1120,
        EM_SETTEXTEX = 1121,
        TAPI_REPLY = 1123,
        ACM_OPENA = 1124,
        BFFM_SETSTATUSTEXTA = 1124,
        CDM_FIRST = 1124,
        CDM_GETSPEC = 1124,
        EM_SETPUNCTUATION = 1124,
        IPM_CLEARADDRESS = 1124,
        WM_CAP_UNICODE_START = 1124,
        ACM_PLAY = 1125,
        BFFM_ENABLEOK = 1125,
        CDM_GETFILEPATH = 1125,
        EM_GETPUNCTUATION = 1125,
        IPM_SETADDRESS = 1125,
        PSM_SETCURSEL = 1125,
        UDM_SETRANGE = 1125,
        WM_CHOOSEFONT_SETLOGFONT = 1125,
        ACM_STOP = 1126,
        BFFM_SETSELECTIONA = 1126,
        CDM_GETFOLDERPATH = 1126,
        EM_SETWORDWRAPMODE = 1126,
        IPM_GETADDRESS = 1126,
        PSM_REMOVEPAGE = 1126,
        UDM_GETRANGE = 1126,
        WM_CAP_SET_CALLBACK_ERRORW = 1126,
        WM_CHOOSEFONT_SETFLAGS = 1126,
        ACM_OPENW = 1127,
        BFFM_SETSELECTIONW = 1127,
        CDM_GETFOLDERIDLIST = 1127,
        EM_GETWORDWRAPMODE = 1127,
        IPM_SETRANGE = 1127,
        PSM_ADDPAGE = 1127,
        UDM_SETPOS = 1127,
        WM_CAP_SET_CALLBACK_STATUSW = 1127,
        BFFM_SETSTATUSTEXTW = 1128,
        CDM_SETCONTROLTEXT = 1128,
        EM_SETIMECOLOR = 1128,
        IPM_SETFOCUS = 1128,
        PSM_CHANGED = 1128,
        UDM_GETPOS = 1128,
        CDM_HIDECONTROL = 1129,
        EM_GETIMECOLOR = 1129,
        IPM_ISBLANK = 1129,
        PSM_RESTARTWINDOWS = 1129,
        UDM_SETBUDDY = 1129,
        CDM_SETDEFEXT = 1130,
        EM_SETIMEOPTIONS = 1130,
        PSM_REBOOTSYSTEM = 1130,
        UDM_GETBUDDY = 1130,
        EM_GETIMEOPTIONS = 1131,
        PSM_CANCELTOCLOSE = 1131,
        UDM_SETACCEL = 1131,
        EM_CONVPOSITION = 1132,
        PSM_QUERYSIBLINGS = 1132,
        UDM_GETACCEL = 1132,
        MCIWNDM_GETZOOM = 1133,
        PSM_UNCHANGED = 1133,
        UDM_SETBASE = 1133,
        PSM_APPLY = 1134,
        UDM_GETBASE = 1134,
        PSM_SETTITLEA = 1135,
        UDM_SETRANGE32 = 1135,
        PSM_SETWIZBUTTONS = 1136,
        UDM_GETRANGE32 = 1136,
        WM_CAP_DRIVER_GET_NAMEW = 1136,
        PSM_PRESSBUTTON = 1137,
        UDM_SETPOS32 = 1137,
        WM_CAP_DRIVER_GET_VERSIONW = 1137,
        PSM_SETCURSELID = 1138,
        UDM_GETPOS32 = 1138,
        PSM_SETFINISHTEXTA = 1139,
        PSM_GETTABCONTROL = 1140,
        PSM_ISDIALOGMESSAGE = 1141,
        MCIWNDM_REALIZE = 1142,
        PSM_GETCURRENTPAGEHWND = 1142,
        MCIWNDM_SETTIMEFORMATA = 1143,
        PSM_INSERTPAGE = 1143,
        EM_SETLANGOPTIONS = 1144,
        MCIWNDM_GETTIMEFORMATA = 1144,
        PSM_SETTITLEW = 1144,
        WM_CAP_FILE_SET_CAPTURE_FILEW = 1144,
        EM_GETLANGOPTIONS = 1145,
        MCIWNDM_VALIDATEMEDIA = 1145,
        PSM_SETFINISHTEXTW = 1145,
        WM_CAP_FILE_GET_CAPTURE_FILEW = 1145,
        EM_GETIMECOMPMODE = 1146,
        EM_FINDTEXTW = 1147,
        MCIWNDM_PLAYTO = 1147,
        WM_CAP_FILE_SAVEASW = 1147,
        EM_FINDTEXTEXW = 1148,
        MCIWNDM_GETFILENAMEA = 1148,
        EM_RECONVERSION = 1149,
        MCIWNDM_GETDEVICEA = 1149,
        PSM_SETHEADERTITLEA = 1149,
        WM_CAP_FILE_SAVEDIBW = 1149,
        EM_SETIMEMODEBIAS = 1150,
        MCIWNDM_GETPALETTE = 1150,
        PSM_SETHEADERTITLEW = 1150,
        EM_GETIMEMODEBIAS = 1151,
        MCIWNDM_SETPALETTE = 1151,
        PSM_SETHEADERSUBTITLEA = 1151,
        MCIWNDM_GETERRORA = 1152,
        PSM_SETHEADERSUBTITLEW = 1152,
        PSM_HWNDTOINDEX = 1153,
        PSM_INDEXTOHWND = 1154,
        MCIWNDM_SETINACTIVETIMER = 1155,
        PSM_PAGETOINDEX = 1155,
        PSM_INDEXTOPAGE = 1156,
        DL_BEGINDRAG = 1157,
        MCIWNDM_GETINACTIVETIMER = 1157,
        PSM_IDTOINDEX = 1157,
        DL_DRAGGING = 1158,
        PSM_INDEXTOID = 1158,
        DL_DROPPED = 1159,
        PSM_GETRESULT = 1159,
        DL_CANCELDRAG = 1160,
        PSM_RECALCPAGESIZES = 1160,
        MCIWNDM_GET_SOURCE = 1164,
        MCIWNDM_PUT_SOURCE = 1165,
        MCIWNDM_GET_DEST = 1166,
        MCIWNDM_PUT_DEST = 1167,
        MCIWNDM_CAN_PLAY = 1168,
        MCIWNDM_CAN_WINDOW = 1169,
        MCIWNDM_CAN_RECORD = 1170,
        MCIWNDM_CAN_SAVE = 1171,
        MCIWNDM_CAN_EJECT = 1172,
        MCIWNDM_CAN_CONFIG = 1173,
        IE_GETINK = 1174,
        IE_MSGFIRST = 1174,
        MCIWNDM_PALETTEKICK = 1174,
        IE_SETINK = 1175,
        IE_GETPENTIP = 1176,
        IE_SETPENTIP = 1177,
        IE_GETERASERTIP = 1178,
        IE_SETERASERTIP = 1179,
        IE_GETBKGND = 1180,
        IE_SETBKGND = 1181,
        IE_GETGRIDORIGIN = 1182,
        IE_SETGRIDORIGIN = 1183,
        IE_GETGRIDPEN = 1184,
        IE_SETGRIDPEN = 1185,
        IE_GETGRIDSIZE = 1186,
        IE_SETGRIDSIZE = 1187,
        IE_GETMODE = 1188,
        IE_SETMODE = 1189,
        IE_GETINKRECT = 1190,
        WM_CAP_SET_MCI_DEVICEW = 1190,
        WM_CAP_GET_MCI_DEVICEW = 1191,
        WM_CAP_PAL_OPENW = 1204,
        WM_CAP_PAL_SAVEW = 1205,
        IE_GETAPPDATA = 1208,
        IE_SETAPPDATA = 1209,
        IE_GETDRAWOPTS = 1210,
        IE_SETDRAWOPTS = 1211,
        IE_GETFORMAT = 1212,
        IE_SETFORMAT = 1213,
        IE_GETINKINPUT = 1214,
        IE_SETINKINPUT = 1215,
        IE_GETNOTIFY = 1216,
        IE_SETNOTIFY = 1217,
        IE_GETRECOG = 1218,
        IE_SETRECOG = 1219,
        IE_GETSECURITY = 1220,
        IE_SETSECURITY = 1221,
        IE_GETSEL = 1222,
        IE_SETSEL = 1223,
        CDM_LAST = 1224,
        EM_SETBIDIOPTIONS = 1224,
        IE_DOCOMMAND = 1224,
        MCIWNDM_NOTIFYMODE = 1224,
        EM_GETBIDIOPTIONS = 1225,
        IE_GETCOMMAND = 1225,
        EM_SETTYPOGRAPHYOPTIONS = 1226,
        IE_GETCOUNT = 1226,
        EM_GETTYPOGRAPHYOPTIONS = 1227,
        IE_GETGESTURE = 1227,
        MCIWNDM_NOTIFYMEDIA = 1227,
        EM_SETEDITSTYLE = 1228,
        IE_GETMENU = 1228,
        EM_GETEDITSTYLE = 1229,
        IE_GETPAINTDC = 1229,
        MCIWNDM_NOTIFYERROR = 1229,
        IE_GETPDEVENT = 1230,
        IE_GETSELCOUNT = 1231,
        IE_GETSELITEMS = 1232,
        IE_GETSTYLE = 1233,
        MCIWNDM_SETTIMEFORMATW = 1243,
        EM_OUTLINE = 1244,
        MCIWNDM_GETTIMEFORMATW = 1244,
        EM_GETSCROLLPOS = 1245,
        EM_SETSCROLLPOS = 1246,
        EM_SETFONTSIZE = 1247,
        EM_GETZOOM = 1248,
        MCIWNDM_GETFILENAMEW = 1248,
        EM_SETZOOM = 1249,
        MCIWNDM_GETDEVICEW = 1249,
        EM_GETVIEWKIND = 1250,
        EM_SETVIEWKIND = 1251,
        EM_GETPAGE = 1252,
        MCIWNDM_GETERRORW = 1252,
        EM_SETPAGE = 1253,
        EM_GETHYPHENATEINFO = 1254,
        EM_SETHYPHENATEINFO = 1255,
        EM_GETPAGEROTATE = 1259,
        EM_SETPAGEROTATE = 1260,
        EM_GETCTFMODEBIAS = 1261,
        EM_SETCTFMODEBIAS = 1262,
        EM_GETCTFOPENSTATUS = 1264,
        EM_SETCTFOPENSTATUS = 1265,
        EM_GETIMECOMPTEXT = 1266,
        EM_ISIME = 1267,
        EM_GETIMEPROPERTY = 1268,
        EM_GETQUERYRTFOBJ = 1293,
        EM_SETQUERYRTFOBJ = 1294,
        FM_GETFOCUS = 1536,
        FM_GETDRIVEINFOA = 1537,
        FM_GETSELCOUNT = 1538,
        FM_GETSELCOUNTLFN = 1539,
        FM_GETFILESELA = 1540,
        FM_GETFILESELLFNA = 1541,
        FM_REFRESH_WINDOWS = 1542,
        FM_RELOAD_EXTENSIONS = 1543,
        FM_GETDRIVEINFOW = 1553,
        FM_GETFILESELW = 1556,
        FM_GETFILESELLFNW = 1557,
        WLX_WM_SAS = 1625,
        SM_GETSELCOUNT = 2024,
        UM_GETSELCOUNT = 2024,
        WM_CPL_LAUNCH = 2024,
        SM_GETSERVERSELA = 2025,
        UM_GETUSERSELA = 2025,
        WM_CPL_LAUNCHED = 2025,
        SM_GETSERVERSELW = 2026,
        UM_GETUSERSELW = 2026,
        SM_GETCURFOCUSA = 2027,
        UM_GETGROUPSELA = 2027,
        SM_GETCURFOCUSW = 2028,
        UM_GETGROUPSELW = 2028,
        SM_GETOPTIONS = 2029,
        UM_GETCURFOCUSA = 2029,
        UM_GETCURFOCUSW = 2030,
        UM_GETOPTIONS = 2031,
        UM_GETOPTIONS2 = 2032,
        LVM_FIRST = 4096,
        LVM_GETBKCOLOR = 4096,
        LVM_SETBKCOLOR = 4097,
        LVM_GETIMAGELIST = 4098,
        LVM_SETIMAGELIST = 4099,
        LVM_GETITEMCOUNT = 4100,
        LVM_GETITEMA = 4101,
        LVM_SETITEMA = 4102,
        LVM_INSERTITEMA = 4103,
        LVM_DELETEITEM = 4104,
        LVM_DELETEALLITEMS = 4105,
        LVM_GETCALLBACKMASK = 4106,
        LVM_SETCALLBACKMASK = 4107,
        LVM_GETNEXTITEM = 4108,
        LVM_FINDITEMA = 4109,
        LVM_GETITEMRECT = 4110,
        LVM_SETITEMPOSITION = 4111,
        LVM_GETITEMPOSITION = 4112,
        LVM_GETSTRINGWIDTHA = 4113,
        LVM_HITTEST = 4114,
        LVM_ENSUREVISIBLE = 4115,
        LVM_SCROLL = 4116,
        LVM_REDRAWITEMS = 4117,
        LVM_ARRANGE = 4118,
        LVM_EDITLABELA = 4119,
        LVM_GETEDITCONTROL = 4120,
        LVM_GETCOLUMNA = 4121,
        LVM_SETCOLUMNA = 4122,
        LVM_INSERTCOLUMNA = 4123,
        LVM_DELETECOLUMN = 4124,
        LVM_GETCOLUMNWIDTH = 4125,
        LVM_SETCOLUMNWIDTH = 4126,
        LVM_GETHEADER = 4127,
        LVM_CREATEDRAGIMAGE = 4129,
        LVM_GETVIEWRECT = 4130,
        LVM_GETTEXTCOLOR = 4131,
        LVM_SETTEXTCOLOR = 4132,
        LVM_GETTEXTBKCOLOR = 4133,
        LVM_SETTEXTBKCOLOR = 4134,
        LVM_GETTOPINDEX = 4135,
        LVM_GETCOUNTPERPAGE = 4136,
        LVM_GETORIGIN = 4137,
        LVM_UPDATE = 4138,
        LVM_SETITEMSTATE = 4139,
        LVM_GETITEMSTATE = 4140,
        LVM_GETITEMTEXTA = 4141,
        LVM_SETITEMTEXTA = 4142,
        LVM_SETITEMCOUNT = 4143,
        LVM_SORTITEMS = 4144,
        LVM_SETITEMPOSITION32 = 4145,
        LVM_GETSELECTEDCOUNT = 4146,
        LVM_GETITEMSPACING = 4147,
        LVM_GETISEARCHSTRINGA = 4148,
        LVM_SETICONSPACING = 4149,
        LVM_SETEXTENDEDLISTVIEWSTYLE = 4150,
        LVM_GETEXTENDEDLISTVIEWSTYLE = 4151,
        LVM_GETSUBITEMRECT = 4152,
        LVM_SUBITEMHITTEST = 4153,
        LVM_SETCOLUMNORDERARRAY = 4154,
        LVM_GETCOLUMNORDERARRAY = 4155,
        LVM_SETHOTITEM = 4156,
        LVM_GETHOTITEM = 4157,
        LVM_SETHOTCURSOR = 4158,
        LVM_GETHOTCURSOR = 4159,
        LVM_APPROXIMATEVIEWRECT = 4160,
        LVM_SETWORKAREAS = 4161,
        LVM_GETSELECTIONMARK = 4162,
        LVM_SETSELECTIONMARK = 4163,
        LVM_SETBKIMAGEA = 4164,
        LVM_GETBKIMAGEA = 4165,
        LVM_GETWORKAREAS = 4166,
        LVM_SETHOVERTIME = 4167,
        LVM_GETHOVERTIME = 4168,
        LVM_GETNUMBEROFWORKAREAS = 4169,
        LVM_SETTOOLTIPS = 4170,
        LVM_GETITEMW = 4171,
        LVM_SETITEMW = 4172,
        LVM_INSERTITEMW = 4173,
        LVM_GETTOOLTIPS = 4174,
        LVM_FINDITEMW = 4179,
        LVM_GETSTRINGWIDTHW = 4183,
        LVM_GETCOLUMNW = 4191,
        LVM_SETCOLUMNW = 4192,
        LVM_INSERTCOLUMNW = 4193,
        LVM_GETITEMTEXTW = 4211,
        LVM_SETITEMTEXTW = 4212,
        LVM_GETISEARCHSTRINGW = 4213,
        LVM_EDITLABELW = 4214,
        LVM_GETBKIMAGEW = 4235,
        LVM_SETSELECTEDCOLUMN = 4236,
        LVM_SETTILEWIDTH = 4237,
        LVM_SETVIEW = 4238,
        LVM_GETVIEW = 4239,
        LVM_INSERTGROUP = 4241,
        LVM_SETGROUPINFO = 4243,
        LVM_GETGROUPINFO = 4245,
        LVM_REMOVEGROUP = 4246,
        LVM_MOVEGROUP = 4247,
        LVM_MOVEITEMTOGROUP = 4250,
        LVM_SETGROUPMETRICS = 4251,
        LVM_GETGROUPMETRICS = 4252,
        LVM_ENABLEGROUPVIEW = 4253,
        LVM_SORTGROUPS = 4254,
        LVM_INSERTGROUPSORTED = 4255,
        LVM_REMOVEALLGROUPS = 4256,
        LVM_HASGROUP = 4257,
        LVM_SETTILEVIEWINFO = 4258,
        LVM_GETTILEVIEWINFO = 4259,
        LVM_SETTILEINFO = 4260,
        LVM_GETTILEINFO = 4261,
        LVM_SETINSERTMARK = 4262,
        LVM_GETINSERTMARK = 4263,
        LVM_INSERTMARKHITTEST = 4264,
        LVM_GETINSERTMARKRECT = 4265,
        LVM_SETINSERTMARKCOLOR = 4266,
        LVM_GETINSERTMARKCOLOR = 4267,
        LVM_SETINFOTIP = 4269,
        LVM_GETSELECTEDCOLUMN = 4270,
        LVM_ISGROUPVIEWENABLED = 4271,
        LVM_GETOUTLINECOLOR = 4272,
        LVM_SETOUTLINECOLOR = 4273,
        LVM_CANCELEDITLABEL = 4275,
        LVM_MAPINDEXTOID = 4276,
        LVM_MAPIDTOINDEX = 4277,
        LVM_ISITEMVISIBLE = 4278,
        LVM_GETEMPTYTEXT = 4300,
        LVM_GETFOOTERRECT = 4301,
        LVM_GETFOOTERINFO = 4302,
        LVM_GETFOOTERITEMRECT = 4303,
        LVM_GETFOOTERITEM = 4304,
        LVM_GETITEMINDEXRECT = 4305,
        LVM_SETITEMINDEXSTATE = 4306,
        LVM_GETNEXTITEMINDEX = 4307,
        CCM_FIRST = 8192,
        OCM__BASE = 8192,
        CCM_SETBKCOLOR = 8193,
        CCM_SETCOLORSCHEME = 8194,
        CCM_GETCOLORSCHEME = 8195,
        CCM_GETDROPTARGET = 8196,
        CCM_SETUNICODEFORMAT = 8197,
        LVM_SETUNICODEFORMAT = 8197,
        CCM_GETUNICODEFORMAT = 8198,
        LVM_GETUNICODEFORMAT = 8198,
        CCM_SETVERSION = 8199,
        CCM_GETVERSION = 8200,
        CCM_SETNOTIFYWINDOW = 8201,
        CCM_SETWINDOWTHEME = 8203,
        CCM_DPISCALE = 8204,
        OCM_CTLCOLOR = 8217,
        OCM_DRAWITEM = 8235,
        OCM_MEASUREITEM = 8236,
        OCM_DELETEITEM = 8237,
        OCM_VKEYTOITEM = 8238,
        OCM_CHARTOITEM = 8239,
        OCM_COMPAREITEM = 8249,
        OCM_NOTIFY = 8270,
        OCM_COMMAND = 8465,
        OCM_HSCROLL = 8468,
        OCM_VSCROLL = 8469,
        OCM_CTLCOLORMSGBOX = 8498,
        OCM_CTLCOLOREDIT = 8499,
        OCM_CTLCOLORLISTBOX = 8500,
        OCM_CTLCOLORBTN = 8501,
        OCM_CTLCOLORDLG = 8502,
        OCM_CTLCOLORSCROLLBAR = 8503,
        OCM_CTLCOLORSTATIC = 8504,
        OCM_PARENTNOTIFY = 8704,
        OCM_PARENTNOTIFY2 = 8720,
        WM_APP = 32768,
        WM_RASDIALEVENT = 52429,
    }
}
