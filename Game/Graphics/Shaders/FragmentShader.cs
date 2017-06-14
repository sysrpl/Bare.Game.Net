using static Bare.Interop.GLES20;

namespace Bare.Graphics
{
    public sealed class FragmentShader : ShaderSource
    {
        public FragmentShader() : base(GL_FRAGMENT_SHADER)
        {
        }
    }
}
