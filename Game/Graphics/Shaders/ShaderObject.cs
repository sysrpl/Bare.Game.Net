﻿using System;

namespace Bare.Graphics
{
    public abstract class ShaderObject : ContextHandle
    {
        public bool Valid { get; protected set; } = false;
        public string ErrorMessage { get; protected set; } = "";
        public ShaderObject ErrorObject { get; protected set; } = null;
    }
}
