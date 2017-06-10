using System;
using System.Text;
using System.Runtime.InteropServices;

using static Bare.Interop.SDL2;

namespace Bare.Interop
{
    /// <summary>
    /// Entry point for all OpenGL ES 2.0-related types and methods.
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

        /// <summary>
        /// Delegates contains the function definitions for OpenGL ES 2.0.
        /// </summary>
        public static class Delegates
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
            public delegate void glColorMask(bool red, bool green, bool blue, bool alpha);
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
            public delegate void glDepthMask(bool flag);
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
            public unsafe delegate void glGetBooleanv(int pname, bool* data);
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
            public delegate void glStencilFunc(int func, int @ref, int mask);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glStencilFuncSeparate(int face, int func, int @ref, int mask);
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
            public delegate void glVertexAttribPointer(int index, int size, int type, bool normalized, int stride, IntPtr pointer);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void glViewport(int x, int y, int width, int height);
        }

        public static Delegates.glActiveTexture glActiveTexture;
        public static Delegates.glAttachShader glAttachShader;
        public static Delegates.glBindAttribLocation glBindAttribLocation;
        public static Delegates.glBindBuffer glBindBuffer;
        public static Delegates.glBindFramebuffer glBindFramebuffer;
        public static Delegates.glBindRenderbuffer glBindRenderbuffer;
        public static Delegates.glBindTexture glBindTexture;
        public static Delegates.glBlendColor glBlendColor;
        public static Delegates.glBlendEquation glBlendEquation;
        public static Delegates.glBlendEquationSeparate glBlendEquationSeparate;
        public static Delegates.glBlendFunc glBlendFunc;
        public static Delegates.glBlendFuncSeparate glBlendFuncSeparate;
        public static Delegates.glBufferData glBufferData;
        public static Delegates.glBufferSubData glBufferSubData;
        public static Delegates.glCheckFramebufferStatus glCheckFramebufferStatus;
        public static Delegates.glClear glClear;
        public static Delegates.glClearColor glClearColor;
        public static Delegates.glClearDepthf glClearDepthf;
        public static Delegates.glClearStencil glClearStencil;
        public static Delegates.glColorMask glColorMask;
        public static Delegates.glCompileShader glCompileShader;
        public static Delegates.glCompressedTexImage2D glCompressedTexImage2D;
        public static Delegates.glCompressedTexSubImage2D glCompressedTexSubImage2D;
        public static Delegates.glCopyTexImage2D glCopyTexImage2D;
        public static Delegates.glCopyTexSubImage2D glCopyTexSubImage2D;
        public static Delegates.glCreateProgram glCreateProgram;
        public static Delegates.glCreateShader glCreateShader;
        public static Delegates.glCullFace glCullFace;
        public static Delegates.glDeleteBuffers _glDeleteBuffers;
        public static Delegates.glDeleteFramebuffers glDeleteFramebuffers;
        public static Delegates.glDeleteProgram glDeleteProgram;
        public static Delegates.glDeleteRenderbuffers glDeleteRenderbuffers;
        public static Delegates.glDeleteShader glDeleteShader;
        public static Delegates.glDeleteTextures glDeleteTextures;
        public static Delegates.glDepthFunc glDepthFunc;
        public static Delegates.glDepthMask glDepthMask;
        public static Delegates.glDepthRangef glDepthRangef;
        public static Delegates.glDetachShader glDetachShader;
        public static Delegates.glDisable glDisable;
        public static Delegates.glDisableVertexAttribArray glDisableVertexAttribArray;
        public static Delegates.glDrawArrays glDrawArrays;
        public static Delegates.glDrawElements glDrawElements;
        public static Delegates.glEnable glEnable;
        public static Delegates.glEnableVertexAttribArray glEnableVertexAttribArray;
        public static Delegates.glFinish glFinish;
        public static Delegates.glFlush glFlush;
        public static Delegates.glFramebufferRenderbuffer glFramebufferRenderbuffer;
        public static Delegates.glFramebufferTexture2D glFramebufferTexture2D;
        public static Delegates.glFrontFace glFrontFace;
        public static Delegates.glGenBuffers _glGenBuffers;
        public static Delegates.glGenerateMipmap glGenerateMipmap;
        public static Delegates.glGenFramebuffers glGenFramebuffers;
        public static Delegates.glGenRenderbuffers glGenRenderbuffers;
        public static Delegates.glGenTextures glGenTextures;
        public static Delegates.glGetActiveAttrib glGetActiveAttrib;
        public static Delegates.glGetActiveUniform glGetActiveUniform;
        public static Delegates.glGetAttachedShaders glGetAttachedShaders;
        public static Delegates.glGetAttribLocation glGetAttribLocation;
        public static Delegates.glGetBooleanv glGetBooleanv;
        public static Delegates.glGetBufferParameteriv glGetBufferParameteriv;
        public static Delegates.glGetError glGetError;
        public static Delegates.glGetFloatv glGetFloatv;
        public static Delegates.glGetFramebufferAttachmentParameteriv glGetFramebufferAttachmentParameteriv;
        public static Delegates.glGetIntegerv glGetIntegerv;
        public static Delegates.glGetPointerv glGetPointerv;
        public static Delegates.glGetProgramInfoLog glGetProgramInfoLog;
        public static Delegates.glGetProgramiv glGetProgramiv;
        public static Delegates.glGetRenderbufferParameteriv glGetRenderbufferParameteriv;
        public static Delegates.glGetShaderInfoLog glGetShaderInfoLog;
        public static Delegates.glGetShaderiv glGetShaderiv;
        public static Delegates.glGetShaderPrecisionFormat glGetShaderPrecisionFormat;
        public static Delegates.glGetShaderSource glGetShaderSource;
        public static Delegates.glGetString _glGetString;
        public static Delegates.glGetTexParameterfv glGetTexParameterfv;
        public static Delegates.glGetTexParameteriv glGetTexParameteriv;
        public static Delegates.glGetUniformfv glGetUniformfv;
        public static Delegates.glGetUniformiv glGetUniformiv;
        public static Delegates.glGetUniformLocation glGetUniformLocation;
        public static Delegates.glGetVertexAttribfv glGetVertexAttribfv;
        public static Delegates.glGetVertexAttribiv glGetVertexAttribiv;
        public static Delegates.glGetVertexAttribPointerv glGetVertexAttribPointerv;
        public static Delegates.glHint glHint;
        public static Delegates.glIsBuffer glIsBuffer;
        public static Delegates.glIsEnabled glIsEnabled;
        public static Delegates.glIsFramebuffer glIsFramebuffer;
        public static Delegates.glIsProgram glIsProgram;
        public static Delegates.glIsRenderbuffer glIsRenderbuffer;
        public static Delegates.glIsShader glIsShader;
        public static Delegates.glIsTexture glIsTexture;
        public static Delegates.glLineWidth glLineWidth;
        public static Delegates.glLinkProgram glLinkProgram;
        public static Delegates.glPixelStorei glPixelStorei;
        public static Delegates.glPolygonOffset glPolygonOffset;
        public static Delegates.glReadPixels glReadPixels;
        public static Delegates.glReleaseShaderCompiler glReleaseShaderCompiler;
        public static Delegates.glRenderbufferStorage glRenderbufferStorage;
        public static Delegates.glSampleCoverage glSampleCoverage;
        public static Delegates.glScissor glScissor;
        public static Delegates.glShaderBinary glShaderBinary;
        public static Delegates.glShaderSource _glShaderSource;
        public static Delegates.glStencilFunc glStencilFunc;
        public static Delegates.glStencilFuncSeparate glStencilFuncSeparate;
        public static Delegates.glStencilMask glStencilMask;
        public static Delegates.glStencilMaskSeparate glStencilMaskSeparate;
        public static Delegates.glStencilOp glStencilOp;
        public static Delegates.glStencilOpSeparate glStencilOpSeparate;
        public static Delegates.glTexImage2D glTexImage2D;
        public static Delegates.glTexParameterf glTexParameterf;
        public static Delegates.glTexParameterfv glTexParameterfv;
        public static Delegates.glTexParameteri glTexParameteri;
        public static Delegates.glTexParameteriv glTexParameteriv;
        public static Delegates.glTexSubImage2D glTexSubImage2D;
        public static Delegates.glUniform1f glUniform1f;
        public static Delegates.glUniform1fv glUniform1fv;
        public static Delegates.glUniform1i glUniform1i;
        public static Delegates.glUniform1iv glUniform1iv;
        public static Delegates.glUniform2f glUniform2f;
        public static Delegates.glUniform2fv glUniform2fv;
        public static Delegates.glUniform2i glUniform2i;
        public static Delegates.glUniform2iv glUniform2iv;
        public static Delegates.glUniform3f glUniform3f;
        public static Delegates.glUniform3fv glUniform3fv;
        public static Delegates.glUniform3i glUniform3i;
        public static Delegates.glUniform3iv glUniform3iv;
        public static Delegates.glUniform4f glUniform4f;
        public static Delegates.glUniform4fv glUniform4fv;
        public static Delegates.glUniform4i glUniform4i;
        public static Delegates.glUniform4iv glUniform4iv;
        public static Delegates.glUniformMatrix2fv glUniformMatrix2fv;
        public static Delegates.glUniformMatrix3fv glUniformMatrix3fv;
        public static Delegates.glUniformMatrix4fv glUniformMatrix4fv;
        public static Delegates.glUseProgram glUseProgram;
        public static Delegates.glValidateProgram glValidateProgram;
        public static Delegates.glVertexAttrib1f glVertexAttrib1f;
        public static Delegates.glVertexAttrib1fv glVertexAttrib1fv;
        public static Delegates.glVertexAttrib2f glVertexAttrib2f;
        public static Delegates.glVertexAttrib2fv glVertexAttrib2fv;
        public static Delegates.glVertexAttrib3f glVertexAttrib3f;
        public static Delegates.glVertexAttrib3fv glVertexAttrib3fv;
        public static Delegates.glVertexAttrib4f glVertexAttrib4f;
        public static Delegates.glVertexAttrib4fv glVertexAttrib4fv;
        public static Delegates.glVertexAttribPointer glVertexAttribPointer;
        public static Delegates.glViewport glViewport;

        #region Safer functions
        public static unsafe void glDeleteBuffers(ref int[] buffers)
        {
            var n = buffers.Length;
            fixed (int* b = buffers)
				_glDeleteBuffers(n, b);
		}
		public static unsafe int[] glGenBuffers(int n)
        {
            var buffers = new int[n];
			fixed (int* b = buffers)
                _glGenBuffers(n, b);
            return buffers;
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
                void* pp = &p;
				_glShaderSource(shader, 1, (IntPtr)pp, null);
			}
	    }
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
				GetProcAddress(out glActiveTexture) &&
				GetProcAddress(out glAttachShader) &&
				GetProcAddress(out glBindAttribLocation) &&
				GetProcAddress(out glBindBuffer) &&
				GetProcAddress(out glBindFramebuffer) &&
				GetProcAddress(out glBindRenderbuffer) &&
				GetProcAddress(out glBindTexture) &&
				GetProcAddress(out glBlendColor) &&
				GetProcAddress(out glBlendEquation) &&
				GetProcAddress(out glBlendEquationSeparate) &&
				GetProcAddress(out glBlendFunc) &&
				GetProcAddress(out glBlendFuncSeparate) &&
				GetProcAddress(out glBufferData) &&
				GetProcAddress(out glBufferSubData) &&
				GetProcAddress(out glCheckFramebufferStatus) &&
				GetProcAddress(out glClear) &&
				GetProcAddress(out glClearColor) &&
				GetProcAddress(out glClearDepthf) &&
				GetProcAddress(out glClearStencil) &&
				GetProcAddress(out glColorMask) &&
				GetProcAddress(out glCompileShader) &&
				GetProcAddress(out glCompressedTexImage2D) &&
				GetProcAddress(out glCompressedTexSubImage2D) &&
				GetProcAddress(out glCopyTexImage2D) &&
				GetProcAddress(out glCopyTexSubImage2D) &&
				GetProcAddress(out glCreateProgram) &&
				GetProcAddress(out glCreateShader) &&
				GetProcAddress(out glCullFace) &&
				GetProcAddress(out _glDeleteBuffers) &&
				GetProcAddress(out glDeleteFramebuffers) &&
				GetProcAddress(out glDeleteProgram) &&
				GetProcAddress(out glDeleteRenderbuffers) &&
				GetProcAddress(out glDeleteShader) &&
				GetProcAddress(out glDeleteTextures) &&
				GetProcAddress(out glDepthFunc) &&
				GetProcAddress(out glDepthMask) &&
				GetProcAddress(out glDepthRangef) &&
				GetProcAddress(out glDetachShader) &&
				GetProcAddress(out glDisable) &&
				GetProcAddress(out glDisableVertexAttribArray) &&
				GetProcAddress(out glDrawArrays) &&
				GetProcAddress(out glDrawElements) &&
				GetProcAddress(out glEnable) &&
				GetProcAddress(out glEnableVertexAttribArray) &&
				GetProcAddress(out glFinish) &&
				GetProcAddress(out glFlush) &&
				GetProcAddress(out glFramebufferRenderbuffer) &&
				GetProcAddress(out glFramebufferTexture2D) &&
				GetProcAddress(out glFrontFace) &&
				GetProcAddress(out _glGenBuffers) &&
				GetProcAddress(out glGenerateMipmap) &&
				GetProcAddress(out glGenFramebuffers) &&
				GetProcAddress(out glGenRenderbuffers) &&
				GetProcAddress(out glGenTextures) &&
				GetProcAddress(out glGetActiveAttrib) &&
				GetProcAddress(out glGetActiveUniform) &&
				GetProcAddress(out glGetAttachedShaders) &&
				GetProcAddress(out glGetAttribLocation) &&
				GetProcAddress(out glGetBooleanv) &&
				GetProcAddress(out glGetBufferParameteriv) &&
				GetProcAddress(out glGetError) &&
				GetProcAddress(out glGetFloatv) &&
				GetProcAddress(out glGetFramebufferAttachmentParameteriv) &&
				GetProcAddress(out glGetIntegerv) &&
				GetProcAddress(out glGetPointerv) &&
				GetProcAddress(out glGetProgramInfoLog) &&
				GetProcAddress(out glGetProgramiv) &&
				GetProcAddress(out glGetRenderbufferParameteriv) &&
				GetProcAddress(out glGetShaderInfoLog) &&
				GetProcAddress(out glGetShaderiv) &&
				GetProcAddress(out glGetShaderPrecisionFormat) &&
				GetProcAddress(out glGetShaderSource) &&
				GetProcAddress(out _glGetString) &&
				GetProcAddress(out glGetTexParameterfv) &&
				GetProcAddress(out glGetTexParameteriv) &&
				GetProcAddress(out glGetUniformfv) &&
				GetProcAddress(out glGetUniformiv) &&
				GetProcAddress(out glGetUniformLocation) &&
				GetProcAddress(out glGetVertexAttribfv) &&
				GetProcAddress(out glGetVertexAttribiv) &&
				GetProcAddress(out glGetVertexAttribPointerv) &&
				GetProcAddress(out glHint) &&
				GetProcAddress(out glIsBuffer) &&
				GetProcAddress(out glIsEnabled) &&
				GetProcAddress(out glIsFramebuffer) &&
				GetProcAddress(out glIsProgram) &&
				GetProcAddress(out glIsRenderbuffer) &&
				GetProcAddress(out glIsShader) &&
				GetProcAddress(out glIsTexture) &&
				GetProcAddress(out glLineWidth) &&
				GetProcAddress(out glLinkProgram) &&
				GetProcAddress(out glPixelStorei) &&
				GetProcAddress(out glPolygonOffset) &&
				GetProcAddress(out glReadPixels) &&
				GetProcAddress(out glReleaseShaderCompiler) &&
				GetProcAddress(out glRenderbufferStorage) &&
				GetProcAddress(out glSampleCoverage) &&
				GetProcAddress(out glScissor) &&
				GetProcAddress(out glShaderBinary) &&
				GetProcAddress(out _glShaderSource) &&
				GetProcAddress(out glStencilFunc) &&
				GetProcAddress(out glStencilFuncSeparate) &&
				GetProcAddress(out glStencilMask) &&
				GetProcAddress(out glStencilMaskSeparate) &&
				GetProcAddress(out glStencilOp) &&
				GetProcAddress(out glStencilOpSeparate) &&
				GetProcAddress(out glTexImage2D) &&
				GetProcAddress(out glTexParameterf) &&
				GetProcAddress(out glTexParameterfv) &&
				GetProcAddress(out glTexParameteri) &&
				GetProcAddress(out glTexParameteriv) &&
				GetProcAddress(out glTexSubImage2D) &&
				GetProcAddress(out glUniform1f) &&
				GetProcAddress(out glUniform1fv) &&
				GetProcAddress(out glUniform1i) &&
				GetProcAddress(out glUniform1iv) &&
				GetProcAddress(out glUniform2f) &&
				GetProcAddress(out glUniform2fv) &&
				GetProcAddress(out glUniform2i) &&
				GetProcAddress(out glUniform2iv) &&
				GetProcAddress(out glUniform3f) &&
				GetProcAddress(out glUniform3fv) &&
				GetProcAddress(out glUniform3i) &&
				GetProcAddress(out glUniform3iv) &&
				GetProcAddress(out glUniform4f) &&
				GetProcAddress(out glUniform4fv) &&
				GetProcAddress(out glUniform4i) &&
				GetProcAddress(out glUniform4iv) &&
				GetProcAddress(out glUniformMatrix2fv) &&
				GetProcAddress(out glUniformMatrix3fv) &&
				GetProcAddress(out glUniformMatrix4fv) &&
				GetProcAddress(out glUseProgram) &&
				GetProcAddress(out glValidateProgram) &&
				GetProcAddress(out glVertexAttrib1f) &&
				GetProcAddress(out glVertexAttrib1fv) &&
				GetProcAddress(out glVertexAttrib2f) &&
				GetProcAddress(out glVertexAttrib2fv) &&
				GetProcAddress(out glVertexAttrib3f) &&
				GetProcAddress(out glVertexAttrib3fv) &&
				GetProcAddress(out glVertexAttrib4f) &&
				GetProcAddress(out glVertexAttrib4fv) &&
				GetProcAddress(out glVertexAttribPointer) &&
				GetProcAddress(out glViewport);
            return loaded;
        }
    }
}
