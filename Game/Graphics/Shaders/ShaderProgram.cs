using System;
using System.Collections;
using System.Collections.Generic;
using static Bare.Interop.GLES20;

namespace Bare.Graphics
{
    public sealed class ShaderProgram : ShaderObject, IReadOnlyList<ShaderSource>
    {
        private bool linked;
        private List<ShaderSource> shaders;

        protected override void Destroy()
        {
            glDeleteProgram(Handle);
        }

        public ShaderProgram()
        {
            SetHandle(glCreateProgram());
            shaders = new List<ShaderSource>();
        }

        public bool Attach(ShaderSource shader)
        {
            if (linked)
                return false;
            if (!shader.Compiled)
                return false;
            if (shaders.IndexOf(shader) > -1)
                return false;
            shaders.Add(shader);
            if (shader.Valid)
            {
                glAttachShader(Handle, shader.Handle);
                return true;
            }
            else
            {
                ErrorObject = shader;
                ErrorMessage = shader.ErrorMessage;
                return false;
            }
        }

        public bool Link()
        {
            if (linked)
                return false;
            if (ErrorObject != null)
                return false;
            linked = true;
            glLinkProgram(Handle);
            int i;
            glGetProgramiv(Handle, GL_LINK_STATUS, out i);
            Valid = i == GL_TRUE;
            if (Valid)
                return true;
            ErrorObject = this;
            string s;
            glGetProgramInfoLog(Handle, out s);
            ErrorMessage = s;
            return false;
        }

        public int Count => shaders.Count;
        public ShaderSource this[int index] => shaders[index];

        public IEnumerator<ShaderSource> GetEnumerator()
        {
            return shaders.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return shaders.GetEnumerator();
        }

        public override string ToString()
        {
            if (Valid)
                return string.Format("[ShaderProgram: Valid={0}]", Valid);
            if (ErrorObject == null)
                return string.Format("[ShaderProgram: Valid={0}", Valid);
            if (ErrorObject == this)
                return string.Format("[ShaderProgram: Valid={0} ErrorObject=this ErrorMessage={1}]",
                    this, ErrorMessage);
            return string.Format("[ShaderProgram: Valid={0} ErrorObject={1} ErrorMessage={2}]", 
                Valid, ErrorObject.GetType().Name, ErrorObject.ErrorMessage);
        }
    }
}
