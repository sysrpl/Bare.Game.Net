using static Bare.Interop.GLES20;

namespace Bare.Graphics
{
    public sealed class VertexShader : ShaderSource
    {
        public VertexShader() : base(GL_VERTEX_SHADER)
        {
        }
    }
}
