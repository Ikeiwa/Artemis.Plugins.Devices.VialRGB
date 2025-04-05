using System.Collections.Generic;
using RGB.NET.Core;
using SharpVialRGB;

namespace Artemis.Plugins.Devices.VialRGB;

internal static class LedMappings
{
    public static readonly Dictionary<QmkKeycode, LedId> DEFAULT = new()
    {
        [QmkKeycode.KC_NO] = LedId.Unknown1,
        [QmkKeycode.KC_TRANSPARENT] = LedId.Unknown2,
        [QmkKeycode.KC_A] = LedId.Keyboard_A,
        [QmkKeycode.KC_B] = LedId.Keyboard_B,
        [QmkKeycode.KC_C] = LedId.Keyboard_C,
        [QmkKeycode.KC_D] = LedId.Keyboard_D,
        [QmkKeycode.KC_E] = LedId.Keyboard_E,
        [QmkKeycode.KC_F] = LedId.Keyboard_F,
        [QmkKeycode.KC_G] = LedId.Keyboard_G,
        [QmkKeycode.KC_H] = LedId.Keyboard_H,
        [QmkKeycode.KC_I] = LedId.Keyboard_I,
        [QmkKeycode.KC_J] = LedId.Keyboard_J,
        [QmkKeycode.KC_K] = LedId.Keyboard_K,
        [QmkKeycode.KC_L] = LedId.Keyboard_L,
        [QmkKeycode.KC_M] = LedId.Keyboard_M,
        [QmkKeycode.KC_N] = LedId.Keyboard_N,
        [QmkKeycode.KC_O] = LedId.Keyboard_O,
        [QmkKeycode.KC_P] = LedId.Keyboard_P,
        [QmkKeycode.KC_Q] = LedId.Keyboard_Q,
        [QmkKeycode.KC_R] = LedId.Keyboard_R,
        [QmkKeycode.KC_S] = LedId.Keyboard_S,
        [QmkKeycode.KC_T] = LedId.Keyboard_T,
        [QmkKeycode.KC_U] = LedId.Keyboard_U,
        [QmkKeycode.KC_V] = LedId.Keyboard_V,
        [QmkKeycode.KC_W] = LedId.Keyboard_W,
        [QmkKeycode.KC_X] = LedId.Keyboard_X,
        [QmkKeycode.KC_Y] = LedId.Keyboard_Y,
        [QmkKeycode.KC_Z] = LedId.Keyboard_Z,
        [QmkKeycode.KC_1] = LedId.Keyboard_1,
        [QmkKeycode.KC_2] = LedId.Keyboard_2,
        [QmkKeycode.KC_3] = LedId.Keyboard_3,
        [QmkKeycode.KC_4] = LedId.Keyboard_4,
        [QmkKeycode.KC_5] = LedId.Keyboard_5,
        [QmkKeycode.KC_6] = LedId.Keyboard_6,
        [QmkKeycode.KC_7] = LedId.Keyboard_7,
        [QmkKeycode.KC_8] = LedId.Keyboard_8,
        [QmkKeycode.KC_9] = LedId.Keyboard_9,
        [QmkKeycode.KC_0] = LedId.Keyboard_0,
        [QmkKeycode.KC_ENTER] = LedId.Keyboard_Enter,
        [QmkKeycode.KC_ESCAPE] = LedId.Keyboard_Escape,
        [QmkKeycode.KC_BACKSPACE] = LedId.Keyboard_Backspace,
        [QmkKeycode.KC_TAB] = LedId.Keyboard_Tab,
        [QmkKeycode.KC_SPACE] = LedId.Keyboard_Space,
        [QmkKeycode.KC_MINUS] = LedId.Keyboard_MinusAndUnderscore,
        [QmkKeycode.KC_EQUAL] = LedId.Keyboard_EqualsAndPlus,
        [QmkKeycode.KC_LEFT_BRACKET] = LedId.Keyboard_BracketLeft,
        [QmkKeycode.KC_RIGHT_BRACKET] = LedId.Keyboard_BracketRight,
        [QmkKeycode.KC_BACKSLASH] = LedId.Keyboard_Backslash,
        [QmkKeycode.KC_NONUS_HASH] = LedId.Keyboard_NonUsTilde,
        [QmkKeycode.KC_SEMICOLON] = LedId.Keyboard_SemicolonAndColon,
        [QmkKeycode.KC_QUOTE] = LedId.Keyboard_ApostropheAndDoubleQuote,
        [QmkKeycode.KC_GRAVE] = LedId.Keyboard_GraveAccentAndTilde,
        [QmkKeycode.KC_COMMA] = LedId.Keyboard_CommaAndLessThan,
        [QmkKeycode.KC_DOT] = LedId.Keyboard_PeriodAndBiggerThan,
        [QmkKeycode.KC_SLASH] = LedId.Keyboard_SlashAndQuestionMark,
        [QmkKeycode.KC_CAPS_LOCK] = LedId.Keyboard_CapsLock,
        [QmkKeycode.KC_F1] = LedId.Keyboard_F1,
        [QmkKeycode.KC_F2] = LedId.Keyboard_F2,
        [QmkKeycode.KC_F3] = LedId.Keyboard_F3,
        [QmkKeycode.KC_F4] = LedId.Keyboard_F4,
        [QmkKeycode.KC_F5] = LedId.Keyboard_F5,
        [QmkKeycode.KC_F6] = LedId.Keyboard_F6,
        [QmkKeycode.KC_F7] = LedId.Keyboard_F7,
        [QmkKeycode.KC_F8] = LedId.Keyboard_F8,
        [QmkKeycode.KC_F9] = LedId.Keyboard_F9,
        [QmkKeycode.KC_F10] = LedId.Keyboard_F10,
        [QmkKeycode.KC_F11] = LedId.Keyboard_F11,
        [QmkKeycode.KC_F12] = LedId.Keyboard_F12,
        [QmkKeycode.KC_PRINT_SCREEN] = LedId.Keyboard_PrintScreen,
        [QmkKeycode.KC_SCROLL_LOCK] = LedId.Keyboard_ScrollLock,
        [QmkKeycode.KC_PAUSE] = LedId.Keyboard_PauseBreak,
        [QmkKeycode.KC_INSERT] = LedId.Keyboard_Insert,
        [QmkKeycode.KC_HOME] = LedId.Keyboard_Home,
        [QmkKeycode.KC_PAGE_UP] = LedId.Keyboard_PageUp,
        [QmkKeycode.KC_DELETE] = LedId.Keyboard_Delete,
        [QmkKeycode.KC_END] = LedId.Keyboard_End,
        [QmkKeycode.KC_PAGE_DOWN] = LedId.Keyboard_PageDown,
        [QmkKeycode.KC_RIGHT] = LedId.Keyboard_ArrowRight,
        [QmkKeycode.KC_LEFT] = LedId.Keyboard_ArrowLeft,
        [QmkKeycode.KC_DOWN] = LedId.Keyboard_ArrowDown,
        [QmkKeycode.KC_UP] = LedId.Keyboard_ArrowUp,
        [QmkKeycode.KC_NUM_LOCK] = LedId.Keyboard_NumLock,
        [QmkKeycode.KC_KP_SLASH] = LedId.Keyboard_NumSlash,
        [QmkKeycode.KC_KP_ASTERISK] = LedId.Keyboard_NumAsterisk,
        [QmkKeycode.KC_KP_MINUS] = LedId.Keyboard_NumMinus,
        [QmkKeycode.KC_KP_PLUS] = LedId.Keyboard_NumPlus,
        [QmkKeycode.KC_KP_ENTER] = LedId.Keyboard_NumEnter,
        [QmkKeycode.KC_KP_1] = LedId.Keyboard_Num1,
        [QmkKeycode.KC_KP_2] = LedId.Keyboard_Num2,
        [QmkKeycode.KC_KP_3] = LedId.Keyboard_Num3,
        [QmkKeycode.KC_KP_4] = LedId.Keyboard_Num4,
        [QmkKeycode.KC_KP_5] = LedId.Keyboard_Num5,
        [QmkKeycode.KC_KP_6] = LedId.Keyboard_Num6,
        [QmkKeycode.KC_KP_7] = LedId.Keyboard_Num7,
        [QmkKeycode.KC_KP_8] = LedId.Keyboard_Num8,
        [QmkKeycode.KC_KP_9] = LedId.Keyboard_Num9,
        [QmkKeycode.KC_KP_0] = LedId.Keyboard_Num0,
        [QmkKeycode.KC_KP_DOT] = LedId.Keyboard_NumPeriodAndDelete,
        [QmkKeycode.KC_NONUS_BACKSLASH] = LedId.Keyboard_NonUsBackslash,
        [QmkKeycode.KC_APPLICATION] = LedId.Keyboard_Application,
        [QmkKeycode.KC_KB_POWER] = LedId.Keyboard_IndicatorPower,
        [QmkKeycode.KC_KP_EQUAL] = LedId.Keyboard_Num00,
        [QmkKeycode.KC_F13] = LedId.Keyboard_Function,
        [QmkKeycode.KC_F14] = LedId.Custom1,
        [QmkKeycode.KC_F15] = LedId.Custom2,
        [QmkKeycode.KC_F16] = LedId.Custom3,
        [QmkKeycode.KC_F17] = LedId.Custom4,
        [QmkKeycode.KC_F18] = LedId.Custom5,
        [QmkKeycode.KC_F19] = LedId.Custom6,
        [QmkKeycode.KC_F20] = LedId.Custom7,
        [QmkKeycode.KC_F21] = LedId.Custom8,
        [QmkKeycode.KC_F22] = LedId.Custom9,
        [QmkKeycode.KC_F23] = LedId.Custom10,
        [QmkKeycode.KC_F24] = LedId.Custom11,
        [QmkKeycode.KC_EXECUTE] = LedId.Custom12,
        [QmkKeycode.KC_HELP] = LedId.Custom13,
        [QmkKeycode.KC_MENU] = LedId.Custom14,
        [QmkKeycode.KC_SELECT] = LedId.Custom15,
        [QmkKeycode.KC_STOP] = LedId.Custom16,
        [QmkKeycode.KC_AGAIN] = LedId.Custom17,
        [QmkKeycode.KC_UNDO] = LedId.Custom18,
        [QmkKeycode.KC_CUT] = LedId.Custom19,
        [QmkKeycode.KC_COPY] = LedId.Custom20,
        [QmkKeycode.KC_PASTE] = LedId.Custom21,
        [QmkKeycode.KC_FIND] = LedId.Custom22,
        [QmkKeycode.KC_KB_MUTE] = LedId.Keyboard_MediaMute,
        [QmkKeycode.KC_KB_VOLUME_UP] = LedId.Keyboard_MediaVolumeUp,
        [QmkKeycode.KC_KB_VOLUME_DOWN] = LedId.Keyboard_MediaVolumeDown,
        [QmkKeycode.KC_LOCKING_CAPS_LOCK] = LedId.Custom23,
        [QmkKeycode.KC_LOCKING_NUM_LOCK] = LedId.Custom24,
        [QmkKeycode.KC_LOCKING_SCROLL_LOCK] = LedId.Custom25,
        [QmkKeycode.KC_KP_COMMA] = LedId.Keyboard_NumComma,
        [QmkKeycode.KC_KP_EQUAL_AS400] = LedId.Custom26,
        [QmkKeycode.KC_INTERNATIONAL_1] = LedId.Custom27,
        [QmkKeycode.KC_INTERNATIONAL_2] = LedId.Custom28,
        [QmkKeycode.KC_INTERNATIONAL_3] = LedId.Custom29,
        [QmkKeycode.KC_INTERNATIONAL_4] = LedId.Custom30,
        [QmkKeycode.KC_INTERNATIONAL_5] = LedId.Custom31,
        [QmkKeycode.KC_INTERNATIONAL_6] = LedId.Custom32,
        [QmkKeycode.KC_INTERNATIONAL_7] = LedId.Custom33,
        [QmkKeycode.KC_INTERNATIONAL_8] = LedId.Custom34,
        [QmkKeycode.KC_INTERNATIONAL_9] = LedId.Custom35,
        [QmkKeycode.KC_LANGUAGE_1] = LedId.Custom36,
        [QmkKeycode.KC_LANGUAGE_2] = LedId.Custom37,
        [QmkKeycode.KC_LANGUAGE_3] = LedId.Custom38,
        [QmkKeycode.KC_LANGUAGE_4] = LedId.Custom39,
        [QmkKeycode.KC_LANGUAGE_5] = LedId.Custom40,
        [QmkKeycode.KC_LANGUAGE_6] = LedId.Custom41,
        [QmkKeycode.KC_LANGUAGE_7] = LedId.Custom42,
        [QmkKeycode.KC_LANGUAGE_8] = LedId.Custom43,
        [QmkKeycode.KC_LANGUAGE_9] = LedId.Custom44,
        [QmkKeycode.KC_ALTERNATE_ERASE] = LedId.Custom45,
        [QmkKeycode.KC_SYSTEM_REQUEST] = LedId.Custom46,
        [QmkKeycode.KC_CANCEL] = LedId.Custom47,
        [QmkKeycode.KC_CLEAR] = LedId.Custom48,
        [QmkKeycode.KC_PRIOR] = LedId.Custom49,
        [QmkKeycode.KC_RETURN] = LedId.Custom50,
        [QmkKeycode.KC_SEPARATOR] = LedId.Custom51,
        [QmkKeycode.KC_OUT] = LedId.Custom52,
        [QmkKeycode.KC_OPER] = LedId.Custom53,
        [QmkKeycode.KC_CLEAR_AGAIN] = LedId.Custom54,
        [QmkKeycode.KC_CRSEL] = LedId.Custom55,
        [QmkKeycode.KC_EXSEL] = LedId.Custom56,
        [QmkKeycode.KC_SYSTEM_POWER] = LedId.Custom57,
        [QmkKeycode.KC_SYSTEM_SLEEP] = LedId.Custom58,
        [QmkKeycode.KC_SYSTEM_WAKE] = LedId.Custom59,
        [QmkKeycode.KC_AUDIO_MUTE] = LedId.Custom60,
        [QmkKeycode.KC_AUDIO_VOL_UP] = LedId.Keyboard_MediaVolumeUp,
        [QmkKeycode.KC_AUDIO_VOL_DOWN] = LedId.Keyboard_MediaVolumeDown,
        [QmkKeycode.KC_MEDIA_NEXT_TRACK] = LedId.Keyboard_MediaNextTrack,
        [QmkKeycode.KC_MEDIA_PREV_TRACK] = LedId.Keyboard_MediaPreviousTrack,
        [QmkKeycode.KC_MEDIA_STOP] = LedId.Keyboard_MediaStop,
        [QmkKeycode.KC_MEDIA_PLAY_PAUSE] = LedId.Keyboard_MediaPlay,
        [QmkKeycode.KC_MEDIA_SELECT] = LedId.Custom61,
        [QmkKeycode.KC_MEDIA_EJECT] = LedId.Custom62,
        [QmkKeycode.KC_MAIL] = LedId.Custom63,
        [QmkKeycode.KC_CALCULATOR] = LedId.Custom64,
        [QmkKeycode.KC_MY_COMPUTER] = LedId.Custom65,
        [QmkKeycode.KC_WWW_SEARCH] = LedId.Custom66,
        [QmkKeycode.KC_WWW_HOME] = LedId.Custom67,
        [QmkKeycode.KC_WWW_BACK] = LedId.Custom68,
        [QmkKeycode.KC_WWW_FORWARD] = LedId.Custom69,
        [QmkKeycode.KC_WWW_STOP] = LedId.Custom70,
        [QmkKeycode.KC_WWW_REFRESH] = LedId.Custom71,
        [QmkKeycode.KC_WWW_FAVORITES] = LedId.Custom72,
        [QmkKeycode.KC_MEDIA_FAST_FORWARD] = LedId.Custom73,
        [QmkKeycode.KC_MEDIA_REWIND] = LedId.Custom74,
        [QmkKeycode.KC_BRIGHTNESS_UP] = LedId.Custom75,
        [QmkKeycode.KC_BRIGHTNESS_DOWN] = LedId.Custom76,
        [QmkKeycode.KC_CONTROL_PANEL] = LedId.Custom77,
        [QmkKeycode.KC_ASSISTANT] = LedId.Custom78,
        [QmkKeycode.KC_MISSION_CONTROL] = LedId.Custom79,
        [QmkKeycode.KC_LAUNCHPAD] = LedId.Custom80,
        [QmkKeycode.KC_LEFT_CTRL] = LedId.Keyboard_LeftCtrl,
        [QmkKeycode.KC_LEFT_SHIFT] = LedId.Keyboard_LeftShift,
        [QmkKeycode.KC_LEFT_ALT] = LedId.Keyboard_LeftAlt,
        [QmkKeycode.KC_LEFT_GUI] = LedId.Keyboard_LeftGui,
        [QmkKeycode.KC_RIGHT_CTRL] = LedId.Keyboard_RightCtrl,
        [QmkKeycode.KC_RIGHT_SHIFT] = LedId.Keyboard_RightShift,
        [QmkKeycode.KC_RIGHT_ALT] = LedId.Keyboard_RightAlt,
        [QmkKeycode.KC_RIGHT_GUI] = LedId.Keyboard_RightGui,
    };
    
    
    
    public static readonly Dictionary<LedId, QmkKeycode> INVERT = new()
    {
		[LedId.Unknown1]                         =QmkKeycode.KC_NO,
		[LedId.Unknown2]                         =QmkKeycode.KC_TRANSPARENT,
		[LedId.Keyboard_A]                       =QmkKeycode.KC_A,
		[LedId.Keyboard_B]                       =QmkKeycode.KC_B,
		[LedId.Keyboard_C]                       =QmkKeycode.KC_C,
		[LedId.Keyboard_D]                       =QmkKeycode.KC_D,
		[LedId.Keyboard_E]                       =QmkKeycode.KC_E,
		[LedId.Keyboard_F]                       =QmkKeycode.KC_F,
		[LedId.Keyboard_G]                       =QmkKeycode.KC_G,
		[LedId.Keyboard_H]                       =QmkKeycode.KC_H,
		[LedId.Keyboard_I]                       =QmkKeycode.KC_I,
		[LedId.Keyboard_J]                       =QmkKeycode.KC_J,
		[LedId.Keyboard_K]                       =QmkKeycode.KC_K,
		[LedId.Keyboard_L]                       =QmkKeycode.KC_L,
		[LedId.Keyboard_M]                       =QmkKeycode.KC_M,
		[LedId.Keyboard_N]                       =QmkKeycode.KC_N,
		[LedId.Keyboard_O]                       =QmkKeycode.KC_O,
		[LedId.Keyboard_P]                       =QmkKeycode.KC_P,
		[LedId.Keyboard_Q]                       =QmkKeycode.KC_Q,
		[LedId.Keyboard_R]                       =QmkKeycode.KC_R,
		[LedId.Keyboard_S]                       =QmkKeycode.KC_S,
		[LedId.Keyboard_T]                       =QmkKeycode.KC_T,
		[LedId.Keyboard_U]                       =QmkKeycode.KC_U,
		[LedId.Keyboard_V]                       =QmkKeycode.KC_V,
		[LedId.Keyboard_W]                       =QmkKeycode.KC_W,
		[LedId.Keyboard_X]                       =QmkKeycode.KC_X,
		[LedId.Keyboard_Y]                       =QmkKeycode.KC_Y,
		[LedId.Keyboard_Z]                       =QmkKeycode.KC_Z,
		[LedId.Keyboard_1]                       =QmkKeycode.KC_1,
		[LedId.Keyboard_2]                       =QmkKeycode.KC_2,
		[LedId.Keyboard_3]                       =QmkKeycode.KC_3,
		[LedId.Keyboard_4]                       =QmkKeycode.KC_4,
		[LedId.Keyboard_5]                       =QmkKeycode.KC_5,
		[LedId.Keyboard_6]                       =QmkKeycode.KC_6,
		[LedId.Keyboard_7]                       =QmkKeycode.KC_7,
		[LedId.Keyboard_8]                       =QmkKeycode.KC_8,
		[LedId.Keyboard_9]                       =QmkKeycode.KC_9,
		[LedId.Keyboard_0]                       =QmkKeycode.KC_0,
		[LedId.Keyboard_Enter]                   =QmkKeycode.KC_ENTER,
		[LedId.Keyboard_Escape]                  =QmkKeycode.KC_ESCAPE,
		[LedId.Keyboard_Backspace]               =QmkKeycode.KC_BACKSPACE,
		[LedId.Keyboard_Tab]                     =QmkKeycode.KC_TAB,
		[LedId.Keyboard_Space]                   =QmkKeycode.KC_SPACE,
		[LedId.Keyboard_MinusAndUnderscore]      =QmkKeycode.KC_MINUS,
		[LedId.Keyboard_EqualsAndPlus]           =QmkKeycode.KC_EQUAL,
		[LedId.Keyboard_BracketLeft]             =QmkKeycode.KC_LEFT_BRACKET,
		[LedId.Keyboard_BracketRight]            =QmkKeycode.KC_RIGHT_BRACKET,
		[LedId.Keyboard_Backslash]               =QmkKeycode.KC_BACKSLASH,
		[LedId.Keyboard_NonUsTilde]              =QmkKeycode.KC_NONUS_HASH,
		[LedId.Keyboard_SemicolonAndColon]       =QmkKeycode.KC_SEMICOLON,
		[LedId.Keyboard_ApostropheAndDoubleQuote]=QmkKeycode.KC_QUOTE,
		[LedId.Keyboard_GraveAccentAndTilde]     =QmkKeycode.KC_GRAVE,
		[LedId.Keyboard_CommaAndLessThan]        =QmkKeycode.KC_COMMA,
		[LedId.Keyboard_PeriodAndBiggerThan]     =QmkKeycode.KC_DOT,
		[LedId.Keyboard_SlashAndQuestionMark]    =QmkKeycode.KC_SLASH,
		[LedId.Keyboard_CapsLock]                =QmkKeycode.KC_CAPS_LOCK,
		[LedId.Keyboard_F1]                      =QmkKeycode.KC_F1,
		[LedId.Keyboard_F2]                      =QmkKeycode.KC_F2,
		[LedId.Keyboard_F3]                      =QmkKeycode.KC_F3,
		[LedId.Keyboard_F4]                      =QmkKeycode.KC_F4,
		[LedId.Keyboard_F5]                      =QmkKeycode.KC_F5,
		[LedId.Keyboard_F6]                      =QmkKeycode.KC_F6,
		[LedId.Keyboard_F7]                      =QmkKeycode.KC_F7,
		[LedId.Keyboard_F8]                      =QmkKeycode.KC_F8,
		[LedId.Keyboard_F9]                      =QmkKeycode.KC_F9,
		[LedId.Keyboard_F10]                     =QmkKeycode.KC_F10,
		[LedId.Keyboard_F11]                     =QmkKeycode.KC_F11,
		[LedId.Keyboard_F12]                     =QmkKeycode.KC_F12,
		[LedId.Keyboard_PrintScreen]             =QmkKeycode.KC_PRINT_SCREEN,
		[LedId.Keyboard_ScrollLock]              =QmkKeycode.KC_SCROLL_LOCK,
		[LedId.Keyboard_PauseBreak]              =QmkKeycode.KC_PAUSE,
		[LedId.Keyboard_Insert]                  =QmkKeycode.KC_INSERT,
		[LedId.Keyboard_Home]                    =QmkKeycode.KC_HOME,
		[LedId.Keyboard_PageUp]                  =QmkKeycode.KC_PAGE_UP,
		[LedId.Keyboard_Delete]                  =QmkKeycode.KC_DELETE,
		[LedId.Keyboard_End]                     =QmkKeycode.KC_END,
		[LedId.Keyboard_PageDown]                =QmkKeycode.KC_PAGE_DOWN,
		[LedId.Keyboard_ArrowRight]              =QmkKeycode.KC_RIGHT,
		[LedId.Keyboard_ArrowLeft]               =QmkKeycode.KC_LEFT,
		[LedId.Keyboard_ArrowDown]               =QmkKeycode.KC_DOWN,
		[LedId.Keyboard_ArrowUp]                 =QmkKeycode.KC_UP,
		[LedId.Keyboard_NumLock]                 =QmkKeycode.KC_NUM_LOCK,
		[LedId.Keyboard_NumSlash]                =QmkKeycode.KC_KP_SLASH,
		[LedId.Keyboard_NumAsterisk]             =QmkKeycode.KC_KP_ASTERISK,
		[LedId.Keyboard_NumMinus]                =QmkKeycode.KC_KP_MINUS,
		[LedId.Keyboard_NumPlus]                 =QmkKeycode.KC_KP_PLUS,
		[LedId.Keyboard_NumEnter]                =QmkKeycode.KC_KP_ENTER,
		[LedId.Keyboard_Num1]                    =QmkKeycode.KC_KP_1,
		[LedId.Keyboard_Num2]                    =QmkKeycode.KC_KP_2,
		[LedId.Keyboard_Num3]                    =QmkKeycode.KC_KP_3,
		[LedId.Keyboard_Num4]                    =QmkKeycode.KC_KP_4,
		[LedId.Keyboard_Num5]                    =QmkKeycode.KC_KP_5,
		[LedId.Keyboard_Num6]                    =QmkKeycode.KC_KP_6,
		[LedId.Keyboard_Num7]                    =QmkKeycode.KC_KP_7,
		[LedId.Keyboard_Num8]                    =QmkKeycode.KC_KP_8,
		[LedId.Keyboard_Num9]                    =QmkKeycode.KC_KP_9,
		[LedId.Keyboard_Num0]                    =QmkKeycode.KC_KP_0,
		[LedId.Keyboard_NumPeriodAndDelete]      =QmkKeycode.KC_KP_DOT,
		[LedId.Keyboard_NonUsBackslash]          =QmkKeycode.KC_NONUS_BACKSLASH,
		[LedId.Keyboard_Application]             =QmkKeycode.KC_APPLICATION,
		[LedId.Keyboard_IndicatorPower]          =QmkKeycode.KC_KB_POWER,
		[LedId.Keyboard_Num00]                   =QmkKeycode.KC_KP_EQUAL,
		[LedId.Keyboard_Function]                =QmkKeycode.KC_F13,
		[LedId.Custom1]                          =QmkKeycode.KC_F14,
		[LedId.Custom2]                          =QmkKeycode.KC_F15,
		[LedId.Custom3]                          =QmkKeycode.KC_F16,
		[LedId.Custom4]                          =QmkKeycode.KC_F17,
		[LedId.Custom5]                          =QmkKeycode.KC_F18,
		[LedId.Custom6]                          =QmkKeycode.KC_F19,
		[LedId.Custom7]                          =QmkKeycode.KC_F20,
		[LedId.Custom8]                          =QmkKeycode.KC_F21,
		[LedId.Custom9]                          =QmkKeycode.KC_F22,
		[LedId.Custom10]                         =QmkKeycode.KC_F23,
		[LedId.Custom11]                         =QmkKeycode.KC_F24,
		[LedId.Custom12]                         =QmkKeycode.KC_EXECUTE,
		[LedId.Custom13]                         =QmkKeycode.KC_HELP,
		[LedId.Custom14]                         =QmkKeycode.KC_MENU,
		[LedId.Custom15]                         =QmkKeycode.KC_SELECT,
		[LedId.Custom16]                         =QmkKeycode.KC_STOP,
		[LedId.Custom17]                         =QmkKeycode.KC_AGAIN,
		[LedId.Custom18]                         =QmkKeycode.KC_UNDO,
		[LedId.Custom19]                         =QmkKeycode.KC_CUT,
		[LedId.Custom20]                         =QmkKeycode.KC_COPY,
		[LedId.Custom21]                         =QmkKeycode.KC_PASTE,
		[LedId.Custom22]                         =QmkKeycode.KC_FIND,
		[LedId.Keyboard_MediaMute]               =QmkKeycode.KC_KB_MUTE,
		[LedId.Keyboard_MediaVolumeUp]           =QmkKeycode.KC_KB_VOLUME_UP,
		[LedId.Keyboard_MediaVolumeDown]         =QmkKeycode.KC_KB_VOLUME_DOWN,
		[LedId.Custom23]                         =QmkKeycode.KC_LOCKING_CAPS_LOCK,
		[LedId.Custom24]                         =QmkKeycode.KC_LOCKING_NUM_LOCK,
		[LedId.Custom25]                         =QmkKeycode.KC_LOCKING_SCROLL_LOCK,
		[LedId.Keyboard_NumComma]                =QmkKeycode.KC_KP_COMMA,
		[LedId.Custom26]                         =QmkKeycode.KC_KP_EQUAL_AS400,
		[LedId.Custom27]                         =QmkKeycode.KC_INTERNATIONAL_1,
		[LedId.Custom28]                         =QmkKeycode.KC_INTERNATIONAL_2,
		[LedId.Custom29]                         =QmkKeycode.KC_INTERNATIONAL_3,
		[LedId.Custom30]                         =QmkKeycode.KC_INTERNATIONAL_4,
		[LedId.Custom31]                         =QmkKeycode.KC_INTERNATIONAL_5,
		[LedId.Custom32]                         =QmkKeycode.KC_INTERNATIONAL_6,
		[LedId.Custom33]                         =QmkKeycode.KC_INTERNATIONAL_7,
		[LedId.Custom34]                         =QmkKeycode.KC_INTERNATIONAL_8,
		[LedId.Custom35]                         =QmkKeycode.KC_INTERNATIONAL_9,
		[LedId.Custom36]                         =QmkKeycode.KC_LANGUAGE_1,
		[LedId.Custom37]                         =QmkKeycode.KC_LANGUAGE_2,
		[LedId.Custom38]                         =QmkKeycode.KC_LANGUAGE_3,
		[LedId.Custom39]                         =QmkKeycode.KC_LANGUAGE_4,
		[LedId.Custom40]                         =QmkKeycode.KC_LANGUAGE_5,
		[LedId.Custom41]                         =QmkKeycode.KC_LANGUAGE_6,
		[LedId.Custom42]                         =QmkKeycode.KC_LANGUAGE_7,
		[LedId.Custom43]                         =QmkKeycode.KC_LANGUAGE_8,
		[LedId.Custom44]                         =QmkKeycode.KC_LANGUAGE_9,
		[LedId.Custom45]                         =QmkKeycode.KC_ALTERNATE_ERASE,
		[LedId.Custom46]                         =QmkKeycode.KC_SYSTEM_REQUEST,
		[LedId.Custom47]                         =QmkKeycode.KC_CANCEL,
		[LedId.Custom48]                         =QmkKeycode.KC_CLEAR,
		[LedId.Custom49]                         =QmkKeycode.KC_PRIOR,
		[LedId.Custom50]                         =QmkKeycode.KC_RETURN,
		[LedId.Custom51]                         =QmkKeycode.KC_SEPARATOR,
		[LedId.Custom52]                         =QmkKeycode.KC_OUT,
		[LedId.Custom53]                         =QmkKeycode.KC_OPER,
		[LedId.Custom54]                         =QmkKeycode.KC_CLEAR_AGAIN,
		[LedId.Custom55]                         =QmkKeycode.KC_CRSEL,
		[LedId.Custom56]                         =QmkKeycode.KC_EXSEL,
		[LedId.Custom57]                         =QmkKeycode.KC_SYSTEM_POWER,
		[LedId.Custom58]                         =QmkKeycode.KC_SYSTEM_SLEEP,
		[LedId.Custom59]                         =QmkKeycode.KC_SYSTEM_WAKE,
		[LedId.Custom60]                         =QmkKeycode.KC_AUDIO_MUTE,
		[LedId.Keyboard_MediaVolumeUp]           =QmkKeycode.KC_AUDIO_VOL_UP,
		[LedId.Keyboard_MediaVolumeDown]         =QmkKeycode.KC_AUDIO_VOL_DOWN,
		[LedId.Keyboard_MediaNextTrack]          =QmkKeycode.KC_MEDIA_NEXT_TRACK,
		[LedId.Keyboard_MediaPreviousTrack]      =QmkKeycode.KC_MEDIA_PREV_TRACK,
		[LedId.Keyboard_MediaStop]               =QmkKeycode.KC_MEDIA_STOP,
		[LedId.Keyboard_MediaPlay]               =QmkKeycode.KC_MEDIA_PLAY_PAUSE,
		[LedId.Custom61]                         =QmkKeycode.KC_MEDIA_SELECT,
		[LedId.Custom62]                         =QmkKeycode.KC_MEDIA_EJECT,
		[LedId.Custom63]                         =QmkKeycode.KC_MAIL,
		[LedId.Custom64]                         =QmkKeycode.KC_CALCULATOR,
		[LedId.Custom65]                         =QmkKeycode.KC_MY_COMPUTER,
		[LedId.Custom66]                         =QmkKeycode.KC_WWW_SEARCH,
		[LedId.Custom67]                         =QmkKeycode.KC_WWW_HOME,
		[LedId.Custom68]                         =QmkKeycode.KC_WWW_BACK,
		[LedId.Custom69]                         =QmkKeycode.KC_WWW_FORWARD,
		[LedId.Custom70]                         =QmkKeycode.KC_WWW_STOP,
		[LedId.Custom71]                         =QmkKeycode.KC_WWW_REFRESH,
		[LedId.Custom72]                         =QmkKeycode.KC_WWW_FAVORITES,
		[LedId.Custom73]                         =QmkKeycode.KC_MEDIA_FAST_FORWARD,
		[LedId.Custom74]                         =QmkKeycode.KC_MEDIA_REWIND,
		[LedId.Custom75]                         =QmkKeycode.KC_BRIGHTNESS_UP,
		[LedId.Custom76]                         =QmkKeycode.KC_BRIGHTNESS_DOWN,
		[LedId.Custom77]                         =QmkKeycode.KC_CONTROL_PANEL,
		[LedId.Custom78]                         =QmkKeycode.KC_ASSISTANT,
		[LedId.Custom79]                         =QmkKeycode.KC_MISSION_CONTROL,
		[LedId.Custom80]                         =QmkKeycode.KC_LAUNCHPAD,
		[LedId.Keyboard_LeftCtrl]                =QmkKeycode.KC_LEFT_CTRL,
		[LedId.Keyboard_LeftShift]               =QmkKeycode.KC_LEFT_SHIFT,
		[LedId.Keyboard_LeftAlt]                 =QmkKeycode.KC_LEFT_ALT,
		[LedId.Keyboard_LeftGui]                 =QmkKeycode.KC_LEFT_GUI,
		[LedId.Keyboard_RightCtrl]               =QmkKeycode.KC_RIGHT_CTRL,
		[LedId.Keyboard_RightShift]              =QmkKeycode.KC_RIGHT_SHIFT,
		[LedId.Keyboard_RightAlt]                =QmkKeycode.KC_RIGHT_ALT,
		[LedId.Keyboard_RightGui]                =QmkKeycode.KC_RIGHT_GUI,
    };
}