using System;
using System.Text;
using System.Runtime.InteropServices;

using static Bare.Interop.SDL2;

namespace Bare.Interop
{
    /// <summary>
    /// Entry point for all OpenGL ES 2.0 related types and methods.
    /// </summary>
    public static class GLES20
    {
        public const int GL_ES_VERSION_2_0 = 1;
        public const int GL_DEPTH_BUFFER_BIT = 0x00000100;
        public const int GL_STENCIL_BUFFER_BIT = 0x00000400;
        public const int GL_COLOR_BUFFER_BIT = 0x00004000;
        public const int GL_FALSE = 0;
        public const int GL_TRUE = 1;
        public const int GL_POINTS = 0x0000;
        public const int GL_LINES = 0x0001;
        public const int GL_LINE_LOOP = 0x0002;
        public const int GL_LINE_STRIP = 0x0003;
        public const int GL_TRIANGLES = 0x0004;
        public const int GL_TRIANGLE_STRIP = 0x0005;
        public const int GL_TRIANGLE_FAN = 0x0006;
        public const int GL_ZERO = 0;
        public const int GL_ONE = 1;
        public const int GL_SRC_COLOR = 0x0300;
        public const int GL_ONE_MINUS_SRC_COLOR = 0x0301;
        public const int GL_SRC_ALPHA = 0x0302;
        public const int GL_ONE_MINUS_SRC_ALPHA = 0x0303;
        public const int GL_DST_ALPHA = 0x0304;
        public const int GL_ONE_MINUS_DST_ALPHA = 0x0305;
        public const int GL_DST_COLOR = 0x0306;
        public const int GL_ONE_MINUS_DST_COLOR = 0x0307;
        public const int GL_SRC_ALPHA_SATURATE = 0x0308;
        public const int GL_FUNC_ADD = 0x8006;
        public const int GL_BLEND_EQUATION = 0x8009;
        public const int GL_BLEND_EQUATION_RGB = 0x8009;
        public const int GL_BLEND_EQUATION_ALPHA = 0x883D;
        public const int GL_FUNC_SUBTRACT = 0x800A;
        public const int GL_FUNC_REVERSE_SUBTRACT = 0x800B;
        public const int GL_BLEND_DST_RGB = 0x80C8;
        public const int GL_BLEND_SRC_RGB = 0x80C9;
        public const int GL_BLEND_DST_ALPHA = 0x80CA;
        public const int GL_BLEND_SRC_ALPHA = 0x80CB;
        public const int GL_CONSTANT_COLOR = 0x8001;
        public const int GL_ONE_MINUS_CONSTANT_COLOR = 0x8002;
        public const int GL_CONSTANT_ALPHA = 0x8003;
        public const int GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004;
        public const int GL_BLEND_COLOR = 0x8005;
        public const int GL_ARRAY_BUFFER = 0x8892;
        public const int GL_ELEMENT_ARRAY_BUFFER = 0x8893;
        public const int GL_ARRAY_BUFFER_BINDING = 0x8894;
        public const int GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;
        public const int GL_STREAM_DRAW = 0x88E0;
        public const int GL_STATIC_DRAW = 0x88E4;
        public const int GL_DYNAMIC_DRAW = 0x88E8;
        public const int GL_BUFFER_SIZE = 0x8764;
        public const int GL_BUFFER_USAGE = 0x8765;
        public const int GL_CURRENT_VERTEX_ATTRIB = 0x8626;
        public const int GL_FRONT = 0x0404;
        public const int GL_BACK = 0x0405;
        public const int GL_FRONT_AND_BACK = 0x0408;
        public const int GL_TEXTURE_2D = 0x0DE1;
        public const int GL_CULL_FACE = 0x0B44;
        public const int GL_BLEND = 0x0BE2;
        public const int GL_DITHER = 0x0BD0;
        public const int GL_STENCIL_TEST = 0x0B90;
        public const int GL_DEPTH_TEST = 0x0B71;
        public const int GL_SCISSOR_TEST = 0x0C11;
        public const int GL_POLYGON_OFFSET_FILL = 0x8037;
        public const int GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
        public const int GL_SAMPLE_COVERAGE = 0x80A0;
        public const int GL_NO_ERROR = 0;
        public const int GL_INVALID_ENUM = 0x0500;
        public const int GL_INVALID_VALUE = 0x0501;
        public const int GL_INVALID_OPERATION = 0x0502;
        public const int GL_OUT_OF_MEMORY = 0x0505;
        public const int GL_CW = 0x0900;
        public const int GL_CCW = 0x0901;
        public const int GL_LINE_WIDTH = 0x0B21;
        public const int GL_ALIASED_POINT_SIZE_RANGE = 0x846D;
        public const int GL_ALIASED_LINE_WIDTH_RANGE = 0x846E;
        public const int GL_CULL_FACE_MODE = 0x0B45;
        public const int GL_FRONT_FACE = 0x0B46;
        public const int GL_DEPTH_RANGE = 0x0B70;
        public const int GL_DEPTH_WRITEMASK = 0x0B72;
        public const int GL_DEPTH_CLEAR_VALUE = 0x0B73;
        public const int GL_DEPTH_FUNC = 0x0B74;
        public const int GL_STENCIL_CLEAR_VALUE = 0x0B91;
        public const int GL_STENCIL_FUNC = 0x0B92;
        public const int GL_STENCIL_FAIL = 0x0B94;
        public const int GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95;
        public const int GL_STENCIL_PASS_DEPTH_PASS = 0x0B96;
        public const int GL_STENCIL_REF = 0x0B97;
        public const int GL_STENCIL_VALUE_MASK = 0x0B93;
        public const int GL_STENCIL_WRITEMASK = 0x0B98;
        public const int GL_STENCIL_BACK_FUNC = 0x8800;
        public const int GL_STENCIL_BACK_FAIL = 0x8801;
        public const int GL_STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;
        public const int GL_STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;
        public const int GL_STENCIL_BACK_REF = 0x8CA3;
        public const int GL_STENCIL_BACK_VALUE_MASK = 0x8CA4;
        public const int GL_STENCIL_BACK_WRITEMASK = 0x8CA5;
        public const int GL_VIEWPORT = 0x0BA2;
        public const int GL_SCISSOR_BOX = 0x0C10;
        public const int GL_COLOR_CLEAR_VALUE = 0x0C22;
        public const int GL_COLOR_WRITEMASK = 0x0C23;
        public const int GL_UNPACK_ALIGNMENT = 0x0CF5;
        public const int GL_PACK_ALIGNMENT = 0x0D05;
        public const int GL_MAX_TEXTURE_SIZE = 0x0D33;
        public const int GL_MAX_VIEWPORT_DIMS = 0x0D3A;
        public const int GL_SUBPIXEL_BITS = 0x0D50;
        public const int GL_RED_BITS = 0x0D52;
        public const int GL_GREEN_BITS = 0x0D53;
        public const int GL_BLUE_BITS = 0x0D54;
        public const int GL_ALPHA_BITS = 0x0D55;
        public const int GL_DEPTH_BITS = 0x0D56;
        public const int GL_STENCIL_BITS = 0x0D57;
        public const int GL_POLYGON_OFFSET_UNITS = 0x2A00;
        public const int GL_POLYGON_OFFSET_FACTOR = 0x8038;
        public const int GL_TEXTURE_BINDING_2D = 0x8069;
        public const int GL_SAMPLE_BUFFERS = 0x80A8;
        public const int GL_SAMPLES = 0x80A9;
        public const int GL_SAMPLE_COVERAGE_VALUE = 0x80AA;
        public const int GL_SAMPLE_COVERAGE_INVERT = 0x80AB;
        public const int GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;
        public const int GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3;
        public const int GL_DONT_CARE = 0x1100;
        public const int GL_FASTEST = 0x1101;
        public const int GL_NICEST = 0x1102;
        public const int GL_GENERATE_MIPMAP_HINT = 0x8192;
        public const int GL_BYTE = 0x1400;
        public const int GL_UNSIGNED_BYTE = 0x1401;
        public const int GL_SHORT = 0x1402;
        public const int GL_UNSIGNED_SHORT = 0x1403;
        public const int GL_INT = 0x1404;
        public const int GL_UNSIGNED_INT = 0x1405;
        public const int GL_FLOAT = 0x1406;
        public const int GL_FIXED = 0x140C;
        public const int GL_DEPTH_COMPONENT = 0x1902;
        public const int GL_ALPHA = 0x1906;
        public const int GL_RGB = 0x1907;
        public const int GL_RGBA = 0x1908;
        public const int GL_LUMINANCE = 0x1909;
        public const int GL_LUMINANCE_ALPHA = 0x190A;
        public const int GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033;
        public const int GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034;
        public const int GL_UNSIGNED_SHORT_5_6_5 = 0x8363;
        public const int GL_FRAGMENT_SHADER = 0x8B30;
        public const int GL_VERTEX_SHADER = 0x8B31;
        public const int GL_MAX_VERTEX_ATTRIBS = 0x8869;
        public const int GL_MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
        public const int GL_MAX_VARYING_VECTORS = 0x8DFC;
        public const int GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;
        public const int GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;
        public const int GL_MAX_TEXTURE_IMAGE_UNITS = 0x8872;
        public const int GL_MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;
        public const int GL_SHADER_TYPE = 0x8B4F;
        public const int GL_DELETE_STATUS = 0x8B80;
        public const int GL_LINK_STATUS = 0x8B82;
        public const int GL_VALIDATE_STATUS = 0x8B83;
        public const int GL_ATTACHED_SHADERS = 0x8B85;
        public const int GL_ACTIVE_UNIFORMS = 0x8B86;
        public const int GL_ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87;
        public const int GL_ACTIVE_ATTRIBUTES = 0x8B89;
        public const int GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A;
        public const int GL_CURRENT_PROGRAM = 0x8B8D;
        public const int GL_NEVER = 0x0200;
        public const int GL_LESS = 0x0201;
        public const int GL_EQUAL = 0x0202;
        public const int GL_LEQUAL = 0x0203;
        public const int GL_GREATER = 0x0204;
        public const int GL_NOTEQUAL = 0x0205;
        public const int GL_GEQUAL = 0x0206;
        public const int GL_ALWAYS = 0x0207;
        public const int GL_KEEP = 0x1E00;
        public const int GL_REPLACE = 0x1E01;
        public const int GL_INCR = 0x1E02;
        public const int GL_DECR = 0x1E03;
        public const int GL_INVERT = 0x150A;
        public const int GL_INCR_WRAP = 0x8507;
        public const int GL_DECR_WRAP = 0x8508;
        // Used by glGetString
        public const int GL_VENDOR = 0x1F00;
        public const int GL_RENDERER = 0x1F01;
        public const int GL_VERSION = 0x1F02;
        public const int GL_EXTENSIONS = 0x1F03;
        public const int GL_SHADING_LANGUAGE_VERSION = 0x8B8C;
        // Used by glTexParameter
        public const int GL_NEAREST = 0x2600;
        public const int GL_LINEAR = 0x2601;
        public const int GL_NEAREST_MIPMAP_NEAREST = 0x2700;
        public const int GL_LINEAR_MIPMAP_NEAREST = 0x2701;
        public const int GL_NEAREST_MIPMAP_LINEAR = 0x2702;
        public const int GL_LINEAR_MIPMAP_LINEAR = 0x2703;
        public const int GL_TEXTURE_MAG_FILTER = 0x2800;
        public const int GL_TEXTURE_MIN_FILTER = 0x2801;
        public const int GL_TEXTURE_WRAP_S = 0x2802;
        public const int GL_TEXTURE_WRAP_T = 0x2803;

        public const int GL_TEXTURE = 0x1702;
        public const int GL_TEXTURE_CUBE_MAP = 0x8513;
        public const int GL_TEXTURE_BINDING_CUBE_MAP = 0x8514;
        public const int GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
        public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
        public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
        public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
        public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
        public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
        public const int GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;
        public const int GL_TEXTURE0 = 0x84C0;
        public const int GL_TEXTURE1 = 0x84C1;
        public const int GL_TEXTURE2 = 0x84C2;
        public const int GL_TEXTURE3 = 0x84C3;
        public const int GL_TEXTURE4 = 0x84C4;
        public const int GL_TEXTURE5 = 0x84C5;
        public const int GL_TEXTURE6 = 0x84C6;
        public const int GL_TEXTURE7 = 0x84C7;
        public const int GL_TEXTURE8 = 0x84C8;
        public const int GL_TEXTURE9 = 0x84C9;
        public const int GL_TEXTURE10 = 0x84CA;
        public const int GL_TEXTURE11 = 0x84CB;
        public const int GL_TEXTURE12 = 0x84CC;
        public const int GL_TEXTURE13 = 0x84CD;
        public const int GL_TEXTURE14 = 0x84CE;
        public const int GL_TEXTURE15 = 0x84CF;
        public const int GL_TEXTURE16 = 0x84D0;
        public const int GL_TEXTURE17 = 0x84D1;
        public const int GL_TEXTURE18 = 0x84D2;
        public const int GL_TEXTURE19 = 0x84D3;
        public const int GL_TEXTURE20 = 0x84D4;
        public const int GL_TEXTURE21 = 0x84D5;
        public const int GL_TEXTURE22 = 0x84D6;
        public const int GL_TEXTURE23 = 0x84D7;
        public const int GL_TEXTURE24 = 0x84D8;
        public const int GL_TEXTURE25 = 0x84D9;
        public const int GL_TEXTURE26 = 0x84DA;
        public const int GL_TEXTURE27 = 0x84DB;
        public const int GL_TEXTURE28 = 0x84DC;
        public const int GL_TEXTURE29 = 0x84DD;
        public const int GL_TEXTURE30 = 0x84DE;
        public const int GL_TEXTURE31 = 0x84DF;
        public const int GL_ACTIVE_TEXTURE = 0x84E0;
        public const int GL_REPEAT = 0x2901;
        public const int GL_CLAMP_TO_EDGE = 0x812F;
        public const int GL_MIRRORED_REPEAT = 0x8370;
        public const int GL_FLOAT_VEC2 = 0x8B50;
        public const int GL_FLOAT_VEC3 = 0x8B51;
        public const int GL_FLOAT_VEC4 = 0x8B52;
        public const int GL_INT_VEC2 = 0x8B53;
        public const int GL_INT_VEC3 = 0x8B54;
        public const int GL_INT_VEC4 = 0x8B55;
        public const int GL_BOOL = 0x8B56;
        public const int GL_BOOL_VEC2 = 0x8B57;
        public const int GL_BOOL_VEC3 = 0x8B58;
        public const int GL_BOOL_VEC4 = 0x8B59;
        public const int GL_FLOAT_MAT2 = 0x8B5A;
        public const int GL_FLOAT_MAT3 = 0x8B5B;
        public const int GL_FLOAT_MAT4 = 0x8B5C;
        public const int GL_SAMPLER_2D = 0x8B5E;
        public const int GL_SAMPLER_CUBE = 0x8B60;
        public const int GL_VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;
        public const int GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;
        public const int GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;
        public const int GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;
        public const int GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;
        public const int GL_VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;
        public const int GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;
        public const int GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;
        public const int GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;
        public const int GL_COMPILE_STATUS = 0x8B81;
        public const int GL_INFO_LOG_LENGTH = 0x8B84;
        public const int GL_SHADER_SOURCE_LENGTH = 0x8B88;
        public const int GL_SHADER_COMPILER = 0x8DFA;
        public const int GL_SHADER_BINARY_FORMATS = 0x8DF8;
        public const int GL_NUM_SHADER_BINARY_FORMATS = 0x8DF9;
        public const int GL_LOW_FLOAT = 0x8DF0;
        public const int GL_MEDIUM_FLOAT = 0x8DF1;
        public const int GL_HIGH_FLOAT = 0x8DF2;
        public const int GL_LOW_INT = 0x8DF3;
        public const int GL_MEDIUM_INT = 0x8DF4;
        public const int GL_HIGH_INT = 0x8DF5;
        public const int GL_FRAMEBUFFER = 0x8D40;
        public const int GL_RENDERBUFFER = 0x8D41;
        public const int GL_RGBA4 = 0x8056;
        public const int GL_RGB5_A1 = 0x8057;
        public const int GL_RGB565 = 0x8D62;
        public const int GL_DEPTH_COMPONENT16 = 0x81A5;
        public const int GL_STENCIL_INDEX8 = 0x8D48;
        public const int GL_RENDERBUFFER_WIDTH = 0x8D42;
        public const int GL_RENDERBUFFER_HEIGHT = 0x8D43;
        public const int GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;
        public const int GL_RENDERBUFFER_RED_SIZE = 0x8D50;
        public const int GL_RENDERBUFFER_GREEN_SIZE = 0x8D51;
        public const int GL_RENDERBUFFER_BLUE_SIZE = 0x8D52;
        public const int GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53;
        public const int GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54;
        public const int GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55;
        public const int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
        public const int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
        public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
        public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;
        public const int GL_COLOR_ATTACHMENT0 = 0x8CE0;
        public const int GL_DEPTH_ATTACHMENT = 0x8D00;
        public const int GL_STENCIL_ATTACHMENT = 0x8D20;
        public const int GL_NONE = 0;
        public const int GL_FRAMEBUFFER_COMPLETE = 0x8CD5;
        public const int GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
        public const int GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
        public const int GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS = 0x8CD9;
        public const int GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD;
        public const int GL_FRAMEBUFFER_BINDING = 0x8CA6;
        public const int GL_RENDERBUFFER_BINDING = 0x8CA7;
        public const int GL_MAX_RENDERBUFFER_SIZE = 0x84E8;
        public const int GL_INVALID_FRAMEBUFFER_OPERATION = 0x0506;

        private static class Delegates
        {
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glActiveTexture(int texture);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glAttachShader(int program, int shader);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glBindAttribLocation(int program, int index, IntPtr name);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glBindBuffer(int target, int buffer);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glBindFramebuffer(int target, int framebuffer);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glBindRenderbuffer(int target, int renderbuffer);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glBindTexture(int target, int texture);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glBlendColor(float red, float green, float blue, float alpha);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glBlendEquation(int mode);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glBlendEquationSeparate(int modeRGB, int modeAlpha);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glBlendFunc(int sfactor, int dfactor);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glBlendFuncSeparate(int sfactorRGB, int dfactorRGB, int sfactorAlpha, int dfactorAlpha);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glBufferData(int target, IntPtr size, IntPtr data, int usage);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glBufferSubData(int target, IntPtr offset, IntPtr size, IntPtr data);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate int glCheckFramebufferStatus(int target);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glClear(int mask);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glClearColor(float red, float green, float blue, float alpha);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glClearDepthf(float d);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glClearStencil(int s);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glColorMask(byte red, byte green, byte blue, byte alpha);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glCompileShader(int shader);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glCompressedTexImage2D(int target, int level, int internalformat, int width, int height, int border, int imageSize, IntPtr data);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glCompressedTexSubImage2D(int target, int level, int xoffset, int yoffset, int width, int height, int format, int imageSize, IntPtr data);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glCopyTexImage2D(int target, int level, int internalformat, int x, int y, int width, int height, int border);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glCopyTexSubImage2D(int target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate int glCreateProgram();
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate int glCreateShader(int type);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glCullFace(int mode);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glDebugMessageCallback(IntPtr callback, IntPtr userParam);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glDeleteBuffers(int n, int* buffers);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glDeleteFramebuffers(int n, int* framebuffers);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glDeleteProgram(int program);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glDeleteRenderbuffers(int n, int* renderbuffers);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glDeleteShader(int shader);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glDeleteTextures(int n, int* textures);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glDepthFunc(int func);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glDepthMask(byte flag);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glDepthRangef(float n, float f);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glDetachShader(int program, int shader);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glDisable(int cap);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glDisableVertexAttribArray(int index);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glDrawArrays(int mode, int first, int count);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glDrawElements(int mode, int count, int type, IntPtr indices);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glEnable(int cap);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glEnableVertexAttribArray(int index);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glFinish();
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glFlush();
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glFramebufferRenderbuffer(int target, int attachment, int renderbuffertarget, int renderbuffer);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glFramebufferTexture2D(int target, int attachment, int textarget, int texture, int level);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glFrontFace(int mode);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glGenBuffers(int n, int* buffers);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glGenerateMipmap(int target);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glGenFramebuffers(int n, int* framebuffers);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glGenRenderbuffers(int n, int* renderbuffers);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glGenTextures(int n, int* textures);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glGetActiveAttrib(int program, int index, int bufSize, int* length, int* size, int* type, IntPtr name);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glGetActiveUniform(int program, int index, int bufSize, int* length, int* size, int* type, IntPtr name);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glGetAttachedShaders(int program, int maxCount, int* count, int* shaders);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate int glGetAttribLocation(int program, IntPtr name);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glGetBooleanv(int pname, byte* data);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glGetBufferParameteriv(int target, int pname, int* values);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate int glGetError();
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glGetFloatv(int pname, float* data);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glGetFramebufferAttachmentParameteriv(int target, int attachment, int pname, int* values);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glGetIntegerv(int pname, int* data);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glGetPointerv(int pname, IntPtr values);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glGetProgramInfoLog(int program, int bufSize, int* length, IntPtr infoLog);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glGetProgramiv(int program, int pname, int* values);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glGetRenderbufferParameteriv(int target, int pname, int* values);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glGetShaderInfoLog(int shader, int bufSize, int* length, IntPtr infoLog);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glGetShaderiv(int shader, int pname, int* values);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glGetShaderPrecisionFormat(int shadertype, int precisiontype, int* range, int* precision);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glGetShaderSource(int shader, int bufSize, int* length, IntPtr source);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr glGetString(int name);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glGetTexParameterfv(int target, int pname, float* values);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glGetTexParameteriv(int target, int pname, int* values);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glGetUniformfv(int program, int location, float* values);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glGetUniformiv(int program, int location, int* values);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate int glGetUniformLocation(int program, IntPtr name);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glGetVertexAttribfv(int index, int pname, float* values);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glGetVertexAttribiv(int index, int pname, int* values);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glGetVertexAttribPointerv(int index, int pname, out IntPtr pointer);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glHint(int target, int mode);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate byte glIsBuffer(int buffer);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate byte glIsEnabled(int cap);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate byte glIsFramebuffer(int framebuffer);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate byte glIsProgram(int program);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate byte glIsRenderbuffer(int renderbuffer);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate byte glIsShader(int shader);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate byte glIsTexture(int texture);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glLineWidth(float width);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glLinkProgram(int program);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glObjectPtrLabel(IntPtr ptr, int length, IntPtr label);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glPixelStorei(int pname, int param);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glPolygonOffset(float factor, float units);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glReadPixels(int x, int y, int width, int height, int format, int type, IntPtr pixels);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glReleaseShaderCompiler();
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glRenderbufferStorage(int target, int internalformat, int width, int height);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glSampleCoverage(float value, bool invert);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glScissor(int x, int y, int width, int height);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glShaderBinary(int count, int* shaders, int binaryformat, IntPtr binary, int length);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glShaderSource(int shader, int count, IntPtr strings, int* length);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glStencilFunc(int func, int addr, int mask);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glStencilFuncSeparate(int face, int func, int addr, int mask);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glStencilMask(int mask);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glStencilMaskSeparate(int face, int mask);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glStencilOp(int fail, int zfail, int zpass);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glStencilOpSeparate(int face, int sfail, int dpfail, int dppass);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glTexImage2D(int target, int level, int internalformat, int width, int height, int border, int format, int type, IntPtr pixels);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glTexParameterf(int target, int pname, float param);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glTexParameterfv(int target, int pname, float* values);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glTexParameteri(int target, int pname, int param);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glTexParameteriv(int target, int pname, int* values);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glTexSubImage2D(int target, int level, int xoffset, int yoffset, int width, int height, int format, int type, IntPtr pixels);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glUniform1f(int location, float v0);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glUniform1fv(int location, int count, float* value);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glUniform1i(int location, int v0);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glUniform1iv(int location, int count, int* value);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glUniform2f(int location, float v0, float v1);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glUniform2fv(int location, int count, float* value);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glUniform2i(int location, int v0, int v1);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glUniform2iv(int location, int count, int* value);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glUniform3f(int location, float v0, float v1, float v2);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glUniform3fv(int location, int count, float* value);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glUniform3i(int location, int v0, int v1, int v2);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glUniform3iv(int location, int count, int* value);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glUniform4f(int location, float v0, float v1, float v2, float v3);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glUniform4fv(int location, int count, float* value);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glUniform4i(int location, int v0, int v1, int v2, int v3);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glUniform4iv(int location, int count, int* value);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glUniformMatrix2fv(int location, int count, bool transpose, float* value);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glUniformMatrix3fv(int location, int count, bool transpose, float* value);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glUniformMatrix4fv(int location, int count, bool transpose, float* value);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glUseProgram(int program);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glValidateProgram(int program);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glVertexAttrib1f(int index, float x);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glVertexAttrib1fv(int index, float* v);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glVertexAttrib2f(int index, float x, float y);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glVertexAttrib2fv(int index, float* v);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glVertexAttrib3f(int index, float x, float y, float z);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glVertexAttrib3fv(int index, float* v);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glVertexAttrib4f(int index, float x, float y, float z, float w);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public unsafe delegate void glVertexAttrib4fv(int index, float* v);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glVertexAttribPointer(int index, int size, int type, byte normalized, int stride, IntPtr pointer);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glViewport(int x, int y, int width, int height);
        }

        private static Delegates.glActiveTexture _glActiveTexture;
        private static Delegates.glAttachShader _glAttachShader;
        private static Delegates.glBindAttribLocation _glBindAttribLocation;
        private static Delegates.glBindBuffer _glBindBuffer;
        private static Delegates.glBindFramebuffer _glBindFramebuffer;
        private static Delegates.glBindRenderbuffer _glBindRenderbuffer;
        private static Delegates.glBindTexture _glBindTexture;
        private static Delegates.glBlendColor _glBlendColor;
        private static Delegates.glBlendEquation _glBlendEquation;
        private static Delegates.glBlendEquationSeparate _glBlendEquationSeparate;
        private static Delegates.glBlendFunc _glBlendFunc;
        private static Delegates.glBlendFuncSeparate _glBlendFuncSeparate;
        private static Delegates.glBufferData _glBufferData;
        private static Delegates.glBufferSubData _glBufferSubData;
        private static Delegates.glCheckFramebufferStatus _glCheckFramebufferStatus;
        private static Delegates.glClear _glClear;
        private static Delegates.glClearColor _glClearColor;
        private static Delegates.glClearDepthf _glClearDepthf;
        private static Delegates.glClearStencil _glClearStencil;
        private static Delegates.glColorMask _glColorMask;
        private static Delegates.glCompileShader _glCompileShader;
        private static Delegates.glCompressedTexImage2D _glCompressedTexImage2D;
        private static Delegates.glCompressedTexSubImage2D _glCompressedTexSubImage2D;
        private static Delegates.glCopyTexImage2D _glCopyTexImage2D;
        private static Delegates.glCopyTexSubImage2D _glCopyTexSubImage2D;
        private static Delegates.glCreateProgram _glCreateProgram;
        private static Delegates.glCreateShader _glCreateShader;
        private static Delegates.glCullFace _glCullFace;
        private static Delegates.glDeleteBuffers _glDeleteBuffers;
        private static Delegates.glDeleteFramebuffers _glDeleteFramebuffers;
        private static Delegates.glDeleteProgram _glDeleteProgram;
        private static Delegates.glDeleteRenderbuffers _glDeleteRenderbuffers;
        private static Delegates.glDeleteShader _glDeleteShader;
        private static Delegates.glDeleteTextures _glDeleteTextures;
        private static Delegates.glDepthFunc _glDepthFunc;
        private static Delegates.glDepthMask _glDepthMask;
        private static Delegates.glDepthRangef _glDepthRangef;
        private static Delegates.glDetachShader _glDetachShader;
        private static Delegates.glDisable _glDisable;
        private static Delegates.glDisableVertexAttribArray _glDisableVertexAttribArray;
        private static Delegates.glDrawArrays _glDrawArrays;
        private static Delegates.glDrawElements _glDrawElements;
        private static Delegates.glEnable _glEnable;
        private static Delegates.glEnableVertexAttribArray _glEnableVertexAttribArray;
        private static Delegates.glFinish _glFinish;
        private static Delegates.glFlush _glFlush;
        private static Delegates.glFramebufferRenderbuffer _glFramebufferRenderbuffer;
        private static Delegates.glFramebufferTexture2D _glFramebufferTexture2D;
        private static Delegates.glFrontFace _glFrontFace;
        private static Delegates.glGenBuffers _glGenBuffers;
        private static Delegates.glGenerateMipmap _glGenerateMipmap;
        private static Delegates.glGenFramebuffers _glGenFramebuffers;
        private static Delegates.glGenRenderbuffers _glGenRenderbuffers;
        private static Delegates.glGenTextures _glGenTextures;
        private static Delegates.glGetActiveAttrib _glGetActiveAttrib;
        private static Delegates.glGetActiveUniform _glGetActiveUniform;
        private static Delegates.glGetAttachedShaders _glGetAttachedShaders;
        private static Delegates.glGetAttribLocation _glGetAttribLocation;
        private static Delegates.glGetBooleanv _glGetBooleanv;
        private static Delegates.glGetBufferParameteriv _glGetBufferParameteriv;
        private static Delegates.glGetError _glGetError;
        private static Delegates.glGetFloatv _glGetFloatv;
        private static Delegates.glGetFramebufferAttachmentParameteriv _glGetFramebufferAttachmentParameteriv;
        private static Delegates.glGetIntegerv _glGetIntegerv;
        private static Delegates.glGetPointerv _glGetPointerv;
        private static Delegates.glGetProgramInfoLog _glGetProgramInfoLog;
        private static Delegates.glGetProgramiv _glGetProgramiv;
        private static Delegates.glGetRenderbufferParameteriv _glGetRenderbufferParameteriv;
        private static Delegates.glGetShaderInfoLog _glGetShaderInfoLog;
        private static Delegates.glGetShaderiv _glGetShaderiv;
        private static Delegates.glGetShaderPrecisionFormat _glGetShaderPrecisionFormat;
        private static Delegates.glGetShaderSource _glGetShaderSource;
        private static Delegates.glGetString _glGetString;
        private static Delegates.glGetTexParameterfv _glGetTexParameterfv;
        private static Delegates.glGetTexParameteriv _glGetTexParameteriv;
        private static Delegates.glGetUniformfv _glGetUniformfv;
        private static Delegates.glGetUniformiv _glGetUniformiv;
        private static Delegates.glGetUniformLocation _glGetUniformLocation;
        private static Delegates.glGetVertexAttribfv _glGetVertexAttribfv;
        private static Delegates.glGetVertexAttribiv _glGetVertexAttribiv;
        private static Delegates.glGetVertexAttribPointerv _glGetVertexAttribPointerv;
        private static Delegates.glHint _glHint;
        private static Delegates.glIsBuffer _glIsBuffer;
        private static Delegates.glIsEnabled _glIsEnabled;
        private static Delegates.glIsFramebuffer _glIsFramebuffer;
        private static Delegates.glIsProgram _glIsProgram;
        private static Delegates.glIsRenderbuffer _glIsRenderbuffer;
        private static Delegates.glIsShader _glIsShader;
        private static Delegates.glIsTexture _glIsTexture;
        private static Delegates.glLineWidth _glLineWidth;
        private static Delegates.glLinkProgram _glLinkProgram;
        private static Delegates.glPixelStorei _glPixelStorei;
        private static Delegates.glPolygonOffset _glPolygonOffset;
        private static Delegates.glReadPixels _glReadPixels;
        private static Delegates.glReleaseShaderCompiler _glReleaseShaderCompiler;
        private static Delegates.glRenderbufferStorage _glRenderbufferStorage;
        private static Delegates.glSampleCoverage _glSampleCoverage;
        private static Delegates.glScissor _glScissor;
        private static Delegates.glShaderBinary _glShaderBinary;
        private static Delegates.glShaderSource _glShaderSource;
        private static Delegates.glStencilFunc _glStencilFunc;
        private static Delegates.glStencilFuncSeparate _glStencilFuncSeparate;
        private static Delegates.glStencilMask _glStencilMask;
        private static Delegates.glStencilMaskSeparate _glStencilMaskSeparate;
        private static Delegates.glStencilOp _glStencilOp;
        private static Delegates.glStencilOpSeparate _glStencilOpSeparate;
        private static Delegates.glTexImage2D _glTexImage2D;
        private static Delegates.glTexParameterf _glTexParameterf;
        private static Delegates.glTexParameterfv _glTexParameterfv;
        private static Delegates.glTexParameteri _glTexParameteri;
        private static Delegates.glTexParameteriv _glTexParameteriv;
        private static Delegates.glTexSubImage2D _glTexSubImage2D;
        private static Delegates.glUniform1f _glUniform1f;
        private static Delegates.glUniform1fv _glUniform1fv;
        private static Delegates.glUniform1i _glUniform1i;
        private static Delegates.glUniform1iv _glUniform1iv;
        private static Delegates.glUniform2f _glUniform2f;
        private static Delegates.glUniform2fv _glUniform2fv;
        private static Delegates.glUniform2i _glUniform2i;
        private static Delegates.glUniform2iv _glUniform2iv;
        private static Delegates.glUniform3f _glUniform3f;
        private static Delegates.glUniform3fv _glUniform3fv;
        private static Delegates.glUniform3i _glUniform3i;
        private static Delegates.glUniform3iv _glUniform3iv;
        private static Delegates.glUniform4f _glUniform4f;
        private static Delegates.glUniform4fv _glUniform4fv;
        private static Delegates.glUniform4i _glUniform4i;
        private static Delegates.glUniform4iv _glUniform4iv;
        private static Delegates.glUniformMatrix2fv _glUniformMatrix2fv;
        private static Delegates.glUniformMatrix3fv _glUniformMatrix3fv;
        private static Delegates.glUniformMatrix4fv _glUniformMatrix4fv;
        private static Delegates.glUseProgram _glUseProgram;
        private static Delegates.glValidateProgram _glValidateProgram;
        private static Delegates.glVertexAttrib1f _glVertexAttrib1f;
        private static Delegates.glVertexAttrib1fv _glVertexAttrib1fv;
        private static Delegates.glVertexAttrib2f _glVertexAttrib2f;
        private static Delegates.glVertexAttrib2fv _glVertexAttrib2fv;
        private static Delegates.glVertexAttrib3f _glVertexAttrib3f;
        private static Delegates.glVertexAttrib3fv _glVertexAttrib3fv;
        private static Delegates.glVertexAttrib4f _glVertexAttrib4f;
        private static Delegates.glVertexAttrib4fv _glVertexAttrib4fv;
        private static Delegates.glVertexAttribPointer _glVertexAttribPointer;
        private static Delegates.glViewport _glViewport;

        #region Safer functions
        public static void glActiveTexture(int texture)
        {
            _glActiveTexture(texture);
        }

        public static void glAttachShader(int program, int shader)
        {
            _glAttachShader(program, shader);
        }

        public static void glBindAttribLocation(int program, int index, string name)
        {
            if (String.IsNullOrEmpty(name))
                return;
            var n = Marshal.StringToHGlobalAnsi(name);
            _glBindAttribLocation(program, index, n);
            Marshal.FreeHGlobal(n);
        }

        public static void glBindBuffer(int target, int buffer)
        {
            _glBindBuffer(target, buffer);
        }

        public static void glBindFramebuffer(int target, int framebuffer)
        {
            _glBindFramebuffer(target, framebuffer);
        }

        public static void glBindRenderbuffer(int target, int renderbuffer)
        {
            _glBindRenderbuffer(target, renderbuffer);
        }

        public static void glBindTexture(int target, int texture)
        {
            _glBindTexture(target, texture);
        }

        public static void glBlendColor(float red, float green, float blue, float alpha)
        {
            _glBlendColor(red, green, blue, alpha);
        }

        public static void glBlendEquation(int mode)
        {
            _glBlendEquation(mode);
        }

        public static void glBlendEquationSeparate(int modeRGB, int modeAlpha)
        {
            _glBlendEquationSeparate(modeRGB, modeAlpha);
        }

        public static void glBlendFunc(int sfactor, int dfactor)
        {
            _glBlendFunc(sfactor, dfactor);
        }

        /*
        public static void glBlendFuncSeparate(int sfactorRGB, int dfactorRGB, int sfactorAlpha, int dfactorAlpha)
        {
            _glBlendFuncSeparate();
        }

        public static void glBufferData(int target, IntPtr size, IntPtr data, int usage)
        {
            _glBufferData();
        }

        public static void glBufferSubData(int target, IntPtr offset, IntPtr size, IntPtr data)
        {
            _glBufferSubData();
        }

        public static int glCheckFramebufferStatus(int target)
        {
            _glCheckFramebufferStatus();
        }
        */

        public static void glClear(int mask)
        {
            _glClear(mask);
        } 

        public static void glClearColor(float red, float green, float blue, float alpha)
        {
            _glClearColor(red, green, blue, alpha);
        }

        public static void glClearDepthf(float d)
        {
            _glClearDepthf(d);
        }

        public static void glClearStencil(int s)
        {
            _glClearStencil(s);
        }

        public static void glColorMask(byte red, byte green, byte blue, byte alpha)
        {
            _glColorMask(red, green, blue, alpha);
        }

        public static void glCompileShader(int shader)
        {
            _glCompileShader(shader);
        }

        /*
        public static void glCompressedTexImage2D(int target, int level, int internalformat, int width, int height, int border, int imageSize, IntPtr data)
        {
            _glCompressedTexImage2D();
        }

        public static void glCompressedTexSubImage2D(int target, int level, int xoffset, int yoffset, int width, int height, int format, int imageSize, IntPtr data)
        {
            _glCompressedTexSubImage2D();
        }

        public static void glCopyTexImage2D(int target, int level, int internalformat, int x, int y, int width, int height, int border)
        {
            _glCopyTexImage2D(target, level, internalformat, x, y, width, height, border);
        }

        public static void glCopyTexSubImage2D(int target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
        {
            _glCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
        }*/

        public static int glCreateProgram()
        {
            return _glCreateProgram();
        }

        public static int glCreateShader(int type)
        {
            return _glCreateShader(type);
        }

        public static void glCullFace(int mode)
        {
            _glCullFace(mode);
        }

        public static unsafe void glDeleteBuffers(int[] buffers)
        {
            int n = buffers.Length;
            fixed (int* b = buffers)
                _glDeleteBuffers(n, b);
        }

        public static unsafe void glDeleteFramebuffers(int[] framebuffers)
        {
            int n = framebuffers.Length;
            fixed (int* b = framebuffers)
                _glDeleteFramebuffers(n, b);
        }

        public static void glDeleteProgram(int program)
        {
            _glDeleteProgram(program);
        }

        public static void glDeleteRenderbuffers(int[] renderbuffers)
        {
            int n = renderbuffers.Length;
            unsafe
            {
                fixed (int* b = renderbuffers)
                    _glDeleteRenderbuffers(n, b);
            }
        }

        public static void glDeleteShader(int shader)
        {
            _glDeleteShader(shader);
        }

        public static void glDeleteTextures(int[] textures)
        {
            int n = textures.Length;
            unsafe
            {
                fixed (int* b = textures)
                    _glDeleteTextures(n, b);
            }
        }

        public static void glDepthFunc(int func)
        {
            _glDepthFunc(func);
        }

        public static void glDepthMask(byte flag)
        {
            _glDepthMask(flag);
        }

        public static void glDepthRangef(float n, float f)
        {
            _glDepthRangef(n, f);
        }

        public static void glDetachShader(int program, int shader)
        {
            _glDetachShader(program, shader);
        }

        public static void glDisable(int cap)
        {
            _glDisable(cap);
        }

        public static void glDisableVertexAttribArray(int index)
        {
            _glDisableVertexAttribArray(index);
        }

        public static void glDrawArrays(int mode, int first, int count)
        {
            _glDrawArrays(mode, first, count);
        }

        public static void glDrawElements(int mode, int count, int type, IntPtr indices)
        {
            _glDrawElements(mode, count, type, indices);
        }

        public static void glEnable(int cap)
        {
            _glEnable(cap);
        }

        public static void glEnableVertexAttribArray(int index)
        {
            _glEnableVertexAttribArray(index);
        }

        public static void glFinish()
        {
            _glFinish();
        }

        public static void glFlush()
        {
            _glFlush();
        }

        public static void glFramebufferRenderbuffer(int target, int attachment, int renderbuffertarget, int renderbuffer)
        {
            _glFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
        }

        public static void glFramebufferTexture2D(int target, int attachment, int textarget, int texture, int level)
        {
            _glFramebufferTexture2D(target, attachment, textarget, texture, level);
        }

        public static void glFrontFace(int mode)
        {
            _glFrontFace(mode);
        }

        public static void glGenBuffers(int n, out int[] buffers)
        {
            buffers = new int[n];
            unsafe
            {
                fixed (int* b = buffers)
                    _glGenBuffers(n, b);
            }
        }

        public static void glGenerateMipmap(int target)
        {
            _glGenerateMipmap(target);
        }

        /*public static void glGenFramebuffers(int n, int* framebuffers)
        {
            _glGenFramebuffers();
        }

        public static void glGenRenderbuffers(int n, int* renderbuffers)
        {
            _glGenRenderbuffers();
        }

        public static void glGenTextures(int n, int* textures)
        {
            _glGenTextures();
        }

        public static void glGetActiveAttrib(int program, int index, int bufSize, int* length, int* size, int* type, IntPtr name)
        {
            _glGetActiveAttrib();
        }

        public static void glGetActiveUniform(int program, int index, int bufSize, int* length, int* size, int* type, IntPtr name)
        {
            _glGetActiveUniform();
        }

        public static void glGetAttachedShaders(int program, int maxCount, int* count, int* shaders)
        {
            _glGetAttachedShaders();
        }*/

        public static int glGetAttribLocation(int program, string name)
        {
            if (String.IsNullOrEmpty(name))
                return -1;
            var n = Marshal.StringToHGlobalAnsi(name);
            var i = _glGetAttribLocation(program, n);
            Marshal.FreeHGlobal(n);
            return i;
        }

        public static unsafe void glGetBooleanv(int pname, out byte data)
        {
            byte b;
            _glGetBooleanv(pname, &b);
            data = b;
        }

        /*public static void glGetBufferParameteriv(int target, int pname, int* values)
        {
            _glGetBufferParameteriv();
        }

        public static int glGetError()
        {
            _glGetError();
        }

        public static void glGetFloatv(int pname, float* data)
        {
            _glGetFloatv();
        }

        public static void glGetFramebufferAttachmentParameteriv(int target, int attachment, int pname, int* values)
        {
            _glGetFramebufferAttachmentParameteriv();
        }

        public static void glGetIntegerv(int pname, int* data)
        {
            _glGetIntegerv();
        }

        public static void glGetPointerv(int pname, IntPtr values)
        {
            _glGetPointerv();
        }*/

        public static void glGetProgramInfoLog(int program, out string infoLog)
        {
            int i;
            glGetProgramiv(program, GL_INFO_LOG_LENGTH, out i);
            if (i < 1)
            {
                infoLog = String.Empty;
                return;
            }
            byte[] buffer = new byte[i + 1];
            buffer[i] = 0;
            unsafe
            {
                fixed (byte* b = buffer)
                {
                    int length;
                    var s = (IntPtr)b;
                    _glGetProgramInfoLog(program, i + 1, &length, s);
                    infoLog = Marshal.PtrToStringAuto(s);
                }
            }
        }

        public static unsafe void glGetProgramiv(int program, int pname, out int values)
        {
            int i = 0;
            fixed (int* v = &values)
            {
                _glGetProgramiv(program, pname, v);
                i = *v;
            }
            values = i;
        }

        /*public static void glGetRenderbufferParameteriv(int target, int pname, int* values)
        {
            _glGetRenderbufferParameteriv();
        }*/

        public static unsafe void glGetShaderInfoLog(int shader, out string infoLog)
        {
            int i;
            glGetShaderiv(shader, GL_INFO_LOG_LENGTH, out i);
            if (i < 1)
            {
                infoLog = String.Empty;
                return;
            }
            byte[] buffer = new byte[i + 1];
            buffer[i] = 0;
            fixed (byte* b = buffer)
            {
                int length;
                var s = (IntPtr)b;
                _glGetShaderInfoLog(shader, i + 1, &length, s);
                infoLog = Marshal.PtrToStringAuto(s);
            }
        }

        public static unsafe void glGetShaderiv(int shader, int pname, out int values)
        {
            int i = 0;
            fixed (int* v = &values)
            {
                _glGetShaderiv(shader, pname, v);
                i = *v;
            }
            values = i;
        }

        /*public static void glGetShaderPrecisionFormat(int shadertype, int precisiontype, int* range, int* precision)
        {
            _glGetShaderPrecisionFormat();
        }*/

        public static unsafe void glGetShaderSource(int shader, out string source)
        {
            int i;
            glGetShaderiv(shader, GL_SHADER_SOURCE_LENGTH, out i);
            if (i < 1)
            {
                source = String.Empty;
                return;
            }
            byte[] buffer = new byte[i + 1];
            buffer[i] = 0;
            fixed (byte* b = buffer)
            {
                int length;
                var s = (IntPtr)b;
                _glGetShaderSource(shader, i + 1, &length, s);    
                source = Marshal.PtrToStringAuto(s);
            }
        }

        public static string glGetString(int name)
        {
            var s = _glGetString(name);
            return Marshal.PtrToStringAuto(s);
        }

        /*
        public static void glGetTexParameterfv(int target, int pname, float* values)
        {
            _glGetTexParameterfv();
        }

        public static void glGetTexParameteriv(int target, int pname, int* values)
        {
            _glGetTexParameteriv();
        }

        public static void glGetUniformfv(int program, int location, float* values)
        {
            _glGetUniformfv();
        }

        public static void glGetUniformiv(int program, int location, int* values)
        {
            _glGetUniformiv();
        }*/

        public static int glGetUniformLocation(int program, string name)
        {
            if (String.IsNullOrEmpty(name))
                return -1;
            var n = Marshal.StringToHGlobalAnsi(name);
            var i = _glGetUniformLocation(program, n);
            Marshal.FreeHGlobal(n);
            return i;
        }

        /*public static void glGetVertexAttribfv(int index, int pname, float* values)
        {
            _glGetVertexAttribfv();
        }

        public static void glGetVertexAttribiv(int index, int pname, int* values)
        {
            _glGetVertexAttribiv();
        }

        public static void glGetVertexAttribPointerv(int index, int pname, out IntPtr pointer)
        {
            _glGetVertexAttribPointerv();
        }

        public static void glHint(int target, int mode)
        {
            _glHint();
        }

        public static byte glIsBuffer(int buffer)
        {
            _glIsBuffer();
        }

        public static byte glIsEnabled(int cap)
        {
            _glIsEnabled();
        }

        public static byte glIsFramebuffer(int framebuffer)
        {
            _glIsFramebuffer();
        }

        public static byte glIsProgram(int program)
        {
            _glIsProgram();
        }

        public static byte glIsRenderbuffer(int renderbuffer)
        {
            _glIsRenderbuffer();
        }

        public static byte glIsShader(int shader)
        {
            _glIsShader();
        }

        public static byte glIsTexture(int texture)
        {
            _glIsTexture();
        }

        public static void glLineWidth(float width)
        {
            _glLineWidth();
        }*/

        public static void glLinkProgram(int program)
        {
            _glLinkProgram(program);
        }

        /*public static void glObjectPtrLabel(IntPtr ptr, int length, IntPtr label)
        {
            _glObjectPtrLabel();
        }

        public static void glPixelStorei(int pname, int param)
        {
            _glPixelStorei();
        }

        public static void glPolygonOffset(float factor, float units)
        {
            _glPolygonOffset();
        }

        public static void glReadPixels(int x, int y, int width, int height, int format, int type, IntPtr pixels)
        {
            _glReadPixels();
        }

        public static void glReleaseShaderCompiler()
        {
            _glReleaseShaderCompiler();
        }

        public static void glRenderbufferStorage(int target, int internalformat, int width, int height)
        {
            _glRenderbufferStorage();
        }

        public static void glSampleCoverage(float value, bool invert)
        {
            _glSampleCoverage();
        }

        public static void glScissor(int x, int y, int width, int height)
        {
            _glScissor();
        }

        public static void glShaderBinary(int count, int* shaders, int binaryformat, IntPtr binary, int length)
        {
            _glShaderBinary();
        }*/

        public static void glShaderSource(int shader, string source)
        {
            if (String.IsNullOrWhiteSpace(source))
                source = " ";
            var buffer = Encoding.ASCII.GetBytes(source + "\0");
            unsafe
            {
                fixed (byte* b = buffer)
                {
                    void* p = b;
                    void* sources = &p;
                    _glShaderSource(shader, 1, (IntPtr)sources, null);
                }
            }
        }

        /*public static void glStencilFunc(int func, int addr, int mask)
        {
            _glStencilFunc();
        }

        public static void glStencilFuncSeparate(int face, int func, int addr, int mask)
        {
            _glStencilFuncSeparate();
        }

        public static void glStencilMask(int mask)
        {
            _glStencilMask();
        }

        public static void glStencilMaskSeparate(int face, int mask)
        {
            _glStencilMaskSeparate();
        }

        public static void glStencilOp(int fail, int zfail, int zpass)
        {
            _glStencilOp();
        }

        public static void glStencilOpSeparate(int face, int sfail, int dpfail, int dppass)
        {
            _glStencilOpSeparate();
        }

        public static void glTexImage2D(int target, int level, int internalformat, int width, int height, int border, int format, int type, IntPtr pixels)
        {
            _glTexImage2D();
        }

        public static void glTexParameterf(int target, int pname, float param)
        {
            _glTexParameterf();
        }

        public static void glTexParameterfv(int target, int pname, float* values)
        {
            _glTexParameterfv();
        }

        public static void glTexParameteri(int target, int pname, int param)
        {
            _glTexParameteri();
        }

        public static void glTexParameteriv(int target, int pname, int* values)
        {
            _glTexParameteriv();
        }

        public static void glTexSubImage2D(int target, int level, int xoffset, int yoffset, int width, int height, int format, int type, IntPtr pixels)
        {
            _glTexSubImage2D();
        }*/

        public static void glUniform(int location, float v0)
        {
            glUniform1f(location, v0);
        }

        public static void glUniform(int location, int v0)
        {
            glUniform1i(location, v0);
        }

        public static void glUniform(int location, float v0, float v1)
        {
            glUniform2f(location, v0, v1);
        }

        public static void glUniform(int location, int v0, int v1)
        {
            glUniform2i(location, v0, v1);
        }

        public static void glUniform(int location, float v0, float v1, float v2)
        {
            glUniform3f(location, v0, v1, v2);
        }

        public static void glUniform(int location, int v0, int v1, int v2)
        {
            glUniform3i(location, v0, v1, v2);
        }

        public static void glUniform1f(int location, float v0)
        {
            _glUniform1f(location, v0);
        }

        public static unsafe void glUniform1fv(int location, int count, IntPtr value)
        {
            _glUniform1fv(location, count, (float*)value);
        }

        public static void glUniform1i(int location, int v0)
        {
            _glUniform1i(location, v0);
        }

        public static unsafe void glUniform1iv(int location, int count, int* value)
        {
            _glUniform1iv(location, count, (int*)value);
        }

        public static void glUniform2f(int location, float v0, float v1)
        {
            _glUniform2f(location, v0, v1);
        }

        public static unsafe void glUniform2fv(int location, int count, IntPtr value)
        {
            _glUniform2fv(location, count, (float*)value);
        }

        public static void glUniform2i(int location, int v0, int v1)
        {
            _glUniform2i(location, v0, v1);
        }

        public static unsafe void glUniform2iv(int location, int count, IntPtr value)
        {
            _glUniform2iv(location, count, (int*)value);
        }

        public static void glUniform3f(int location, float v0, float v1, float v2)
        {
            _glUniform3f(location, v0, v1, v2);
        }

        public static unsafe void glUniform3fv(int location, int count, IntPtr value)
        {
            _glUniform3fv(location, count, (float*)value);
        }

        public static void glUniform3i(int location, int v0, int v1, int v2)
        {
            _glUniform3i(location, v0, v1, v2);
        }

        /*public static void glUniform3iv(int location, int count, int* value)
        {
            _glUniform3iv();
        }

        public static void glUniform4f(int location, float v0, float v1, float v2, float v3)
        {
            _glUniform4f();
        }

        public static void glUniform4fv(int location, int count, float* value)
        {
            _glUniform4fv();
        }

        public static void glUniform4i(int location, int v0, int v1, int v2, int v3)
        {
            _glUniform4i();
        }

        public static void glUniform4iv(int location, int count, int* value)
        {
            _glUniform4iv();
        }

        public static void glUniformMatrix2fv(int location, int count, bool transpose, float* value)
        {
            _glUniformMatrix2fv();
        }

        public static void glUniformMatrix3fv(int location, int count, bool transpose, float* value)
        {
            _glUniformMatrix3fv();
        }

        public static void glUniformMatrix4fv(int location, int count, bool transpose, float* value)
        {
            _glUniformMatrix4fv();
        }*/

        public static void glUseProgram(int program)
        {
            _glUseProgram(program);
        }

        /*public static void glValidateProgram(int program)
        {
            _glValidateProgram();
        }

        public static void glVertexAttrib1f(int index, float x)
        {
            _glVertexAttrib1f();
        }

        public static void glVertexAttrib1fv(int index, float* v)
        {
            _glVertexAttrib1fv();
        }

        public static void glVertexAttrib2f(int index, float x, float y)
        {
            _glVertexAttrib2f();
        }

        public static void glVertexAttrib2fv(int index, float* v)
        {
            _glVertexAttrib2fv();
        }

        public static void glVertexAttrib3f(int index, float x, float y, float z)
        {
            _glVertexAttrib3f();
        }

        public static void glVertexAttrib3fv(int index, float* v)
        {
            _glVertexAttrib3fv();
        }

        public static void glVertexAttrib4f(int index, float x, float y, float z, float w)
        {
            _glVertexAttrib4f();
        }

        public static void glVertexAttrib4fv(int index, float* v)
        {
            _glVertexAttrib4fv();
        }*/

        public static void glVertexAttribPointer(int index, int size, int type, byte normalized, int stride, IntPtr pointer)
        {
            _glVertexAttribPointer(index, size, type, normalized, stride, pointer);
        }

        public static void glViewport(int x, int y, int width, int height)
        {
            _glViewport(x, y, width, height);
        }

        /*
        public static unsafe void glDeleteBuffers(ref int[] buffers)
        {
            var n = buffers.Length;
            fixed (int* b = buffers)
                _glDeleteBuffers(n, b);
        }

        public static unsafe void glDeleteFrameBuffers(ref int[] frameBuffers)
        {
            var n = frameBuffers.Length;
            fixed (int* b = frameBuffers)
                _glDeleteFramebuffers(n, b);
        }

        public static unsafe void glDeleteRenderBuffers(ref int[] renderBuffers)
        {
            var n = renderBuffers.Length;
            fixed (int* b = renderBuffers)
               _glDeleteRenderbuffers(n, b);
        }

        public static unsafe void glDeleteTextures(ref int[] textures)
        {
            var n = textures.Length;
            fixed (int* b = textures)
                _glDeleteTextures(n, b);
        }

        public static unsafe int[] glGenBuffers(int n)
        {
            var buffers = new int[n];
            fixed (int* b = buffers)
                _glGenBuffers(n, b);
            return buffers;
        }

        public static unsafe int[] glGenFrameBuffers(int n)
        {
            var buffers = new int[n];
            fixed (int* b = buffers)
                _glGenFramebuffers(n, b);
            return buffers;
        }

        public static unsafe int[] glGenRenderBuffers(int n)
        {
            var buffers = new int[n];
            fixed (int* b = buffers)
                _glGenRenderbuffers(n, b);
            return buffers;
        }

        public static unsafe int[] glGenTextures(int n)
        {
            var buffers = new int[n];
            fixed (int* b = buffers)
                _glGenTextures(n, b);
            return buffers;
        }

        public static unsafe void glGetActiveAttrib(int program, int index, out int size, out int type, out string name)
        {
            byte[] buffer = new byte[255];
            buffer[0] = 0;
            fixed (byte* b = buffer)
            fixed (int* s = &size, t = &type)
            {
                IntPtr n = (IntPtr)b;
                _glGetActiveAttrib(program, index, 255, null, s, t, n);
                name = Marshal.PtrToStringAuto(n);
            }
        }

        public static unsafe void glGetActiveUniform(int program, int index, out int size, out int type, out string name)
        {
            byte[] buffer = new byte[255];
            buffer[0] = 0;
            fixed (byte* b = buffer)
            fixed (int* s = &size, t = &type)
            {
                IntPtr n = (IntPtr)b;
                _glGetActiveUniform(program, index, 255, null, s, t, n);
                name = Marshal.PtrToStringAuto(n);
            }
        }

        public static unsafe int[] glGetAttachedShaders(int program)
        {
            int[] buffer = new int[20];
            int count = 0;
            fixed (int* b = buffer, c = &count)
                _glGetAttachedShaders(program, 20, c, b);
            return buffer.Subset(0, count);
        }

        public static unsafe bool glGetBooleanv(int pname)
        {
            bool b;
            fixed (bool* p = &b)
                _glGetBooleanv(pname, p);
            return b;
        }

        public static unsafe int glGetBufferParameteriv(int target, int pname)
        {
            int i;
            fixed (int* p = &i)
                _glGetBufferParameteriv(target, pname, p);
            return i;
        }

        public static unsafe float glGetFloatv(int pname)
        {
            float f;
            fixed (float* p = &f)
                _glGetFloatv(pname, p);
            return f;
        }

        public static unsafe int glGetFrameBufferAttachmentParameteriv(int target, int attachment, int pname)
        {
            int i;
            fixed (int* p = &i)
                _glGetFramebufferAttachmentParameteriv(target, attachment, pname, p);
            return i;

        }

        public static unsafe void glGetIntegerv(int pname, int* data)
        {
        }
        public static unsafe void glGetProgramInfoLog(int program, int bufSize, int* length, IntPtr infoLog)
        {
        }
        public static unsafe void glGetProgramiv(int program, int pname, int* values)
        {
        }
        public static unsafe void glGetRenderbufferParameteriv(int target, int pname, int* values)
        {
        }
        public static unsafe void glGetShaderInfoLog(int shader, int bufSize, int* length, IntPtr infoLog)
        {
        }
        public static unsafe void glGetShaderiv(int shader, int pname, int* values)
        {
        }
        public static unsafe void glGetShaderPrecisionFormat(int shadertype, int precisiontype, int* range, int* precision)
        {
        }
        public static unsafe void glGetShaderSource(int shader, int bufSize, int* length, IntPtr source)
        {
        }
        public static unsafe void glGetTexParameterfv(int target, int pname, float* values)
        {
        }
        public static unsafe void glGetTexParameteriv(int target, int pname, int* values)
        {
        }
        public static unsafe void glGetUniformfv(int program, int location, float* values)
        {
        }
        public static unsafe void glGetUniformiv(int program, int location, int* values)
        {
        }
        public static unsafe void glGetVertexAttribfv(int index, int pname, float* values)
        {
        }
        public static unsafe void glGetVertexAttribiv(int index, int pname, int* values)
        {
        }
        public static unsafe void glShaderBinary(int count, int* shaders, int binaryformat, IntPtr binary, int length)
        {
        }
        public static unsafe void glShaderSource(int shader, int count, IntPtr strings, int* length)
        {
        }
        public static unsafe void glTexParameterfv(int target, int pname, float* values)
        {
        }
        public static unsafe void glTexParameteriv(int target, int pname, int* values)
        {
        }
        public static unsafe void glUniform1fv(int location, int count, float* value)
        {
        }
        public static unsafe void glUniform1iv(int location, int count, int* value)
        {
        }
        public static unsafe void glUniform2fv(int location, int count, float* value)
        {
        }
        public static unsafe void glUniform2iv(int location, int count, int* value)
        {
        }
        public static unsafe void glUniform3fv(int location, int count, float* value)
        {
        }
        public static unsafe void glUniform3iv(int location, int count, int* value)
        {
        }
        public static unsafe void glUniform4fv(int location, int count, float* value)
        {
        }
        public static unsafe void glUniform4iv(int location, int count, int* value)
        {
        }
        public static unsafe void glUniformMatrix2fv(int location, int count, bool transpose, float* value)
        {
        }
        public static unsafe void glUniformMatrix3fv(int location, int count, bool transpose, float* value)
        {
        }
        public static unsafe void glUniformMatrix4fv(int location, int count, bool transpose, float* value)
        {
        }
        public static unsafe void glVertexAttrib1fv(int index, float* v)
        {
        }
        public static unsafe void glVertexAttrib2fv(int index, float* v)
        {
        }
        public static unsafe void glVertexAttrib3fv(int index, float* v)
        {
        }
        public static unsafe void glVertexAttrib4fv(int index, float* v)
        {
        }

        public static string glGetString(int name)
        {
            var s = _glGetString(name);
            return Marshal.PtrToStringAuto(s);
        }

        public static unsafe void glShaderSource(int shader, string source)
        {
            if (String.IsNullOrWhiteSpace(source))
                source = " ";
            var buffer = Encoding.ASCII.GetBytes(source + "\0");
            fixed (byte* b = buffer)
            {
                void* p = b;
                void* sources = &p;
                _glShaderSource(shader, 1, (IntPtr)sources, null);
            }
        }*/
        #endregion

        private static bool GetProcAddress<T>(out T t)
        {
            Object proc = null;
            var name = typeof(T).Name;
            IntPtr pointer = SDL_GL_GetProcAddress(name);
            if (pointer != IntPtr.Zero)
                proc = Marshal.GetDelegateForFunctionPointer(pointer, typeof(T)) as Object;
            t = (T)proc;
            return proc != null;
        }

        private static bool loaded = false;

        internal static bool GLES20Load()
        {
            if (loaded)
                return loaded;
            loaded =
                GetProcAddress(out _glActiveTexture) &&
                GetProcAddress(out _glAttachShader) &&
                GetProcAddress(out _glBindAttribLocation) &&
                GetProcAddress(out _glBindBuffer) &&
                GetProcAddress(out _glBindFramebuffer) &&
                GetProcAddress(out _glBindRenderbuffer) &&
                GetProcAddress(out _glBindTexture) &&
                GetProcAddress(out _glBlendColor) &&
                GetProcAddress(out _glBlendEquation) &&
                GetProcAddress(out _glBlendEquationSeparate) &&
                GetProcAddress(out _glBlendFunc) &&
                GetProcAddress(out _glBlendFuncSeparate) &&
                GetProcAddress(out _glBufferData) &&
                GetProcAddress(out _glBufferSubData) &&
                GetProcAddress(out _glCheckFramebufferStatus) &&
                GetProcAddress(out _glClear) &&
                GetProcAddress(out _glClearColor) &&
                GetProcAddress(out _glClearDepthf) &&
                GetProcAddress(out _glClearStencil) &&
                GetProcAddress(out _glColorMask) &&
                GetProcAddress(out _glCompileShader) &&
                GetProcAddress(out _glCompressedTexImage2D) &&
                GetProcAddress(out _glCompressedTexSubImage2D) &&
                GetProcAddress(out _glCopyTexImage2D) &&
                GetProcAddress(out _glCopyTexSubImage2D) &&
                GetProcAddress(out _glCreateProgram) &&
                GetProcAddress(out _glCreateShader) &&
                GetProcAddress(out _glCullFace) &&
                GetProcAddress(out _glDeleteBuffers) &&
                GetProcAddress(out _glDeleteFramebuffers) &&
                GetProcAddress(out _glDeleteProgram) &&
                GetProcAddress(out _glDeleteRenderbuffers) &&
                GetProcAddress(out _glDeleteShader) &&
                GetProcAddress(out _glDeleteTextures) &&
                GetProcAddress(out _glDepthFunc) &&
                GetProcAddress(out _glDepthMask) &&
                GetProcAddress(out _glDepthRangef) &&
                GetProcAddress(out _glDetachShader) &&
                GetProcAddress(out _glDisable) &&
                GetProcAddress(out _glDisableVertexAttribArray) &&
                GetProcAddress(out _glDrawArrays) &&
                GetProcAddress(out _glDrawElements) &&
                GetProcAddress(out _glEnable) &&
                GetProcAddress(out _glEnableVertexAttribArray) &&
                GetProcAddress(out _glFinish) &&
                GetProcAddress(out _glFlush) &&
                GetProcAddress(out _glFramebufferRenderbuffer) &&
                GetProcAddress(out _glFramebufferTexture2D) &&
                GetProcAddress(out _glFrontFace) &&
                GetProcAddress(out _glGenBuffers) &&
                GetProcAddress(out _glGenerateMipmap) &&
                GetProcAddress(out _glGenFramebuffers) &&
                GetProcAddress(out _glGenRenderbuffers) &&
                GetProcAddress(out _glGenTextures) &&
                GetProcAddress(out _glGetActiveAttrib) &&
                GetProcAddress(out _glGetActiveUniform) &&
                GetProcAddress(out _glGetAttachedShaders) &&
                GetProcAddress(out _glGetAttribLocation) &&
                GetProcAddress(out _glGetBooleanv) &&
                GetProcAddress(out _glGetBufferParameteriv) &&
                GetProcAddress(out _glGetError) &&
                GetProcAddress(out _glGetFloatv) &&
                GetProcAddress(out _glGetFramebufferAttachmentParameteriv) &&
                GetProcAddress(out _glGetIntegerv) &&
                GetProcAddress(out _glGetPointerv) &&
                GetProcAddress(out _glGetProgramInfoLog) &&
                GetProcAddress(out _glGetProgramiv) &&
                GetProcAddress(out _glGetRenderbufferParameteriv) &&
                GetProcAddress(out _glGetShaderInfoLog) &&
                GetProcAddress(out _glGetShaderiv) &&
                GetProcAddress(out _glGetShaderPrecisionFormat) &&
                GetProcAddress(out _glGetShaderSource) &&
                GetProcAddress(out _glGetString) &&
                GetProcAddress(out _glGetTexParameterfv) &&
                GetProcAddress(out _glGetTexParameteriv) &&
                GetProcAddress(out _glGetUniformfv) &&
                GetProcAddress(out _glGetUniformiv) &&
                GetProcAddress(out _glGetUniformLocation) &&
                GetProcAddress(out _glGetVertexAttribfv) &&
                GetProcAddress(out _glGetVertexAttribiv) &&
                GetProcAddress(out _glGetVertexAttribPointerv) &&
                GetProcAddress(out _glHint) &&
                GetProcAddress(out _glIsBuffer) &&
                GetProcAddress(out _glIsEnabled) &&
                GetProcAddress(out _glIsFramebuffer) &&
                GetProcAddress(out _glIsProgram) &&
                GetProcAddress(out _glIsRenderbuffer) &&
                GetProcAddress(out _glIsShader) &&
                GetProcAddress(out _glIsTexture) &&
                GetProcAddress(out _glLineWidth) &&
                GetProcAddress(out _glLinkProgram) &&
                GetProcAddress(out _glPixelStorei) &&
                GetProcAddress(out _glPolygonOffset) &&
                GetProcAddress(out _glReadPixels) &&
                GetProcAddress(out _glReleaseShaderCompiler) &&
                GetProcAddress(out _glRenderbufferStorage) &&
                GetProcAddress(out _glSampleCoverage) &&
                GetProcAddress(out _glScissor) &&
                GetProcAddress(out _glShaderBinary) &&
                GetProcAddress(out _glShaderSource) &&
                GetProcAddress(out _glStencilFunc) &&
                GetProcAddress(out _glStencilFuncSeparate) &&
                GetProcAddress(out _glStencilMask) &&
                GetProcAddress(out _glStencilMaskSeparate) &&
                GetProcAddress(out _glStencilOp) &&
                GetProcAddress(out _glStencilOpSeparate) &&
                GetProcAddress(out _glTexImage2D) &&
                GetProcAddress(out _glTexParameterf) &&
                GetProcAddress(out _glTexParameterfv) &&
                GetProcAddress(out _glTexParameteri) &&
                GetProcAddress(out _glTexParameteriv) &&
                GetProcAddress(out _glTexSubImage2D) &&
                GetProcAddress(out _glUniform1f) &&
                GetProcAddress(out _glUniform1fv) &&
                GetProcAddress(out _glUniform1i) &&
                GetProcAddress(out _glUniform1iv) &&
                GetProcAddress(out _glUniform2f) &&
                GetProcAddress(out _glUniform2fv) &&
                GetProcAddress(out _glUniform2i) &&
                GetProcAddress(out _glUniform2iv) &&
                GetProcAddress(out _glUniform3f) &&
                GetProcAddress(out _glUniform3fv) &&
                GetProcAddress(out _glUniform3i) &&
                GetProcAddress(out _glUniform3iv) &&
                GetProcAddress(out _glUniform4f) &&
                GetProcAddress(out _glUniform4fv) &&
                GetProcAddress(out _glUniform4i) &&
                GetProcAddress(out _glUniform4iv) &&
                GetProcAddress(out _glUniformMatrix2fv) &&
                GetProcAddress(out _glUniformMatrix3fv) &&
                GetProcAddress(out _glUniformMatrix4fv) &&
                GetProcAddress(out _glUseProgram) &&
                GetProcAddress(out _glValidateProgram) &&
                GetProcAddress(out _glVertexAttrib1f) &&
                GetProcAddress(out _glVertexAttrib1fv) &&
                GetProcAddress(out _glVertexAttrib2f) &&
                GetProcAddress(out _glVertexAttrib2fv) &&
                GetProcAddress(out _glVertexAttrib3f) &&
                GetProcAddress(out _glVertexAttrib3fv) &&
                GetProcAddress(out _glVertexAttrib4f) &&
                GetProcAddress(out _glVertexAttrib4fv) &&
                GetProcAddress(out _glVertexAttribPointer) &&
                GetProcAddress(out _glViewport);
            return loaded;
        }
    }
}
