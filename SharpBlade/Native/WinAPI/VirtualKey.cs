// <auto-generated>
// This code was "auto-generated" from pinvoke.net and MSDN.
// (Doesn't really count as auto-generated but we circumvent StyleCop this way)
// </auto-generated>

// ReSharper disable InconsistentNaming
namespace SharpBlade.Native.WinAPI
{
    using System.CodeDom.Compiler;

    using SharpBlade.Annotations;

    /// <summary>
    /// Virtual-key codes used by the system.
    /// </summary>
    [GeneratedCode("WinAPI", "1.0.0.0")]
    public enum VirtualKey
    {
        /// <summary>
        /// Left mouse button.
        /// </summary>
        [UsedImplicitly]
        LBUTTON = 0x01,

        /// <summary>
        /// Right mouse button.
        /// </summary>
        [UsedImplicitly]
        RBUTTON = 0x02,

        /// <summary>
        /// Control-break processing.
        /// </summary>
        [UsedImplicitly]
        CANCEL = 0x03,

        /// <summary>
        /// Middle mouse button (three-button mouse).
        /// </summary>
        [UsedImplicitly]
        MBUTTON = 0x04,

        /// <summary>
        /// X1 mouse button.
        /// </summary>
        [UsedImplicitly]
        XBUTTON1 = 0x05,

        /// <summary>
        /// X2 mouse button.
        /// </summary>
        [UsedImplicitly]
        XBUTTON2 = 0x06,

        /// <summary>
        /// Undefined, not used.
        /// </summary>
        [UsedImplicitly]
        UNDEFINED1 = 0x07,

        /// <summary>
        /// BACKSPACE key.
        /// </summary>
        [UsedImplicitly]
        BACK = 0x08,

        /// <summary>
        /// TAB key.
        /// </summary>
        [UsedImplicitly]
        TAB = 0x09,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        RESERVED1 = 0x0A,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        RESERVED2 = 0x0B,

        /// <summary>
        /// CLEAR key.
        /// </summary>
        [UsedImplicitly]
        CLEAR = 0x0C,

        /// <summary>
        /// ENTER key.
        /// </summary>
        [UsedImplicitly]
        RETURN = 0x0D,

        /// <summary>
        /// Undefined, not used.
        /// </summary>
        [UsedImplicitly]
        UNDEFINED2 = 0x0E,

        /// <summary>
        /// Undefined, not used.
        /// </summary>
        [UsedImplicitly]
        UNDEFINED3 = 0x0F,

        /// <summary>
        /// SHIFT key.
        /// </summary>
        [UsedImplicitly]
        SHIFT = 0x10,

        /// <summary>
        /// CTRL key.
        /// </summary>
        [UsedImplicitly]
        CONTROL = 0x11,

        /// <summary>
        /// ALT key.
        /// </summary>
        [UsedImplicitly]
        MENU = 0x12,

        /// <summary>
        /// PAUSE key.
        /// </summary>
        [UsedImplicitly]
        PAUSE = 0x13,

        /// <summary>
        /// CAPS LOCK key.
        /// </summary>
        [UsedImplicitly]
        CAPITAL = 0x14,

        /// <summary>
        /// IME Kana mode.
        /// </summary>
        [UsedImplicitly]
        KANA = 0x15,

        /// <summary>
        /// IME Hanguel mode (maintained for compatibility; use VK_HANGUL).
        /// </summary>
        [UsedImplicitly]
        HANGUEL = 0x15,

        /// <summary>
        /// IME Hangul mode.
        /// </summary>
        [UsedImplicitly]
        HANGUL = 0x15,

        /// <summary>
        /// Undefined, not used.
        /// </summary>
        [UsedImplicitly]
        UNDEFINED4 = 0x16,

        /// <summary>
        /// IME Junja mode.
        /// </summary>
        [UsedImplicitly]
        JUNJA = 0x17,

        /// <summary>
        /// IME final mode.
        /// </summary>
        [UsedImplicitly]
        FINAL = 0x18,

        /// <summary>
        /// IME Hanja mode.
        /// </summary>
        [UsedImplicitly]
        HANJA = 0x19,

        /// <summary>
        /// IME Kanji mode.
        /// </summary>
        [UsedImplicitly]
        KANJI = 0x19,

        /// <summary>
        /// Undefined, not used.
        /// </summary>
        [UsedImplicitly]
        UNDEFINED5 = 0x0A,

        /// <summary>
        /// ESC key.
        /// </summary>
        [UsedImplicitly]
        ESCAPE = 0x1B,

        /// <summary>
        /// IME convert.
        /// </summary>
        [UsedImplicitly]
        CONVERT = 0x1C,

        /// <summary>
        /// IME nonconvert.
        /// </summary>
        [UsedImplicitly]
        NONCONVERT = 0x1D,

        /// <summary>
        /// IME accept.
        /// </summary>
        [UsedImplicitly]
        ACCEPT = 0x1E,

        /// <summary>
        /// IME mode change request.
        /// </summary>
        [UsedImplicitly]
        MODECHANGE = 0x1F,

        /// <summary>
        /// SPACEBAR key.
        /// </summary>
        [UsedImplicitly]
        SPACE = 0x20,

        /// <summary>
        /// PAGE UP key.
        /// </summary>
        [UsedImplicitly]
        PRIOR = 0x21,

        /// <summary>
        /// PAGE DOWN key.
        /// </summary>
        [UsedImplicitly]
        NEXT = 0x22,

        /// <summary>
        /// END key.
        /// </summary>
        [UsedImplicitly]
        END = 0x23,

        /// <summary>
        /// HOME key.
        /// </summary>
        [UsedImplicitly]
        HOME = 0x24,

        /// <summary>
        /// LEFT ARROW key.
        /// </summary>
        [UsedImplicitly]
        LEFT = 0x25,

        /// <summary>
        /// UP ARROW key.
        /// </summary>
        [UsedImplicitly]
        UP = 0x26,

        /// <summary>
        /// RIGHT ARROW key.
        /// </summary>
        [UsedImplicitly]
        RIGHT = 0x27,

        /// <summary>
        /// DOWN ARROW key.
        /// </summary>
        [UsedImplicitly]
        DOWN = 0x28,

        /// <summary>
        /// SELECT key.
        /// </summary>
        [UsedImplicitly]
        SELECT = 0x29,

        /// <summary>
        /// PRINT key.
        /// </summary>
        [UsedImplicitly]
        PRINT = 0x2A,

        /// <summary>
        /// EXECUTE key.
        /// </summary>
        [UsedImplicitly]
        EXECUTE = 0x2B,

        /// <summary>
        /// PRINT SCREEN key.
        /// </summary>
        [UsedImplicitly]
        SNAPSHOT = 0x2C,

        /// <summary>
        /// INS key.
        /// </summary>
        [UsedImplicitly]
        INSERT = 0x2D,

        /// <summary>
        /// DEL key.
        /// </summary>
        [UsedImplicitly]
        DELETE = 0x2E,

        /// <summary>
        /// HELP key.
        /// </summary>
        [UsedImplicitly]
        HELP = 0x2F,

        /// <summary>
        /// 0 key.
        /// </summary>
        [UsedImplicitly]
        Zero = 0x30,

        /// <summary>
        /// 1 key.
        /// </summary>
        [UsedImplicitly]
        One = 0x31,

        /// <summary>
        /// 2 key.
        /// </summary>
        [UsedImplicitly]
        Two = 0x32,

        /// <summary>
        /// 3 key.
        /// </summary>
        [UsedImplicitly]
        Three = 0x33,

        /// <summary>
        /// 4 key.
        /// </summary>
        [UsedImplicitly]
        Four = 0x34,

        /// <summary>
        /// 5 key.
        /// </summary>
        [UsedImplicitly]
        Five = 0x35,

        /// <summary>
        /// 6 key.
        /// </summary>
        [UsedImplicitly]
        Six = 0x36,

        /// <summary>
        /// 7 key.
        /// </summary>
        [UsedImplicitly]
        Seven = 0x37,

        /// <summary>
        /// 8 key.
        /// </summary>
        [UsedImplicitly]
        Eight = 0x38,

        /// <summary>
        /// 9 key.
        /// </summary>
        [UsedImplicitly]
        Nine = 0x39,

        /// <summary>
        /// Undefined, not used.
        /// </summary>
        [UsedImplicitly]
        UNDEFINED6 = 0x3A,

        /// <summary>
        /// Undefined, not used.
        /// </summary>
        [UsedImplicitly]
        UNDEFINED7 = 0x3B,

        /// <summary>
        /// Undefined, not used.
        /// </summary>
        [UsedImplicitly]
        UNDEFINED8 = 0x3C,

        /// <summary>
        /// Undefined, not used.
        /// </summary>
        [UsedImplicitly]
        UNDEFINED9 = 0x3D,

        /// <summary>
        /// Undefined, not used.
        /// </summary>
        [UsedImplicitly]
        UNDEFINED10 = 0x3E,

        /// <summary>
        /// Undefined, not used.
        /// </summary>
        [UsedImplicitly]
        UNDEFINED11 = 0x3F,

        /// <summary>
        /// Undefined, not used.
        /// </summary>
        [UsedImplicitly]
        UNDEFINED12 = 0x40,

        /// <summary>
        /// A key.
        /// </summary>
        [UsedImplicitly]
        A = 0x41,

        /// <summary>
        /// B key.
        /// </summary>
        [UsedImplicitly]
        B = 0x42,

        /// <summary>
        /// C key.
        /// </summary>
        [UsedImplicitly]
        C = 0x43,

        /// <summary>
        /// D key.
        /// </summary>
        [UsedImplicitly]
        D = 0x44,

        /// <summary>
        /// E key.
        /// </summary>
        [UsedImplicitly]
        E = 0x45,

        /// <summary>
        /// F key.
        /// </summary>
        [UsedImplicitly]
        F = 0x46,

        /// <summary>
        /// G key.
        /// </summary>
        [UsedImplicitly]
        G = 0x47,

        /// <summary>
        /// H key.
        /// </summary>
        [UsedImplicitly]
        H = 0x48,

        /// <summary>
        /// I key.
        /// </summary>
        [UsedImplicitly]
        I = 0x49,

        /// <summary>
        /// J key.
        /// </summary>
        [UsedImplicitly]
        J = 0x4A,

        /// <summary>
        /// K key.
        /// </summary>
        [UsedImplicitly]
        K = 0x4B,

        /// <summary>
        /// L key.
        /// </summary>
        [UsedImplicitly]
        L = 0x4C,

        /// <summary>
        /// M key.
        /// </summary>
        [UsedImplicitly]
        M = 0x4D,

        /// <summary>
        /// N key.
        /// </summary>
        [UsedImplicitly]
        N = 0x4E,

        /// <summary>
        /// O key.
        /// </summary>
        [UsedImplicitly]
        O = 0x4F,

        /// <summary>
        /// P key.
        /// </summary>
        [UsedImplicitly]
        P = 0x50,

        /// <summary>
        /// Q key.
        /// </summary>
        [UsedImplicitly]
        Q = 0x51,

        /// <summary>
        /// R key.
        /// </summary>
        [UsedImplicitly]
        R = 0x52,

        /// <summary>
        /// S key.
        /// </summary>
        [UsedImplicitly]
        S = 0x53,

        /// <summary>
        /// T key.
        /// </summary>
        [UsedImplicitly]
        T = 0x54,

        /// <summary>
        /// U key.
        /// </summary>
        [UsedImplicitly]
        U = 0x55,

        /// <summary>
        /// V key.
        /// </summary>
        [UsedImplicitly]
        V = 0x56,

        /// <summary>
        /// W key.
        /// </summary>
        [UsedImplicitly]
        W = 0x57,

        /// <summary>
        /// X key.
        /// </summary>
        [UsedImplicitly]
        X = 0x58,

        /// <summary>
        /// Y key.
        /// </summary>
        [UsedImplicitly]
        Y = 0x59,

        /// <summary>
        /// Z key.
        /// </summary>
        [UsedImplicitly]
        Z = 0x5A,

        /// <summary>
        /// Left Windows key (Natural keyboard) .
        /// </summary>
        [UsedImplicitly]
        LWIN = 0x5B,

        /// <summary>
        /// Right Windows key (Natural keyboard).
        /// </summary>
        [UsedImplicitly]
        RWIN = 0x5C,

        /// <summary>
        /// Applications key (Natural keyboard).
        /// </summary>
        [UsedImplicitly]
        APPS = 0x5D,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        RESERVED3 = 0x5E,

        /// <summary>
        /// Computer Sleep key.
        /// </summary>
        [UsedImplicitly]
        SLEEP = 0x5F,

        /// <summary>
        /// Numeric keypad 0 key.
        /// </summary>
        [UsedImplicitly]
        NUMPAD0 = 0x60,

        /// <summary>
        /// Numeric keypad 1 key.
        /// </summary>
        [UsedImplicitly]
        NUMPAD1 = 0x61,

        /// <summary>
        /// Numeric keypad 2 key.
        /// </summary>
        [UsedImplicitly]
        NUMPAD2 = 0x62,

        /// <summary>
        /// Numeric keypad 3 key.
        /// </summary>
        [UsedImplicitly]
        NUMPAD3 = 0x63,

        /// <summary>
        /// Numeric keypad 4 key.
        /// </summary>
        [UsedImplicitly]
        NUMPAD4 = 0x64,

        /// <summary>
        /// Numeric keypad 5 key.
        /// </summary>
        [UsedImplicitly]
        NUMPAD5 = 0x65,

        /// <summary>
        /// Numeric keypad 6 key.
        /// </summary>
        [UsedImplicitly]
        NUMPAD6 = 0x66,

        /// <summary>
        /// Numeric keypad 7 key.
        /// </summary>
        [UsedImplicitly]
        NUMPAD7 = 0x67,

        /// <summary>
        /// Numeric keypad 8 key.
        /// </summary>
        [UsedImplicitly]
        NUMPAD8 = 0x68,

        /// <summary>
        /// Numeric keypad 9 key.
        /// </summary>
        [UsedImplicitly]
        NUMPAD9 = 0x69,

        /// <summary>
        /// Multiply key.
        /// </summary>
        [UsedImplicitly]
        MULTIPLY = 0x6A,

        /// <summary>
        /// Add key.
        /// </summary>
        [UsedImplicitly]
        ADD = 0x6B,

        /// <summary>
        /// Separator key.
        /// </summary>
        [UsedImplicitly]
        SEPARATOR = 0x6C,

        /// <summary>
        /// Subtract key.
        /// </summary>
        [UsedImplicitly]
        SUBTRACT = 0x6D,

        /// <summary>
        /// Decimal key.
        /// </summary>
        [UsedImplicitly]
        DECIMAL = 0x6E,

        /// <summary>
        /// Divide key.
        /// </summary>
        [UsedImplicitly]
        DIVIDE = 0x6F,

        /// <summary>
        /// F1 key.
        /// </summary>
        [UsedImplicitly]
        F1 = 0x70,

        /// <summary>
        /// F2 key.
        /// </summary>
        [UsedImplicitly]
        F2 = 0x71,

        /// <summary>
        /// F3 key.
        /// </summary>
        [UsedImplicitly]
        F3 = 0x72,

        /// <summary>
        /// F4 key.
        /// </summary>
        [UsedImplicitly]
        F4 = 0x73,

        /// <summary>
        /// F5 key.
        /// </summary>
        [UsedImplicitly]
        F5 = 0x74,

        /// <summary>
        /// F6 key.
        /// </summary>
        [UsedImplicitly]
        F6 = 0x75,

        /// <summary>
        /// F7 key.
        /// </summary>
        [UsedImplicitly]
        F7 = 0x76,

        /// <summary>
        /// F8 key.
        /// </summary>
        [UsedImplicitly]
        F8 = 0x77,

        /// <summary>
        /// F9 key.
        /// </summary>
        [UsedImplicitly]
        F9 = 0x78,

        /// <summary>
        /// F10 key.
        /// </summary>
        [UsedImplicitly]
        F10 = 0x79,

        /// <summary>
        /// F11 key.
        /// </summary>
        [UsedImplicitly]
        F11 = 0x7A,

        /// <summary>
        /// F12 key.
        /// </summary>
        [UsedImplicitly]
        F12 = 0x7B,

        /// <summary>
        /// F13 key.
        /// </summary>
        [UsedImplicitly]
        F13 = 0x7C,

        /// <summary>
        /// F14 key.
        /// </summary>
        [UsedImplicitly]
        F14 = 0x7D,

        /// <summary>
        /// F15 key.
        /// </summary>
        [UsedImplicitly]
        F15 = 0x7E,

        /// <summary>
        /// F16 key.
        /// </summary>
        [UsedImplicitly]
        F16 = 0x7F,

        /// <summary>
        /// F17 key.
        /// </summary>
        [UsedImplicitly]
        F17 = 0x80,

        /// <summary>
        /// F18 key.
        /// </summary>
        [UsedImplicitly]
        F18 = 0x81,

        /// <summary>
        /// F19 key.
        /// </summary>
        [UsedImplicitly]
        F19 = 0x82,

        /// <summary>
        /// F20 key.
        /// </summary>
        [UsedImplicitly]
        F20 = 0x83,

        /// <summary>
        /// F21 key.
        /// </summary>
        [UsedImplicitly]
        F21 = 0x84,

        /// <summary>
        /// F22 key.
        /// </summary>
        [UsedImplicitly]
        F22 = 0x85,

        /// <summary>
        /// F23 key.
        /// </summary>
        [UsedImplicitly]
        F23 = 0x86,

        /// <summary>
        /// F24 key.
        /// </summary>
        [UsedImplicitly]
        F24 = 0x87,

        /// <summary>
        /// Unassigned, not used.
        /// </summary>
        [UsedImplicitly]
        UNASSIGNED1 = 0x88,

        /// <summary>
        /// Unassigned, not used.
        /// </summary>
        [UsedImplicitly]
        UNASSIGNED2 = 0x89,

        /// <summary>
        /// Unassigned, not used.
        /// </summary>
        [UsedImplicitly]
        UNASSIGNED3 = 0x8A,

        /// <summary>
        /// Unassigned, not used.
        /// </summary>
        [UsedImplicitly]
        UNASSIGNED4 = 0x8B,

        /// <summary>
        /// Unassigned, not used.
        /// </summary>
        [UsedImplicitly]
        UNASSIGNED5 = 0x8C,

        /// <summary>
        /// Unassigned, not used.
        /// </summary>
        [UsedImplicitly]
        UNASSIGNED6 = 0x8D,

        /// <summary>
        /// Unassigned, not used.
        /// </summary>
        [UsedImplicitly]
        UNASSIGNED7 = 0x8E,

        /// <summary>
        /// Unassigned, not used.
        /// </summary>
        [UsedImplicitly]
        UNASSIGNED8 = 0x8F,

        /// <summary>
        /// NUM LOCK key.
        /// </summary>
        [UsedImplicitly]
        NUMLOCK = 0x90,

        /// <summary>
        /// SCROLL LOCK key.
        /// </summary>
        [UsedImplicitly]
        SCROLL = 0x91,

        /// <summary>
        /// OEM Specific.
        /// </summary>
        [UsedImplicitly]
        OEM1 = 0x92,

        /// <summary>
        /// OEM Specific.
        /// </summary>
        [UsedImplicitly]
        OEM2 = 0x93,

        /// <summary>
        /// OEM Specific.
        /// </summary>
        [UsedImplicitly]
        OEM3 = 0x94,

        /// <summary>
        /// OEM Specific.
        /// </summary>
        [UsedImplicitly]
        OEM4 = 0x95,

        /// <summary>
        /// OEM Specific.
        /// </summary>
        [UsedImplicitly]
        OEM5 = 0x96,

        /// <summary>
        /// Unassigned, not used.
        /// </summary>
        [UsedImplicitly]
        UNASSIGNED9 = 0x97,

        /// <summary>
        /// Unassigned, not used.
        /// </summary>
        [UsedImplicitly]
        UNASSIGNED10 = 0x97,

        /// <summary>
        /// Unassigned, not used.
        /// </summary>
        [UsedImplicitly]
        UNASSIGNED11 = 0x97,

        /// <summary>
        /// Unassigned, not used.
        /// </summary>
        [UsedImplicitly]
        UNASSIGNED12 = 0x97,

        /// <summary>
        /// Unassigned, not used.
        /// </summary>
        [UsedImplicitly]
        UNASSIGNED13 = 0x97,

        /// <summary>
        /// Unassigned, not used.
        /// </summary>
        [UsedImplicitly]
        UNASSIGNED14 = 0x97,

        /// <summary>
        /// Unassigned, not used.
        /// </summary>
        [UsedImplicitly]
        UNASSIGNED15 = 0x97,

        /// <summary>
        /// Unassigned, not used.
        /// </summary>
        [UsedImplicitly]
        UNASSIGNED16 = 0x97,

        /// <summary>
        /// Unassigned, not used.
        /// </summary>
        [UsedImplicitly]
        UNASSIGNED17 = 0x97,

        /// <summary>
        /// Left SHIFT key.
        /// </summary>
        [UsedImplicitly]
        LSHIFT = 0xA0,

        /// <summary>
        /// Right SHIFT key.
        /// </summary>
        [UsedImplicitly]
        RSHIFT = 0xA1,

        /// <summary>
        /// Left CONTROL key.
        /// </summary>
        [UsedImplicitly]
        LCONTROL = 0xA2,

        /// <summary>
        /// Right CONTROL key.
        /// </summary>
        [UsedImplicitly]
        RCONTROL = 0xA3,

        /// <summary>
        /// Left MENU key.
        /// </summary>
        [UsedImplicitly]
        LMENU = 0xA4,

        /// <summary>
        /// Right MENU key.
        /// </summary>
        [UsedImplicitly]
        RMENU = 0xA5,

        /// <summary>
        /// Browser Back key.
        /// </summary>
        [UsedImplicitly]
        BROWSER_BACK = 0xA6,

        /// <summary>
        /// Browser Forward key.
        /// </summary>
        [UsedImplicitly]
        BROWSER_FORWARD = 0xA7,

        /// <summary>
        /// Browser Refresh key.
        /// </summary>
        [UsedImplicitly]
        BROWSER_REFRESH = 0xA8,

        /// <summary>
        /// Browser Stop key.
        /// </summary>
        [UsedImplicitly]
        BROWSER_STOP = 0xA9,

        /// <summary>
        /// Browser Search key .
        /// </summary>
        [UsedImplicitly]
        BROWSER_SEARCH = 0xAA,

        /// <summary>
        /// Browser Favorites key.
        /// </summary>
        [UsedImplicitly]
        BROWSER_FAVORITES = 0xAB,

        /// <summary>
        /// Browser Start and Home key.
        /// </summary>
        [UsedImplicitly]
        BROWSER_HOME = 0xAC,

        /// <summary>
        /// Volume Mute key.
        /// </summary>
        [UsedImplicitly]
        VOLUME_MUTE = 0xAD,

        /// <summary>
        /// Volume Down key.
        /// </summary>
        [UsedImplicitly]
        VOLUME_DOWN = 0xAE,

        /// <summary>
        /// Volume Up key.
        /// </summary>
        [UsedImplicitly]
        VOLUME_UP = 0xAF,

        /// <summary>
        /// Next Track key.
        /// </summary>
        [UsedImplicitly]
        MEDIA_NEXT_TRACK = 0xB0,

        /// <summary>
        /// Previous Track key.
        /// </summary>
        [UsedImplicitly]
        MEDIA_PREV_TRACK = 0xB1,

        /// <summary>
        /// Stop Media key.
        /// </summary>
        [UsedImplicitly]
        MEDIA_STOP = 0xB2,

        /// <summary>
        /// Play/Pause Media key.
        /// </summary>
        [UsedImplicitly]
        MEDIA_PLAY_PAUSE = 0xB3,

        /// <summary>
        /// Start Mail key.
        /// </summary>
        [UsedImplicitly]
        LAUNCH_MAIL = 0xB4,

        /// <summary>
        /// Select Media key.
        /// </summary>
        [UsedImplicitly]
        LAUNCH_MEDIA_SELECT = 0xB5,

        /// <summary>
        /// Start Application 1 key.
        /// </summary>
        [UsedImplicitly]
        LAUNCH_APP1 = 0xB6,

        /// <summary>
        /// Start Application 2 key.
        /// </summary>
        [UsedImplicitly]
        LAUNCH_APP2 = 0xB7,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        RESERVED4 = 0xB8,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        RESERVED5 = 0xB9,

        /// <summary>
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// For the US standard keyboard, the ';:' key.
        /// </summary>
        [UsedImplicitly]
        OEM_1 = 0xBA,

        /// <summary>
        /// For any country/region, the '+' key.
        /// </summary>
        [UsedImplicitly]
        OEM_PLUS = 0xBB,

        /// <summary>
        /// For any country/region, the ',' key.
        /// </summary>
        [UsedImplicitly]
        OEM_COMMA = 0xBC,

        /// <summary>
        /// For any country/region, the '-' key.
        /// </summary>
        [UsedImplicitly]
        OEM_MINUS = 0xBD,

        /// <summary>
        /// For any country/region, the '.' key.
        /// </summary>
        [UsedImplicitly]
        OEM_PERIOD = 0xBE,

        /// <summary>
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// For the US standard keyboard, the '/?' key.
        /// </summary>
        [UsedImplicitly]
        OEM_2 = 0xBF,

        /// <summary>
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// For the US standard keyboard, the '`~' key.
        /// </summary>
        [UsedImplicitly]
        OEM_3 = 0xC0,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        RESERVED6 = 0xC1,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        RESERVED7 = 0xC2,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        RESERVED8 = 0xC3,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        RESERVED9 = 0xC4,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        RESERVED12 = 0xC5,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        RESERVED13 = 0xC6,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        RESERVED14 = 0xC7,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        RESERVED15 = 0xC8,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        RESERVED16 = 0xC9,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        RESERVED17 = 0xCA,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        RESERVED18 = 0xCB,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        RESERVED19 = 0xCC,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        RESERVED20 = 0xCD,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        RESERVED21 = 0xCE,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        RESERVED22 = 0xCF,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        RESERVED23 = 0xD1,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        RESERVED24 = 0xD2,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        RESERVED25 = 0xD3,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        RESERVED26 = 0xD4,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        RESERVED27 = 0xD5,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        RESERVED28 = 0xD6,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        RESERVED29 = 0xD7,

        /// <summary>
        /// Unassigned, not used.
        /// </summary>
        [UsedImplicitly]
        UNASSIGNED18 = 0xD8,

        /// <summary>
        /// Unassigned, not used.
        /// </summary>
        [UsedImplicitly]
        UNASSIGNED19 = 0xD9,

        /// <summary>
        /// Unassigned, not used.
        /// </summary>
        [UsedImplicitly]
        UNASSIGNED20 = 0xDA,

        /// <summary>
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// For the US standard keyboard, the '[{' key.
        /// </summary>
        [UsedImplicitly]
        OEM_4 = 0xDB,

        /// <summary>
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// For the US standard keyboard, the '\|' key.
        /// </summary>
        [UsedImplicitly]
        OEM_5 = 0xDC,

        /// <summary>
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// For the US standard keyboard, the ']}' key.
        /// </summary>
        [UsedImplicitly]
        OEM_6 = 0xDD,

        /// <summary>
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// For the US standard keyboard, the 'single-quote/double-quote' key.
        /// </summary>
        [UsedImplicitly]
        OEM_7 = 0xDE,

        /// <summary>
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// </summary>
        [UsedImplicitly]
        OEM_8 = 0xDF,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        RESERVED30 = 0xE0,

        /// <summary>
        /// OEM Specific.
        /// </summary>
        [UsedImplicitly]
        OEM6 = 0xE1,

        /// <summary>
        /// Either the angle bracket key or the backslash key on the RT 102-key keyboard.
        /// </summary>
        [UsedImplicitly]
        OEM_102 = 0xE2,

        /// <summary>
        /// OEM Specific.
        /// </summary>
        [UsedImplicitly]
        OEM7 = 0xE3,

        /// <summary>
        /// OEM Specific.
        /// </summary>
        [UsedImplicitly]
        OEM8 = 0xE4,

        /// <summary>
        /// IME PROCESS key.
        /// </summary>
        [UsedImplicitly]
        PROCESSKEY = 0xE5,

        /// <summary>
        /// OEM Specific.
        /// </summary>
        [UsedImplicitly]
        OEM9 = 0xE6,

        /// <summary>
        /// Used to pass Unicode characters as if they were keystrokes.
        /// The VK_PACKET key is the low word of a 32-bit
        /// Virtual Key value used for non-keyboard input methods.
        /// For more information, see Remark in KEYBDINPUT, SendInput, WM_KEYDOWN, and WM_KEYUP.
        /// </summary>
        [UsedImplicitly]
        PACKET = 0xE7,

        /// <summary>
        /// Unassigned, not used.
        /// </summary>
        [UsedImplicitly]
        UNASSIGNED21 = 0xE8,

        /// <summary>
        /// OEM Specific.
        /// </summary>
        [UsedImplicitly]
        OEM10 = 0xE9,

        /// <summary>
        /// OEM Specific.
        /// </summary>
        [UsedImplicitly]
        OEM11 = 0xEA,

        /// <summary>
        /// OEM Specific.
        /// </summary>
        [UsedImplicitly]
        OEM12 = 0xEB,

        /// <summary>
        /// OEM Specific.
        /// </summary>
        [UsedImplicitly]
        OEM13 = 0xEC,

        /// <summary>
        /// OEM Specific.
        /// </summary>
        [UsedImplicitly]
        OEM14 = 0xED,

        /// <summary>
        /// OEM Specific.
        /// </summary>
        [UsedImplicitly]
        OEM15 = 0xEE,

        /// <summary>
        /// OEM Specific.
        /// </summary>
        [UsedImplicitly]
        OEM16 = 0xEF,

        /// <summary>
        /// OEM Specific.
        /// </summary>
        [UsedImplicitly]
        OEM17 = 0xF1,

        /// <summary>
        /// OEM Specific.
        /// </summary>
        [UsedImplicitly]
        OEM18 = 0xF2,

        /// <summary>
        /// OEM Specific.
        /// </summary>
        [UsedImplicitly]
        OEM19 = 0xF3,

        /// <summary>
        /// OEM Specific.
        /// </summary>
        [UsedImplicitly]
        OEM20 = 0xF4,

        /// <summary>
        /// OEM Specific.
        /// </summary>
        [UsedImplicitly]
        OEM21 = 0xF5,

        /// <summary>
        /// <c>Attn</c> key.
        /// </summary>
        [UsedImplicitly]
        ATTN = 0xF6,

        /// <summary>
        /// <c>CrSel</c> key.
        /// </summary>
        [UsedImplicitly]
        CRSEL = 0xF7,

        /// <summary>
        /// <c>ExSel</c> key.
        /// </summary>
        [UsedImplicitly]
        EXSEL = 0xF8,

        /// <summary>
        /// Erase EOF key.
        /// </summary>
        [UsedImplicitly]
        EREOF = 0xF9,

        /// <summary>
        /// Play key.
        /// </summary>
        [UsedImplicitly]
        PLAY = 0xFA,

        /// <summary>
        /// Zoom key.
        /// </summary>
        [UsedImplicitly]
        ZOOM = 0xFB,

        /// <summary>
        /// Reserved for future.
        /// </summary>
        [UsedImplicitly]
        NONAME = 0xFC,

        /// <summary>
        /// PA1 key.
        /// </summary>
        [UsedImplicitly]
        PA1 = 0xFD,

        /// <summary>
        /// Clear key.
        /// </summary>
        [UsedImplicitly]
        OEM_CLEAR = 0xFE,
    }
}
