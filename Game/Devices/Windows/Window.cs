﻿using System;
using Bare.Geometry;

using static Bare.Interop.SDL2;
using static Bare.Interop.GLES20;

namespace Bare.Devices
{
    public class Window : IDisposable
    {
        private Stopwatch stopwatch;
        private WindowStyle style;
        internal IntPtr window;
        internal IntPtr context;

        protected bool WindowExists
        {
            get
            {
                return window != IntPtr.Zero;
            }
        }

        internal bool CreateWindow()
        {
            CreateStyle(style);
            var x = style.Centered ? SDL_WINDOWPOS_CENTERED : style.X;
            var y = style.Centered ? SDL_WINDOWPOS_CENTERED : style.Y;
            uint flags = SDL_WINDOW_OPENGL |
                (style.Borderless ? SDL_WINDOW_BORDERLESS : 0) |
                (style.InputGrabbed ? SDL_WINDOW_INPUT_GRABBED : 0) |
                (style.Sizable ? SDL_WINDOW_RESIZABLE : 0) |
                (style.Visible ? SDL_WINDOW_SHOWN | SDL_WINDOW_INPUT_FOCUS : SDL_WINDOW_HIDDEN) |
                (style.Maximized ? SDL_WINDOW_MAXIMIZED : 0);
            if (style.WindowMode == WindowMode.Fullscreen)
                flags = flags | SDL_WINDOW_FULLSCREEN_DESKTOP;
            if (style.WindowMode == WindowMode.Exclusive)
                flags = flags | SDL_WINDOW_FULLSCREEN;
            var w = SDL_CreateWindow(style.Caption, x, y, style.Width,
                style.Height, flags);
            if (w == IntPtr.Zero)
                return false;
            var c = SDL_GL_CreateContext(w);
            if (c == IntPtr.Zero)
            {
                SDL_DestroyWindow(w);
                return false;
            }
            SDL_GL_MakeCurrent(w, c);
            try
            {
                if (GLES20Load())
                {
                    window = w;
                    context = c;
                    ContextCreated();
                    stopwatch.Reset();
                    return true;
                }
                else
                {
                    SDL_GL_DeleteContext(c);
                    SDL_DestroyWindow(w);
                    return false;
                }
            }
            finally
            {
                SDL_GL_MakeCurrent(IntPtr.Zero, IntPtr.Zero);
            }
        }

        protected virtual void CreateStyle(WindowStyle info)
        {
        }

        public Window()
        {
            stopwatch = new Stopwatch();
            style = new WindowStyle();
        }

        public void Dispose()
        {
            if (WindowExists)
            {
                var w = window;
                var c = context;
                window = IntPtr.Zero;
                context = IntPtr.Zero;
                try
                {
                    SDL_GL_MakeCurrent(w, c);
                    ContextDestroyed();
                }
                finally
                {
                    SDL_GL_MakeCurrent(IntPtr.Zero, IntPtr.Zero);
                    SDL_GL_DeleteContext(c);
                    SDL_DestroyWindow(w);
                }
            }
        }

        public int ClientWidth 
        {
            get
            {
                PointI p;
                GetClientSize(out p);
                return p.X;
            }
        }

        public int ClientHeight
        {
            get
            {
                PointI p;
                GetClientSize(out p);
                return p.Y;
            }
        }

        public void GetClientSize(out PointI p)
        {
            int x;
            int y;
            if (WindowExists)
                SDL_GetWindowSize(window, out x, out y);
            else
            {
                x = style.Width;
                y = style.Height;
            }
            p = new PointI(x, y);
        }

        #region properties

        /*public WindowMode WindowMode { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool Borderless { get; set; }
        public string Caption { get; set; }
        public bool Visible { get; set; }
        public bool Sizable { get; set; }*/
        #endregion


        public Display GetDisplay()
        {
            return WindowExists ? Game.Displays[SDL_GetWindowDisplayIndex(window)] : Game.Displays[0];
        }

        public void SetDisplayMode(DisplayMode mode)
        {
            style.DisplayMode = GetDisplay().Modes.Closest(mode.Width, mode.Height, mode.RefreshRate);
            //if (WindowExists)
            //   SDL_SetWindowDisplayMode(window, )
        }

        public void SetWindowMode(WindowMode mode)
        {
            if (style.WindowMode != mode)
            {
                style.WindowMode = mode;
                if (WindowExists)
                    SDL_SetWindowFullscreen(window, (uint)mode);
            }
        }

        internal void ProcessLoop(EventList events)
        {
            if (WindowExists)
                try
                {
                    stopwatch.Tick();
                    Logic(events, stopwatch);
                    if (WindowExists)
                    {
                        SDL_GL_MakeCurrent(window, context);
                        Render(stopwatch);
                    }
                }
                finally
                {
                    SDL_GL_MakeCurrent(IntPtr.Zero, IntPtr.Zero);
                }

        }

        protected virtual void ContextCreated()
        {

        }

        protected virtual void ContextDestroyed()
        {

        }

        protected virtual void Logic(EventList events, Stopwatch stopwatch)
        {

        }

        protected virtual void Render(Stopwatch stopwatch)
        {
        }
        /// <summary>
        /// Swaps the buffers for the current OpenGL context.
        /// </summary>
        public void SwapBuffers()
        {
            if (WindowExists)
                SDL_GL_SwapWindow(window);
        }
    }
}
