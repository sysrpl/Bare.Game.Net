using System;

using static Bare.Interop.GLES20;

namespace Bare.Graphics
{

    public class ShaderSource : ShaderObject
    {
        private bool compiled;

        protected override void Destroy()
        {
            glDeleteShader(Handle);
        }

        public ShaderSource(int kind)
        {
            SetHandle(glCreateShader((int)kind));
            compiled = false;
        }

        public bool Compile(string source)
        {
            if (compiled)
                return false;
            compiled = true;
            Source = source;
            glShaderSource(Handle, source);
            glCompileShader(Handle);
            int i;
            glGetShaderiv(Handle, GL_COMPILE_STATUS, out i);
            Valid = i == GL_TRUE;
            if (!Valid)
            {
                ErrorObject = this;
                string s;
                glGetShaderInfoLog(Handle, out s);
                ErrorMessage = s;
            }
            return Valid;
        }

        public bool Compiled { get { return compiled; } }
        public string Source { get; private set; } = "";
    }
}
