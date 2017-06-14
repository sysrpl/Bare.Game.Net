﻿﻿using System;
using System.IO;
using System.Runtime.InteropServices;
using Bare;
using Bare.Devices;
using Bare.Geometry;
using Bare.Graphics;

using static System.Console;
using static Bare.Game;
using static Bare.Interop.GLES20;

namespace Tests
{
    public class Test03Window : Window
    {
        public static void Test()
        {
            WriteLine("Bare Game Shader Tests");
            WriteLine("--------------------------");
            Run(new Test03Window());
        }

        ShaderProgram program;
        ShaderSource vertex;
        ShaderSource fragment;
        DataBuffer<Vec3> verts;
        int time;
        int mouse;
        int resolution;

        protected override void ContextCreated()
        {
            verts = new DataBuffer<Vec3>();
            verts.Add(new Vec3(-1, 1, 0));
            verts.Add(new Vec3(-1, -1, 0));
            verts.Add(new Vec3(1, -1, 0));
            verts.Add(new Vec3(1, 1, 0));
            glEnableVertexAttribArray(0);
            glClearColor(0, 0, 0, 1);
        }

        protected override void ContextDestroyed()
        {
            if (loaded)
            {
                vertex.Dispose();
                fragment.Dispose();
                program.Dispose();
            }
            verts.Dispose();
        }

        protected override void Logic(EventList events, Stopwatch stopwatch)
        {
            foreach (var e in events)
            {
                if (e is KeyboardEvent)
                {
                    var k = e as KeyboardEvent;
                    if (k.Code == KeyCode.Space && k.State == KeyState.Up)
                        loadNext = true;
                    if (k.Code == KeyCode.Escape)
                        Quit();
                }
            }
        }

        private bool loaded = false;
        private bool loadNext = true;
        private int loadIndex = 0;

        private void NextFile()
        {
            if (loaded)
            {
                vertex.Dispose();
                fragment.Dispose();
                program.Dispose();
            }
            loaded = true;
            loadNext = false;
            program = new ShaderProgram();
            vertex = new VertexShader();
            vertex.Compile(
@"precision mediump float;

attribute vec3 point;
varying vec2 surfacePosition;

void main() {
  surfacePosition = point.xy + vec2(1, 5);
  gl_Position = vec4(point, 1);
}");
            fragment = new FragmentShader();
            loadIndex++;
            string s = $"Test03/shader{loadIndex}.glsl";
            if (!File.Exists(s))
            {
                loadIndex = 1;
                s = $"Test03/shader{loadIndex}.glsl";
            }
            fragment.Compile(File.ReadAllText(s));
            program.Attach(vertex);
            program.Attach(fragment);
            program.Link();
            WriteLine(program);
            glUseProgram(program.Handle);
            time = glGetUniformLocation(program.Handle, "time");
            mouse = glGetUniformLocation(program.Handle, "mouse");
            resolution = glGetUniformLocation(program.Handle, "resolution");
        }

        protected override void Render(Stopwatch stopwatch)
        {
            if (loadNext)
            {
                NextFile();
                stopwatch.Reset();
            }
            var w = ClientWidth;
            var h = ClientHeight;
            glViewport(0, 0, ClientWidth, ClientHeight);
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
            glUniform1f(time, (float)stopwatch.Time);
            glUniform2f(mouse, 0, 0);
            glUniform2f(resolution, w, h);
            glVertexAttribPointer(0, 3, GL_FLOAT, GL_FALSE, verts.SizeOf, verts[0]);
            glDrawArrays(GL_TRIANGLE_FAN, 0, 4);
            SwapBuffers();
        }
    }
}
