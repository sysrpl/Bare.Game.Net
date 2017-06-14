﻿﻿using System;
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
    public class Test02Window : Window
    {
        public static void Test()
        {
            WriteLine("Bare Game DataBuffer Tests");
            WriteLine("--------------------------");
            Run(new Test02Window());
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct VecColor
        {
            public Vec3 Point;
            public Vec3 Color;

            public VecColor(float x, float y, float z, float r, float g, float b)
            {
                Point.v0 = x;
                Point.v1 = y;
                Point.v2 = z;
                Color.v0 = r;
                Color.v1 = g;
                Color.v2 = b;
            }
        }

        ShaderProgram program;
        ShaderSource vertex;
        ShaderSource fragment;
        DataBuffer<VecColor> verts;

        protected override void ContextCreated()
        {
            verts = new DataBuffer<VecColor>();
            verts.Add(new VecColor(0.0f, 0.5f, 0.0f, 1, 0, 0));
            verts.Add(new VecColor(-0.5f, -0.5f, 0.0f, 0, 1, 0));
            verts.Add(new VecColor(0.5f, -0.5f, 0.0f, 0, 0, 1));
            program = new ShaderProgram();
            vertex = new VertexShader();
            vertex.Compile(
@"#version 100
precision mediump float;

attribute vec3 point;
attribute vec3 color;

varying vec3 c;

void main() {
  c = color;
  gl_Position = vec4(point, 1);
}");
            fragment = new FragmentShader();
            fragment.Compile(
@"#version 100
precision mediump float;

varying vec3 c;

void main() {
  gl_FragColor = vec4(c, 1);
}");
            program.Attach(vertex);
            program.Attach(fragment);
            program.Link();
            WriteLine(program);
        }

        protected override void ContextDestroyed()
        {
            vertex.Dispose();
            fragment.Dispose();
            program.Dispose();
            verts.Dispose();
        }

        protected override void Logic(EventList events, Stopwatch stopwatch)
        {
            foreach (var e in events)
            {
                if (e is KeyboardEvent)
                {
                    var k = e as KeyboardEvent;
                    if (k.Code == KeyCode.Escape)
                        Quit();
                }
            }
            if (stopwatch.Seconds > 10)
                Quit();
        }

        private static float Flip(float f)
        {
            f = f - (float)Math.Floor(f);
            f = f * 2;
            if (f > 1) f = 2 - f;
            return f;
        }

        protected override void Render(Stopwatch stopwatch)
        {
            glViewport(0, 0, ClientWidth, ClientHeight);
            float i = (float)(stopwatch.Time * 60);
            float r = Flip(0.5f + i / 400.0f);
            float g = Flip(0.3f + i / 680.0f);
            float b = Flip(0.8f + i / 840.0f);
            glClearColor(r, g, b, 1);
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
            glUseProgram(program.Handle);
            glEnableVertexAttribArray(0);
            glEnableVertexAttribArray(1);
            glVertexAttribPointer(0, 3, GL_FLOAT, GL_FALSE, verts.SizeOf, verts.Seek(0));
            glVertexAttribPointer(1, 3, GL_FLOAT, GL_FALSE, verts.SizeOf, verts.Next());
            glDrawArrays(GL_TRIANGLES, 0, 3);
            SwapBuffers();
        }
    }
}
