﻿using System.Drawing;
using System.Runtime.InteropServices;
using Windows.Win32.Foundation;
using Windows.Win32.Graphics.Gdi;

namespace ManualWindow
{
    internal class Window
    {
        const uint WS_OVERLAPPEDWINDOW = 0b1100_1111_0000_0000_0000_0000;
        const uint WS_VISIBLE = 0x10000000;
        const uint CS_USEDEFAULT = 0x80000000;
        const uint CS_DBLCLKS = 8;
        const uint CS_VREDRAW = 1;
        const uint CS_HREDRAW = 2;
        const uint IDC_CROSS = 32515;

        /// <summary>
        /// Utility function for getting screen position from <paramref name="lParam"/>.
        /// </summary>
        /// <param name="lParam"></param>
        /// <returns></returns>
        public static Point PointFromLParam(nint lParam)
        {
            return new Point((int)lParam & 0xFFFF, ((int)lParam >> 16) & 0xFFFF);
        }

        public static CursorPosWindowPart GetWindowPartFromPos(nint lparam)
        {
            var pos = PointFromLParam(lparam);
            return CursorPosWindowPart.CLIENT;
        }

        public static ushort GetLowerHalf(nint param)
        {
            return (ushort)param;
        }

        public static ushort GetUpperHalf(nint param)
        {
            return (ushort)(param >> 16);
        }

        /// <summary>
        /// Returns a string representation of the message.
        /// </summary>
        /// <param name="windowHandle">A handle to the window.</param>
        /// <param name="message">The message.</param>
        /// <param name="messageExtra1">Additional message information. The contents of this depends on <paramref name="message"/>.</param>
        /// <param name="messageExtra2">Additional message information. The contents of this depends on <paramref name="message"/>.</param>
        /// <param name="sendTime">The timestamp the message was sent.</param>
        public static string WindowMessageToString(
            HWND windowHandle,
            uint message,
            nint messageExtra1,
            nint messageExtra2,
            DateTime? sendTime = null
        )
        {
            string MouseEventParamsExtraText()
            {
                return $"buttons pressed: [{string.Join(", ", Enum.GetValues<MouseVirtualKey>().Where(key => (messageExtra1 & (int)key) != 0))}] , cursor pos: {PointFromLParam(messageExtra2)}";
            }

            string ContextMenuRequestExtraPart()
            {
                var pos = new NativeMethods.POINTS((short)GetLowerHalf(messageExtra2), (short)GetUpperHalf(messageExtra2));
                return pos.x == -1 && pos.x == -1 ? "[NOT RIGHT CLICK TRIGGERED]" : pos.ToString();
            }

            var sendDt = sendTime ?? DateTime.Now;
            var messageEnum = (WindowProcessMessage)message;
            var extraText = messageEnum switch
            {
                WindowProcessMessage.PAINT_WINDOW_REQUEST or
                WindowProcessMessage.SYNC_WINDOW_PAINT or
                WindowProcessMessage.MOUSE_LEAVE_NONCLIENT_AREA
                    => null,
                WindowProcessMessage.BEFORE_SIZE_OR_POSITION_CHANGE => $"MINMAXINFO pointer: {messageExtra2}",
                WindowProcessMessage.BEFORE_WINDOW_CREATED => $"CREATESTRUCT pointer: {messageExtra2}",
                WindowProcessMessage.CALCULATE_SIZE_AND_POSITION => $"{(messageExtra1 == 1 ? "NCCALCSIZE_PARAMS" : "RECT")} pointer: {messageExtra2}{(messageExtra1 == 0 ? "" : " The application should indicate which part of the client area contains valid information.")}",
                WindowProcessMessage.ON_CREATE => $"CREATESTRUCT pointer: {messageExtra2}",
                WindowProcessMessage.WINDOW_SHOWN_OR_HIDE => $"window {(messageExtra1 == 1 ? "shown" : "hidden")}, reson: {(WindowShowHideReason)messageExtra2}",
                WindowProcessMessage.BEFORE_WINDOW_POS_CHANGE => $"WINDOWPOS pointer: {messageExtra2}",
                WindowProcessMessage.BEFORE_ACTIVATE_DEACTIVATE => $"window {(messageExtra1 == 1 ? "activated" : "deactivated")}, other window's owner thread ID: {messageExtra2}",
                WindowProcessMessage.NONCLIENT_ACTIVATE_DEACTIVEATE => $"title bar/icon {(messageExtra1 == 1 ? "activated" : "deactivated")}, other window's owner thread ID: {messageExtra2}",
                WindowProcessMessage.ACTIVATE_DEACTIVEATE => $"(de)activation method: {(WindowActivatedLowerHalf)GetLowerHalf(messageExtra1)}, window {(GetUpperHalf(messageExtra1) == 0 ? "not" : "")} minimized, pointer to {((WindowActivatedLowerHalf)GetLowerHalf(messageExtra1) == WindowActivatedLowerHalf.DEACTIVATED ? "" : "de")}activating window: {messageExtra2}",
                WindowProcessMessage.GET_ICON => $"icon type: {(WindowIconType)messageExtra1}, icon DPI: {messageExtra2}",
                WindowProcessMessage.IME_ACTIVATE_DEACTIVATE => $"window {(messageExtra1 == 1 ? "" : "in")}active, display options: [{
                    string.Join(", ",
                        Enum.GetValues<WindowActivateDeactivateDisplayOptionsPart>()
                        .Where(dispO =>
                            dispO != WindowActivateDeactivateDisplayOptionsPart.SHOW_UI_ALL_CANDIDATE_WINDOW &&
                            dispO != WindowActivateDeactivateDisplayOptionsPart.SHOW_UI_ALL &&
                            ((uint)dispO & messageExtra1) != 0)
                        )
                    }]",
                WindowProcessMessage.IME_NOTIFY => $"command type: {(IMENotifyCommand)messageExtra1}, argument: {messageExtra2}",
                WindowProcessMessage.AFTER_KEYBOARD_FOCUS_GAINED => $"keyboard focus lost window handle: {messageExtra1}",
                WindowProcessMessage.FRAME_PAINT_NEEDED => $"window update region handle: {messageExtra1}",
                WindowProcessMessage.BACKGROUND_ERASE_NEEDED => $"device context handle: {messageExtra1}",
                WindowProcessMessage.WINDOW_POS_CHANGED => $"WINDOWPOS pointer: {messageExtra2}",
                WindowProcessMessage.CLIPBOARD_SIZE_CHANGED => $"clipboard viewer window hadle: {messageExtra1}, RECT pointer: {messageExtra2}",
                WindowProcessMessage.WINDOW_SIZE_CHANGED => $"resize type: {(WindowResizeType)messageExtra1}, new size: [width: {GetLowerHalf(messageExtra2)}, height: {GetUpperHalf(messageExtra2)}]",
                WindowProcessMessage.WINDOW_MOVED => $"new position: [x: {GetLowerHalf(messageExtra2)}, y: {GetUpperHalf(messageExtra2)}]",
                WindowProcessMessage.NONCLIENT_AREA_RENDERING_POLICY_CHANGED => $"DWM rendering for the non-client area of the window: {(messageExtra1 == 1 ? "enabled" : "disabled")}",
                WindowProcessMessage.BEFORE_KEYBOARD_FOCUS_LOST => $"keyboard focus gained window handle: {messageExtra1}",
                WindowProcessMessage.SCREEN_POS_TO_WINDOW_PART => $"cursor pos: {PointFromLParam(messageExtra2)}",
                WindowProcessMessage.CURSOR_MOVE => $"cursor window handle: {messageExtra1}, part hit: {(CursorPosWindowPart)GetLowerHalf(messageExtra2)}, event trigger: {(WindowProcessMessage)GetUpperHalf(messageExtra2)}",
                WindowProcessMessage.NONCLIENT_MOUSE_MOVE => $"part hit: {(CursorPosWindowPart)messageExtra1}, cursor pos: {new NativeMethods.POINTS(messageExtra2)}",
                WindowProcessMessage.MOUSE_MOVE or
                WindowProcessMessage.MOUSE_LEFT_BUTTON_DOWN or
                WindowProcessMessage.MOUSE_LEFT_BUTTON_UP or
                WindowProcessMessage.MOUSE_LEFT_BUTTON_DOUBLE_CLICK or
                WindowProcessMessage.MOUSE_RIGHT_BUTTON_DOWN or
                WindowProcessMessage.MOUSE_RIGHT_BUTTON_UP or
                WindowProcessMessage.MOUSE_RIGHT_BUTTON_DOUBLE_CLICK or
                WindowProcessMessage.MOUSE_MIDDLE_BUTTON_DOWN or
                WindowProcessMessage.MOUSE_MIDDLE_BUTTON_UP or
                WindowProcessMessage.MOUSE_MIDDLE_BUTTON_DOUBLE_CLICK
                     => MouseEventParamsExtraText(),
                WindowProcessMessage.MOUSE_KEY_PRESSED_IN_INACTIVE_WINDOW => $"activated top level window handle {messageExtra1}, part hit: {(CursorPosWindowPart)GetLowerHalf(messageExtra2)}, mouse message ID: {(WindowProcessMessage)GetUpperHalf(messageExtra2)}",
                WindowProcessMessage.CONTEXT_MENU_REQUESTED => $"menu requested window handle: {messageExtra1}, trigger location: {ContextMenuRequestExtraPart()}",
                _ => "[UNREGISTERED MESSAGE]",
            };

            return $"[{sendDt}] {messageEnum}{(Enum.IsDefined(messageEnum) ? "" : " [UNKNOWN MESSAGE]")}{(extraText is null ? "" : $" -> {extraText}")}";
        }

        /// <summary>
        /// 
        /// </summary>
        public static void DisplayLastSystemError()
        {
            var errorCode = Marshal.GetLastWin32Error();
            string errorMessage = Marshal.GetPInvokeErrorMessage(errorCode);
            var message =  $"ERROR({errorCode}) {errorMessage}";
            Console.WriteLine(message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="windowHandle">A handle to the window.</param>
        /// <param name="message">The message.</param>
        /// <param name="messageExtra1">Additional message information. The contents of this depends on <paramref name="message"/>.</param>
        /// <param name="messageExtra2">Additional message information. The contents of this depends on <paramref name="message"/>.</param>
        /// <returns>The result of the message processing, and depends on the message sent.</returns>
        public nint ProcessMessage(HWND windowHandle, WindowProcessMessage message, nint messageExtra1, nint messageExtra2)
        {
            switch (message)
            {
                case WindowProcessMessage.PAINT_WINDOW_REQUEST:
                    var hdc = NativeMethods.BeginPaint(windowHandle, out var ps);
                    if (hdc == nint.Zero)
                    {
                        DisplayLastSystemError();
                    }
                    var brush = NativeMethods.GetSysColorBrush(SysColorIndex.COLOR_WINDOW);
                    var res = NativeMethods.FillRect(new HDC(hdc), ps.rcPaint, brush);
                    var suc = NativeMethods.EndPaint(windowHandle, ps);
                    //Windows.Win32.PInvoke.LocalFree();
                    break;
            }

            return message switch
            {
                WindowProcessMessage.ON_CREATE or
                WindowProcessMessage.WINDOW_SHOWN_OR_HIDE or
                WindowProcessMessage.BEFORE_WINDOW_POS_CHANGE or
                WindowProcessMessage.BEFORE_ACTIVATE_DEACTIVATE or
                WindowProcessMessage.ACTIVATE_DEACTIVEATE or
                WindowProcessMessage.AFTER_KEYBOARD_FOCUS_GAINED or
                WindowProcessMessage.FRAME_PAINT_NEEDED or
                WindowProcessMessage.WINDOW_POS_CHANGED or
                WindowProcessMessage.CLIPBOARD_SIZE_CHANGED or
                WindowProcessMessage.WINDOW_SIZE_CHANGED or
                WindowProcessMessage.WINDOW_MOVED or
                WindowProcessMessage.PAINT_WINDOW_REQUEST or
                WindowProcessMessage.SYNC_WINDOW_PAINT or
                WindowProcessMessage.NONCLIENT_AREA_RENDERING_POLICY_CHANGED or
                WindowProcessMessage.BEFORE_KEYBOARD_FOCUS_LOST or
                WindowProcessMessage.NONCLIENT_MOUSE_MOVE or
                WindowProcessMessage.MOUSE_LEAVE_NONCLIENT_AREA or
                WindowProcessMessage.MOUSE_MOVE or
                WindowProcessMessage.MOUSE_LEFT_BUTTON_DOWN or
                WindowProcessMessage.MOUSE_LEFT_BUTTON_UP or
                WindowProcessMessage.MOUSE_LEFT_BUTTON_DOUBLE_CLICK or
                WindowProcessMessage.MOUSE_RIGHT_BUTTON_DOWN or
                WindowProcessMessage.MOUSE_RIGHT_BUTTON_UP or
                WindowProcessMessage.MOUSE_RIGHT_BUTTON_DOUBLE_CLICK or
                WindowProcessMessage.MOUSE_MIDDLE_BUTTON_DOWN or
                WindowProcessMessage.MOUSE_MIDDLE_BUTTON_UP or
                WindowProcessMessage.MOUSE_MIDDLE_BUTTON_DOUBLE_CLICK or
                WindowProcessMessage.CONTEXT_MENU_REQUESTED
                    => nint.Zero,
                WindowProcessMessage.BEFORE_SIZE_OR_POSITION_CHANGE => nint.Zero,
                WindowProcessMessage.BEFORE_WINDOW_CREATED => 1,
                WindowProcessMessage.CALCULATE_SIZE_AND_POSITION => nint.Zero,
                WindowProcessMessage.NONCLIENT_ACTIVATE_DEACTIVEATE => 1,
                WindowProcessMessage.GET_ICON => nint.Zero,
                WindowProcessMessage.IME_ACTIVATE_DEACTIVATE => nint.Zero,
                WindowProcessMessage.IME_NOTIFY => nint.Zero,
                WindowProcessMessage.BACKGROUND_ERASE_NEEDED => nint.Zero,
                WindowProcessMessage.SCREEN_POS_TO_WINDOW_PART => (int)GetWindowPartFromPos(messageExtra2),
                WindowProcessMessage.CURSOR_MOVE => nint.Zero,
                WindowProcessMessage.MOUSE_KEY_PRESSED_IN_INACTIVE_WINDOW => (int)InactiveWindowMouseActionReturnValue.ACTIVATE,
                _ => nint.Zero,
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="windowHandle">A handle to the window.</param>
        /// <param name="message">The message.</param>
        /// <param name="messageExtra1">Additional message information. The contents of this depends on <paramref name="message"/>.</param>
        /// <param name="messageExtra2">Additional message information. The contents of this depends on <paramref name="message"/>.</param>
        /// <returns>The result of the message processing, and depends on the message sent.</returns>
        public nint WindowProc(HWND windowHandle, uint message, nint messageExtra1, nint messageExtra2)
        {
            var messageEnum = (WindowProcessMessage)message;
            var knownMessage = Enum.IsDefined(messageEnum);
            var response = nint.Zero;
            if (knownMessage)
            {
                response = ProcessMessage(windowHandle, messageEnum, messageExtra1, messageExtra2);
            }

            var defResponse = NativeMethods.DefWindowProc(windowHandle, message, messageExtra1, messageExtra2);

            if (knownMessage)
            {
                Console.WriteLine(WindowMessageToString(windowHandle, message, messageExtra1, messageExtra2) + $"\t-> {response}{(response != defResponse ? $"(def: {defResponse})" : "")}");
            }
            else
            {
                Console.WriteLine($"UNKNOWN MESSAGE: {message}\t-> (def: {defResponse})");
            }
            response = defResponse;

            return response;
        }

        public bool CreateWindow()
        {
            var windowClass = new NativeMethods.WNDCLASSEX
            {
                cbSize = Marshal.SizeOf(typeof(NativeMethods.WNDCLASSEX)),
                style = (int)(CS_HREDRAW | CS_VREDRAW | CS_DBLCLKS), //Doubleclicks are active
                hbrBackground = (nint)SysColorIndex.COLOR_BACKGROUND + 1,
                cbClsExtra = 0,
                cbWndExtra = 0,
                hInstance = Marshal.GetHINSTANCE(GetType().Module), // alternative: Process.GetCurrentProcess().Handle
                hIcon = nint.Zero,
                hCursor = NativeMethods.LoadCursor(nint.Zero, (int)IDC_CROSS),// Crosshair cursor
                lpszMenuName = null,
                lpszClassName = "myClass",
                lpfnWndProc = new NativeMethods.WndProc(WindowProc),
                hIconSm = nint.Zero
            };

            var registrationResult = NativeMethods.RegisterClassEx(ref windowClass);

            if (registrationResult == 0)
            {
                DisplayLastSystemError();
                return false;
            }

            var windowHadle = NativeMethods.CreateWindowEx(
                0,
                registrationResult,
                "Hello Win32",
                WS_OVERLAPPEDWINDOW | WS_VISIBLE,
                0,
                0,
                300,
                400,
                new HWND(nint.Zero),
                nint.Zero,
                windowClass.hInstance,
                nint.Zero
            );

            if (windowHadle == HWND.Null)
            {
                DisplayLastSystemError();
                return false;
            }
            NativeMethods.ShowWindow(windowHadle, 1);

            sbyte res = 0;
            do
            {
                res = NativeMethods.GetMessage(out var msg, windowHadle, 0, 0);
                if (res == 0)
                {
                    continue;
                }

                if (res == -1)
                {
                    DisplayLastSystemError();
                    return false;
                }

                //var r = NativeMethods.TranslateMessage(msg);
                NativeMethods.DispatchMessage(msg);
            }
            while (res != 0);
            return true;
        }
    }
}
