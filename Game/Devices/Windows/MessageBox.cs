using System;
using System.Collections.Generic;
using static Bare.Interop.SDL2;

namespace Bare.Devices
{
    /// <summary>
    /// The message box class can be used to show messages before, during, or after initialization.
    /// </summary>
    public static class MessageBox
    {
        private class Value
        {
            public SDL_MessageBoxFlags Flag;
            public string Caption;
        }

        private static Dictionary<MessageKind, Value> map = new Dictionary<MessageKind, Value>()
        {
            {MessageKind.Information, new Value{Flag=SDL_MessageBoxFlags.SDL_MESSAGEBOX_INFORMATION, Caption="Information"}},
            {MessageKind.Warning, new Value{Flag=SDL_MessageBoxFlags.SDL_MESSAGEBOX_WARNING, Caption="Warning"}},
            {MessageKind.Error, new Value{Flag=SDL_MessageBoxFlags.SDL_MESSAGEBOX_ERROR, Caption="Error"}}
        };

        /// <summary>
        /// Show a dialog with a message.
        /// </summary>
        /// <param name="message">The message to be displayed.</param>
        public static void Show(string message)
        {
            Show(MessageKind.Information, "Message", message);
        }

        public static void Show(MessageKind kind, string message)
        {
            SDL_ShowSimpleMessageBox(map[kind].Flag, map[kind].Caption, message, IntPtr.Zero);
        }

        public static void Show(MessageKind kind, string caption, string message)
        {
            SDL_ShowSimpleMessageBox(map[kind].Flag, caption, message, IntPtr.Zero);
        }
    }
}
