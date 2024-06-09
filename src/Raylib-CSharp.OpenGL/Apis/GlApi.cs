using Raylib_CSharp.OpenGL.Contexts;

namespace Raylib_CSharp.OpenGL.Apis;

internal static class GlApi {

    internal static IBindingsContext Context { get; private set; }

	/// <summary>
	/// The Gl class provides bindings for OpenGL functions.
	/// </summary>
    internal static void Init(IBindingsContext context) {
		Context = context;
	}

	internal static unsafe void AccumxOES(uint op, int value) {
		((delegate* unmanaged<uint, int, void>) Context.GetProcAddress("glAccumxOES"))(op, value);
	}

	internal static unsafe void ActiveShaderProgram(uint pipeline, uint program) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glActiveShaderProgram"))(pipeline, program);
	}

	internal static unsafe void ActiveTexture(uint texture) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glActiveTexture"))(texture);
	}

	internal static unsafe void ActiveTextureARB(uint texture) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glActiveTextureARB"))(texture);
	}

	internal static unsafe void AlphaFuncxOES(uint func, int reference) {
		((delegate* unmanaged<uint, int, void>) Context.GetProcAddress("glAlphaFuncxOES"))(func, reference);
	}

	internal static unsafe void AttachObjectARB(uint containerObj, uint obj) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glAttachObjectARB"))(containerObj, obj);
	}

	internal static unsafe void AttachShader(uint program, uint shader) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glAttachShader"))(program, shader);
	}

	internal static unsafe void BeginConditionalRender(uint id, uint mode) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBeginConditionalRender"))(id, mode);
	}

	internal static unsafe void BeginQuery(uint target, uint id) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBeginQuery"))(target, id);
	}

	internal static unsafe void BeginQueryARB(uint target, uint id) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBeginQueryARB"))(target, id);
	}

	internal static unsafe void BeginQueryIndexed(uint target, uint index, uint id) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glBeginQueryIndexed"))(target, index, id);
	}

	internal static unsafe void BeginTransformFeedback(uint primitiveMode) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glBeginTransformFeedback"))(primitiveMode);
	}

	internal static unsafe void BindAttribLocation(uint program, uint index, char* name) {
		((delegate* unmanaged<uint, uint, char*, void>) Context.GetProcAddress("glBindAttribLocation"))(program, index, name);
	}

	internal static unsafe void BindAttribLocationARB(uint programObj, uint index, char* name) {
		((delegate* unmanaged<uint, uint, char*, void>) Context.GetProcAddress("glBindAttribLocationARB"))(programObj, index, name);
	}

	internal static unsafe void BindBuffer(uint target, uint buffer) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBindBuffer"))(target, buffer);
	}

	internal static unsafe void BindBufferARB(uint target, uint buffer) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBindBufferARB"))(target, buffer);
	}

	internal static unsafe void BindBufferBase(uint target, uint index, uint buffer) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glBindBufferBase"))(target, index, buffer);
	}

	internal static unsafe void BindBufferRange(uint target, uint index, uint buffer, int* offset, nint size) {
		((delegate* unmanaged<uint, uint, uint, int*, nint, void>) Context.GetProcAddress("glBindBufferRange"))(target, index, buffer, offset, size);
	}

	internal static unsafe void BindBuffersBase(uint target, uint first, int count, uint* buffers) {
		((delegate* unmanaged<uint, uint, int, uint*, void>) Context.GetProcAddress("glBindBuffersBase"))(target, first, count, buffers);
	}

	internal static unsafe void BindBuffersRange(uint target, uint first, int count, uint* buffers, int** offsets, nint* sizes) {
		((delegate* unmanaged<uint, uint, int, uint*, int**, nint*, void>) Context.GetProcAddress("glBindBuffersRange"))(target, first, count, buffers, offsets, sizes);
	}

	internal static unsafe void BindFragDataLocation(uint program, uint color, char* name) {
		((delegate* unmanaged<uint, uint, char*, void>) Context.GetProcAddress("glBindFragDataLocation"))(program, color, name);
	}

	internal static unsafe void BindFragDataLocationIndexed(uint program, uint colorNumber, uint index, char* name) {
		((delegate* unmanaged<uint, uint, uint, char*, void>) Context.GetProcAddress("glBindFragDataLocationIndexed"))(program, colorNumber, index, name);
	}

	internal static unsafe void BindFramebuffer(uint target, uint framebuffer) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBindFramebuffer"))(target, framebuffer);
	}

	internal static unsafe void BindFramebufferEXT(uint target, uint framebuffer) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBindFramebufferEXT"))(target, framebuffer);
	}

	internal static unsafe void BindImageTexture(uint unit, uint texture, int level, byte layered, int layer, uint access, uint format) {
		((delegate* unmanaged<uint, uint, int, byte, int, uint, uint, void>) Context.GetProcAddress("glBindImageTexture"))(unit, texture, level, layered, layer, access, format);
	}

	internal static unsafe void BindImageTextures(uint first, int count, uint* textures) {
		((delegate* unmanaged<uint, int, uint*, void>) Context.GetProcAddress("glBindImageTextures"))(first, count, textures);
	}

	internal static unsafe void BindProgramARB(uint target, uint program) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBindProgramARB"))(target, program);
	}

	internal static unsafe void BindProgramPipeline(uint pipeline) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glBindProgramPipeline"))(pipeline);
	}

	internal static unsafe void BindRenderbuffer(uint target, uint renderbuffer) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBindRenderbuffer"))(target, renderbuffer);
	}

	internal static unsafe void BindRenderbufferEXT(uint target, uint renderbuffer) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBindRenderbufferEXT"))(target, renderbuffer);
	}

	internal static unsafe void BindSampler(uint unit, uint sampler) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBindSampler"))(unit, sampler);
	}

	internal static unsafe void BindSamplers(uint first, int count, uint* samplers) {
		((delegate* unmanaged<uint, int, uint*, void>) Context.GetProcAddress("glBindSamplers"))(first, count, samplers);
	}

	internal static unsafe void BindTexture(uint target, uint texture) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBindTexture"))(target, texture);
	}

	internal static unsafe void BindTextureUnit(uint unit, uint texture) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBindTextureUnit"))(unit, texture);
	}

	internal static unsafe void BindTextures(uint first, int count, uint* textures) {
		((delegate* unmanaged<uint, int, uint*, void>) Context.GetProcAddress("glBindTextures"))(first, count, textures);
	}

	internal static unsafe void BindTransformFeedback(uint target, uint id) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBindTransformFeedback"))(target, id);
	}

	internal static unsafe void BindVertexArray(uint array) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glBindVertexArray"))(array);
	}

	internal static unsafe void BindVertexBuffer(uint bindingindex, uint buffer, int* offset, int stride) {
		((delegate* unmanaged<uint, uint, int*, int, void>) Context.GetProcAddress("glBindVertexBuffer"))(bindingindex, buffer, offset, stride);
	}

	internal static unsafe void BindVertexBuffers(uint first, int count, uint* buffers, int** offsets, int* strides) {
		((delegate* unmanaged<uint, int, uint*, int**, int*, void>) Context.GetProcAddress("glBindVertexBuffers"))(first, count, buffers, offsets, strides);
	}

	internal static unsafe void BitmapxOES(int width, int height, int xorig, int yorig, int xmove, int ymove, byte* bitmap) {
		((delegate* unmanaged<int, int, int, int, int, int, byte*, void>) Context.GetProcAddress("glBitmapxOES"))(width, height, xorig, yorig, xmove, ymove, bitmap);
	}

	internal static unsafe void BlendColor(float red, float green, float blue, float alpha) {
		((delegate* unmanaged<float, float, float, float, void>) Context.GetProcAddress("glBlendColor"))(red, green, blue, alpha);
	}

	internal static unsafe void BlendColorxOES(int red, int green, int blue, int alpha) {
		((delegate* unmanaged<int, int, int, int, void>) Context.GetProcAddress("glBlendColorxOES"))(red, green, blue, alpha);
	}

	internal static unsafe void BlendEquation(uint mode) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glBlendEquation"))(mode);
	}

	internal static unsafe void BlendEquationSeparate(uint modeRGB, uint modeAlpha) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBlendEquationSeparate"))(modeRGB, modeAlpha);
	}

	internal static unsafe void BlendEquationSeparatei(uint buf, uint modeRGB, uint modeAlpha) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glBlendEquationSeparatei"))(buf, modeRGB, modeAlpha);
	}

	internal static unsafe void BlendEquationSeparateiARB(uint buf, uint modeRGB, uint modeAlpha) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glBlendEquationSeparateiARB"))(buf, modeRGB, modeAlpha);
	}

	internal static unsafe void BlendEquationi(uint buf, uint mode) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBlendEquationi"))(buf, mode);
	}

	internal static unsafe void BlendEquationiARB(uint buf, uint mode) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBlendEquationiARB"))(buf, mode);
	}

	internal static unsafe void BlendFunc(uint sfactor, uint dfactor) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBlendFunc"))(sfactor, dfactor);
	}

	internal static unsafe void BlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha) {
		((delegate* unmanaged<uint, uint, uint, uint, void>) Context.GetProcAddress("glBlendFuncSeparate"))(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
	}

	internal static unsafe void BlendFuncSeparatei(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha) {
		((delegate* unmanaged<uint, uint, uint, uint, uint, void>) Context.GetProcAddress("glBlendFuncSeparatei"))(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
	}

	internal static unsafe void BlendFuncSeparateiARB(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha) {
		((delegate* unmanaged<uint, uint, uint, uint, uint, void>) Context.GetProcAddress("glBlendFuncSeparateiARB"))(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
	}

	internal static unsafe void BlendFunci(uint buf, uint src, uint dst) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glBlendFunci"))(buf, src, dst);
	}

	internal static unsafe void BlendFunciARB(uint buf, uint src, uint dst) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glBlendFunciARB"))(buf, src, dst);
	}

	internal static unsafe void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter) {
		((delegate* unmanaged<int, int, int, int, int, int, int, int, uint, uint, void>) Context.GetProcAddress("glBlitFramebuffer"))(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
	}

	internal static unsafe void BlitFramebufferEXT(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter) {
		((delegate* unmanaged<int, int, int, int, int, int, int, int, uint, uint, void>) Context.GetProcAddress("glBlitFramebufferEXT"))(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
	}

	internal static unsafe void BlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter) {
		((delegate* unmanaged<uint, uint, int, int, int, int, int, int, int, int, uint, uint, void>) Context.GetProcAddress("glBlitNamedFramebuffer"))(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
	}

	internal static unsafe void BufferData(uint target, nint size, void* data, uint usage) {
		((delegate* unmanaged<uint, nint, void*, uint, void>) Context.GetProcAddress("glBufferData"))(target, size, data, usage);
	}

	internal static unsafe void BufferDataARB(uint target, nint size, void* data, uint usage) {
		((delegate* unmanaged<uint, nint, void*, uint, void>) Context.GetProcAddress("glBufferDataARB"))(target, size, data, usage);
	}

	internal static unsafe void BufferStorage(uint target, nint size, void* data, uint flags) {
		((delegate* unmanaged<uint, nint, void*, uint, void>) Context.GetProcAddress("glBufferStorage"))(target, size, data, flags);
	}

	internal static unsafe void BufferSubData(uint target, int* offset, nint size, void* data) {
		((delegate* unmanaged<uint, int*, nint, void*, void>) Context.GetProcAddress("glBufferSubData"))(target, offset, size, data);
	}

	internal static unsafe void BufferSubDataARB(uint target, int* offset, nint size, void* data) {
		((delegate* unmanaged<uint, int*, nint, void*, void>) Context.GetProcAddress("glBufferSubDataARB"))(target, offset, size, data);
	}

	internal static unsafe uint CheckFramebufferStatus(uint target) {
		return ((delegate* unmanaged<uint, uint>) Context.GetProcAddress("glCheckFramebufferStatus"))(target);
	}

	internal static unsafe uint CheckFramebufferStatusEXT(uint target) {
		return ((delegate* unmanaged<uint, uint>) Context.GetProcAddress("glCheckFramebufferStatusEXT"))(target);
	}

	internal static unsafe uint CheckNamedFramebufferStatus(uint framebuffer, uint target) {
		return ((delegate* unmanaged<uint, uint, uint>) Context.GetProcAddress("glCheckNamedFramebufferStatus"))(framebuffer, target);
	}

	internal static unsafe void ClampColor(uint target, uint clamp) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glClampColor"))(target, clamp);
	}

	internal static unsafe void ClampColorARB(uint target, uint clamp) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glClampColorARB"))(target, clamp);
	}

	internal static unsafe void Clear(uint mask) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glClear"))(mask);
	}

	internal static unsafe void ClearAccumxOES(int red, int green, int blue, int alpha) {
		((delegate* unmanaged<int, int, int, int, void>) Context.GetProcAddress("glClearAccumxOES"))(red, green, blue, alpha);
	}

	internal static unsafe void ClearBufferData(uint target, uint internalformat, uint format, uint type, void* data) {
		((delegate* unmanaged<uint, uint, uint, uint, void*, void>) Context.GetProcAddress("glClearBufferData"))(target, internalformat, format, type, data);
	}

	internal static unsafe void ClearBufferSubData(uint target, uint internalformat, int* offset, nint size, uint format, uint type, void* data) {
		((delegate* unmanaged<uint, uint, int*, nint, uint, uint, void*, void>) Context.GetProcAddress("glClearBufferSubData"))(target, internalformat, offset, size, format, type, data);
	}

	internal static unsafe void ClearBufferfi(uint buffer, int drawbuffer, float depth, int stencil) {
		((delegate* unmanaged<uint, int, float, int, void>) Context.GetProcAddress("glClearBufferfi"))(buffer, drawbuffer, depth, stencil);
	}

	internal static unsafe void ClearBufferfv(uint buffer, int drawbuffer, float* value) {
		((delegate* unmanaged<uint, int, float*, void>) Context.GetProcAddress("glClearBufferfv"))(buffer, drawbuffer, value);
	}

	internal static unsafe void ClearBufferiv(uint buffer, int drawbuffer, int* value) {
		((delegate* unmanaged<uint, int, int*, void>) Context.GetProcAddress("glClearBufferiv"))(buffer, drawbuffer, value);
	}

	internal static unsafe void ClearBufferuiv(uint buffer, int drawbuffer, uint* value) {
		((delegate* unmanaged<uint, int, uint*, void>) Context.GetProcAddress("glClearBufferuiv"))(buffer, drawbuffer, value);
	}

	internal static unsafe void ClearColor(float red, float green, float blue, float alpha) {
		((delegate* unmanaged<float, float, float, float, void>) Context.GetProcAddress("glClearColor"))(red, green, blue, alpha);
	}

	internal static unsafe void ClearColorxOES(int red, int green, int blue, int alpha) {
		((delegate* unmanaged<int, int, int, int, void>) Context.GetProcAddress("glClearColorxOES"))(red, green, blue, alpha);
	}

	internal static unsafe void ClearDepth(double depth) {
		((delegate* unmanaged<double, void>) Context.GetProcAddress("glClearDepth"))(depth);
	}

	internal static unsafe void ClearDepthf(float d) {
		((delegate* unmanaged<float, void>) Context.GetProcAddress("glClearDepthf"))(d);
	}

	internal static unsafe void ClearDepthxOES(int depth) {
		((delegate* unmanaged<int, void>) Context.GetProcAddress("glClearDepthxOES"))(depth);
	}

	internal static unsafe void ClearNamedBufferData(uint buffer, uint internalformat, uint format, uint type, void* data) {
		((delegate* unmanaged<uint, uint, uint, uint, void*, void>) Context.GetProcAddress("glClearNamedBufferData"))(buffer, internalformat, format, type, data);
	}

	internal static unsafe void ClearNamedBufferSubData(uint buffer, uint internalformat, int* offset, nint size, uint format, uint type, void* data) {
		((delegate* unmanaged<uint, uint, int*, nint, uint, uint, void*, void>) Context.GetProcAddress("glClearNamedBufferSubData"))(buffer, internalformat, offset, size, format, type, data);
	}

	internal static unsafe void ClearNamedFramebufferfi(uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil) {
		((delegate* unmanaged<uint, uint, int, float, int, void>) Context.GetProcAddress("glClearNamedFramebufferfi"))(framebuffer, buffer, drawbuffer, depth, stencil);
	}

	internal static unsafe void ClearNamedFramebufferfv(uint framebuffer, uint buffer, int drawbuffer, float* value) {
		((delegate* unmanaged<uint, uint, int, float*, void>) Context.GetProcAddress("glClearNamedFramebufferfv"))(framebuffer, buffer, drawbuffer, value);
	}

	internal static unsafe void ClearNamedFramebufferiv(uint framebuffer, uint buffer, int drawbuffer, int* value) {
		((delegate* unmanaged<uint, uint, int, int*, void>) Context.GetProcAddress("glClearNamedFramebufferiv"))(framebuffer, buffer, drawbuffer, value);
	}

	internal static unsafe void ClearNamedFramebufferuiv(uint framebuffer, uint buffer, int drawbuffer, uint* value) {
		((delegate* unmanaged<uint, uint, int, uint*, void>) Context.GetProcAddress("glClearNamedFramebufferuiv"))(framebuffer, buffer, drawbuffer, value);
	}

	internal static unsafe void ClearStencil(int s) {
		((delegate* unmanaged<int, void>) Context.GetProcAddress("glClearStencil"))(s);
	}

	internal static unsafe void ClearTexImage(uint texture, int level, uint format, uint type, void* data) {
		((delegate* unmanaged<uint, int, uint, uint, void*, void>) Context.GetProcAddress("glClearTexImage"))(texture, level, format, type, data);
	}

	internal static unsafe void ClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* data) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, int, uint, uint, void*, void>) Context.GetProcAddress("glClearTexSubImage"))(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
	}

	internal static unsafe void ClientActiveTextureARB(uint texture) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glClientActiveTextureARB"))(texture);
	}

	internal static unsafe uint ClientWaitSync(GLSync sync, uint flags, nint timeout) {
		return ((delegate* unmanaged<GLSync, uint, nint, uint>) Context.GetProcAddress("glClientWaitSync"))(sync, flags, timeout);
	}

	internal static unsafe void ClipPlanexOES(uint plane, int* equation) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glClipPlanexOES"))(plane, equation);
	}

	internal static unsafe void Color3xOES(int red, int green, int blue) {
		((delegate* unmanaged<int, int, int, void>) Context.GetProcAddress("glColor3xOES"))(red, green, blue);
	}

	internal static unsafe void Color3xvOES(int* components) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glColor3xvOES"))(components);
	}

	internal static unsafe void Color4xOES(int red, int green, int blue, int alpha) {
		((delegate* unmanaged<int, int, int, int, void>) Context.GetProcAddress("glColor4xOES"))(red, green, blue, alpha);
	}

	internal static unsafe void Color4xvOES(int* components) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glColor4xvOES"))(components);
	}

	internal static unsafe void ColorMask(byte red, byte green, byte blue, byte alpha) {
		((delegate* unmanaged<byte, byte, byte, byte, void>) Context.GetProcAddress("glColorMask"))(red, green, blue, alpha);
	}

	internal static unsafe void ColorMaski(uint index, byte r, byte g, byte b, byte a) {
		((delegate* unmanaged<uint, byte, byte, byte, byte, void>) Context.GetProcAddress("glColorMaski"))(index, r, g, b, a);
	}

	internal static unsafe void CompileShader(uint shader) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glCompileShader"))(shader);
	}

	internal static unsafe void CompileShaderARB(uint shaderObj) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glCompileShaderARB"))(shaderObj);
	}

	internal static unsafe void CompileShaderIncludeARB(uint shader, int count, char** path, int* length) {
		((delegate* unmanaged<uint, int, char**, int*, void>) Context.GetProcAddress("glCompileShaderIncludeARB"))(shader, count, path, length);
	}

	internal static unsafe void CompressedTexImage1D(uint target, int level, uint internalformat, int width, int border, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, uint, int, int, int, void*, void>) Context.GetProcAddress("glCompressedTexImage1D"))(target, level, internalformat, width, border, imageSize, data);
	}

	internal static unsafe void CompressedTexImage1DARB(uint target, int level, uint internalformat, int width, int border, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, uint, int, int, int, void*, void>) Context.GetProcAddress("glCompressedTexImage1DARB"))(target, level, internalformat, width, border, imageSize, data);
	}

	internal static unsafe void CompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, uint, int, int, int, int, void*, void>) Context.GetProcAddress("glCompressedTexImage2D"))(target, level, internalformat, width, height, border, imageSize, data);
	}

	internal static unsafe void CompressedTexImage2DARB(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, uint, int, int, int, int, void*, void>) Context.GetProcAddress("glCompressedTexImage2DARB"))(target, level, internalformat, width, height, border, imageSize, data);
	}

	internal static unsafe void CompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, uint, int, int, int, int, int, void*, void>) Context.GetProcAddress("glCompressedTexImage3D"))(target, level, internalformat, width, height, depth, border, imageSize, data);
	}

	internal static unsafe void CompressedTexImage3DARB(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, uint, int, int, int, int, int, void*, void>) Context.GetProcAddress("glCompressedTexImage3DARB"))(target, level, internalformat, width, height, depth, border, imageSize, data);
	}

	internal static unsafe void CompressedTexSubImage1D(uint target, int level, int xoffset, int width, uint format, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, int, int, uint, int, void*, void>) Context.GetProcAddress("glCompressedTexSubImage1D"))(target, level, xoffset, width, format, imageSize, data);
	}

	internal static unsafe void CompressedTexSubImage1DARB(uint target, int level, int xoffset, int width, uint format, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, int, int, uint, int, void*, void>) Context.GetProcAddress("glCompressedTexSubImage1DARB"))(target, level, xoffset, width, format, imageSize, data);
	}

	internal static unsafe void CompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, int, int, int, int, uint, int, void*, void>) Context.GetProcAddress("glCompressedTexSubImage2D"))(target, level, xoffset, yoffset, width, height, format, imageSize, data);
	}

	internal static unsafe void CompressedTexSubImage2DARB(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, int, int, int, int, uint, int, void*, void>) Context.GetProcAddress("glCompressedTexSubImage2DARB"))(target, level, xoffset, yoffset, width, height, format, imageSize, data);
	}

	internal static unsafe void CompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, int, uint, int, void*, void>) Context.GetProcAddress("glCompressedTexSubImage3D"))(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
	}

	internal static unsafe void CompressedTexSubImage3DARB(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, int, uint, int, void*, void>) Context.GetProcAddress("glCompressedTexSubImage3DARB"))(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
	}

	internal static unsafe void CompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, int, int, uint, int, void*, void>) Context.GetProcAddress("glCompressedTextureSubImage1D"))(texture, level, xoffset, width, format, imageSize, data);
	}

	internal static unsafe void CompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, int, int, int, int, uint, int, void*, void>) Context.GetProcAddress("glCompressedTextureSubImage2D"))(texture, level, xoffset, yoffset, width, height, format, imageSize, data);
	}

	internal static unsafe void CompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, int, uint, int, void*, void>) Context.GetProcAddress("glCompressedTextureSubImage3D"))(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
	}

	internal static unsafe void ConvolutionParameterxOES(uint target, uint pname, int param) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glConvolutionParameterxOES"))(target, pname, param);
	}

	internal static unsafe void ConvolutionParameterxvOES(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glConvolutionParameterxvOES"))(target, pname, parameters);
	}

	internal static unsafe void CopyBufferSubData(uint readTarget, uint writeTarget, int* readOffset, int* writeOffset, nint size) {
		((delegate* unmanaged<uint, uint, int*, int*, nint, void>) Context.GetProcAddress("glCopyBufferSubData"))(readTarget, writeTarget, readOffset, writeOffset, size);
	}

	internal static unsafe void CopyImageSubData(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth) {
		((delegate* unmanaged<uint, uint, int, int, int, int, uint, uint, int, int, int, int, int, int, int, void>) Context.GetProcAddress("glCopyImageSubData"))(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
	}

	internal static unsafe void CopyNamedBufferSubData(uint readBuffer, uint writeBuffer, int* readOffset, int* writeOffset, nint size) {
		((delegate* unmanaged<uint, uint, int*, int*, nint, void>) Context.GetProcAddress("glCopyNamedBufferSubData"))(readBuffer, writeBuffer, readOffset, writeOffset, size);
	}

	internal static unsafe void CopyTexImage1D(uint target, int level, uint internalformat, int x, int y, int width, int border) {
		((delegate* unmanaged<uint, int, uint, int, int, int, int, void>) Context.GetProcAddress("glCopyTexImage1D"))(target, level, internalformat, x, y, width, border);
	}

	internal static unsafe void CopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border) {
		((delegate* unmanaged<uint, int, uint, int, int, int, int, int, void>) Context.GetProcAddress("glCopyTexImage2D"))(target, level, internalformat, x, y, width, height, border);
	}

	internal static unsafe void CopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width) {
		((delegate* unmanaged<uint, int, int, int, int, int, void>) Context.GetProcAddress("glCopyTexSubImage1D"))(target, level, xoffset, x, y, width);
	}

	internal static unsafe void CopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, int, void>) Context.GetProcAddress("glCopyTexSubImage2D"))(target, level, xoffset, yoffset, x, y, width, height);
	}

	internal static unsafe void CopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, int, int, void>) Context.GetProcAddress("glCopyTexSubImage3D"))(target, level, xoffset, yoffset, zoffset, x, y, width, height);
	}

	internal static unsafe void CopyTextureSubImage1D(uint texture, int level, int xoffset, int x, int y, int width) {
		((delegate* unmanaged<uint, int, int, int, int, int, void>) Context.GetProcAddress("glCopyTextureSubImage1D"))(texture, level, xoffset, x, y, width);
	}

	internal static unsafe void CopyTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, int, void>) Context.GetProcAddress("glCopyTextureSubImage2D"))(texture, level, xoffset, yoffset, x, y, width, height);
	}

	internal static unsafe void CopyTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, int, int, void>) Context.GetProcAddress("glCopyTextureSubImage3D"))(texture, level, xoffset, yoffset, zoffset, x, y, width, height);
	}

	internal static unsafe void CreateBuffers(int n, uint* buffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glCreateBuffers"))(n, buffers);
	}

	internal static unsafe void CreateFramebuffers(int n, uint* framebuffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glCreateFramebuffers"))(n, framebuffers);
	}

	internal static unsafe uint CreateProgram() {
	    return ((delegate* unmanaged<uint>) Context.GetProcAddress("glCreateProgram"))();
	}

	internal static unsafe uint CreateProgramObjectARB() {
	    return ((delegate* unmanaged<uint>) Context.GetProcAddress("glCreateProgramObjectARB"))();
	}

	internal static unsafe void CreateProgramPipelines(int n, uint* pipelines) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glCreateProgramPipelines"))(n, pipelines);
	}

	internal static unsafe void CreateQueries(uint target, int n, uint* ids) {
		((delegate* unmanaged<uint, int, uint*, void>) Context.GetProcAddress("glCreateQueries"))(target, n, ids);
	}

	internal static unsafe void CreateRenderbuffers(int n, uint* renderbuffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glCreateRenderbuffers"))(n, renderbuffers);
	}

	internal static unsafe void CreateSamplers(int n, uint* samplers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glCreateSamplers"))(n, samplers);
	}

	internal static unsafe uint CreateShader(uint type) {
		return ((delegate* unmanaged<uint, uint>) Context.GetProcAddress("glCreateShader"))(type);
	}

	internal static unsafe uint CreateShaderObjectARB(uint shaderType) {
		return ((delegate* unmanaged<uint, uint>) Context.GetProcAddress("glCreateShaderObjectARB"))(shaderType);
	}

	internal static unsafe uint CreateShaderProgramv(uint type, int count, char** strings) {
		return ((delegate* unmanaged<uint, int, char**, uint>) Context.GetProcAddress("glCreateShaderProgramv"))(type, count, strings);
	}

	internal static unsafe void CreateTextures(uint target, int n, uint* textures) {
		((delegate* unmanaged<uint, int, uint*, void>) Context.GetProcAddress("glCreateTextures"))(target, n, textures);
	}

	internal static unsafe void CreateTransformFeedbacks(int n, uint* ids) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glCreateTransformFeedbacks"))(n, ids);
	}

	internal static unsafe void CreateVertexArrays(int n, uint* arrays) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glCreateVertexArrays"))(n, arrays);
	}

	internal static unsafe void CullFace(uint mode) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glCullFace"))(mode);
	}

	internal static unsafe void DebugMessageCallback(delegate* unmanaged[Cdecl]<uint, uint, uint, uint, int, char*, void*, void> callback, void* userParam) {
		((delegate* unmanaged<delegate* unmanaged[Cdecl]<uint, uint, uint, uint, int, char*, void*, void>, void*, void>) Context.GetProcAddress("glDebugMessageCallback"))(callback, userParam);
	}

	internal static unsafe void DebugMessageCallbackARB(delegate* unmanaged[Cdecl]<uint, uint, uint, uint, int, char*, void*, void> callback, void* userParam) {
		((delegate* unmanaged<delegate* unmanaged[Cdecl]<uint, uint, uint, uint, int, char*, void*, void>, void*, void>) Context.GetProcAddress("glDebugMessageCallbackARB"))(callback, userParam);
	}

	internal static unsafe void DebugMessageControl(uint source, uint type, uint severity, int count, uint* ids, byte enabled) {
		((delegate* unmanaged<uint, uint, uint, int, uint*, byte, void>) Context.GetProcAddress("glDebugMessageControl"))(source, type, severity, count, ids, enabled);
	}

	internal static unsafe void DebugMessageControlARB(uint source, uint type, uint severity, int count, uint* ids, byte enabled) {
		((delegate* unmanaged<uint, uint, uint, int, uint*, byte, void>) Context.GetProcAddress("glDebugMessageControlARB"))(source, type, severity, count, ids, enabled);
	}

	internal static unsafe void DebugMessageInsert(uint source, uint type, uint id, uint severity, int length, char* buf) {
		((delegate* unmanaged<uint, uint, uint, uint, int, char*, void>) Context.GetProcAddress("glDebugMessageInsert"))(source, type, id, severity, length, buf);
	}

	internal static unsafe void DebugMessageInsertARB(uint source, uint type, uint id, uint severity, int length, char* buf) {
		((delegate* unmanaged<uint, uint, uint, uint, int, char*, void>) Context.GetProcAddress("glDebugMessageInsertARB"))(source, type, id, severity, length, buf);
	}

	internal static unsafe void DeleteBuffers(int n, uint* buffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDeleteBuffers"))(n, buffers);
	}

	internal static unsafe void DeleteBuffersARB(int n, uint* buffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDeleteBuffersARB"))(n, buffers);
	}

	internal static unsafe void DeleteFramebuffers(int n, uint* framebuffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDeleteFramebuffers"))(n, framebuffers);
	}

	internal static unsafe void DeleteFramebuffersEXT(int n, uint* framebuffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDeleteFramebuffersEXT"))(n, framebuffers);
	}

	internal static unsafe void DeleteNamedStringARB(int namelen, char* name) {
		((delegate* unmanaged<int, char*, void>) Context.GetProcAddress("glDeleteNamedStringARB"))(namelen, name);
	}

	internal static unsafe void DeleteObjectARB(uint obj) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glDeleteObjectARB"))(obj);
	}

	internal static unsafe void DeleteProgram(uint program) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glDeleteProgram"))(program);
	}

	internal static unsafe void DeleteProgramPipelines(int n, uint* pipelines) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDeleteProgramPipelines"))(n, pipelines);
	}

	internal static unsafe void DeleteProgramsARB(int n, uint* programs) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDeleteProgramsARB"))(n, programs);
	}

	internal static unsafe void DeleteQueries(int n, uint* ids) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDeleteQueries"))(n, ids);
	}

	internal static unsafe void DeleteQueriesARB(int n, uint* ids) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDeleteQueriesARB"))(n, ids);
	}

	internal static unsafe void DeleteRenderbuffers(int n, uint* renderbuffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDeleteRenderbuffers"))(n, renderbuffers);
	}

	internal static unsafe void DeleteRenderbuffersEXT(int n, uint* renderbuffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDeleteRenderbuffersEXT"))(n, renderbuffers);
	}

	internal static unsafe void DeleteSamplers(int count, uint* samplers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDeleteSamplers"))(count, samplers);
	}

	internal static unsafe void DeleteShader(uint shader) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glDeleteShader"))(shader);
	}

	internal static unsafe void DeleteSync(GLSync sync) {
		((delegate* unmanaged<GLSync, void>) Context.GetProcAddress("glDeleteSync"))(sync);
	}

	internal static unsafe void DeleteTextures(int n, uint* textures) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDeleteTextures"))(n, textures);
	}

	internal static unsafe void DeleteTransformFeedbacks(int n, uint* ids) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDeleteTransformFeedbacks"))(n, ids);
	}

	internal static unsafe void DeleteVertexArrays(int n, uint* arrays) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDeleteVertexArrays"))(n, arrays);
	}

	internal static unsafe void DepthFunc(uint func) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glDepthFunc"))(func);
	}

	internal static unsafe void DepthMask(byte flag) {
		((delegate* unmanaged<byte, void>) Context.GetProcAddress("glDepthMask"))(flag);
	}

	internal static unsafe void DepthRange(double n, double f) {
		((delegate* unmanaged<double, double, void>) Context.GetProcAddress("glDepthRange"))(n, f);
	}

	internal static unsafe void DepthRangeArrayv(uint first, int count, double* v) {
		((delegate* unmanaged<uint, int, double*, void>) Context.GetProcAddress("glDepthRangeArrayv"))(first, count, v);
	}

	internal static unsafe void DepthRangeIndexed(uint index, double n, double f) {
		((delegate* unmanaged<uint, double, double, void>) Context.GetProcAddress("glDepthRangeIndexed"))(index, n, f);
	}

	internal static unsafe void DepthRangef(float n, float f) {
		((delegate* unmanaged<float, float, void>) Context.GetProcAddress("glDepthRangef"))(n, f);
	}

	internal static unsafe void DepthRangexOES(int n, int f) {
		((delegate* unmanaged<int, int, void>) Context.GetProcAddress("glDepthRangexOES"))(n, f);
	}

	internal static unsafe void DetachObjectARB(uint containerObj, uint attachedObj) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glDetachObjectARB"))(containerObj, attachedObj);
	}

	internal static unsafe void DetachShader(uint program, uint shader) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glDetachShader"))(program, shader);
	}

	internal static unsafe void Disable(uint cap) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glDisable"))(cap);
	}

	internal static unsafe void DisableVertexArrayAttrib(uint vaobj, uint index) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glDisableVertexArrayAttrib"))(vaobj, index);
	}

	internal static unsafe void DisableVertexAttribArray(uint index) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glDisableVertexAttribArray"))(index);
	}

	internal static unsafe void DisableVertexAttribArrayARB(uint index) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glDisableVertexAttribArrayARB"))(index);
	}

	internal static unsafe void Disablei(uint target, uint index) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glDisablei"))(target, index);
	}

	internal static unsafe void DispatchCompute(uint numgroupsx, uint numgroupsy, uint numgroupsz) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glDispatchCompute"))(numgroupsx, numgroupsy, numgroupsz);
	}

	internal static unsafe void DispatchComputeGroupSizeARB(uint numgroupsx, uint numgroupsy, uint numgroupsz, uint groupsizex, uint groupsizey, uint groupsizez) {
		((delegate* unmanaged<uint, uint, uint, uint, uint, uint, void>) Context.GetProcAddress("glDispatchComputeGroupSizeARB"))(numgroupsx, numgroupsy, numgroupsz, groupsizex, groupsizey, groupsizez);
	}

	internal static unsafe void DispatchComputeIndirect(int* indirect) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glDispatchComputeIndirect"))(indirect);
	}

	internal static unsafe void DrawArrays(uint mode, int first, int count) {
		((delegate* unmanaged<uint, int, int, void>) Context.GetProcAddress("glDrawArrays"))(mode, first, count);
	}

	internal static unsafe void DrawArraysIndirect(uint mode, void* indirect) {
		((delegate* unmanaged<uint, void*, void>) Context.GetProcAddress("glDrawArraysIndirect"))(mode, indirect);
	}

	internal static unsafe void DrawArraysInstanced(uint mode, int first, int count, int instancecount) {
		((delegate* unmanaged<uint, int, int, int, void>) Context.GetProcAddress("glDrawArraysInstanced"))(mode, first, count, instancecount);
	}

	internal static unsafe void DrawArraysInstancedARB(uint mode, int first, int count, int primcount) {
		((delegate* unmanaged<uint, int, int, int, void>) Context.GetProcAddress("glDrawArraysInstancedARB"))(mode, first, count, primcount);
	}

	internal static unsafe void DrawArraysInstancedBaseInstance(uint mode, int first, int count, int instancecount, uint baseinstance) {
		((delegate* unmanaged<uint, int, int, int, uint, void>) Context.GetProcAddress("glDrawArraysInstancedBaseInstance"))(mode, first, count, instancecount, baseinstance);
	}

	internal static unsafe void DrawArraysInstancedEXT(uint mode, int start, int count, int primcount) {
		((delegate* unmanaged<uint, int, int, int, void>) Context.GetProcAddress("glDrawArraysInstancedEXT"))(mode, start, count, primcount);
	}

	internal static unsafe void DrawBuffer(uint buf) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glDrawBuffer"))(buf);
	}

	internal static unsafe void DrawBuffers(int n, uint* bufs) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDrawBuffers"))(n, bufs);
	}

	internal static unsafe void DrawBuffersARB(int n, uint* bufs) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDrawBuffersARB"))(n, bufs);
	}

	internal static unsafe void DrawElements(uint mode, int count, uint type, void* indices) {
		((delegate* unmanaged<uint, int, uint, void*, void>) Context.GetProcAddress("glDrawElements"))(mode, count, type, indices);
	}

	internal static unsafe void DrawElementsBaseVertex(uint mode, int count, uint type, void* indices, int basevertex) {
		((delegate* unmanaged<uint, int, uint, void*, int, void>) Context.GetProcAddress("glDrawElementsBaseVertex"))(mode, count, type, indices, basevertex);
	}

	internal static unsafe void DrawElementsIndirect(uint mode, uint type, void* indirect) {
		((delegate* unmanaged<uint, uint, void*, void>) Context.GetProcAddress("glDrawElementsIndirect"))(mode, type, indirect);
	}

	internal static unsafe void DrawElementsInstanced(uint mode, int count, uint type, void* indices, int instancecount) {
		((delegate* unmanaged<uint, int, uint, void*, int, void>) Context.GetProcAddress("glDrawElementsInstanced"))(mode, count, type, indices, instancecount);
	}

	internal static unsafe void DrawElementsInstancedARB(uint mode, int count, uint type, void* indices, int primcount) {
		((delegate* unmanaged<uint, int, uint, void*, int, void>) Context.GetProcAddress("glDrawElementsInstancedARB"))(mode, count, type, indices, primcount);
	}

	internal static unsafe void DrawElementsInstancedBaseInstance(uint mode, int count, uint type, void* indices, int instancecount, uint baseinstance) {
		((delegate* unmanaged<uint, int, uint, void*, int, uint, void>) Context.GetProcAddress("glDrawElementsInstancedBaseInstance"))(mode, count, type, indices, instancecount, baseinstance);
	}

	internal static unsafe void DrawElementsInstancedBaseVertex(uint mode, int count, uint type, void* indices, int instancecount, int basevertex) {
		((delegate* unmanaged<uint, int, uint, void*, int, int, void>) Context.GetProcAddress("glDrawElementsInstancedBaseVertex"))(mode, count, type, indices, instancecount, basevertex);
	}

	internal static unsafe void DrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, void* indices, int instancecount, int basevertex, uint baseinstance) {
		((delegate* unmanaged<uint, int, uint, void*, int, int, uint, void>) Context.GetProcAddress("glDrawElementsInstancedBaseVertexBaseInstance"))(mode, count, type, indices, instancecount, basevertex, baseinstance);
	}

	internal static unsafe void DrawElementsInstancedEXT(uint mode, int count, uint type, void* indices, int primcount) {
		((delegate* unmanaged<uint, int, uint, void*, int, void>) Context.GetProcAddress("glDrawElementsInstancedEXT"))(mode, count, type, indices, primcount);
	}

	internal static unsafe void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, void* indices) {
		((delegate* unmanaged<uint, uint, uint, int, uint, void*, void>) Context.GetProcAddress("glDrawRangeElements"))(mode, start, end, count, type, indices);
	}

	internal static unsafe void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, void* indices, int basevertex) {
		((delegate* unmanaged<uint, uint, uint, int, uint, void*, int, void>) Context.GetProcAddress("glDrawRangeElementsBaseVertex"))(mode, start, end, count, type, indices, basevertex);
	}

	internal static unsafe void DrawTransformFeedback(uint mode, uint id) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glDrawTransformFeedback"))(mode, id);
	}

	internal static unsafe void DrawTransformFeedbackInstanced(uint mode, uint id, int instancecount) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glDrawTransformFeedbackInstanced"))(mode, id, instancecount);
	}

	internal static unsafe void DrawTransformFeedbackStream(uint mode, uint id, uint stream) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glDrawTransformFeedbackStream"))(mode, id, stream);
	}

	internal static unsafe void DrawTransformFeedbackStreamInstanced(uint mode, uint id, uint stream, int instancecount) {
		((delegate* unmanaged<uint, uint, uint, int, void>) Context.GetProcAddress("glDrawTransformFeedbackStreamInstanced"))(mode, id, stream, instancecount);
	}

	internal static unsafe void Enable(uint cap) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glEnable"))(cap);
	}

	internal static unsafe void EnableVertexArrayAttrib(uint vaobj, uint index) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glEnableVertexArrayAttrib"))(vaobj, index);
	}

	internal static unsafe void EnableVertexAttribArray(uint index) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glEnableVertexAttribArray"))(index);
	}

	internal static unsafe void EnableVertexAttribArrayARB(uint index) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glEnableVertexAttribArrayARB"))(index);
	}

	internal static unsafe void Enablei(uint target, uint index) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glEnablei"))(target, index);
	}

	internal static unsafe void EndConditionalRender() {
	((delegate* unmanaged<void>) Context.GetProcAddress("glEndConditionalRender"))();
	}

	internal static unsafe void EndQuery(uint target) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glEndQuery"))(target);
	}

	internal static unsafe void EndQueryARB(uint target) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glEndQueryARB"))(target);
	}

	internal static unsafe void EndQueryIndexed(uint target, uint index) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glEndQueryIndexed"))(target, index);
	}

	internal static unsafe void EndTransformFeedback() {
	((delegate* unmanaged<void>) Context.GetProcAddress("glEndTransformFeedback"))();
	}

	internal static unsafe void EvalCoord1xOES(int u) {
		((delegate* unmanaged<int, void>) Context.GetProcAddress("glEvalCoord1xOES"))(u);
	}

	internal static unsafe void EvalCoord1xvOES(int* coords) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glEvalCoord1xvOES"))(coords);
	}

	internal static unsafe void EvalCoord2xOES(int u, int v) {
		((delegate* unmanaged<int, int, void>) Context.GetProcAddress("glEvalCoord2xOES"))(u, v);
	}

	internal static unsafe void EvalCoord2xvOES(int* coords) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glEvalCoord2xvOES"))(coords);
	}

	internal static unsafe void EvaluateDepthValuesARB() {
	((delegate* unmanaged<void>) Context.GetProcAddress("glEvaluateDepthValuesARB"))();
	}

	internal static unsafe void FeedbackBufferxOES(int n, uint type, int* buffer) {
		((delegate* unmanaged<int, uint, int*, void>) Context.GetProcAddress("glFeedbackBufferxOES"))(n, type, buffer);
	}

	internal static unsafe GLSync FenceSync(uint condition, uint flags) {
		return ((delegate* unmanaged<uint, uint, GLSync>) Context.GetProcAddress("glFenceSync"))(condition, flags);
	}

	internal static unsafe void Finish() {
	((delegate* unmanaged<void>) Context.GetProcAddress("glFinish"))();
	}

	internal static unsafe void Flush() {
	((delegate* unmanaged<void>) Context.GetProcAddress("glFlush"))();
	}

	internal static unsafe void FlushMappedBufferRange(uint target, int* offset, nint length) {
		((delegate* unmanaged<uint, int*, nint, void>) Context.GetProcAddress("glFlushMappedBufferRange"))(target, offset, length);
	}

	internal static unsafe void FlushMappedNamedBufferRange(uint buffer, int* offset, nint length) {
		((delegate* unmanaged<uint, int*, nint, void>) Context.GetProcAddress("glFlushMappedNamedBufferRange"))(buffer, offset, length);
	}

	internal static unsafe void FogCoordPointerEXT(uint type, int stride, void* pointer) {
		((delegate* unmanaged<uint, int, void*, void>) Context.GetProcAddress("glFogCoordPointerEXT"))(type, stride, pointer);
	}

	internal static unsafe void FogCoorddEXT(double coord) {
		((delegate* unmanaged<double, void>) Context.GetProcAddress("glFogCoorddEXT"))(coord);
	}

	internal static unsafe void FogCoorddvEXT(double* coord) {
		((delegate* unmanaged<double*, void>) Context.GetProcAddress("glFogCoorddvEXT"))(coord);
	}

	internal static unsafe void FogCoordfEXT(float coord) {
		((delegate* unmanaged<float, void>) Context.GetProcAddress("glFogCoordfEXT"))(coord);
	}

	internal static unsafe void FogCoordfvEXT(float* coord) {
		((delegate* unmanaged<float*, void>) Context.GetProcAddress("glFogCoordfvEXT"))(coord);
	}

	internal static unsafe void FogxOES(uint pname, int param) {
		((delegate* unmanaged<uint, int, void>) Context.GetProcAddress("glFogxOES"))(pname, param);
	}

	internal static unsafe void FogxvOES(uint pname, int* param) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glFogxvOES"))(pname, param);
	}

	internal static unsafe void FramebufferParameteri(uint target, uint pname, int param) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glFramebufferParameteri"))(target, pname, param);
	}

	internal static unsafe void FramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer) {
		((delegate* unmanaged<uint, uint, uint, uint, void>) Context.GetProcAddress("glFramebufferRenderbuffer"))(target, attachment, renderbuffertarget, renderbuffer);
	}

	internal static unsafe void FramebufferRenderbufferEXT(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer) {
		((delegate* unmanaged<uint, uint, uint, uint, void>) Context.GetProcAddress("glFramebufferRenderbufferEXT"))(target, attachment, renderbuffertarget, renderbuffer);
	}

	internal static unsafe void FramebufferSampleLocationsfvARB(uint target, uint start, int count, float* v) {
		((delegate* unmanaged<uint, uint, int, float*, void>) Context.GetProcAddress("glFramebufferSampleLocationsfvARB"))(target, start, count, v);
	}

	internal static unsafe void FramebufferTexture(uint target, uint attachment, uint texture, int level) {
		((delegate* unmanaged<uint, uint, uint, int, void>) Context.GetProcAddress("glFramebufferTexture"))(target, attachment, texture, level);
	}

	internal static unsafe void FramebufferTexture1D(uint target, uint attachment, uint textarget, uint texture, int level) {
		((delegate* unmanaged<uint, uint, uint, uint, int, void>) Context.GetProcAddress("glFramebufferTexture1D"))(target, attachment, textarget, texture, level);
	}

	internal static unsafe void FramebufferTexture1DEXT(uint target, uint attachment, uint textarget, uint texture, int level) {
		((delegate* unmanaged<uint, uint, uint, uint, int, void>) Context.GetProcAddress("glFramebufferTexture1DEXT"))(target, attachment, textarget, texture, level);
	}

	internal static unsafe void FramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level) {
		((delegate* unmanaged<uint, uint, uint, uint, int, void>) Context.GetProcAddress("glFramebufferTexture2D"))(target, attachment, textarget, texture, level);
	}

	internal static unsafe void FramebufferTexture2DEXT(uint target, uint attachment, uint textarget, uint texture, int level) {
		((delegate* unmanaged<uint, uint, uint, uint, int, void>) Context.GetProcAddress("glFramebufferTexture2DEXT"))(target, attachment, textarget, texture, level);
	}

	internal static unsafe void FramebufferTexture3D(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset) {
		((delegate* unmanaged<uint, uint, uint, uint, int, int, void>) Context.GetProcAddress("glFramebufferTexture3D"))(target, attachment, textarget, texture, level, zoffset);
	}

	internal static unsafe void FramebufferTexture3DEXT(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset) {
		((delegate* unmanaged<uint, uint, uint, uint, int, int, void>) Context.GetProcAddress("glFramebufferTexture3DEXT"))(target, attachment, textarget, texture, level, zoffset);
	}

	internal static unsafe void FramebufferTextureARB(uint target, uint attachment, uint texture, int level) {
		((delegate* unmanaged<uint, uint, uint, int, void>) Context.GetProcAddress("glFramebufferTextureARB"))(target, attachment, texture, level);
	}

	internal static unsafe void FramebufferTextureFaceARB(uint target, uint attachment, uint texture, int level, uint face) {
		((delegate* unmanaged<uint, uint, uint, int, uint, void>) Context.GetProcAddress("glFramebufferTextureFaceARB"))(target, attachment, texture, level, face);
	}

	internal static unsafe void FramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer) {
		((delegate* unmanaged<uint, uint, uint, int, int, void>) Context.GetProcAddress("glFramebufferTextureLayer"))(target, attachment, texture, level, layer);
	}

	internal static unsafe void FramebufferTextureLayerARB(uint target, uint attachment, uint texture, int level, int layer) {
		((delegate* unmanaged<uint, uint, uint, int, int, void>) Context.GetProcAddress("glFramebufferTextureLayerARB"))(target, attachment, texture, level, layer);
	}

	internal static unsafe void FrontFace(uint mode) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glFrontFace"))(mode);
	}

	internal static unsafe void FrustumxOES(int l, int r, int b, int t, int n, int f) {
		((delegate* unmanaged<int, int, int, int, int, int, void>) Context.GetProcAddress("glFrustumxOES"))(l, r, b, t, n, f);
	}

	internal static unsafe void GenBuffers(int n, uint* buffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glGenBuffers"))(n, buffers);
	}

	internal static unsafe void GenBuffersARB(int n, uint* buffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glGenBuffersARB"))(n, buffers);
	}

	internal static unsafe void GenFramebuffers(int n, uint* framebuffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glGenFramebuffers"))(n, framebuffers);
	}

	internal static unsafe void GenFramebuffersEXT(int n, uint* framebuffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glGenFramebuffersEXT"))(n, framebuffers);
	}

	internal static unsafe void GenProgramPipelines(int n, uint* pipelines) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glGenProgramPipelines"))(n, pipelines);
	}

	internal static unsafe void GenProgramsARB(int n, uint* programs) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glGenProgramsARB"))(n, programs);
	}

	internal static unsafe void GenQueries(int n, uint* ids) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glGenQueries"))(n, ids);
	}

	internal static unsafe void GenQueriesARB(int n, uint* ids) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glGenQueriesARB"))(n, ids);
	}

	internal static unsafe void GenRenderbuffers(int n, uint* renderbuffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glGenRenderbuffers"))(n, renderbuffers);
	}

	internal static unsafe void GenRenderbuffersEXT(int n, uint* renderbuffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glGenRenderbuffersEXT"))(n, renderbuffers);
	}

	internal static unsafe void GenSamplers(int count, uint* samplers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glGenSamplers"))(count, samplers);
	}

	internal static unsafe void GenTextures(int n, uint* textures) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glGenTextures"))(n, textures);
	}

	internal static unsafe void GenTransformFeedbacks(int n, uint* ids) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glGenTransformFeedbacks"))(n, ids);
	}

	internal static unsafe void GenVertexArrays(int n, uint* arrays) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glGenVertexArrays"))(n, arrays);
	}

	internal static unsafe void GenerateMipmap(uint target) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glGenerateMipmap"))(target);
	}

	internal static unsafe void GenerateMipmapEXT(uint target) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glGenerateMipmapEXT"))(target);
	}

	internal static unsafe void GenerateTextureMipmap(uint texture) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glGenerateTextureMipmap"))(texture);
	}

	internal static unsafe void GetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, uint, int*, void>) Context.GetProcAddress("glGetActiveAtomicCounterBufferiv"))(program, bufferIndex, pname, parameters);
	}

	internal static unsafe void GetActiveAttrib(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name) {
		((delegate* unmanaged<uint, uint, int, int*, int*, uint*, char*, void>) Context.GetProcAddress("glGetActiveAttrib"))(program, index, bufSize, length, size, type, name);
	}

	internal static unsafe void GetActiveAttribARB(uint programObj, uint index, int maxLength, int* length, int* size, uint* type, char* name) {
		((delegate* unmanaged<uint, uint, int, int*, int*, uint*, char*, void>) Context.GetProcAddress("glGetActiveAttribARB"))(programObj, index, maxLength, length, size, type, name);
	}

	internal static unsafe void GetActiveSubroutineName(uint program, uint shadertype, uint index, int bufSize, int* length, char* name) {
		((delegate* unmanaged<uint, uint, uint, int, int*, char*, void>) Context.GetProcAddress("glGetActiveSubroutineName"))(program, shadertype, index, bufSize, length, name);
	}

	internal static unsafe void GetActiveSubroutineUniformName(uint program, uint shadertype, uint index, int bufSize, int* length, char* name) {
		((delegate* unmanaged<uint, uint, uint, int, int*, char*, void>) Context.GetProcAddress("glGetActiveSubroutineUniformName"))(program, shadertype, index, bufSize, length, name);
	}

	internal static unsafe void GetActiveSubroutineUniformiv(uint program, uint shadertype, uint index, uint pname, int* values) {
		((delegate* unmanaged<uint, uint, uint, uint, int*, void>) Context.GetProcAddress("glGetActiveSubroutineUniformiv"))(program, shadertype, index, pname, values);
	}

	internal static unsafe void GetActiveUniform(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name) {
		((delegate* unmanaged<uint, uint, int, int*, int*, uint*, char*, void>) Context.GetProcAddress("glGetActiveUniform"))(program, index, bufSize, length, size, type, name);
	}

	internal static unsafe void GetActiveUniformARB(uint programObj, uint index, int maxLength, int* length, int* size, uint* type, char* name) {
		((delegate* unmanaged<uint, uint, int, int*, int*, uint*, char*, void>) Context.GetProcAddress("glGetActiveUniformARB"))(programObj, index, maxLength, length, size, type, name);
	}

	internal static unsafe void GetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int* length, char* uniformBlockName) {
		((delegate* unmanaged<uint, uint, int, int*, char*, void>) Context.GetProcAddress("glGetActiveUniformBlockName"))(program, uniformBlockIndex, bufSize, length, uniformBlockName);
	}

	internal static unsafe void GetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, uint, int*, void>) Context.GetProcAddress("glGetActiveUniformBlockiv"))(program, uniformBlockIndex, pname, parameters);
	}

	internal static unsafe void GetActiveUniformName(uint program, uint uniformIndex, int bufSize, int* length, char* uniformName) {
		((delegate* unmanaged<uint, uint, int, int*, char*, void>) Context.GetProcAddress("glGetActiveUniformName"))(program, uniformIndex, bufSize, length, uniformName);
	}

	internal static unsafe void GetActiveUniformsiv(uint program, int uniformCount, uint* uniformIndices, uint pname, int* parameters) {
		((delegate* unmanaged<uint, int, uint*, uint, int*, void>) Context.GetProcAddress("glGetActiveUniformsiv"))(program, uniformCount, uniformIndices, pname, parameters);
	}

	internal static unsafe void GetAttachedObjectsARB(uint containerObj, int maxCount, int* count, uint* obj) {
		((delegate* unmanaged<uint, int, int*, uint*, void>) Context.GetProcAddress("glGetAttachedObjectsARB"))(containerObj, maxCount, count, obj);
	}

	internal static unsafe void GetAttachedShaders(uint program, int maxCount, int* count, uint* shaders) {
		((delegate* unmanaged<uint, int, int*, uint*, void>) Context.GetProcAddress("glGetAttachedShaders"))(program, maxCount, count, shaders);
	}

	internal static unsafe int GetAttribLocation(uint program, char* name) {
		return ((delegate* unmanaged<uint, char*, int>) Context.GetProcAddress("glGetAttribLocation"))(program, name);
	}

	internal static unsafe int GetAttribLocationARB(uint programObj, char* name) {
		return ((delegate* unmanaged<uint, char*, int>) Context.GetProcAddress("glGetAttribLocationARB"))(programObj, name);
	}

	internal static unsafe void GetBooleani_v(uint target, uint index, byte* data) {
		((delegate* unmanaged<uint, uint, byte*, void>) Context.GetProcAddress("glGetBooleani_v"))(target, index, data);
	}

	internal static unsafe void GetBooleanv(uint pname, byte* data) {
		((delegate* unmanaged<uint, byte*, void>) Context.GetProcAddress("glGetBooleanv"))(pname, data);
	}

	internal static unsafe void GetBufferParameteri64v(uint target, uint pname, nint* parameters) {
		((delegate* unmanaged<uint, uint, nint*, void>) Context.GetProcAddress("glGetBufferParameteri64v"))(target, pname, parameters);
	}

	internal static unsafe void GetBufferParameteriv(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetBufferParameteriv"))(target, pname, parameters);
	}

	internal static unsafe void GetBufferParameterivARB(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetBufferParameterivARB"))(target, pname, parameters);
	}

	internal static unsafe void GetBufferPointerv(uint target, uint pname, void** parameters) {
		((delegate* unmanaged<uint, uint, void**, void>) Context.GetProcAddress("glGetBufferPointerv"))(target, pname, parameters);
	}

	internal static unsafe void GetBufferPointervARB(uint target, uint pname, void** parameters) {
		((delegate* unmanaged<uint, uint, void**, void>) Context.GetProcAddress("glGetBufferPointervARB"))(target, pname, parameters);
	}

	internal static unsafe void GetBufferSubData(uint target, int* offset, nint size, void* data) {
		((delegate* unmanaged<uint, int*, nint, void*, void>) Context.GetProcAddress("glGetBufferSubData"))(target, offset, size, data);
	}

	internal static unsafe void GetBufferSubDataARB(uint target, int* offset, nint size, void* data) {
		((delegate* unmanaged<uint, int*, nint, void*, void>) Context.GetProcAddress("glGetBufferSubDataARB"))(target, offset, size, data);
	}

	internal static unsafe void GetClipPlanexOES(uint plane, int* equation) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glGetClipPlanexOES"))(plane, equation);
	}

	internal static unsafe void GetCompressedTexImage(uint target, int level, void* img) {
		((delegate* unmanaged<uint, int, void*, void>) Context.GetProcAddress("glGetCompressedTexImage"))(target, level, img);
	}

	internal static unsafe void GetCompressedTexImageARB(uint target, int level, void* img) {
		((delegate* unmanaged<uint, int, void*, void>) Context.GetProcAddress("glGetCompressedTexImageARB"))(target, level, img);
	}

	internal static unsafe void GetCompressedTextureImage(uint texture, int level, int bufSize, void* pixels) {
		((delegate* unmanaged<uint, int, int, void*, void>) Context.GetProcAddress("glGetCompressedTextureImage"))(texture, level, bufSize, pixels);
	}

	internal static unsafe void GetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, void* pixels) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, int, int, void*, void>) Context.GetProcAddress("glGetCompressedTextureSubImage"))(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
	}

	internal static unsafe void GetConvolutionParameterxvOES(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetConvolutionParameterxvOES"))(target, pname, parameters);
	}

	internal static unsafe uint GetDebugMessageLog(uint count, int bufSize, uint* sources, uint* types, uint* ids, uint* severities, int* lengths, char* messageLog) {
		return ((delegate* unmanaged<uint, int, uint*, uint*, uint*, uint*, int*, char*, uint>) Context.GetProcAddress("glGetDebugMessageLog"))(count, bufSize, sources, types, ids, severities, lengths, messageLog);
	}

	internal static unsafe uint GetDebugMessageLogARB(uint count, int bufSize, uint* sources, uint* types, uint* ids, uint* severities, int* lengths, char* messageLog) {
		return ((delegate* unmanaged<uint, int, uint*, uint*, uint*, uint*, int*, char*, uint>) Context.GetProcAddress("glGetDebugMessageLogARB"))(count, bufSize, sources, types, ids, severities, lengths, messageLog);
	}

	internal static unsafe void GetDoublei_v(uint target, uint index, double* data) {
		((delegate* unmanaged<uint, uint, double*, void>) Context.GetProcAddress("glGetDoublei_v"))(target, index, data);
	}

	internal static unsafe void GetDoublev(uint pname, double* data) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glGetDoublev"))(pname, data);
	}

	internal static unsafe uint GetError() {
	    return ((delegate* unmanaged<uint>) Context.GetProcAddress("glGetError"))();
	}

	internal static unsafe void GetFixedvOES(uint pname, int* parameters) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glGetFixedvOES"))(pname, parameters);
	}

	internal static unsafe void GetFloati_v(uint target, uint index, float* data) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glGetFloati_v"))(target, index, data);
	}

	internal static unsafe void GetFloatv(uint pname, float* data) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glGetFloatv"))(pname, data);
	}

	internal static unsafe int GetFragDataIndex(uint program, char* name) {
		return ((delegate* unmanaged<uint, char*, int>) Context.GetProcAddress("glGetFragDataIndex"))(program, name);
	}

	internal static unsafe int GetFragDataLocation(uint program, char* name) {
		return ((delegate* unmanaged<uint, char*, int>) Context.GetProcAddress("glGetFragDataLocation"))(program, name);
	}

	internal static unsafe void GetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, uint, int*, void>) Context.GetProcAddress("glGetFramebufferAttachmentParameteriv"))(target, attachment, pname, parameters);
	}

	internal static unsafe void GetFramebufferAttachmentParameterivEXT(uint target, uint attachment, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, uint, int*, void>) Context.GetProcAddress("glGetFramebufferAttachmentParameterivEXT"))(target, attachment, pname, parameters);
	}

	internal static unsafe void GetFramebufferParameteriv(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetFramebufferParameteriv"))(target, pname, parameters);
	}

	internal static unsafe uint GetHandleARB(uint pname) {
		return ((delegate* unmanaged<uint, uint>) Context.GetProcAddress("glGetHandleARB"))(pname);
	}

	internal static unsafe void GetHistogramParameterxvOES(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetHistogramParameterxvOES"))(target, pname, parameters);
	}

	internal static unsafe void GetInfoLogARB(uint obj, int maxLength, int* length, char* infoLog) {
		((delegate* unmanaged<uint, int, int*, char*, void>) Context.GetProcAddress("glGetInfoLogARB"))(obj, maxLength, length, infoLog);
	}

	internal static unsafe void GetInteger64i_v(uint target, uint index, nint* data) {
		((delegate* unmanaged<uint, uint, nint*, void>) Context.GetProcAddress("glGetInteger64i_v"))(target, index, data);
	}

	internal static unsafe void GetInteger64v(uint pname, nint* data) {
		((delegate* unmanaged<uint, nint*, void>) Context.GetProcAddress("glGetInteger64v"))(pname, data);
	}

	internal static unsafe void GetIntegeri_v(uint target, uint index, int* data) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetIntegeri_v"))(target, index, data);
	}

	internal static unsafe void GetIntegerv(uint pname, int* data) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glGetIntegerv"))(pname, data);
	}

	internal static unsafe void GetInternalformati64v(uint target, uint internalformat, uint pname, int count, nint* parameters) {
		((delegate* unmanaged<uint, uint, uint, int, nint*, void>) Context.GetProcAddress("glGetInternalformati64v"))(target, internalformat, pname, count, parameters);
	}

	internal static unsafe void GetInternalformativ(uint target, uint internalformat, uint pname, int count, int* parameters) {
		((delegate* unmanaged<uint, uint, uint, int, int*, void>) Context.GetProcAddress("glGetInternalformativ"))(target, internalformat, pname, count, parameters);
	}

	internal static unsafe void GetLightxOES(uint light, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetLightxOES"))(light, pname, parameters);
	}

	internal static unsafe void GetMapxvOES(uint target, uint query, int* v) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetMapxvOES"))(target, query, v);
	}

	internal static unsafe void GetMaterialxOES(uint face, uint pname, int param) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glGetMaterialxOES"))(face, pname, param);
	}

	internal static unsafe void GetMultisamplefv(uint pname, uint index, float* val) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glGetMultisamplefv"))(pname, index, val);
	}

	internal static unsafe void GetNamedBufferParameteri64v(uint buffer, uint pname, nint* parameters) {
		((delegate* unmanaged<uint, uint, nint*, void>) Context.GetProcAddress("glGetNamedBufferParameteri64v"))(buffer, pname, parameters);
	}

	internal static unsafe void GetNamedBufferParameteriv(uint buffer, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetNamedBufferParameteriv"))(buffer, pname, parameters);
	}

	internal static unsafe void GetNamedBufferPointerv(uint buffer, uint pname, void** parameters) {
		((delegate* unmanaged<uint, uint, void**, void>) Context.GetProcAddress("glGetNamedBufferPointerv"))(buffer, pname, parameters);
	}

	internal static unsafe void GetNamedBufferSubData(uint buffer, int* offset, nint size, void* data) {
		((delegate* unmanaged<uint, int*, nint, void*, void>) Context.GetProcAddress("glGetNamedBufferSubData"))(buffer, offset, size, data);
	}

	internal static unsafe void GetNamedFramebufferAttachmentParameteriv(uint framebuffer, uint attachment, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, uint, int*, void>) Context.GetProcAddress("glGetNamedFramebufferAttachmentParameteriv"))(framebuffer, attachment, pname, parameters);
	}

	internal static unsafe void GetNamedFramebufferParameteriv(uint framebuffer, uint pname, int* param) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetNamedFramebufferParameteriv"))(framebuffer, pname, param);
	}

	internal static unsafe void GetNamedRenderbufferParameteriv(uint renderbuffer, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetNamedRenderbufferParameteriv"))(renderbuffer, pname, parameters);
	}

	internal static unsafe void GetNamedStringARB(int namelen, char* name, int bufSize, int* stringlen, char* str) {
		((delegate* unmanaged<int, char*, int, int*, char*, void>) Context.GetProcAddress("glGetNamedStringARB"))(namelen, name, bufSize, stringlen, str);
	}

	internal static unsafe void GetNamedStringivARB(int namelen, char* name, uint pname, int* parameters) {
		((delegate* unmanaged<int, char*, uint, int*, void>) Context.GetProcAddress("glGetNamedStringivARB"))(namelen, name, pname, parameters);
	}

	internal static unsafe void GetObjectLabel(uint identifier, uint name, int bufSize, int* length, char* label) {
		((delegate* unmanaged<uint, uint, int, int*, char*, void>) Context.GetProcAddress("glGetObjectLabel"))(identifier, name, bufSize, length, label);
	}

	internal static unsafe void GetObjectParameterfvARB(uint obj, uint pname, float* parameters) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glGetObjectParameterfvARB"))(obj, pname, parameters);
	}

	internal static unsafe void GetObjectParameterivARB(uint obj, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetObjectParameterivARB"))(obj, pname, parameters);
	}

	internal static unsafe void GetObjectPtrLabel(void* ptr, int bufSize, int* length, char* label) {
		((delegate* unmanaged<void*, int, int*, char*, void>) Context.GetProcAddress("glGetObjectPtrLabel"))(ptr, bufSize, length, label);
	}

	internal static unsafe void GetPixelMapxv(uint map, int size, int* values) {
		((delegate* unmanaged<uint, int, int*, void>) Context.GetProcAddress("glGetPixelMapxv"))(map, size, values);
	}

	internal static unsafe void GetPointerv(uint pname, void** parameters) {
		((delegate* unmanaged<uint, void**, void>) Context.GetProcAddress("glGetPointerv"))(pname, parameters);
	}

	internal static unsafe void GetProgramBinary(uint program, int bufSize, int* length, uint* binaryFormat, void* binary) {
		((delegate* unmanaged<uint, int, int*, uint*, void*, void>) Context.GetProcAddress("glGetProgramBinary"))(program, bufSize, length, binaryFormat, binary);
	}

	internal static unsafe void GetProgramEnvParameterdvARB(uint target, uint index, double* parameters) {
		((delegate* unmanaged<uint, uint, double*, void>) Context.GetProcAddress("glGetProgramEnvParameterdvARB"))(target, index, parameters);
	}

	internal static unsafe void GetProgramEnvParameterfvARB(uint target, uint index, float* parameters) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glGetProgramEnvParameterfvARB"))(target, index, parameters);
	}

	internal static unsafe void GetProgramInfoLog(uint program, int bufSize, int* length, char* infoLog) {
		((delegate* unmanaged<uint, int, int*, char*, void>) Context.GetProcAddress("glGetProgramInfoLog"))(program, bufSize, length, infoLog);
	}

	internal static unsafe void GetProgramInterfaceiv(uint program, uint programInterface, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, uint, int*, void>) Context.GetProcAddress("glGetProgramInterfaceiv"))(program, programInterface, pname, parameters);
	}

	internal static unsafe void GetProgramLocalParameterdvARB(uint target, uint index, double* parameters) {
		((delegate* unmanaged<uint, uint, double*, void>) Context.GetProcAddress("glGetProgramLocalParameterdvARB"))(target, index, parameters);
	}

	internal static unsafe void GetProgramLocalParameterfvARB(uint target, uint index, float* parameters) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glGetProgramLocalParameterfvARB"))(target, index, parameters);
	}

	internal static unsafe void GetProgramPipelineInfoLog(uint pipeline, int bufSize, int* length, char* infoLog) {
		((delegate* unmanaged<uint, int, int*, char*, void>) Context.GetProcAddress("glGetProgramPipelineInfoLog"))(pipeline, bufSize, length, infoLog);
	}

	internal static unsafe void GetProgramPipelineiv(uint pipeline, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetProgramPipelineiv"))(pipeline, pname, parameters);
	}

	internal static unsafe uint GetProgramResourceIndex(uint program, uint programInterface, char* name) {
		return ((delegate* unmanaged<uint, uint, char*, uint>) Context.GetProcAddress("glGetProgramResourceIndex"))(program, programInterface, name);
	}

	internal static unsafe int GetProgramResourceLocation(uint program, uint programInterface, char* name) {
		return ((delegate* unmanaged<uint, uint, char*, int>) Context.GetProcAddress("glGetProgramResourceLocation"))(program, programInterface, name);
	}

	internal static unsafe int GetProgramResourceLocationIndex(uint program, uint programInterface, char* name) {
		return ((delegate* unmanaged<uint, uint, char*, int>) Context.GetProcAddress("glGetProgramResourceLocationIndex"))(program, programInterface, name);
	}

	internal static unsafe void GetProgramResourceName(uint program, uint programInterface, uint index, int bufSize, int* length, char* name) {
		((delegate* unmanaged<uint, uint, uint, int, int*, char*, void>) Context.GetProcAddress("glGetProgramResourceName"))(program, programInterface, index, bufSize, length, name);
	}

	internal static unsafe void GetProgramResourceiv(uint program, uint programInterface, uint index, int propCount, uint* props, int count, int* length, int* parameters) {
		((delegate* unmanaged<uint, uint, uint, int, uint*, int, int*, int*, void>) Context.GetProcAddress("glGetProgramResourceiv"))(program, programInterface, index, propCount, props, count, length, parameters);
	}

	internal static unsafe void GetProgramStageiv(uint program, uint shadertype, uint pname, int* values) {
		((delegate* unmanaged<uint, uint, uint, int*, void>) Context.GetProcAddress("glGetProgramStageiv"))(program, shadertype, pname, values);
	}

	internal static unsafe void GetProgramStringARB(uint target, uint pname, void* str) {
		((delegate* unmanaged<uint, uint, void*, void>) Context.GetProcAddress("glGetProgramStringARB"))(target, pname, str);
	}

	internal static unsafe void GetProgramiv(uint program, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetProgramiv"))(program, pname, parameters);
	}

	internal static unsafe void GetProgramivARB(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetProgramivARB"))(target, pname, parameters);
	}

	internal static unsafe void GetQueryBufferObjecti64v(uint id, uint buffer, uint pname, int* offset) {
		((delegate* unmanaged<uint, uint, uint, int*, void>) Context.GetProcAddress("glGetQueryBufferObjecti64v"))(id, buffer, pname, offset);
	}

	internal static unsafe void GetQueryBufferObjectiv(uint id, uint buffer, uint pname, int* offset) {
		((delegate* unmanaged<uint, uint, uint, int*, void>) Context.GetProcAddress("glGetQueryBufferObjectiv"))(id, buffer, pname, offset);
	}

	internal static unsafe void GetQueryBufferObjectui64v(uint id, uint buffer, uint pname, int* offset) {
		((delegate* unmanaged<uint, uint, uint, int*, void>) Context.GetProcAddress("glGetQueryBufferObjectui64v"))(id, buffer, pname, offset);
	}

	internal static unsafe void GetQueryBufferObjectuiv(uint id, uint buffer, uint pname, int* offset) {
		((delegate* unmanaged<uint, uint, uint, int*, void>) Context.GetProcAddress("glGetQueryBufferObjectuiv"))(id, buffer, pname, offset);
	}

	internal static unsafe void GetQueryIndexediv(uint target, uint index, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, uint, int*, void>) Context.GetProcAddress("glGetQueryIndexediv"))(target, index, pname, parameters);
	}

	internal static unsafe void GetQueryObjecti64v(uint id, uint pname, nint* parameters) {
		((delegate* unmanaged<uint, uint, nint*, void>) Context.GetProcAddress("glGetQueryObjecti64v"))(id, pname, parameters);
	}

	internal static unsafe void GetQueryObjectiv(uint id, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetQueryObjectiv"))(id, pname, parameters);
	}

	internal static unsafe void GetQueryObjectivARB(uint id, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetQueryObjectivARB"))(id, pname, parameters);
	}

	internal static unsafe void GetQueryObjectui64v(uint id, uint pname, nint* parameters) {
		((delegate* unmanaged<uint, uint, nint*, void>) Context.GetProcAddress("glGetQueryObjectui64v"))(id, pname, parameters);
	}

	internal static unsafe void GetQueryObjectuiv(uint id, uint pname, uint* parameters) {
		((delegate* unmanaged<uint, uint, uint*, void>) Context.GetProcAddress("glGetQueryObjectuiv"))(id, pname, parameters);
	}

	internal static unsafe void GetQueryObjectuivARB(uint id, uint pname, uint* parameters) {
		((delegate* unmanaged<uint, uint, uint*, void>) Context.GetProcAddress("glGetQueryObjectuivARB"))(id, pname, parameters);
	}

	internal static unsafe void GetQueryiv(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetQueryiv"))(target, pname, parameters);
	}

	internal static unsafe void GetQueryivARB(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetQueryivARB"))(target, pname, parameters);
	}

	internal static unsafe void GetRenderbufferParameteriv(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetRenderbufferParameteriv"))(target, pname, parameters);
	}

	internal static unsafe void GetRenderbufferParameterivEXT(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetRenderbufferParameterivEXT"))(target, pname, parameters);
	}

	internal static unsafe void GetSamplerParameterIiv(uint sampler, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetSamplerParameterIiv"))(sampler, pname, parameters);
	}

	internal static unsafe void GetSamplerParameterIuiv(uint sampler, uint pname, uint* parameters) {
		((delegate* unmanaged<uint, uint, uint*, void>) Context.GetProcAddress("glGetSamplerParameterIuiv"))(sampler, pname, parameters);
	}

	internal static unsafe void GetSamplerParameterfv(uint sampler, uint pname, float* parameters) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glGetSamplerParameterfv"))(sampler, pname, parameters);
	}

	internal static unsafe void GetSamplerParameteriv(uint sampler, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetSamplerParameteriv"))(sampler, pname, parameters);
	}

	internal static unsafe void GetShaderInfoLog(uint shader, int bufSize, int* length, char* infoLog) {
		((delegate* unmanaged<uint, int, int*, char*, void>) Context.GetProcAddress("glGetShaderInfoLog"))(shader, bufSize, length, infoLog);
	}

	internal static unsafe void GetShaderPrecisionFormat(uint shadertype, uint precisiontype, int* range, int* precision) {
		((delegate* unmanaged<uint, uint, int*, int*, void>) Context.GetProcAddress("glGetShaderPrecisionFormat"))(shadertype, precisiontype, range, precision);
	}

	internal static unsafe void GetShaderSource(uint shader, int bufSize, int* length, char* source) {
		((delegate* unmanaged<uint, int, int*, char*, void>) Context.GetProcAddress("glGetShaderSource"))(shader, bufSize, length, source);
	}

	internal static unsafe void GetShaderSourceARB(uint obj, int maxLength, int* length, char* source) {
		((delegate* unmanaged<uint, int, int*, char*, void>) Context.GetProcAddress("glGetShaderSourceARB"))(obj, maxLength, length, source);
	}

	internal static unsafe void GetShaderiv(uint shader, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetShaderiv"))(shader, pname, parameters);
	}

	internal static unsafe byte* GetString(uint name) {
		return ((delegate* unmanaged<uint, byte*>) Context.GetProcAddress("glGetString"))(name);
	}

	internal static unsafe byte* GetStringi(uint name, uint index) {
		return ((delegate* unmanaged<uint, uint, byte*>) Context.GetProcAddress("glGetStringi"))(name, index);
	}

	internal static unsafe uint GetSubroutineIndex(uint program, uint shadertype, char* name) {
		return ((delegate* unmanaged<uint, uint, char*, uint>) Context.GetProcAddress("glGetSubroutineIndex"))(program, shadertype, name);
	}

	internal static unsafe int GetSubroutineUniformLocation(uint program, uint shadertype, char* name) {
		return ((delegate* unmanaged<uint, uint, char*, int>) Context.GetProcAddress("glGetSubroutineUniformLocation"))(program, shadertype, name);
	}

	internal static unsafe void GetSynciv(GLSync sync, uint pname, int count, int* length, int* values) {
		((delegate* unmanaged<GLSync, uint, int, int*, int*, void>) Context.GetProcAddress("glGetSynciv"))(sync, pname, count, length, values);
	}

	internal static unsafe void GetTexEnvxvOES(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetTexEnvxvOES"))(target, pname, parameters);
	}

	internal static unsafe void GetTexGenxvOES(uint coord, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetTexGenxvOES"))(coord, pname, parameters);
	}

	internal static unsafe void GetTexImage(uint target, int level, uint format, uint type, void* pixels) {
		((delegate* unmanaged<uint, int, uint, uint, void*, void>) Context.GetProcAddress("glGetTexImage"))(target, level, format, type, pixels);
	}

	internal static unsafe void GetTexLevelParameterfv(uint target, int level, uint pname, float* parameters) {
		((delegate* unmanaged<uint, int, uint, float*, void>) Context.GetProcAddress("glGetTexLevelParameterfv"))(target, level, pname, parameters);
	}

	internal static unsafe void GetTexLevelParameteriv(uint target, int level, uint pname, int* parameters) {
		((delegate* unmanaged<uint, int, uint, int*, void>) Context.GetProcAddress("glGetTexLevelParameteriv"))(target, level, pname, parameters);
	}

	internal static unsafe void GetTexLevelParameterxvOES(uint target, int level, uint pname, int* parameters) {
		((delegate* unmanaged<uint, int, uint, int*, void>) Context.GetProcAddress("glGetTexLevelParameterxvOES"))(target, level, pname, parameters);
	}

	internal static unsafe void GetTexParameterIiv(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetTexParameterIiv"))(target, pname, parameters);
	}

	internal static unsafe void GetTexParameterIuiv(uint target, uint pname, uint* parameters) {
		((delegate* unmanaged<uint, uint, uint*, void>) Context.GetProcAddress("glGetTexParameterIuiv"))(target, pname, parameters);
	}

	internal static unsafe void GetTexParameterfv(uint target, uint pname, float* parameters) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glGetTexParameterfv"))(target, pname, parameters);
	}

	internal static unsafe void GetTexParameteriv(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetTexParameteriv"))(target, pname, parameters);
	}

	internal static unsafe void GetTexParameterxvOES(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetTexParameterxvOES"))(target, pname, parameters);
	}

	internal static unsafe void GetTextureImage(uint texture, int level, uint format, uint type, int bufSize, void* pixels) {
		((delegate* unmanaged<uint, int, uint, uint, int, void*, void>) Context.GetProcAddress("glGetTextureImage"))(texture, level, format, type, bufSize, pixels);
	}

	internal static unsafe void GetTextureLevelParameterfv(uint texture, int level, uint pname, float* parameters) {
		((delegate* unmanaged<uint, int, uint, float*, void>) Context.GetProcAddress("glGetTextureLevelParameterfv"))(texture, level, pname, parameters);
	}

	internal static unsafe void GetTextureLevelParameteriv(uint texture, int level, uint pname, int* parameters) {
		((delegate* unmanaged<uint, int, uint, int*, void>) Context.GetProcAddress("glGetTextureLevelParameteriv"))(texture, level, pname, parameters);
	}

	internal static unsafe void GetTextureParameterIiv(uint texture, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetTextureParameterIiv"))(texture, pname, parameters);
	}

	internal static unsafe void GetTextureParameterIuiv(uint texture, uint pname, uint* parameters) {
		((delegate* unmanaged<uint, uint, uint*, void>) Context.GetProcAddress("glGetTextureParameterIuiv"))(texture, pname, parameters);
	}

	internal static unsafe void GetTextureParameterfv(uint texture, uint pname, float* parameters) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glGetTextureParameterfv"))(texture, pname, parameters);
	}

	internal static unsafe void GetTextureParameteriv(uint texture, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetTextureParameteriv"))(texture, pname, parameters);
	}

	internal static unsafe void GetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int bufSize, void* pixels) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, int, uint, uint, int, void*, void>) Context.GetProcAddress("glGetTextureSubImage"))(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);
	}

	internal static unsafe void GetTransformFeedbackVarying(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name) {
		((delegate* unmanaged<uint, uint, int, int*, int*, uint*, char*, void>) Context.GetProcAddress("glGetTransformFeedbackVarying"))(program, index, bufSize, length, size, type, name);
	}

	internal static unsafe void GetTransformFeedbacki64_v(uint xfb, uint pname, uint index, nint* param) {
		((delegate* unmanaged<uint, uint, uint, nint*, void>) Context.GetProcAddress("glGetTransformFeedbacki64_v"))(xfb, pname, index, param);
	}

	internal static unsafe void GetTransformFeedbacki_v(uint xfb, uint pname, uint index, int* param) {
		((delegate* unmanaged<uint, uint, uint, int*, void>) Context.GetProcAddress("glGetTransformFeedbacki_v"))(xfb, pname, index, param);
	}

	internal static unsafe void GetTransformFeedbackiv(uint xfb, uint pname, int* param) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetTransformFeedbackiv"))(xfb, pname, param);
	}

	internal static unsafe uint GetUniformBlockIndex(uint program, char* uniformBlockName) {
		return ((delegate* unmanaged<uint, char*, uint>) Context.GetProcAddress("glGetUniformBlockIndex"))(program, uniformBlockName);
	}

	internal static unsafe void GetUniformIndices(uint program, int uniformCount, char** uniformNames, uint* uniformIndices) {
		((delegate* unmanaged<uint, int, char**, uint*, void>) Context.GetProcAddress("glGetUniformIndices"))(program, uniformCount, uniformNames, uniformIndices);
	}

	internal static unsafe int GetUniformLocation(uint program, char* name) {
		return ((delegate* unmanaged<uint, char*, int>) Context.GetProcAddress("glGetUniformLocation"))(program, name);
	}

	internal static unsafe int GetUniformLocationARB(uint programObj, char* name) {
		return ((delegate* unmanaged<uint, char*, int>) Context.GetProcAddress("glGetUniformLocationARB"))(programObj, name);
	}

	internal static unsafe void GetUniformSubroutineuiv(uint shadertype, int location, uint* parameters) {
		((delegate* unmanaged<uint, int, uint*, void>) Context.GetProcAddress("glGetUniformSubroutineuiv"))(shadertype, location, parameters);
	}

	internal static unsafe void GetUniformdv(uint program, int location, double* parameters) {
		((delegate* unmanaged<uint, int, double*, void>) Context.GetProcAddress("glGetUniformdv"))(program, location, parameters);
	}

	internal static unsafe void GetUniformfv(uint program, int location, float* parameters) {
		((delegate* unmanaged<uint, int, float*, void>) Context.GetProcAddress("glGetUniformfv"))(program, location, parameters);
	}

	internal static unsafe void GetUniformfvARB(uint programObj, int location, float* parameters) {
		((delegate* unmanaged<uint, int, float*, void>) Context.GetProcAddress("glGetUniformfvARB"))(programObj, location, parameters);
	}

	internal static unsafe void GetUniformi64vARB(uint program, int location, nint* parameters) {
		((delegate* unmanaged<uint, int, nint*, void>) Context.GetProcAddress("glGetUniformi64vARB"))(program, location, parameters);
	}

	internal static unsafe void GetUniformiv(uint program, int location, int* parameters) {
		((delegate* unmanaged<uint, int, int*, void>) Context.GetProcAddress("glGetUniformiv"))(program, location, parameters);
	}

	internal static unsafe void GetUniformivARB(uint programObj, int location, int* parameters) {
		((delegate* unmanaged<uint, int, int*, void>) Context.GetProcAddress("glGetUniformivARB"))(programObj, location, parameters);
	}

	internal static unsafe void GetUniformui64vARB(uint program, int location, nint* parameters) {
		((delegate* unmanaged<uint, int, nint*, void>) Context.GetProcAddress("glGetUniformui64vARB"))(program, location, parameters);
	}

	internal static unsafe void GetUniformuiv(uint program, int location, uint* parameters) {
		((delegate* unmanaged<uint, int, uint*, void>) Context.GetProcAddress("glGetUniformuiv"))(program, location, parameters);
	}

	internal static unsafe void GetVertexArrayIndexed64iv(uint vaobj, uint index, uint pname, nint* param) {
		((delegate* unmanaged<uint, uint, uint, nint*, void>) Context.GetProcAddress("glGetVertexArrayIndexed64iv"))(vaobj, index, pname, param);
	}

	internal static unsafe void GetVertexArrayIndexediv(uint vaobj, uint index, uint pname, int* param) {
		((delegate* unmanaged<uint, uint, uint, int*, void>) Context.GetProcAddress("glGetVertexArrayIndexediv"))(vaobj, index, pname, param);
	}

	internal static unsafe void GetVertexArrayiv(uint vaobj, uint pname, int* param) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetVertexArrayiv"))(vaobj, pname, param);
	}

	internal static unsafe void GetVertexAttribIiv(uint index, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetVertexAttribIiv"))(index, pname, parameters);
	}

	internal static unsafe void GetVertexAttribIuiv(uint index, uint pname, uint* parameters) {
		((delegate* unmanaged<uint, uint, uint*, void>) Context.GetProcAddress("glGetVertexAttribIuiv"))(index, pname, parameters);
	}

	internal static unsafe void GetVertexAttribLdv(uint index, uint pname, double* parameters) {
		((delegate* unmanaged<uint, uint, double*, void>) Context.GetProcAddress("glGetVertexAttribLdv"))(index, pname, parameters);
	}

	internal static unsafe void GetVertexAttribPointerv(uint index, uint pname, void** pointer) {
		((delegate* unmanaged<uint, uint, void**, void>) Context.GetProcAddress("glGetVertexAttribPointerv"))(index, pname, pointer);
	}

	internal static unsafe void GetVertexAttribPointervARB(uint index, uint pname, void** pointer) {
		((delegate* unmanaged<uint, uint, void**, void>) Context.GetProcAddress("glGetVertexAttribPointervARB"))(index, pname, pointer);
	}

	internal static unsafe void GetVertexAttribdv(uint index, uint pname, double* parameters) {
		((delegate* unmanaged<uint, uint, double*, void>) Context.GetProcAddress("glGetVertexAttribdv"))(index, pname, parameters);
	}

	internal static unsafe void GetVertexAttribdvARB(uint index, uint pname, double* parameters) {
		((delegate* unmanaged<uint, uint, double*, void>) Context.GetProcAddress("glGetVertexAttribdvARB"))(index, pname, parameters);
	}

	internal static unsafe void GetVertexAttribfv(uint index, uint pname, float* parameters) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glGetVertexAttribfv"))(index, pname, parameters);
	}

	internal static unsafe void GetVertexAttribfvARB(uint index, uint pname, float* parameters) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glGetVertexAttribfvARB"))(index, pname, parameters);
	}

	internal static unsafe void GetVertexAttribiv(uint index, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetVertexAttribiv"))(index, pname, parameters);
	}

	internal static unsafe void GetVertexAttribivARB(uint index, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetVertexAttribivARB"))(index, pname, parameters);
	}

	internal static unsafe void GetnUniformi64vARB(uint program, int location, int bufSize, nint* parameters) {
		((delegate* unmanaged<uint, int, int, nint*, void>) Context.GetProcAddress("glGetnUniformi64vARB"))(program, location, bufSize, parameters);
	}

	internal static unsafe void GetnUniformui64vARB(uint program, int location, int bufSize, nint* parameters) {
		((delegate* unmanaged<uint, int, int, nint*, void>) Context.GetProcAddress("glGetnUniformui64vARB"))(program, location, bufSize, parameters);
	}

	internal static unsafe void Hint(uint target, uint mode) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glHint"))(target, mode);
	}

	internal static unsafe void IndexxOES(int component) {
		((delegate* unmanaged<int, void>) Context.GetProcAddress("glIndexxOES"))(component);
	}

	internal static unsafe void IndexxvOES(int* component) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glIndexxvOES"))(component);
	}

	internal static unsafe void InvalidateBufferData(uint buffer) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glInvalidateBufferData"))(buffer);
	}

	internal static unsafe void InvalidateBufferSubData(uint buffer, int* offset, nint length) {
		((delegate* unmanaged<uint, int*, nint, void>) Context.GetProcAddress("glInvalidateBufferSubData"))(buffer, offset, length);
	}

	internal static unsafe void InvalidateFramebuffer(uint target, int numAttachments, uint* attachments) {
		((delegate* unmanaged<uint, int, uint*, void>) Context.GetProcAddress("glInvalidateFramebuffer"))(target, numAttachments, attachments);
	}

	internal static unsafe void InvalidateNamedFramebufferData(uint framebuffer, int numAttachments, uint* attachments) {
		((delegate* unmanaged<uint, int, uint*, void>) Context.GetProcAddress("glInvalidateNamedFramebufferData"))(framebuffer, numAttachments, attachments);
	}

	internal static unsafe void InvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, uint* attachments, int x, int y, int width, int height) {
		((delegate* unmanaged<uint, int, uint*, int, int, int, int, void>) Context.GetProcAddress("glInvalidateNamedFramebufferSubData"))(framebuffer, numAttachments, attachments, x, y, width, height);
	}

	internal static unsafe void InvalidateSubFramebuffer(uint target, int numAttachments, uint* attachments, int x, int y, int width, int height) {
		((delegate* unmanaged<uint, int, uint*, int, int, int, int, void>) Context.GetProcAddress("glInvalidateSubFramebuffer"))(target, numAttachments, attachments, x, y, width, height);
	}

	internal static unsafe void InvalidateTexImage(uint texture, int level) {
		((delegate* unmanaged<uint, int, void>) Context.GetProcAddress("glInvalidateTexImage"))(texture, level);
	}

	internal static unsafe void InvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, int, void>) Context.GetProcAddress("glInvalidateTexSubImage"))(texture, level, xoffset, yoffset, zoffset, width, height, depth);
	}

	internal static unsafe byte IsBuffer(uint buffer) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsBuffer"))(buffer);
	}

	internal static unsafe byte IsBufferARB(uint buffer) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsBufferARB"))(buffer);
	}

	internal static unsafe byte IsEnabled(uint cap) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsEnabled"))(cap);
	}

	internal static unsafe byte IsEnabledi(uint target, uint index) {
		return ((delegate* unmanaged<uint, uint, byte>) Context.GetProcAddress("glIsEnabledi"))(target, index);
	}

	internal static unsafe byte IsFramebuffer(uint framebuffer) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsFramebuffer"))(framebuffer);
	}

	internal static unsafe byte IsFramebufferEXT(uint framebuffer) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsFramebufferEXT"))(framebuffer);
	}

	internal static unsafe byte IsNamedStringARB(int namelen, char* name) {
		return ((delegate* unmanaged<int, char*, byte>) Context.GetProcAddress("glIsNamedStringARB"))(namelen, name);
	}

	internal static unsafe byte IsProgram(uint program) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsProgram"))(program);
	}

	internal static unsafe byte IsProgramARB(uint program) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsProgramARB"))(program);
	}

	internal static unsafe byte IsProgramPipeline(uint pipeline) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsProgramPipeline"))(pipeline);
	}

	internal static unsafe byte IsQuery(uint id) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsQuery"))(id);
	}

	internal static unsafe byte IsQueryARB(uint id) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsQueryARB"))(id);
	}

	internal static unsafe byte IsRenderbuffer(uint renderbuffer) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsRenderbuffer"))(renderbuffer);
	}

	internal static unsafe byte IsRenderbufferEXT(uint renderbuffer) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsRenderbufferEXT"))(renderbuffer);
	}

	internal static unsafe byte IsSampler(uint sampler) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsSampler"))(sampler);
	}

	internal static unsafe byte IsShader(uint shader) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsShader"))(shader);
	}

	internal static unsafe byte IsSync(GLSync sync) {
		return ((delegate* unmanaged<GLSync, byte>) Context.GetProcAddress("glIsSync"))(sync);
	}

	internal static unsafe byte IsTexture(uint texture) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsTexture"))(texture);
	}

	internal static unsafe byte IsTransformFeedback(uint id) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsTransformFeedback"))(id);
	}

	internal static unsafe byte IsVertexArray(uint array) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsVertexArray"))(array);
	}

	internal static unsafe void LightModelxOES(uint pname, int param) {
		((delegate* unmanaged<uint, int, void>) Context.GetProcAddress("glLightModelxOES"))(pname, param);
	}

	internal static unsafe void LightModelxvOES(uint pname, int* param) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glLightModelxvOES"))(pname, param);
	}

	internal static unsafe void LightxOES(uint light, uint pname, int param) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glLightxOES"))(light, pname, param);
	}

	internal static unsafe void LightxvOES(uint light, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glLightxvOES"))(light, pname, parameters);
	}

	internal static unsafe void LineWidth(float width) {
		((delegate* unmanaged<float, void>) Context.GetProcAddress("glLineWidth"))(width);
	}

	internal static unsafe void LineWidthxOES(int width) {
		((delegate* unmanaged<int, void>) Context.GetProcAddress("glLineWidthxOES"))(width);
	}

	internal static unsafe void LinkProgram(uint program) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glLinkProgram"))(program);
	}

	internal static unsafe void LinkProgramARB(uint programObj) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glLinkProgramARB"))(programObj);
	}

	internal static unsafe void LoadMatrixxOES(int* m) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glLoadMatrixxOES"))(m);
	}

	internal static unsafe void LoadTransposeMatrixdARB(double* m) {
		((delegate* unmanaged<double*, void>) Context.GetProcAddress("glLoadTransposeMatrixdARB"))(m);
	}

	internal static unsafe void LoadTransposeMatrixfARB(float* m) {
		((delegate* unmanaged<float*, void>) Context.GetProcAddress("glLoadTransposeMatrixfARB"))(m);
	}

	internal static unsafe void LoadTransposeMatrixxOES(int* m) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glLoadTransposeMatrixxOES"))(m);
	}

	internal static unsafe void LogicOp(uint opcode) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glLogicOp"))(opcode);
	}

	internal static unsafe void Map1xOES(uint target, int u1, int u2, int stride, int order, int points) {
		((delegate* unmanaged<uint, int, int, int, int, int, void>) Context.GetProcAddress("glMap1xOES"))(target, u1, u2, stride, order, points);
	}

	internal static unsafe void Map2xOES(uint target, int u1, int u2, int ustride, int uorder, int v1, int v2, int vstride, int vorder, int points) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, int, int, int, void>) Context.GetProcAddress("glMap2xOES"))(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
	}

	internal static unsafe void* MapBuffer(uint target, uint access) {
		return ((delegate* unmanaged<uint, uint, void*>) Context.GetProcAddress("glMapBuffer"))(target, access);
	}

	internal static unsafe void* MapBufferARB(uint target, uint access) {
		return ((delegate* unmanaged<uint, uint, void*>) Context.GetProcAddress("glMapBufferARB"))(target, access);
	}

	internal static unsafe void* MapBufferRange(uint target, int* offset, nint length, uint access) {
		return ((delegate* unmanaged<uint, int*, nint, uint, void*>) Context.GetProcAddress("glMapBufferRange"))(target, offset, length, access);
	}

	internal static unsafe void MapGrid1xOES(int n, int u1, int u2) {
		((delegate* unmanaged<int, int, int, void>) Context.GetProcAddress("glMapGrid1xOES"))(n, u1, u2);
	}

	internal static unsafe void MapGrid2xOES(int n, int u1, int u2, int v1, int v2) {
		((delegate* unmanaged<int, int, int, int, int, void>) Context.GetProcAddress("glMapGrid2xOES"))(n, u1, u2, v1, v2);
	}

	internal static unsafe void* MapNamedBuffer(uint buffer, uint access) {
		return ((delegate* unmanaged<uint, uint, void*>) Context.GetProcAddress("glMapNamedBuffer"))(buffer, access);
	}

	internal static unsafe void* MapNamedBufferRange(uint buffer, int* offset, nint length, uint access) {
		return ((delegate* unmanaged<uint, int*, nint, uint, void*>) Context.GetProcAddress("glMapNamedBufferRange"))(buffer, offset, length, access);
	}

	internal static unsafe void MaterialxOES(uint face, uint pname, int param) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glMaterialxOES"))(face, pname, param);
	}

	internal static unsafe void MaterialxvOES(uint face, uint pname, int* param) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glMaterialxvOES"))(face, pname, param);
	}

	internal static unsafe void MemoryBarrier(uint barriers) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glMemoryBarrier"))(barriers);
	}

	internal static unsafe void MemoryBarrierByRegion(uint barriers) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glMemoryBarrierByRegion"))(barriers);
	}

	internal static unsafe void MinSampleShading(float value) {
		((delegate* unmanaged<float, void>) Context.GetProcAddress("glMinSampleShading"))(value);
	}

	internal static unsafe void MinSampleShadingARB(float value) {
		((delegate* unmanaged<float, void>) Context.GetProcAddress("glMinSampleShadingARB"))(value);
	}

	internal static unsafe void MultMatrixxOES(int* m) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glMultMatrixxOES"))(m);
	}

	internal static unsafe void MultTransposeMatrixdARB(double* m) {
		((delegate* unmanaged<double*, void>) Context.GetProcAddress("glMultTransposeMatrixdARB"))(m);
	}

	internal static unsafe void MultTransposeMatrixfARB(float* m) {
		((delegate* unmanaged<float*, void>) Context.GetProcAddress("glMultTransposeMatrixfARB"))(m);
	}

	internal static unsafe void MultTransposeMatrixxOES(int* m) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glMultTransposeMatrixxOES"))(m);
	}

	internal static unsafe void MultiDrawArrays(uint mode, int* first, int* count, int drawcount) {
		((delegate* unmanaged<uint, int*, int*, int, void>) Context.GetProcAddress("glMultiDrawArrays"))(mode, first, count, drawcount);
	}

	internal static unsafe void MultiDrawArraysIndirect(uint mode, void* indirect, int drawcount, int stride) {
		((delegate* unmanaged<uint, void*, int, int, void>) Context.GetProcAddress("glMultiDrawArraysIndirect"))(mode, indirect, drawcount, stride);
	}

	internal static unsafe void MultiDrawElements(uint mode, int* count, uint type, void** indices, int drawcount) {
		((delegate* unmanaged<uint, int*, uint, void**, int, void>) Context.GetProcAddress("glMultiDrawElements"))(mode, count, type, indices, drawcount);
	}

	internal static unsafe void MultiDrawElementsBaseVertex(uint mode, int* count, uint type, void** indices, int drawcount, int* basevertex) {
		((delegate* unmanaged<uint, int*, uint, void**, int, int*, void>) Context.GetProcAddress("glMultiDrawElementsBaseVertex"))(mode, count, type, indices, drawcount, basevertex);
	}

	internal static unsafe void MultiDrawElementsIndirect(uint mode, uint type, void* indirect, int drawcount, int stride) {
		((delegate* unmanaged<uint, uint, void*, int, int, void>) Context.GetProcAddress("glMultiDrawElementsIndirect"))(mode, type, indirect, drawcount, stride);
	}

	internal static unsafe void MultiTexCoord1dARB(uint target, double s) {
		((delegate* unmanaged<uint, double, void>) Context.GetProcAddress("glMultiTexCoord1dARB"))(target, s);
	}

	internal static unsafe void MultiTexCoord1dvARB(uint target, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glMultiTexCoord1dvARB"))(target, v);
	}

	internal static unsafe void MultiTexCoord1fARB(uint target, float s) {
		((delegate* unmanaged<uint, float, void>) Context.GetProcAddress("glMultiTexCoord1fARB"))(target, s);
	}

	internal static unsafe void MultiTexCoord1fvARB(uint target, float* v) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glMultiTexCoord1fvARB"))(target, v);
	}

	internal static unsafe void MultiTexCoord1iARB(uint target, int s) {
		((delegate* unmanaged<uint, int, void>) Context.GetProcAddress("glMultiTexCoord1iARB"))(target, s);
	}

	internal static unsafe void MultiTexCoord1ivARB(uint target, int* v) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glMultiTexCoord1ivARB"))(target, v);
	}

	internal static unsafe void MultiTexCoord1sARB(uint target, short s) {
		((delegate* unmanaged<uint, short, void>) Context.GetProcAddress("glMultiTexCoord1sARB"))(target, s);
	}

	internal static unsafe void MultiTexCoord1svARB(uint target, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glMultiTexCoord1svARB"))(target, v);
	}

	internal static unsafe void MultiTexCoord1xOES(uint texture, int s) {
		((delegate* unmanaged<uint, int, void>) Context.GetProcAddress("glMultiTexCoord1xOES"))(texture, s);
	}

	internal static unsafe void MultiTexCoord1xvOES(uint texture, int* coords) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glMultiTexCoord1xvOES"))(texture, coords);
	}

	internal static unsafe void MultiTexCoord2dARB(uint target, double s, double t) {
		((delegate* unmanaged<uint, double, double, void>) Context.GetProcAddress("glMultiTexCoord2dARB"))(target, s, t);
	}

	internal static unsafe void MultiTexCoord2dvARB(uint target, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glMultiTexCoord2dvARB"))(target, v);
	}

	internal static unsafe void MultiTexCoord2fARB(uint target, float s, float t) {
		((delegate* unmanaged<uint, float, float, void>) Context.GetProcAddress("glMultiTexCoord2fARB"))(target, s, t);
	}

	internal static unsafe void MultiTexCoord2fvARB(uint target, float* v) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glMultiTexCoord2fvARB"))(target, v);
	}

	internal static unsafe void MultiTexCoord2iARB(uint target, int s, int t) {
		((delegate* unmanaged<uint, int, int, void>) Context.GetProcAddress("glMultiTexCoord2iARB"))(target, s, t);
	}

	internal static unsafe void MultiTexCoord2ivARB(uint target, int* v) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glMultiTexCoord2ivARB"))(target, v);
	}

	internal static unsafe void MultiTexCoord2sARB(uint target, short s, short t) {
		((delegate* unmanaged<uint, short, short, void>) Context.GetProcAddress("glMultiTexCoord2sARB"))(target, s, t);
	}

	internal static unsafe void MultiTexCoord2svARB(uint target, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glMultiTexCoord2svARB"))(target, v);
	}

	internal static unsafe void MultiTexCoord2xOES(uint texture, int s, int t) {
		((delegate* unmanaged<uint, int, int, void>) Context.GetProcAddress("glMultiTexCoord2xOES"))(texture, s, t);
	}

	internal static unsafe void MultiTexCoord2xvOES(uint texture, int* coords) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glMultiTexCoord2xvOES"))(texture, coords);
	}

	internal static unsafe void MultiTexCoord3dARB(uint target, double s, double t, double r) {
		((delegate* unmanaged<uint, double, double, double, void>) Context.GetProcAddress("glMultiTexCoord3dARB"))(target, s, t, r);
	}

	internal static unsafe void MultiTexCoord3dvARB(uint target, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glMultiTexCoord3dvARB"))(target, v);
	}

	internal static unsafe void MultiTexCoord3fARB(uint target, float s, float t, float r) {
		((delegate* unmanaged<uint, float, float, float, void>) Context.GetProcAddress("glMultiTexCoord3fARB"))(target, s, t, r);
	}

	internal static unsafe void MultiTexCoord3fvARB(uint target, float* v) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glMultiTexCoord3fvARB"))(target, v);
	}

	internal static unsafe void MultiTexCoord3iARB(uint target, int s, int t, int r) {
		((delegate* unmanaged<uint, int, int, int, void>) Context.GetProcAddress("glMultiTexCoord3iARB"))(target, s, t, r);
	}

	internal static unsafe void MultiTexCoord3ivARB(uint target, int* v) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glMultiTexCoord3ivARB"))(target, v);
	}

	internal static unsafe void MultiTexCoord3sARB(uint target, short s, short t, short r) {
		((delegate* unmanaged<uint, short, short, short, void>) Context.GetProcAddress("glMultiTexCoord3sARB"))(target, s, t, r);
	}

	internal static unsafe void MultiTexCoord3svARB(uint target, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glMultiTexCoord3svARB"))(target, v);
	}

	internal static unsafe void MultiTexCoord3xOES(uint texture, int s, int t, int r) {
		((delegate* unmanaged<uint, int, int, int, void>) Context.GetProcAddress("glMultiTexCoord3xOES"))(texture, s, t, r);
	}

	internal static unsafe void MultiTexCoord3xvOES(uint texture, int* coords) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glMultiTexCoord3xvOES"))(texture, coords);
	}

	internal static unsafe void MultiTexCoord4dARB(uint target, double s, double t, double r, double q) {
		((delegate* unmanaged<uint, double, double, double, double, void>) Context.GetProcAddress("glMultiTexCoord4dARB"))(target, s, t, r, q);
	}

	internal static unsafe void MultiTexCoord4dvARB(uint target, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glMultiTexCoord4dvARB"))(target, v);
	}

	internal static unsafe void MultiTexCoord4fARB(uint target, float s, float t, float r, float q) {
		((delegate* unmanaged<uint, float, float, float, float, void>) Context.GetProcAddress("glMultiTexCoord4fARB"))(target, s, t, r, q);
	}

	internal static unsafe void MultiTexCoord4fvARB(uint target, float* v) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glMultiTexCoord4fvARB"))(target, v);
	}

	internal static unsafe void MultiTexCoord4iARB(uint target, int s, int t, int r, int q) {
		((delegate* unmanaged<uint, int, int, int, int, void>) Context.GetProcAddress("glMultiTexCoord4iARB"))(target, s, t, r, q);
	}

	internal static unsafe void MultiTexCoord4ivARB(uint target, int* v) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glMultiTexCoord4ivARB"))(target, v);
	}

	internal static unsafe void MultiTexCoord4sARB(uint target, short s, short t, short r, short q) {
		((delegate* unmanaged<uint, short, short, short, short, void>) Context.GetProcAddress("glMultiTexCoord4sARB"))(target, s, t, r, q);
	}

	internal static unsafe void MultiTexCoord4svARB(uint target, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glMultiTexCoord4svARB"))(target, v);
	}

	internal static unsafe void MultiTexCoord4xOES(uint texture, int s, int t, int r, int q) {
		((delegate* unmanaged<uint, int, int, int, int, void>) Context.GetProcAddress("glMultiTexCoord4xOES"))(texture, s, t, r, q);
	}

	internal static unsafe void MultiTexCoord4xvOES(uint texture, int* coords) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glMultiTexCoord4xvOES"))(texture, coords);
	}

	internal static unsafe void NamedBufferData(uint buffer, nint size, void* data, uint usage) {
		((delegate* unmanaged<uint, nint, void*, uint, void>) Context.GetProcAddress("glNamedBufferData"))(buffer, size, data, usage);
	}

	internal static unsafe void NamedBufferStorage(uint buffer, nint size, void* data, uint flags) {
		((delegate* unmanaged<uint, nint, void*, uint, void>) Context.GetProcAddress("glNamedBufferStorage"))(buffer, size, data, flags);
	}

	internal static unsafe void NamedBufferSubData(uint buffer, int* offset, nint size, void* data) {
		((delegate* unmanaged<uint, int*, nint, void*, void>) Context.GetProcAddress("glNamedBufferSubData"))(buffer, offset, size, data);
	}

	internal static unsafe void NamedFramebufferDrawBuffer(uint framebuffer, uint buf) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glNamedFramebufferDrawBuffer"))(framebuffer, buf);
	}

	internal static unsafe void NamedFramebufferDrawBuffers(uint framebuffer, int n, uint* bufs) {
		((delegate* unmanaged<uint, int, uint*, void>) Context.GetProcAddress("glNamedFramebufferDrawBuffers"))(framebuffer, n, bufs);
	}

	internal static unsafe void NamedFramebufferParameteri(uint framebuffer, uint pname, int param) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glNamedFramebufferParameteri"))(framebuffer, pname, param);
	}

	internal static unsafe void NamedFramebufferReadBuffer(uint framebuffer, uint src) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glNamedFramebufferReadBuffer"))(framebuffer, src);
	}

	internal static unsafe void NamedFramebufferRenderbuffer(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer) {
		((delegate* unmanaged<uint, uint, uint, uint, void>) Context.GetProcAddress("glNamedFramebufferRenderbuffer"))(framebuffer, attachment, renderbuffertarget, renderbuffer);
	}

	internal static unsafe void NamedFramebufferSampleLocationsfvARB(uint framebuffer, uint start, int count, float* v) {
		((delegate* unmanaged<uint, uint, int, float*, void>) Context.GetProcAddress("glNamedFramebufferSampleLocationsfvARB"))(framebuffer, start, count, v);
	}

	internal static unsafe void NamedFramebufferTexture(uint framebuffer, uint attachment, uint texture, int level) {
		((delegate* unmanaged<uint, uint, uint, int, void>) Context.GetProcAddress("glNamedFramebufferTexture"))(framebuffer, attachment, texture, level);
	}

	internal static unsafe void NamedFramebufferTextureLayer(uint framebuffer, uint attachment, uint texture, int level, int layer) {
		((delegate* unmanaged<uint, uint, uint, int, int, void>) Context.GetProcAddress("glNamedFramebufferTextureLayer"))(framebuffer, attachment, texture, level, layer);
	}

	internal static unsafe void NamedRenderbufferStorage(uint renderbuffer, uint internalformat, int width, int height) {
		((delegate* unmanaged<uint, uint, int, int, void>) Context.GetProcAddress("glNamedRenderbufferStorage"))(renderbuffer, internalformat, width, height);
	}

	internal static unsafe void NamedRenderbufferStorageMultisample(uint renderbuffer, int samples, uint internalformat, int width, int height) {
		((delegate* unmanaged<uint, int, uint, int, int, void>) Context.GetProcAddress("glNamedRenderbufferStorageMultisample"))(renderbuffer, samples, internalformat, width, height);
	}

	internal static unsafe void NamedStringARB(uint type, int namelen, char* name, int stringlen, char* str) {
		((delegate* unmanaged<uint, int, char*, int, char*, void>) Context.GetProcAddress("glNamedStringARB"))(type, namelen, name, stringlen, str);
	}

	internal static unsafe void Normal3xOES(int nx, int ny, int nz) {
		((delegate* unmanaged<int, int, int, void>) Context.GetProcAddress("glNormal3xOES"))(nx, ny, nz);
	}

	internal static unsafe void Normal3xvOES(int* coords) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glNormal3xvOES"))(coords);
	}

	internal static unsafe void ObjectLabel(uint identifier, uint name, int length, char* label) {
		((delegate* unmanaged<uint, uint, int, char*, void>) Context.GetProcAddress("glObjectLabel"))(identifier, name, length, label);
	}

	internal static unsafe void ObjectPtrLabel(void* ptr, int length, char* label) {
		((delegate* unmanaged<void*, int, char*, void>) Context.GetProcAddress("glObjectPtrLabel"))(ptr, length, label);
	}

	internal static unsafe void OrthoxOES(int l, int r, int b, int t, int n, int f) {
		((delegate* unmanaged<int, int, int, int, int, int, void>) Context.GetProcAddress("glOrthoxOES"))(l, r, b, t, n, f);
	}

	internal static unsafe void PassThroughxOES(int token) {
		((delegate* unmanaged<int, void>) Context.GetProcAddress("glPassThroughxOES"))(token);
	}

	internal static unsafe void PatchParameterfv(uint pname, float* values) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glPatchParameterfv"))(pname, values);
	}

	internal static unsafe void PatchParameteri(uint pname, int value) {
		((delegate* unmanaged<uint, int, void>) Context.GetProcAddress("glPatchParameteri"))(pname, value);
	}

	internal static unsafe void PauseTransformFeedback() {
	((delegate* unmanaged<void>) Context.GetProcAddress("glPauseTransformFeedback"))();
	}

	internal static unsafe void PixelMapx(uint map, int size, int* values) {
		((delegate* unmanaged<uint, int, int*, void>) Context.GetProcAddress("glPixelMapx"))(map, size, values);
	}

	internal static unsafe void PixelStoref(uint pname, float param) {
		((delegate* unmanaged<uint, float, void>) Context.GetProcAddress("glPixelStoref"))(pname, param);
	}

	internal static unsafe void PixelStorei(uint pname, int param) {
		((delegate* unmanaged<uint, int, void>) Context.GetProcAddress("glPixelStorei"))(pname, param);
	}

	internal static unsafe void PixelStorex(uint pname, int param) {
		((delegate* unmanaged<uint, int, void>) Context.GetProcAddress("glPixelStorex"))(pname, param);
	}

	internal static unsafe void PixelTransferxOES(uint pname, int param) {
		((delegate* unmanaged<uint, int, void>) Context.GetProcAddress("glPixelTransferxOES"))(pname, param);
	}

	internal static unsafe void PixelZoomxOES(int xfactor, int yfactor) {
		((delegate* unmanaged<int, int, void>) Context.GetProcAddress("glPixelZoomxOES"))(xfactor, yfactor);
	}

	internal static unsafe void PointParameterf(uint pname, float param) {
		((delegate* unmanaged<uint, float, void>) Context.GetProcAddress("glPointParameterf"))(pname, param);
	}

	internal static unsafe void PointParameterfv(uint pname, float* parameters) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glPointParameterfv"))(pname, parameters);
	}

	internal static unsafe void PointParameteri(uint pname, int param) {
		((delegate* unmanaged<uint, int, void>) Context.GetProcAddress("glPointParameteri"))(pname, param);
	}

	internal static unsafe void PointParameteriv(uint pname, int* parameters) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glPointParameteriv"))(pname, parameters);
	}

	internal static unsafe void PointParameterxvOES(uint pname, int* parameters) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glPointParameterxvOES"))(pname, parameters);
	}

	internal static unsafe void PointSize(float size) {
		((delegate* unmanaged<float, void>) Context.GetProcAddress("glPointSize"))(size);
	}

	internal static unsafe void PointSizexOES(int size) {
		((delegate* unmanaged<int, void>) Context.GetProcAddress("glPointSizexOES"))(size);
	}

	internal static unsafe void PolygonMode(uint face, uint mode) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glPolygonMode"))(face, mode);
	}

	internal static unsafe void PolygonOffset(float factor, float units) {
		((delegate* unmanaged<float, float, void>) Context.GetProcAddress("glPolygonOffset"))(factor, units);
	}

	internal static unsafe void PolygonOffsetxOES(int factor, int units) {
		((delegate* unmanaged<int, int, void>) Context.GetProcAddress("glPolygonOffsetxOES"))(factor, units);
	}

	internal static unsafe void PopDebugGroup() {
	((delegate* unmanaged<void>) Context.GetProcAddress("glPopDebugGroup"))();
	}

	internal static unsafe void PrimitiveBoundingBoxARB(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW) {
		((delegate* unmanaged<float, float, float, float, float, float, float, float, void>) Context.GetProcAddress("glPrimitiveBoundingBoxARB"))(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
	}

	internal static unsafe void PrimitiveRestartIndex(uint index) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glPrimitiveRestartIndex"))(index);
	}

	internal static unsafe void PrioritizeTexturesxOES(int n, uint* textures, int* priorities) {
		((delegate* unmanaged<int, uint*, int*, void>) Context.GetProcAddress("glPrioritizeTexturesxOES"))(n, textures, priorities);
	}

	internal static unsafe void ProgramBinary(uint program, uint binaryFormat, void* binary, int length) {
		((delegate* unmanaged<uint, uint, void*, int, void>) Context.GetProcAddress("glProgramBinary"))(program, binaryFormat, binary, length);
	}

	internal static unsafe void ProgramEnvParameter4dARB(uint target, uint index, double x, double y, double z, double w) {
		((delegate* unmanaged<uint, uint, double, double, double, double, void>) Context.GetProcAddress("glProgramEnvParameter4dARB"))(target, index, x, y, z, w);
	}

	internal static unsafe void ProgramEnvParameter4dvARB(uint target, uint index, double* parameters) {
		((delegate* unmanaged<uint, uint, double*, void>) Context.GetProcAddress("glProgramEnvParameter4dvARB"))(target, index, parameters);
	}

	internal static unsafe void ProgramEnvParameter4fARB(uint target, uint index, float x, float y, float z, float w) {
		((delegate* unmanaged<uint, uint, float, float, float, float, void>) Context.GetProcAddress("glProgramEnvParameter4fARB"))(target, index, x, y, z, w);
	}

	internal static unsafe void ProgramEnvParameter4fvARB(uint target, uint index, float* parameters) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glProgramEnvParameter4fvARB"))(target, index, parameters);
	}

	internal static unsafe void ProgramLocalParameter4dARB(uint target, uint index, double x, double y, double z, double w) {
		((delegate* unmanaged<uint, uint, double, double, double, double, void>) Context.GetProcAddress("glProgramLocalParameter4dARB"))(target, index, x, y, z, w);
	}

	internal static unsafe void ProgramLocalParameter4dvARB(uint target, uint index, double* parameters) {
		((delegate* unmanaged<uint, uint, double*, void>) Context.GetProcAddress("glProgramLocalParameter4dvARB"))(target, index, parameters);
	}

	internal static unsafe void ProgramLocalParameter4fARB(uint target, uint index, float x, float y, float z, float w) {
		((delegate* unmanaged<uint, uint, float, float, float, float, void>) Context.GetProcAddress("glProgramLocalParameter4fARB"))(target, index, x, y, z, w);
	}

	internal static unsafe void ProgramLocalParameter4fvARB(uint target, uint index, float* parameters) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glProgramLocalParameter4fvARB"))(target, index, parameters);
	}

	internal static unsafe void ProgramParameteri(uint program, uint pname, int value) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glProgramParameteri"))(program, pname, value);
	}

	internal static unsafe void ProgramParameteriARB(uint program, uint pname, int value) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glProgramParameteriARB"))(program, pname, value);
	}

	internal static unsafe void ProgramStringARB(uint target, uint format, int len, void* str) {
		((delegate* unmanaged<uint, uint, int, void*, void>) Context.GetProcAddress("glProgramStringARB"))(target, format, len, str);
	}

	internal static unsafe void ProgramUniform1d(uint program, int location, double v0) {
		((delegate* unmanaged<uint, int, double, void>) Context.GetProcAddress("glProgramUniform1d"))(program, location, v0);
	}

	internal static unsafe void ProgramUniform1dv(uint program, int location, int count, double* value) {
		((delegate* unmanaged<uint, int, int, double*, void>) Context.GetProcAddress("glProgramUniform1dv"))(program, location, count, value);
	}

	internal static unsafe void ProgramUniform1f(uint program, int location, float v0) {
		((delegate* unmanaged<uint, int, float, void>) Context.GetProcAddress("glProgramUniform1f"))(program, location, v0);
	}

	internal static unsafe void ProgramUniform1fv(uint program, int location, int count, float* value) {
		((delegate* unmanaged<uint, int, int, float*, void>) Context.GetProcAddress("glProgramUniform1fv"))(program, location, count, value);
	}

	internal static unsafe void ProgramUniform1i(uint program, int location, int v0) {
		((delegate* unmanaged<uint, int, int, void>) Context.GetProcAddress("glProgramUniform1i"))(program, location, v0);
	}

	internal static unsafe void ProgramUniform1i64ARB(uint program, int location, nint x) {
		((delegate* unmanaged<uint, int, nint, void>) Context.GetProcAddress("glProgramUniform1i64ARB"))(program, location, x);
	}

	internal static unsafe void ProgramUniform1i64vARB(uint program, int location, int count, nint* value) {
		((delegate* unmanaged<uint, int, int, nint*, void>) Context.GetProcAddress("glProgramUniform1i64vARB"))(program, location, count, value);
	}

	internal static unsafe void ProgramUniform1iv(uint program, int location, int count, int* value) {
		((delegate* unmanaged<uint, int, int, int*, void>) Context.GetProcAddress("glProgramUniform1iv"))(program, location, count, value);
	}

	internal static unsafe void ProgramUniform1ui(uint program, int location, uint v0) {
		((delegate* unmanaged<uint, int, uint, void>) Context.GetProcAddress("glProgramUniform1ui"))(program, location, v0);
	}

	internal static unsafe void ProgramUniform1ui64ARB(uint program, int location, nint x) {
		((delegate* unmanaged<uint, int, nint, void>) Context.GetProcAddress("glProgramUniform1ui64ARB"))(program, location, x);
	}

	internal static unsafe void ProgramUniform1ui64vARB(uint program, int location, int count, nint* value) {
		((delegate* unmanaged<uint, int, int, nint*, void>) Context.GetProcAddress("glProgramUniform1ui64vARB"))(program, location, count, value);
	}

	internal static unsafe void ProgramUniform1uiv(uint program, int location, int count, uint* value) {
		((delegate* unmanaged<uint, int, int, uint*, void>) Context.GetProcAddress("glProgramUniform1uiv"))(program, location, count, value);
	}

	internal static unsafe void ProgramUniform2d(uint program, int location, double v0, double v1) {
		((delegate* unmanaged<uint, int, double, double, void>) Context.GetProcAddress("glProgramUniform2d"))(program, location, v0, v1);
	}

	internal static unsafe void ProgramUniform2dv(uint program, int location, int count, double* value) {
		((delegate* unmanaged<uint, int, int, double*, void>) Context.GetProcAddress("glProgramUniform2dv"))(program, location, count, value);
	}

	internal static unsafe void ProgramUniform2f(uint program, int location, float v0, float v1) {
		((delegate* unmanaged<uint, int, float, float, void>) Context.GetProcAddress("glProgramUniform2f"))(program, location, v0, v1);
	}

	internal static unsafe void ProgramUniform2fv(uint program, int location, int count, float* value) {
		((delegate* unmanaged<uint, int, int, float*, void>) Context.GetProcAddress("glProgramUniform2fv"))(program, location, count, value);
	}

	internal static unsafe void ProgramUniform2i(uint program, int location, int v0, int v1) {
		((delegate* unmanaged<uint, int, int, int, void>) Context.GetProcAddress("glProgramUniform2i"))(program, location, v0, v1);
	}

	internal static unsafe void ProgramUniform2i64ARB(uint program, int location, nint x, nint y) {
		((delegate* unmanaged<uint, int, nint, nint, void>) Context.GetProcAddress("glProgramUniform2i64ARB"))(program, location, x, y);
	}

	internal static unsafe void ProgramUniform2i64vARB(uint program, int location, int count, nint* value) {
		((delegate* unmanaged<uint, int, int, nint*, void>) Context.GetProcAddress("glProgramUniform2i64vARB"))(program, location, count, value);
	}

	internal static unsafe void ProgramUniform2iv(uint program, int location, int count, int* value) {
		((delegate* unmanaged<uint, int, int, int*, void>) Context.GetProcAddress("glProgramUniform2iv"))(program, location, count, value);
	}

	internal static unsafe void ProgramUniform2ui(uint program, int location, uint v0, uint v1) {
		((delegate* unmanaged<uint, int, uint, uint, void>) Context.GetProcAddress("glProgramUniform2ui"))(program, location, v0, v1);
	}

	internal static unsafe void ProgramUniform2ui64ARB(uint program, int location, nint x, nint y) {
		((delegate* unmanaged<uint, int, nint, nint, void>) Context.GetProcAddress("glProgramUniform2ui64ARB"))(program, location, x, y);
	}

	internal static unsafe void ProgramUniform2ui64vARB(uint program, int location, int count, nint* value) {
		((delegate* unmanaged<uint, int, int, nint*, void>) Context.GetProcAddress("glProgramUniform2ui64vARB"))(program, location, count, value);
	}

	internal static unsafe void ProgramUniform2uiv(uint program, int location, int count, uint* value) {
		((delegate* unmanaged<uint, int, int, uint*, void>) Context.GetProcAddress("glProgramUniform2uiv"))(program, location, count, value);
	}

	internal static unsafe void ProgramUniform3d(uint program, int location, double v0, double v1, double v2) {
		((delegate* unmanaged<uint, int, double, double, double, void>) Context.GetProcAddress("glProgramUniform3d"))(program, location, v0, v1, v2);
	}

	internal static unsafe void ProgramUniform3dv(uint program, int location, int count, double* value) {
		((delegate* unmanaged<uint, int, int, double*, void>) Context.GetProcAddress("glProgramUniform3dv"))(program, location, count, value);
	}

	internal static unsafe void ProgramUniform3f(uint program, int location, float v0, float v1, float v2) {
		((delegate* unmanaged<uint, int, float, float, float, void>) Context.GetProcAddress("glProgramUniform3f"))(program, location, v0, v1, v2);
	}

	internal static unsafe void ProgramUniform3fv(uint program, int location, int count, float* value) {
		((delegate* unmanaged<uint, int, int, float*, void>) Context.GetProcAddress("glProgramUniform3fv"))(program, location, count, value);
	}

	internal static unsafe void ProgramUniform3i(uint program, int location, int v0, int v1, int v2) {
		((delegate* unmanaged<uint, int, int, int, int, void>) Context.GetProcAddress("glProgramUniform3i"))(program, location, v0, v1, v2);
	}

	internal static unsafe void ProgramUniform3i64ARB(uint program, int location, nint x, nint y, nint z) {
		((delegate* unmanaged<uint, int, nint, nint, nint, void>) Context.GetProcAddress("glProgramUniform3i64ARB"))(program, location, x, y, z);
	}

	internal static unsafe void ProgramUniform3i64vARB(uint program, int location, int count, nint* value) {
		((delegate* unmanaged<uint, int, int, nint*, void>) Context.GetProcAddress("glProgramUniform3i64vARB"))(program, location, count, value);
	}

	internal static unsafe void ProgramUniform3iv(uint program, int location, int count, int* value) {
		((delegate* unmanaged<uint, int, int, int*, void>) Context.GetProcAddress("glProgramUniform3iv"))(program, location, count, value);
	}

	internal static unsafe void ProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2) {
		((delegate* unmanaged<uint, int, uint, uint, uint, void>) Context.GetProcAddress("glProgramUniform3ui"))(program, location, v0, v1, v2);
	}

	internal static unsafe void ProgramUniform3ui64ARB(uint program, int location, nint x, nint y, nint z) {
		((delegate* unmanaged<uint, int, nint, nint, nint, void>) Context.GetProcAddress("glProgramUniform3ui64ARB"))(program, location, x, y, z);
	}

	internal static unsafe void ProgramUniform3ui64vARB(uint program, int location, int count, nint* value) {
		((delegate* unmanaged<uint, int, int, nint*, void>) Context.GetProcAddress("glProgramUniform3ui64vARB"))(program, location, count, value);
	}

	internal static unsafe void ProgramUniform3uiv(uint program, int location, int count, uint* value) {
		((delegate* unmanaged<uint, int, int, uint*, void>) Context.GetProcAddress("glProgramUniform3uiv"))(program, location, count, value);
	}

	internal static unsafe void ProgramUniform4d(uint program, int location, double v0, double v1, double v2, double v3) {
		((delegate* unmanaged<uint, int, double, double, double, double, void>) Context.GetProcAddress("glProgramUniform4d"))(program, location, v0, v1, v2, v3);
	}

	internal static unsafe void ProgramUniform4dv(uint program, int location, int count, double* value) {
		((delegate* unmanaged<uint, int, int, double*, void>) Context.GetProcAddress("glProgramUniform4dv"))(program, location, count, value);
	}

	internal static unsafe void ProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3) {
		((delegate* unmanaged<uint, int, float, float, float, float, void>) Context.GetProcAddress("glProgramUniform4f"))(program, location, v0, v1, v2, v3);
	}

	internal static unsafe void ProgramUniform4fv(uint program, int location, int count, float* value) {
		((delegate* unmanaged<uint, int, int, float*, void>) Context.GetProcAddress("glProgramUniform4fv"))(program, location, count, value);
	}

	internal static unsafe void ProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3) {
		((delegate* unmanaged<uint, int, int, int, int, int, void>) Context.GetProcAddress("glProgramUniform4i"))(program, location, v0, v1, v2, v3);
	}

	internal static unsafe void ProgramUniform4i64ARB(uint program, int location, nint x, nint y, nint z, nint w) {
		((delegate* unmanaged<uint, int, nint, nint, nint, nint, void>) Context.GetProcAddress("glProgramUniform4i64ARB"))(program, location, x, y, z, w);
	}

	internal static unsafe void ProgramUniform4i64vARB(uint program, int location, int count, nint* value) {
		((delegate* unmanaged<uint, int, int, nint*, void>) Context.GetProcAddress("glProgramUniform4i64vARB"))(program, location, count, value);
	}

	internal static unsafe void ProgramUniform4iv(uint program, int location, int count, int* value) {
		((delegate* unmanaged<uint, int, int, int*, void>) Context.GetProcAddress("glProgramUniform4iv"))(program, location, count, value);
	}

	internal static unsafe void ProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3) {
		((delegate* unmanaged<uint, int, uint, uint, uint, uint, void>) Context.GetProcAddress("glProgramUniform4ui"))(program, location, v0, v1, v2, v3);
	}

	internal static unsafe void ProgramUniform4ui64ARB(uint program, int location, nint x, nint y, nint z, nint w) {
		((delegate* unmanaged<uint, int, nint, nint, nint, nint, void>) Context.GetProcAddress("glProgramUniform4ui64ARB"))(program, location, x, y, z, w);
	}

	internal static unsafe void ProgramUniform4ui64vARB(uint program, int location, int count, nint* value) {
		((delegate* unmanaged<uint, int, int, nint*, void>) Context.GetProcAddress("glProgramUniform4ui64vARB"))(program, location, count, value);
	}

	internal static unsafe void ProgramUniform4uiv(uint program, int location, int count, uint* value) {
		((delegate* unmanaged<uint, int, int, uint*, void>) Context.GetProcAddress("glProgramUniform4uiv"))(program, location, count, value);
	}

	internal static unsafe void ProgramUniformMatrix2dv(uint program, int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<uint, int, int, byte, double*, void>) Context.GetProcAddress("glProgramUniformMatrix2dv"))(program, location, count, transpose, value);
	}

	internal static unsafe void ProgramUniformMatrix2fv(uint program, int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<uint, int, int, byte, float*, void>) Context.GetProcAddress("glProgramUniformMatrix2fv"))(program, location, count, transpose, value);
	}

	internal static unsafe void ProgramUniformMatrix2x3dv(uint program, int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<uint, int, int, byte, double*, void>) Context.GetProcAddress("glProgramUniformMatrix2x3dv"))(program, location, count, transpose, value);
	}

	internal static unsafe void ProgramUniformMatrix2x3fv(uint program, int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<uint, int, int, byte, float*, void>) Context.GetProcAddress("glProgramUniformMatrix2x3fv"))(program, location, count, transpose, value);
	}

	internal static unsafe void ProgramUniformMatrix2x4dv(uint program, int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<uint, int, int, byte, double*, void>) Context.GetProcAddress("glProgramUniformMatrix2x4dv"))(program, location, count, transpose, value);
	}

	internal static unsafe void ProgramUniformMatrix2x4fv(uint program, int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<uint, int, int, byte, float*, void>) Context.GetProcAddress("glProgramUniformMatrix2x4fv"))(program, location, count, transpose, value);
	}

	internal static unsafe void ProgramUniformMatrix3dv(uint program, int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<uint, int, int, byte, double*, void>) Context.GetProcAddress("glProgramUniformMatrix3dv"))(program, location, count, transpose, value);
	}

	internal static unsafe void ProgramUniformMatrix3fv(uint program, int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<uint, int, int, byte, float*, void>) Context.GetProcAddress("glProgramUniformMatrix3fv"))(program, location, count, transpose, value);
	}

	internal static unsafe void ProgramUniformMatrix3x2dv(uint program, int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<uint, int, int, byte, double*, void>) Context.GetProcAddress("glProgramUniformMatrix3x2dv"))(program, location, count, transpose, value);
	}

	internal static unsafe void ProgramUniformMatrix3x2fv(uint program, int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<uint, int, int, byte, float*, void>) Context.GetProcAddress("glProgramUniformMatrix3x2fv"))(program, location, count, transpose, value);
	}

	internal static unsafe void ProgramUniformMatrix3x4dv(uint program, int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<uint, int, int, byte, double*, void>) Context.GetProcAddress("glProgramUniformMatrix3x4dv"))(program, location, count, transpose, value);
	}

	internal static unsafe void ProgramUniformMatrix3x4fv(uint program, int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<uint, int, int, byte, float*, void>) Context.GetProcAddress("glProgramUniformMatrix3x4fv"))(program, location, count, transpose, value);
	}

	internal static unsafe void ProgramUniformMatrix4dv(uint program, int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<uint, int, int, byte, double*, void>) Context.GetProcAddress("glProgramUniformMatrix4dv"))(program, location, count, transpose, value);
	}

	internal static unsafe void ProgramUniformMatrix4fv(uint program, int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<uint, int, int, byte, float*, void>) Context.GetProcAddress("glProgramUniformMatrix4fv"))(program, location, count, transpose, value);
	}

	internal static unsafe void ProgramUniformMatrix4x2dv(uint program, int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<uint, int, int, byte, double*, void>) Context.GetProcAddress("glProgramUniformMatrix4x2dv"))(program, location, count, transpose, value);
	}

	internal static unsafe void ProgramUniformMatrix4x2fv(uint program, int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<uint, int, int, byte, float*, void>) Context.GetProcAddress("glProgramUniformMatrix4x2fv"))(program, location, count, transpose, value);
	}

	internal static unsafe void ProgramUniformMatrix4x3dv(uint program, int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<uint, int, int, byte, double*, void>) Context.GetProcAddress("glProgramUniformMatrix4x3dv"))(program, location, count, transpose, value);
	}

	internal static unsafe void ProgramUniformMatrix4x3fv(uint program, int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<uint, int, int, byte, float*, void>) Context.GetProcAddress("glProgramUniformMatrix4x3fv"))(program, location, count, transpose, value);
	}

	internal static unsafe void ProvokingVertex(uint mode) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glProvokingVertex"))(mode);
	}

	internal static unsafe void PushDebugGroup(uint source, uint id, int length, char* message) {
		((delegate* unmanaged<uint, uint, int, char*, void>) Context.GetProcAddress("glPushDebugGroup"))(source, id, length, message);
	}

	internal static unsafe void QueryCounter(uint id, uint target) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glQueryCounter"))(id, target);
	}

	internal static unsafe void RasterPos2xOES(int x, int y) {
		((delegate* unmanaged<int, int, void>) Context.GetProcAddress("glRasterPos2xOES"))(x, y);
	}

	internal static unsafe void RasterPos2xvOES(int* coords) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glRasterPos2xvOES"))(coords);
	}

	internal static unsafe void RasterPos3xOES(int x, int y, int z) {
		((delegate* unmanaged<int, int, int, void>) Context.GetProcAddress("glRasterPos3xOES"))(x, y, z);
	}

	internal static unsafe void RasterPos3xvOES(int* coords) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glRasterPos3xvOES"))(coords);
	}

	internal static unsafe void RasterPos4xOES(int x, int y, int z, int w) {
		((delegate* unmanaged<int, int, int, int, void>) Context.GetProcAddress("glRasterPos4xOES"))(x, y, z, w);
	}

	internal static unsafe void RasterPos4xvOES(int* coords) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glRasterPos4xvOES"))(coords);
	}

	internal static unsafe void ReadBuffer(uint src) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glReadBuffer"))(src);
	}

	internal static unsafe void ReadPixels(int x, int y, int width, int height, uint format, uint type, void* pixels) {
		((delegate* unmanaged<int, int, int, int, uint, uint, void*, void>) Context.GetProcAddress("glReadPixels"))(x, y, width, height, format, type, pixels);
	}

	internal static unsafe void RectxOES(int x1, int y1, int x2, int y2) {
		((delegate* unmanaged<int, int, int, int, void>) Context.GetProcAddress("glRectxOES"))(x1, y1, x2, y2);
	}

	internal static unsafe void RectxvOES(int* v1, int* v2) {
		((delegate* unmanaged<int*, int*, void>) Context.GetProcAddress("glRectxvOES"))(v1, v2);
	}

	internal static unsafe void ReleaseShaderCompiler() {
	((delegate* unmanaged<void>) Context.GetProcAddress("glReleaseShaderCompiler"))();
	}

	internal static unsafe void RenderbufferStorage(uint target, uint internalformat, int width, int height) {
		((delegate* unmanaged<uint, uint, int, int, void>) Context.GetProcAddress("glRenderbufferStorage"))(target, internalformat, width, height);
	}

	internal static unsafe void RenderbufferStorageEXT(uint target, uint internalformat, int width, int height) {
		((delegate* unmanaged<uint, uint, int, int, void>) Context.GetProcAddress("glRenderbufferStorageEXT"))(target, internalformat, width, height);
	}

	internal static unsafe void RenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height) {
		((delegate* unmanaged<uint, int, uint, int, int, void>) Context.GetProcAddress("glRenderbufferStorageMultisample"))(target, samples, internalformat, width, height);
	}

	internal static unsafe void RenderbufferStorageMultisampleEXT(uint target, int samples, uint internalformat, int width, int height) {
		((delegate* unmanaged<uint, int, uint, int, int, void>) Context.GetProcAddress("glRenderbufferStorageMultisampleEXT"))(target, samples, internalformat, width, height);
	}

	internal static unsafe void ResumeTransformFeedback() {
	((delegate* unmanaged<void>) Context.GetProcAddress("glResumeTransformFeedback"))();
	}

	internal static unsafe void RotatexOES(int angle, int x, int y, int z) {
		((delegate* unmanaged<int, int, int, int, void>) Context.GetProcAddress("glRotatexOES"))(angle, x, y, z);
	}

	internal static unsafe void SampleCoverage(float value, byte invert) {
		((delegate* unmanaged<float, byte, void>) Context.GetProcAddress("glSampleCoverage"))(value, invert);
	}

	internal static unsafe void SampleCoverageARB(float value, byte invert) {
		((delegate* unmanaged<float, byte, void>) Context.GetProcAddress("glSampleCoverageARB"))(value, invert);
	}

	internal static unsafe void SampleMaski(uint maskNumber, uint mask) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glSampleMaski"))(maskNumber, mask);
	}

	internal static unsafe void SamplerParameterIiv(uint sampler, uint pname, int* param) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glSamplerParameterIiv"))(sampler, pname, param);
	}

	internal static unsafe void SamplerParameterIuiv(uint sampler, uint pname, uint* param) {
		((delegate* unmanaged<uint, uint, uint*, void>) Context.GetProcAddress("glSamplerParameterIuiv"))(sampler, pname, param);
	}

	internal static unsafe void SamplerParameterf(uint sampler, uint pname, float param) {
		((delegate* unmanaged<uint, uint, float, void>) Context.GetProcAddress("glSamplerParameterf"))(sampler, pname, param);
	}

	internal static unsafe void SamplerParameterfv(uint sampler, uint pname, float* param) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glSamplerParameterfv"))(sampler, pname, param);
	}

	internal static unsafe void SamplerParameteri(uint sampler, uint pname, int param) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glSamplerParameteri"))(sampler, pname, param);
	}

	internal static unsafe void SamplerParameteriv(uint sampler, uint pname, int* param) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glSamplerParameteriv"))(sampler, pname, param);
	}

	internal static unsafe void ScalexOES(int x, int y, int z) {
		((delegate* unmanaged<int, int, int, void>) Context.GetProcAddress("glScalexOES"))(x, y, z);
	}

	internal static unsafe void Scissor(int x, int y, int width, int height) {
		((delegate* unmanaged<int, int, int, int, void>) Context.GetProcAddress("glScissor"))(x, y, width, height);
	}

	internal static unsafe void ScissorArrayv(uint first, int count, int* v) {
		((delegate* unmanaged<uint, int, int*, void>) Context.GetProcAddress("glScissorArrayv"))(first, count, v);
	}

	internal static unsafe void ScissorIndexed(uint index, int left, int bottom, int width, int height) {
		((delegate* unmanaged<uint, int, int, int, int, void>) Context.GetProcAddress("glScissorIndexed"))(index, left, bottom, width, height);
	}

	internal static unsafe void ScissorIndexedv(uint index, int* v) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glScissorIndexedv"))(index, v);
	}

	internal static unsafe void ShaderBinary(int count, uint* shaders, uint binaryFormat, void* binary, int length) {
		((delegate* unmanaged<int, uint*, uint, void*, int, void>) Context.GetProcAddress("glShaderBinary"))(count, shaders, binaryFormat, binary, length);
	}

	internal static unsafe void ShaderSource(uint shader, int count, char** str, int* length) {
		((delegate* unmanaged<uint, int, char**, int*, void>) Context.GetProcAddress("glShaderSource"))(shader, count, str, length);
	}

	internal static unsafe void ShaderSourceARB(uint shaderObj, int count, char** str, int* length) {
		((delegate* unmanaged<uint, int, char**, int*, void>) Context.GetProcAddress("glShaderSourceARB"))(shaderObj, count, str, length);
	}

	internal static unsafe void ShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glShaderStorageBlockBinding"))(program, storageBlockIndex, storageBlockBinding);
	}

	internal static unsafe void SpecializeShaderARB(uint shader, char* pEntryPoint, uint numSpecializationConstants, uint* pConstantIndex, uint* pConstantValue) {
		((delegate* unmanaged<uint, char*, uint, uint*, uint*, void>) Context.GetProcAddress("glSpecializeShaderARB"))(shader, pEntryPoint, numSpecializationConstants, pConstantIndex, pConstantValue);
	}

	internal static unsafe void StencilFunc(uint func, int reference, uint mask) {
		((delegate* unmanaged<uint, int, uint, void>) Context.GetProcAddress("glStencilFunc"))(func, reference, mask);
	}

	internal static unsafe void StencilFuncSeparate(uint face, uint func, int reference, uint mask) {
		((delegate* unmanaged<uint, uint, int, uint, void>) Context.GetProcAddress("glStencilFuncSeparate"))(face, func, reference, mask);
	}

	internal static unsafe void StencilMask(uint mask) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glStencilMask"))(mask);
	}

	internal static unsafe void StencilMaskSeparate(uint face, uint mask) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glStencilMaskSeparate"))(face, mask);
	}

	internal static unsafe void StencilOp(uint fail, uint zfail, uint zpass) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glStencilOp"))(fail, zfail, zpass);
	}

	internal static unsafe void StencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass) {
		((delegate* unmanaged<uint, uint, uint, uint, void>) Context.GetProcAddress("glStencilOpSeparate"))(face, sfail, dpfail, dppass);
	}

	internal static unsafe void TexBuffer(uint target, uint internalformat, uint buffer) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glTexBuffer"))(target, internalformat, buffer);
	}

	internal static unsafe void TexBufferRange(uint target, uint internalformat, uint buffer, int* offset, nint size) {
		((delegate* unmanaged<uint, uint, uint, int*, nint, void>) Context.GetProcAddress("glTexBufferRange"))(target, internalformat, buffer, offset, size);
	}

	internal static unsafe void TexCoord1xOES(int s) {
		((delegate* unmanaged<int, void>) Context.GetProcAddress("glTexCoord1xOES"))(s);
	}

	internal static unsafe void TexCoord1xvOES(int* coords) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glTexCoord1xvOES"))(coords);
	}

	internal static unsafe void TexCoord2xOES(int s, int t) {
		((delegate* unmanaged<int, int, void>) Context.GetProcAddress("glTexCoord2xOES"))(s, t);
	}

	internal static unsafe void TexCoord2xvOES(int* coords) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glTexCoord2xvOES"))(coords);
	}

	internal static unsafe void TexCoord3xOES(int s, int t, int r) {
		((delegate* unmanaged<int, int, int, void>) Context.GetProcAddress("glTexCoord3xOES"))(s, t, r);
	}

	internal static unsafe void TexCoord3xvOES(int* coords) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glTexCoord3xvOES"))(coords);
	}

	internal static unsafe void TexCoord4xOES(int s, int t, int r, int q) {
		((delegate* unmanaged<int, int, int, int, void>) Context.GetProcAddress("glTexCoord4xOES"))(s, t, r, q);
	}

	internal static unsafe void TexCoord4xvOES(int* coords) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glTexCoord4xvOES"))(coords);
	}

	internal static unsafe void TexEnvxOES(uint target, uint pname, int param) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glTexEnvxOES"))(target, pname, param);
	}

	internal static unsafe void TexEnvxvOES(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glTexEnvxvOES"))(target, pname, parameters);
	}

	internal static unsafe void TexGenxOES(uint coord, uint pname, int param) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glTexGenxOES"))(coord, pname, param);
	}

	internal static unsafe void TexGenxvOES(uint coord, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glTexGenxvOES"))(coord, pname, parameters);
	}

	internal static unsafe void TexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, void* pixels) {
		((delegate* unmanaged<uint, int, int, int, int, uint, uint, void*, void>) Context.GetProcAddress("glTexImage1D"))(target, level, internalformat, width, border, format, type, pixels);
	}

	internal static unsafe void TexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels) {
		((delegate* unmanaged<uint, int, int, int, int, int, uint, uint, void*, void>) Context.GetProcAddress("glTexImage2D"))(target, level, internalformat, width, height, border, format, type, pixels);
	}

	internal static unsafe void TexImage2DMultisample(uint target, int samples, uint internalformat, int width, int height, byte fixedsamplelocations) {
		((delegate* unmanaged<uint, int, uint, int, int, byte, void>) Context.GetProcAddress("glTexImage2DMultisample"))(target, samples, internalformat, width, height, fixedsamplelocations);
	}

	internal static unsafe void TexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, void* pixels) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, uint, uint, void*, void>) Context.GetProcAddress("glTexImage3D"))(target, level, internalformat, width, height, depth, border, format, type, pixels);
	}

	internal static unsafe void TexImage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, byte fixedsamplelocations) {
		((delegate* unmanaged<uint, int, uint, int, int, int, byte, void>) Context.GetProcAddress("glTexImage3DMultisample"))(target, samples, internalformat, width, height, depth, fixedsamplelocations);
	}

	internal static unsafe void TexParameterIiv(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glTexParameterIiv"))(target, pname, parameters);
	}

	internal static unsafe void TexParameterIuiv(uint target, uint pname, uint* parameters) {
		((delegate* unmanaged<uint, uint, uint*, void>) Context.GetProcAddress("glTexParameterIuiv"))(target, pname, parameters);
	}

	internal static unsafe void TexParameterf(uint target, uint pname, float param) {
		((delegate* unmanaged<uint, uint, float, void>) Context.GetProcAddress("glTexParameterf"))(target, pname, param);
	}

	internal static unsafe void TexParameterfv(uint target, uint pname, float* parameters) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glTexParameterfv"))(target, pname, parameters);
	}

	internal static unsafe void TexParameteri(uint target, uint pname, int param) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glTexParameteri"))(target, pname, param);
	}

	internal static unsafe void TexParameteriv(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glTexParameteriv"))(target, pname, parameters);
	}

	internal static unsafe void TexParameterxOES(uint target, uint pname, int param) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glTexParameterxOES"))(target, pname, param);
	}

	internal static unsafe void TexParameterxvOES(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glTexParameterxvOES"))(target, pname, parameters);
	}

	internal static unsafe void TexStorage1D(uint target, int levels, uint internalformat, int width) {
		((delegate* unmanaged<uint, int, uint, int, void>) Context.GetProcAddress("glTexStorage1D"))(target, levels, internalformat, width);
	}

	internal static unsafe void TexStorage2D(uint target, int levels, uint internalformat, int width, int height) {
		((delegate* unmanaged<uint, int, uint, int, int, void>) Context.GetProcAddress("glTexStorage2D"))(target, levels, internalformat, width, height);
	}

	internal static unsafe void TexStorage2DMultisample(uint target, int samples, uint internalformat, int width, int height, byte fixedsamplelocations) {
		((delegate* unmanaged<uint, int, uint, int, int, byte, void>) Context.GetProcAddress("glTexStorage2DMultisample"))(target, samples, internalformat, width, height, fixedsamplelocations);
	}

	internal static unsafe void TexStorage3D(uint target, int levels, uint internalformat, int width, int height, int depth) {
		((delegate* unmanaged<uint, int, uint, int, int, int, void>) Context.GetProcAddress("glTexStorage3D"))(target, levels, internalformat, width, height, depth);
	}

	internal static unsafe void TexStorage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, byte fixedsamplelocations) {
		((delegate* unmanaged<uint, int, uint, int, int, int, byte, void>) Context.GetProcAddress("glTexStorage3DMultisample"))(target, samples, internalformat, width, height, depth, fixedsamplelocations);
	}

	internal static unsafe void TexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, void* pixels) {
		((delegate* unmanaged<uint, int, int, int, uint, uint, void*, void>) Context.GetProcAddress("glTexSubImage1D"))(target, level, xoffset, width, format, type, pixels);
	}

	internal static unsafe void TexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels) {
		((delegate* unmanaged<uint, int, int, int, int, int, uint, uint, void*, void>) Context.GetProcAddress("glTexSubImage2D"))(target, level, xoffset, yoffset, width, height, format, type, pixels);
	}

	internal static unsafe void TexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, int, uint, uint, void*, void>) Context.GetProcAddress("glTexSubImage3D"))(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
	}

	internal static unsafe void TextureBuffer(uint texture, uint internalformat, uint buffer) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glTextureBuffer"))(texture, internalformat, buffer);
	}

	internal static unsafe void TextureBufferRange(uint texture, uint internalformat, uint buffer, int* offset, nint size) {
		((delegate* unmanaged<uint, uint, uint, int*, nint, void>) Context.GetProcAddress("glTextureBufferRange"))(texture, internalformat, buffer, offset, size);
	}

	internal static unsafe void TextureParameterIiv(uint texture, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glTextureParameterIiv"))(texture, pname, parameters);
	}

	internal static unsafe void TextureParameterIuiv(uint texture, uint pname, uint* parameters) {
		((delegate* unmanaged<uint, uint, uint*, void>) Context.GetProcAddress("glTextureParameterIuiv"))(texture, pname, parameters);
	}

	internal static unsafe void TextureParameterf(uint texture, uint pname, float param) {
		((delegate* unmanaged<uint, uint, float, void>) Context.GetProcAddress("glTextureParameterf"))(texture, pname, param);
	}

	internal static unsafe void TextureParameterfv(uint texture, uint pname, float* param) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glTextureParameterfv"))(texture, pname, param);
	}

	internal static unsafe void TextureParameteri(uint texture, uint pname, int param) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glTextureParameteri"))(texture, pname, param);
	}

	internal static unsafe void TextureParameteriv(uint texture, uint pname, int* param) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glTextureParameteriv"))(texture, pname, param);
	}

	internal static unsafe void TextureStorage1D(uint texture, int levels, uint internalformat, int width) {
		((delegate* unmanaged<uint, int, uint, int, void>) Context.GetProcAddress("glTextureStorage1D"))(texture, levels, internalformat, width);
	}

	internal static unsafe void TextureStorage2D(uint texture, int levels, uint internalformat, int width, int height) {
		((delegate* unmanaged<uint, int, uint, int, int, void>) Context.GetProcAddress("glTextureStorage2D"))(texture, levels, internalformat, width, height);
	}

	internal static unsafe void TextureStorage2DMultisample(uint texture, int samples, uint internalformat, int width, int height, byte fixedsamplelocations) {
		((delegate* unmanaged<uint, int, uint, int, int, byte, void>) Context.GetProcAddress("glTextureStorage2DMultisample"))(texture, samples, internalformat, width, height, fixedsamplelocations);
	}

	internal static unsafe void TextureStorage3D(uint texture, int levels, uint internalformat, int width, int height, int depth) {
		((delegate* unmanaged<uint, int, uint, int, int, int, void>) Context.GetProcAddress("glTextureStorage3D"))(texture, levels, internalformat, width, height, depth);
	}

	internal static unsafe void TextureStorage3DMultisample(uint texture, int samples, uint internalformat, int width, int height, int depth, byte fixedsamplelocations) {
		((delegate* unmanaged<uint, int, uint, int, int, int, byte, void>) Context.GetProcAddress("glTextureStorage3DMultisample"))(texture, samples, internalformat, width, height, depth, fixedsamplelocations);
	}

	internal static unsafe void TextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, uint type, void* pixels) {
		((delegate* unmanaged<uint, int, int, int, uint, uint, void*, void>) Context.GetProcAddress("glTextureSubImage1D"))(texture, level, xoffset, width, format, type, pixels);
	}

	internal static unsafe void TextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels) {
		((delegate* unmanaged<uint, int, int, int, int, int, uint, uint, void*, void>) Context.GetProcAddress("glTextureSubImage2D"))(texture, level, xoffset, yoffset, width, height, format, type, pixels);
	}

	internal static unsafe void TextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, int, uint, uint, void*, void>) Context.GetProcAddress("glTextureSubImage3D"))(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
	}

	internal static unsafe void TextureView(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers) {
		((delegate* unmanaged<uint, uint, uint, uint, uint, uint, uint, uint, void>) Context.GetProcAddress("glTextureView"))(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
	}

	internal static unsafe void TransformFeedbackBufferBase(uint xfb, uint index, uint buffer) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glTransformFeedbackBufferBase"))(xfb, index, buffer);
	}

	internal static unsafe void TransformFeedbackBufferRange(uint xfb, uint index, uint buffer, int* offset, nint size) {
		((delegate* unmanaged<uint, uint, uint, int*, nint, void>) Context.GetProcAddress("glTransformFeedbackBufferRange"))(xfb, index, buffer, offset, size);
	}

	internal static unsafe void TransformFeedbackVaryings(uint program, int count, char** varyings, uint bufferMode) {
		((delegate* unmanaged<uint, int, char**, uint, void>) Context.GetProcAddress("glTransformFeedbackVaryings"))(program, count, varyings, bufferMode);
	}

	internal static unsafe void TranslatexOES(int x, int y, int z) {
		((delegate* unmanaged<int, int, int, void>) Context.GetProcAddress("glTranslatexOES"))(x, y, z);
	}

	internal static unsafe void Uniform1d(int location, double x) {
		((delegate* unmanaged<int, double, void>) Context.GetProcAddress("glUniform1d"))(location, x);
	}

	internal static unsafe void Uniform1dv(int location, int count, double* value) {
		((delegate* unmanaged<int, int, double*, void>) Context.GetProcAddress("glUniform1dv"))(location, count, value);
	}

	internal static unsafe void Uniform1f(int location, float v0) {
		((delegate* unmanaged<int, float, void>) Context.GetProcAddress("glUniform1f"))(location, v0);
	}

	internal static unsafe void Uniform1fARB(int location, float v0) {
		((delegate* unmanaged<int, float, void>) Context.GetProcAddress("glUniform1fARB"))(location, v0);
	}

	internal static unsafe void Uniform1fv(int location, int count, float* value) {
		((delegate* unmanaged<int, int, float*, void>) Context.GetProcAddress("glUniform1fv"))(location, count, value);
	}

	internal static unsafe void Uniform1fvARB(int location, int count, float* value) {
		((delegate* unmanaged<int, int, float*, void>) Context.GetProcAddress("glUniform1fvARB"))(location, count, value);
	}

	internal static unsafe void Uniform1i(int location, int v0) {
		((delegate* unmanaged<int, int, void>) Context.GetProcAddress("glUniform1i"))(location, v0);
	}

	internal static unsafe void Uniform1i64ARB(int location, nint x) {
		((delegate* unmanaged<int, nint, void>) Context.GetProcAddress("glUniform1i64ARB"))(location, x);
	}

	internal static unsafe void Uniform1i64vARB(int location, int count, nint* value) {
		((delegate* unmanaged<int, int, nint*, void>) Context.GetProcAddress("glUniform1i64vARB"))(location, count, value);
	}

	internal static unsafe void Uniform1iARB(int location, int v0) {
		((delegate* unmanaged<int, int, void>) Context.GetProcAddress("glUniform1iARB"))(location, v0);
	}

	internal static unsafe void Uniform1iv(int location, int count, int* value) {
		((delegate* unmanaged<int, int, int*, void>) Context.GetProcAddress("glUniform1iv"))(location, count, value);
	}

	internal static unsafe void Uniform1ivARB(int location, int count, int* value) {
		((delegate* unmanaged<int, int, int*, void>) Context.GetProcAddress("glUniform1ivARB"))(location, count, value);
	}

	internal static unsafe void Uniform1ui(int location, uint v0) {
		((delegate* unmanaged<int, uint, void>) Context.GetProcAddress("glUniform1ui"))(location, v0);
	}

	internal static unsafe void Uniform1ui64ARB(int location, nint x) {
		((delegate* unmanaged<int, nint, void>) Context.GetProcAddress("glUniform1ui64ARB"))(location, x);
	}

	internal static unsafe void Uniform1ui64vARB(int location, int count, nint* value) {
		((delegate* unmanaged<int, int, nint*, void>) Context.GetProcAddress("glUniform1ui64vARB"))(location, count, value);
	}

	internal static unsafe void Uniform1uiv(int location, int count, uint* value) {
		((delegate* unmanaged<int, int, uint*, void>) Context.GetProcAddress("glUniform1uiv"))(location, count, value);
	}

	internal static unsafe void Uniform2d(int location, double x, double y) {
		((delegate* unmanaged<int, double, double, void>) Context.GetProcAddress("glUniform2d"))(location, x, y);
	}

	internal static unsafe void Uniform2dv(int location, int count, double* value) {
		((delegate* unmanaged<int, int, double*, void>) Context.GetProcAddress("glUniform2dv"))(location, count, value);
	}

	internal static unsafe void Uniform2f(int location, float v0, float v1) {
		((delegate* unmanaged<int, float, float, void>) Context.GetProcAddress("glUniform2f"))(location, v0, v1);
	}

	internal static unsafe void Uniform2fARB(int location, float v0, float v1) {
		((delegate* unmanaged<int, float, float, void>) Context.GetProcAddress("glUniform2fARB"))(location, v0, v1);
	}

	internal static unsafe void Uniform2fv(int location, int count, float* value) {
		((delegate* unmanaged<int, int, float*, void>) Context.GetProcAddress("glUniform2fv"))(location, count, value);
	}

	internal static unsafe void Uniform2fvARB(int location, int count, float* value) {
		((delegate* unmanaged<int, int, float*, void>) Context.GetProcAddress("glUniform2fvARB"))(location, count, value);
	}

	internal static unsafe void Uniform2i(int location, int v0, int v1) {
		((delegate* unmanaged<int, int, int, void>) Context.GetProcAddress("glUniform2i"))(location, v0, v1);
	}

	internal static unsafe void Uniform2i64ARB(int location, nint x, nint y) {
		((delegate* unmanaged<int, nint, nint, void>) Context.GetProcAddress("glUniform2i64ARB"))(location, x, y);
	}

	internal static unsafe void Uniform2i64vARB(int location, int count, nint* value) {
		((delegate* unmanaged<int, int, nint*, void>) Context.GetProcAddress("glUniform2i64vARB"))(location, count, value);
	}

	internal static unsafe void Uniform2iARB(int location, int v0, int v1) {
		((delegate* unmanaged<int, int, int, void>) Context.GetProcAddress("glUniform2iARB"))(location, v0, v1);
	}

	internal static unsafe void Uniform2iv(int location, int count, int* value) {
		((delegate* unmanaged<int, int, int*, void>) Context.GetProcAddress("glUniform2iv"))(location, count, value);
	}

	internal static unsafe void Uniform2ivARB(int location, int count, int* value) {
		((delegate* unmanaged<int, int, int*, void>) Context.GetProcAddress("glUniform2ivARB"))(location, count, value);
	}

	internal static unsafe void Uniform2ui(int location, uint v0, uint v1) {
		((delegate* unmanaged<int, uint, uint, void>) Context.GetProcAddress("glUniform2ui"))(location, v0, v1);
	}

	internal static unsafe void Uniform2ui64ARB(int location, nint x, nint y) {
		((delegate* unmanaged<int, nint, nint, void>) Context.GetProcAddress("glUniform2ui64ARB"))(location, x, y);
	}

	internal static unsafe void Uniform2ui64vARB(int location, int count, nint* value) {
		((delegate* unmanaged<int, int, nint*, void>) Context.GetProcAddress("glUniform2ui64vARB"))(location, count, value);
	}

	internal static unsafe void Uniform2uiv(int location, int count, uint* value) {
		((delegate* unmanaged<int, int, uint*, void>) Context.GetProcAddress("glUniform2uiv"))(location, count, value);
	}

	internal static unsafe void Uniform3d(int location, double x, double y, double z) {
		((delegate* unmanaged<int, double, double, double, void>) Context.GetProcAddress("glUniform3d"))(location, x, y, z);
	}

	internal static unsafe void Uniform3dv(int location, int count, double* value) {
		((delegate* unmanaged<int, int, double*, void>) Context.GetProcAddress("glUniform3dv"))(location, count, value);
	}

	internal static unsafe void Uniform3f(int location, float v0, float v1, float v2) {
		((delegate* unmanaged<int, float, float, float, void>) Context.GetProcAddress("glUniform3f"))(location, v0, v1, v2);
	}

	internal static unsafe void Uniform3fARB(int location, float v0, float v1, float v2) {
		((delegate* unmanaged<int, float, float, float, void>) Context.GetProcAddress("glUniform3fARB"))(location, v0, v1, v2);
	}

	internal static unsafe void Uniform3fv(int location, int count, float* value) {
		((delegate* unmanaged<int, int, float*, void>) Context.GetProcAddress("glUniform3fv"))(location, count, value);
	}

	internal static unsafe void Uniform3fvARB(int location, int count, float* value) {
		((delegate* unmanaged<int, int, float*, void>) Context.GetProcAddress("glUniform3fvARB"))(location, count, value);
	}

	internal static unsafe void Uniform3i(int location, int v0, int v1, int v2) {
		((delegate* unmanaged<int, int, int, int, void>) Context.GetProcAddress("glUniform3i"))(location, v0, v1, v2);
	}

	internal static unsafe void Uniform3i64ARB(int location, nint x, nint y, nint z) {
		((delegate* unmanaged<int, nint, nint, nint, void>) Context.GetProcAddress("glUniform3i64ARB"))(location, x, y, z);
	}

	internal static unsafe void Uniform3i64vARB(int location, int count, nint* value) {
		((delegate* unmanaged<int, int, nint*, void>) Context.GetProcAddress("glUniform3i64vARB"))(location, count, value);
	}

	internal static unsafe void Uniform3iARB(int location, int v0, int v1, int v2) {
		((delegate* unmanaged<int, int, int, int, void>) Context.GetProcAddress("glUniform3iARB"))(location, v0, v1, v2);
	}

	internal static unsafe void Uniform3iv(int location, int count, int* value) {
		((delegate* unmanaged<int, int, int*, void>) Context.GetProcAddress("glUniform3iv"))(location, count, value);
	}

	internal static unsafe void Uniform3ivARB(int location, int count, int* value) {
		((delegate* unmanaged<int, int, int*, void>) Context.GetProcAddress("glUniform3ivARB"))(location, count, value);
	}

	internal static unsafe void Uniform3ui(int location, uint v0, uint v1, uint v2) {
		((delegate* unmanaged<int, uint, uint, uint, void>) Context.GetProcAddress("glUniform3ui"))(location, v0, v1, v2);
	}

	internal static unsafe void Uniform3ui64ARB(int location, nint x, nint y, nint z) {
		((delegate* unmanaged<int, nint, nint, nint, void>) Context.GetProcAddress("glUniform3ui64ARB"))(location, x, y, z);
	}

	internal static unsafe void Uniform3ui64vARB(int location, int count, nint* value) {
		((delegate* unmanaged<int, int, nint*, void>) Context.GetProcAddress("glUniform3ui64vARB"))(location, count, value);
	}

	internal static unsafe void Uniform3uiv(int location, int count, uint* value) {
		((delegate* unmanaged<int, int, uint*, void>) Context.GetProcAddress("glUniform3uiv"))(location, count, value);
	}

	internal static unsafe void Uniform4d(int location, double x, double y, double z, double w) {
		((delegate* unmanaged<int, double, double, double, double, void>) Context.GetProcAddress("glUniform4d"))(location, x, y, z, w);
	}

	internal static unsafe void Uniform4dv(int location, int count, double* value) {
		((delegate* unmanaged<int, int, double*, void>) Context.GetProcAddress("glUniform4dv"))(location, count, value);
	}

	internal static unsafe void Uniform4f(int location, float v0, float v1, float v2, float v3) {
		((delegate* unmanaged<int, float, float, float, float, void>) Context.GetProcAddress("glUniform4f"))(location, v0, v1, v2, v3);
	}

	internal static unsafe void Uniform4fARB(int location, float v0, float v1, float v2, float v3) {
		((delegate* unmanaged<int, float, float, float, float, void>) Context.GetProcAddress("glUniform4fARB"))(location, v0, v1, v2, v3);
	}

	internal static unsafe void Uniform4fv(int location, int count, float* value) {
		((delegate* unmanaged<int, int, float*, void>) Context.GetProcAddress("glUniform4fv"))(location, count, value);
	}

	internal static unsafe void Uniform4fvARB(int location, int count, float* value) {
		((delegate* unmanaged<int, int, float*, void>) Context.GetProcAddress("glUniform4fvARB"))(location, count, value);
	}

	internal static unsafe void Uniform4i(int location, int v0, int v1, int v2, int v3) {
		((delegate* unmanaged<int, int, int, int, int, void>) Context.GetProcAddress("glUniform4i"))(location, v0, v1, v2, v3);
	}

	internal static unsafe void Uniform4i64ARB(int location, nint x, nint y, nint z, nint w) {
		((delegate* unmanaged<int, nint, nint, nint, nint, void>) Context.GetProcAddress("glUniform4i64ARB"))(location, x, y, z, w);
	}

	internal static unsafe void Uniform4i64vARB(int location, int count, nint* value) {
		((delegate* unmanaged<int, int, nint*, void>) Context.GetProcAddress("glUniform4i64vARB"))(location, count, value);
	}

	internal static unsafe void Uniform4iARB(int location, int v0, int v1, int v2, int v3) {
		((delegate* unmanaged<int, int, int, int, int, void>) Context.GetProcAddress("glUniform4iARB"))(location, v0, v1, v2, v3);
	}

	internal static unsafe void Uniform4iv(int location, int count, int* value) {
		((delegate* unmanaged<int, int, int*, void>) Context.GetProcAddress("glUniform4iv"))(location, count, value);
	}

	internal static unsafe void Uniform4ivARB(int location, int count, int* value) {
		((delegate* unmanaged<int, int, int*, void>) Context.GetProcAddress("glUniform4ivARB"))(location, count, value);
	}

	internal static unsafe void Uniform4ui(int location, uint v0, uint v1, uint v2, uint v3) {
		((delegate* unmanaged<int, uint, uint, uint, uint, void>) Context.GetProcAddress("glUniform4ui"))(location, v0, v1, v2, v3);
	}

	internal static unsafe void Uniform4ui64ARB(int location, nint x, nint y, nint z, nint w) {
		((delegate* unmanaged<int, nint, nint, nint, nint, void>) Context.GetProcAddress("glUniform4ui64ARB"))(location, x, y, z, w);
	}

	internal static unsafe void Uniform4ui64vARB(int location, int count, nint* value) {
		((delegate* unmanaged<int, int, nint*, void>) Context.GetProcAddress("glUniform4ui64vARB"))(location, count, value);
	}

	internal static unsafe void Uniform4uiv(int location, int count, uint* value) {
		((delegate* unmanaged<int, int, uint*, void>) Context.GetProcAddress("glUniform4uiv"))(location, count, value);
	}

	internal static unsafe void UniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glUniformBlockBinding"))(program, uniformBlockIndex, uniformBlockBinding);
	}

	internal static unsafe void UniformMatrix2dv(int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<int, int, byte, double*, void>) Context.GetProcAddress("glUniformMatrix2dv"))(location, count, transpose, value);
	}

	internal static unsafe void UniformMatrix2fv(int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<int, int, byte, float*, void>) Context.GetProcAddress("glUniformMatrix2fv"))(location, count, transpose, value);
	}

	internal static unsafe void UniformMatrix2fvARB(int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<int, int, byte, float*, void>) Context.GetProcAddress("glUniformMatrix2fvARB"))(location, count, transpose, value);
	}

	internal static unsafe void UniformMatrix2x3dv(int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<int, int, byte, double*, void>) Context.GetProcAddress("glUniformMatrix2x3dv"))(location, count, transpose, value);
	}

	internal static unsafe void UniformMatrix2x3fv(int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<int, int, byte, float*, void>) Context.GetProcAddress("glUniformMatrix2x3fv"))(location, count, transpose, value);
	}

	internal static unsafe void UniformMatrix2x4dv(int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<int, int, byte, double*, void>) Context.GetProcAddress("glUniformMatrix2x4dv"))(location, count, transpose, value);
	}

	internal static unsafe void UniformMatrix2x4fv(int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<int, int, byte, float*, void>) Context.GetProcAddress("glUniformMatrix2x4fv"))(location, count, transpose, value);
	}

	internal static unsafe void UniformMatrix3dv(int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<int, int, byte, double*, void>) Context.GetProcAddress("glUniformMatrix3dv"))(location, count, transpose, value);
	}

	internal static unsafe void UniformMatrix3fv(int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<int, int, byte, float*, void>) Context.GetProcAddress("glUniformMatrix3fv"))(location, count, transpose, value);
	}

	internal static unsafe void UniformMatrix3fvARB(int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<int, int, byte, float*, void>) Context.GetProcAddress("glUniformMatrix3fvARB"))(location, count, transpose, value);
	}

	internal static unsafe void UniformMatrix3x2dv(int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<int, int, byte, double*, void>) Context.GetProcAddress("glUniformMatrix3x2dv"))(location, count, transpose, value);
	}

	internal static unsafe void UniformMatrix3x2fv(int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<int, int, byte, float*, void>) Context.GetProcAddress("glUniformMatrix3x2fv"))(location, count, transpose, value);
	}

	internal static unsafe void UniformMatrix3x4dv(int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<int, int, byte, double*, void>) Context.GetProcAddress("glUniformMatrix3x4dv"))(location, count, transpose, value);
	}

	internal static unsafe void UniformMatrix3x4fv(int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<int, int, byte, float*, void>) Context.GetProcAddress("glUniformMatrix3x4fv"))(location, count, transpose, value);
	}

	internal static unsafe void UniformMatrix4dv(int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<int, int, byte, double*, void>) Context.GetProcAddress("glUniformMatrix4dv"))(location, count, transpose, value);
	}

	internal static unsafe void UniformMatrix4fv(int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<int, int, byte, float*, void>) Context.GetProcAddress("glUniformMatrix4fv"))(location, count, transpose, value);
	}

	internal static unsafe void UniformMatrix4fvARB(int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<int, int, byte, float*, void>) Context.GetProcAddress("glUniformMatrix4fvARB"))(location, count, transpose, value);
	}

	internal static unsafe void UniformMatrix4x2dv(int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<int, int, byte, double*, void>) Context.GetProcAddress("glUniformMatrix4x2dv"))(location, count, transpose, value);
	}

	internal static unsafe void UniformMatrix4x2fv(int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<int, int, byte, float*, void>) Context.GetProcAddress("glUniformMatrix4x2fv"))(location, count, transpose, value);
	}

	internal static unsafe void UniformMatrix4x3dv(int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<int, int, byte, double*, void>) Context.GetProcAddress("glUniformMatrix4x3dv"))(location, count, transpose, value);
	}

	internal static unsafe void UniformMatrix4x3fv(int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<int, int, byte, float*, void>) Context.GetProcAddress("glUniformMatrix4x3fv"))(location, count, transpose, value);
	}

	internal static unsafe void UniformSubroutinesuiv(uint shadertype, int count, uint* indices) {
		((delegate* unmanaged<uint, int, uint*, void>) Context.GetProcAddress("glUniformSubroutinesuiv"))(shadertype, count, indices);
	}

	internal static unsafe byte UnmapBuffer(uint target) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glUnmapBuffer"))(target);
	}

	internal static unsafe byte UnmapBufferARB(uint target) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glUnmapBufferARB"))(target);
	}

	internal static unsafe byte UnmapNamedBuffer(uint buffer) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glUnmapNamedBuffer"))(buffer);
	}

	internal static unsafe void UseProgram(uint program) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glUseProgram"))(program);
	}

	internal static unsafe void UseProgramObjectARB(uint programObj) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glUseProgramObjectARB"))(programObj);
	}

	internal static unsafe void UseProgramStages(uint pipeline, uint stages, uint program) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glUseProgramStages"))(pipeline, stages, program);
	}

	internal static unsafe void ValidateProgram(uint program) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glValidateProgram"))(program);
	}

	internal static unsafe void ValidateProgramARB(uint programObj) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glValidateProgramARB"))(programObj);
	}

	internal static unsafe void ValidateProgramPipeline(uint pipeline) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glValidateProgramPipeline"))(pipeline);
	}

	internal static unsafe void Vertex2xOES(int x) {
		((delegate* unmanaged<int, void>) Context.GetProcAddress("glVertex2xOES"))(x);
	}

	internal static unsafe void Vertex2xvOES(int* coords) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glVertex2xvOES"))(coords);
	}

	internal static unsafe void Vertex3xOES(int x, int y) {
		((delegate* unmanaged<int, int, void>) Context.GetProcAddress("glVertex3xOES"))(x, y);
	}

	internal static unsafe void Vertex3xvOES(int* coords) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glVertex3xvOES"))(coords);
	}

	internal static unsafe void Vertex4xOES(int x, int y, int z) {
		((delegate* unmanaged<int, int, int, void>) Context.GetProcAddress("glVertex4xOES"))(x, y, z);
	}

	internal static unsafe void Vertex4xvOES(int* coords) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glVertex4xvOES"))(coords);
	}

	internal static unsafe void VertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glVertexArrayAttribBinding"))(vaobj, attribindex, bindingindex);
	}

	internal static unsafe void VertexArrayAttribFormat(uint vaobj, uint attribindex, int size, uint type, byte normalized, uint relativeoffset) {
		((delegate* unmanaged<uint, uint, int, uint, byte, uint, void>) Context.GetProcAddress("glVertexArrayAttribFormat"))(vaobj, attribindex, size, type, normalized, relativeoffset);
	}

	internal static unsafe void VertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset) {
		((delegate* unmanaged<uint, uint, int, uint, uint, void>) Context.GetProcAddress("glVertexArrayAttribIFormat"))(vaobj, attribindex, size, type, relativeoffset);
	}

	internal static unsafe void VertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset) {
		((delegate* unmanaged<uint, uint, int, uint, uint, void>) Context.GetProcAddress("glVertexArrayAttribLFormat"))(vaobj, attribindex, size, type, relativeoffset);
	}

	internal static unsafe void VertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glVertexArrayBindingDivisor"))(vaobj, bindingindex, divisor);
	}

	internal static unsafe void VertexArrayElementBuffer(uint vaobj, uint buffer) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glVertexArrayElementBuffer"))(vaobj, buffer);
	}

	internal static unsafe void VertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, int* offset, int stride) {
		((delegate* unmanaged<uint, uint, uint, int*, int, void>) Context.GetProcAddress("glVertexArrayVertexBuffer"))(vaobj, bindingindex, buffer, offset, stride);
	}

	internal static unsafe void VertexArrayVertexBuffers(uint vaobj, uint first, int count, uint* buffers, int** offsets, int* strides) {
		((delegate* unmanaged<uint, uint, int, uint*, int**, int*, void>) Context.GetProcAddress("glVertexArrayVertexBuffers"))(vaobj, first, count, buffers, offsets, strides);
	}

	internal static unsafe void VertexAttrib1d(uint index, double x) {
		((delegate* unmanaged<uint, double, void>) Context.GetProcAddress("glVertexAttrib1d"))(index, x);
	}

	internal static unsafe void VertexAttrib1dARB(uint index, double x) {
		((delegate* unmanaged<uint, double, void>) Context.GetProcAddress("glVertexAttrib1dARB"))(index, x);
	}

	internal static unsafe void VertexAttrib1dv(uint index, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glVertexAttrib1dv"))(index, v);
	}

	internal static unsafe void VertexAttrib1dvARB(uint index, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glVertexAttrib1dvARB"))(index, v);
	}

	internal static unsafe void VertexAttrib1f(uint index, float x) {
		((delegate* unmanaged<uint, float, void>) Context.GetProcAddress("glVertexAttrib1f"))(index, x);
	}

	internal static unsafe void VertexAttrib1fARB(uint index, float x) {
		((delegate* unmanaged<uint, float, void>) Context.GetProcAddress("glVertexAttrib1fARB"))(index, x);
	}

	internal static unsafe void VertexAttrib1fv(uint index, float* v) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glVertexAttrib1fv"))(index, v);
	}

	internal static unsafe void VertexAttrib1fvARB(uint index, float* v) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glVertexAttrib1fvARB"))(index, v);
	}

	internal static unsafe void VertexAttrib1s(uint index, short x) {
		((delegate* unmanaged<uint, short, void>) Context.GetProcAddress("glVertexAttrib1s"))(index, x);
	}

	internal static unsafe void VertexAttrib1sARB(uint index, short x) {
		((delegate* unmanaged<uint, short, void>) Context.GetProcAddress("glVertexAttrib1sARB"))(index, x);
	}

	internal static unsafe void VertexAttrib1sv(uint index, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glVertexAttrib1sv"))(index, v);
	}

	internal static unsafe void VertexAttrib1svARB(uint index, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glVertexAttrib1svARB"))(index, v);
	}

	internal static unsafe void VertexAttrib2d(uint index, double x, double y) {
		((delegate* unmanaged<uint, double, double, void>) Context.GetProcAddress("glVertexAttrib2d"))(index, x, y);
	}

	internal static unsafe void VertexAttrib2dARB(uint index, double x, double y) {
		((delegate* unmanaged<uint, double, double, void>) Context.GetProcAddress("glVertexAttrib2dARB"))(index, x, y);
	}

	internal static unsafe void VertexAttrib2dv(uint index, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glVertexAttrib2dv"))(index, v);
	}

	internal static unsafe void VertexAttrib2dvARB(uint index, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glVertexAttrib2dvARB"))(index, v);
	}

	internal static unsafe void VertexAttrib2f(uint index, float x, float y) {
		((delegate* unmanaged<uint, float, float, void>) Context.GetProcAddress("glVertexAttrib2f"))(index, x, y);
	}

	internal static unsafe void VertexAttrib2fARB(uint index, float x, float y) {
		((delegate* unmanaged<uint, float, float, void>) Context.GetProcAddress("glVertexAttrib2fARB"))(index, x, y);
	}

	internal static unsafe void VertexAttrib2fv(uint index, float* v) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glVertexAttrib2fv"))(index, v);
	}

	internal static unsafe void VertexAttrib2fvARB(uint index, float* v) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glVertexAttrib2fvARB"))(index, v);
	}

	internal static unsafe void VertexAttrib2s(uint index, short x, short y) {
		((delegate* unmanaged<uint, short, short, void>) Context.GetProcAddress("glVertexAttrib2s"))(index, x, y);
	}

	internal static unsafe void VertexAttrib2sARB(uint index, short x, short y) {
		((delegate* unmanaged<uint, short, short, void>) Context.GetProcAddress("glVertexAttrib2sARB"))(index, x, y);
	}

	internal static unsafe void VertexAttrib2sv(uint index, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glVertexAttrib2sv"))(index, v);
	}

	internal static unsafe void VertexAttrib2svARB(uint index, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glVertexAttrib2svARB"))(index, v);
	}

	internal static unsafe void VertexAttrib3d(uint index, double x, double y, double z) {
		((delegate* unmanaged<uint, double, double, double, void>) Context.GetProcAddress("glVertexAttrib3d"))(index, x, y, z);
	}

	internal static unsafe void VertexAttrib3dARB(uint index, double x, double y, double z) {
		((delegate* unmanaged<uint, double, double, double, void>) Context.GetProcAddress("glVertexAttrib3dARB"))(index, x, y, z);
	}

	internal static unsafe void VertexAttrib3dv(uint index, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glVertexAttrib3dv"))(index, v);
	}

	internal static unsafe void VertexAttrib3dvARB(uint index, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glVertexAttrib3dvARB"))(index, v);
	}

	internal static unsafe void VertexAttrib3f(uint index, float x, float y, float z) {
		((delegate* unmanaged<uint, float, float, float, void>) Context.GetProcAddress("glVertexAttrib3f"))(index, x, y, z);
	}

	internal static unsafe void VertexAttrib3fARB(uint index, float x, float y, float z) {
		((delegate* unmanaged<uint, float, float, float, void>) Context.GetProcAddress("glVertexAttrib3fARB"))(index, x, y, z);
	}

	internal static unsafe void VertexAttrib3fv(uint index, float* v) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glVertexAttrib3fv"))(index, v);
	}

	internal static unsafe void VertexAttrib3fvARB(uint index, float* v) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glVertexAttrib3fvARB"))(index, v);
	}

	internal static unsafe void VertexAttrib3s(uint index, short x, short y, short z) {
		((delegate* unmanaged<uint, short, short, short, void>) Context.GetProcAddress("glVertexAttrib3s"))(index, x, y, z);
	}

	internal static unsafe void VertexAttrib3sARB(uint index, short x, short y, short z) {
		((delegate* unmanaged<uint, short, short, short, void>) Context.GetProcAddress("glVertexAttrib3sARB"))(index, x, y, z);
	}

	internal static unsafe void VertexAttrib3sv(uint index, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glVertexAttrib3sv"))(index, v);
	}

	internal static unsafe void VertexAttrib3svARB(uint index, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glVertexAttrib3svARB"))(index, v);
	}

	internal static unsafe void VertexAttrib4Nbv(uint index, sbyte* v) {
		((delegate* unmanaged<uint, sbyte*, void>) Context.GetProcAddress("glVertexAttrib4Nbv"))(index, v);
	}

	internal static unsafe void VertexAttrib4NbvARB(uint index, sbyte* v) {
		((delegate* unmanaged<uint, sbyte*, void>) Context.GetProcAddress("glVertexAttrib4NbvARB"))(index, v);
	}

	internal static unsafe void VertexAttrib4Niv(uint index, int* v) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glVertexAttrib4Niv"))(index, v);
	}

	internal static unsafe void VertexAttrib4NivARB(uint index, int* v) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glVertexAttrib4NivARB"))(index, v);
	}

	internal static unsafe void VertexAttrib4Nsv(uint index, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glVertexAttrib4Nsv"))(index, v);
	}

	internal static unsafe void VertexAttrib4NsvARB(uint index, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glVertexAttrib4NsvARB"))(index, v);
	}

	internal static unsafe void VertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w) {
		((delegate* unmanaged<uint, byte, byte, byte, byte, void>) Context.GetProcAddress("glVertexAttrib4Nub"))(index, x, y, z, w);
	}

	internal static unsafe void VertexAttrib4NubARB(uint index, byte x, byte y, byte z, byte w) {
		((delegate* unmanaged<uint, byte, byte, byte, byte, void>) Context.GetProcAddress("glVertexAttrib4NubARB"))(index, x, y, z, w);
	}

	internal static unsafe void VertexAttrib4Nubv(uint index, byte* v) {
		((delegate* unmanaged<uint, byte*, void>) Context.GetProcAddress("glVertexAttrib4Nubv"))(index, v);
	}

	internal static unsafe void VertexAttrib4NubvARB(uint index, byte* v) {
		((delegate* unmanaged<uint, byte*, void>) Context.GetProcAddress("glVertexAttrib4NubvARB"))(index, v);
	}

	internal static unsafe void VertexAttrib4Nuiv(uint index, uint* v) {
		((delegate* unmanaged<uint, uint*, void>) Context.GetProcAddress("glVertexAttrib4Nuiv"))(index, v);
	}

	internal static unsafe void VertexAttrib4NuivARB(uint index, uint* v) {
		((delegate* unmanaged<uint, uint*, void>) Context.GetProcAddress("glVertexAttrib4NuivARB"))(index, v);
	}

	internal static unsafe void VertexAttrib4Nusv(uint index, ushort* v) {
		((delegate* unmanaged<uint, ushort*, void>) Context.GetProcAddress("glVertexAttrib4Nusv"))(index, v);
	}

	internal static unsafe void VertexAttrib4NusvARB(uint index, ushort* v) {
		((delegate* unmanaged<uint, ushort*, void>) Context.GetProcAddress("glVertexAttrib4NusvARB"))(index, v);
	}

	internal static unsafe void VertexAttrib4bv(uint index, sbyte* v) {
		((delegate* unmanaged<uint, sbyte*, void>) Context.GetProcAddress("glVertexAttrib4bv"))(index, v);
	}

	internal static unsafe void VertexAttrib4bvARB(uint index, sbyte* v) {
		((delegate* unmanaged<uint, sbyte*, void>) Context.GetProcAddress("glVertexAttrib4bvARB"))(index, v);
	}

	internal static unsafe void VertexAttrib4d(uint index, double x, double y, double z, double w) {
		((delegate* unmanaged<uint, double, double, double, double, void>) Context.GetProcAddress("glVertexAttrib4d"))(index, x, y, z, w);
	}

	internal static unsafe void VertexAttrib4dARB(uint index, double x, double y, double z, double w) {
		((delegate* unmanaged<uint, double, double, double, double, void>) Context.GetProcAddress("glVertexAttrib4dARB"))(index, x, y, z, w);
	}

	internal static unsafe void VertexAttrib4dv(uint index, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glVertexAttrib4dv"))(index, v);
	}

	internal static unsafe void VertexAttrib4dvARB(uint index, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glVertexAttrib4dvARB"))(index, v);
	}

	internal static unsafe void VertexAttrib4f(uint index, float x, float y, float z, float w) {
		((delegate* unmanaged<uint, float, float, float, float, void>) Context.GetProcAddress("glVertexAttrib4f"))(index, x, y, z, w);
	}

	internal static unsafe void VertexAttrib4fARB(uint index, float x, float y, float z, float w) {
		((delegate* unmanaged<uint, float, float, float, float, void>) Context.GetProcAddress("glVertexAttrib4fARB"))(index, x, y, z, w);
	}

	internal static unsafe void VertexAttrib4fv(uint index, float* v) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glVertexAttrib4fv"))(index, v);
	}

	internal static unsafe void VertexAttrib4fvARB(uint index, float* v) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glVertexAttrib4fvARB"))(index, v);
	}

	internal static unsafe void VertexAttrib4iv(uint index, int* v) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glVertexAttrib4iv"))(index, v);
	}

	internal static unsafe void VertexAttrib4ivARB(uint index, int* v) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glVertexAttrib4ivARB"))(index, v);
	}

	internal static unsafe void VertexAttrib4s(uint index, short x, short y, short z, short w) {
		((delegate* unmanaged<uint, short, short, short, short, void>) Context.GetProcAddress("glVertexAttrib4s"))(index, x, y, z, w);
	}

	internal static unsafe void VertexAttrib4sARB(uint index, short x, short y, short z, short w) {
		((delegate* unmanaged<uint, short, short, short, short, void>) Context.GetProcAddress("glVertexAttrib4sARB"))(index, x, y, z, w);
	}

	internal static unsafe void VertexAttrib4sv(uint index, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glVertexAttrib4sv"))(index, v);
	}

	internal static unsafe void VertexAttrib4svARB(uint index, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glVertexAttrib4svARB"))(index, v);
	}

	internal static unsafe void VertexAttrib4ubv(uint index, byte* v) {
		((delegate* unmanaged<uint, byte*, void>) Context.GetProcAddress("glVertexAttrib4ubv"))(index, v);
	}

	internal static unsafe void VertexAttrib4ubvARB(uint index, byte* v) {
		((delegate* unmanaged<uint, byte*, void>) Context.GetProcAddress("glVertexAttrib4ubvARB"))(index, v);
	}

	internal static unsafe void VertexAttrib4uiv(uint index, uint* v) {
		((delegate* unmanaged<uint, uint*, void>) Context.GetProcAddress("glVertexAttrib4uiv"))(index, v);
	}

	internal static unsafe void VertexAttrib4uivARB(uint index, uint* v) {
		((delegate* unmanaged<uint, uint*, void>) Context.GetProcAddress("glVertexAttrib4uivARB"))(index, v);
	}

	internal static unsafe void VertexAttrib4usv(uint index, ushort* v) {
		((delegate* unmanaged<uint, ushort*, void>) Context.GetProcAddress("glVertexAttrib4usv"))(index, v);
	}

	internal static unsafe void VertexAttrib4usvARB(uint index, ushort* v) {
		((delegate* unmanaged<uint, ushort*, void>) Context.GetProcAddress("glVertexAttrib4usvARB"))(index, v);
	}

	internal static unsafe void VertexAttribBinding(uint attribindex, uint bindingindex) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glVertexAttribBinding"))(attribindex, bindingindex);
	}

	internal static unsafe void VertexAttribDivisor(uint index, uint divisor) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glVertexAttribDivisor"))(index, divisor);
	}

	internal static unsafe void VertexAttribDivisorARB(uint index, uint divisor) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glVertexAttribDivisorARB"))(index, divisor);
	}

	internal static unsafe void VertexAttribFormat(uint attribindex, int size, uint type, byte normalized, uint relativeoffset) {
		((delegate* unmanaged<uint, int, uint, byte, uint, void>) Context.GetProcAddress("glVertexAttribFormat"))(attribindex, size, type, normalized, relativeoffset);
	}

	internal static unsafe void VertexAttribI1i(uint index, int x) {
		((delegate* unmanaged<uint, int, void>) Context.GetProcAddress("glVertexAttribI1i"))(index, x);
	}

	internal static unsafe void VertexAttribI1iv(uint index, int* v) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glVertexAttribI1iv"))(index, v);
	}

	internal static unsafe void VertexAttribI1ui(uint index, uint x) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glVertexAttribI1ui"))(index, x);
	}

	internal static unsafe void VertexAttribI1uiv(uint index, uint* v) {
		((delegate* unmanaged<uint, uint*, void>) Context.GetProcAddress("glVertexAttribI1uiv"))(index, v);
	}

	internal static unsafe void VertexAttribI2i(uint index, int x, int y) {
		((delegate* unmanaged<uint, int, int, void>) Context.GetProcAddress("glVertexAttribI2i"))(index, x, y);
	}

	internal static unsafe void VertexAttribI2iv(uint index, int* v) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glVertexAttribI2iv"))(index, v);
	}

	internal static unsafe void VertexAttribI2ui(uint index, uint x, uint y) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glVertexAttribI2ui"))(index, x, y);
	}

	internal static unsafe void VertexAttribI2uiv(uint index, uint* v) {
		((delegate* unmanaged<uint, uint*, void>) Context.GetProcAddress("glVertexAttribI2uiv"))(index, v);
	}

	internal static unsafe void VertexAttribI3i(uint index, int x, int y, int z) {
		((delegate* unmanaged<uint, int, int, int, void>) Context.GetProcAddress("glVertexAttribI3i"))(index, x, y, z);
	}

	internal static unsafe void VertexAttribI3iv(uint index, int* v) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glVertexAttribI3iv"))(index, v);
	}

	internal static unsafe void VertexAttribI3ui(uint index, uint x, uint y, uint z) {
		((delegate* unmanaged<uint, uint, uint, uint, void>) Context.GetProcAddress("glVertexAttribI3ui"))(index, x, y, z);
	}

	internal static unsafe void VertexAttribI3uiv(uint index, uint* v) {
		((delegate* unmanaged<uint, uint*, void>) Context.GetProcAddress("glVertexAttribI3uiv"))(index, v);
	}

	internal static unsafe void VertexAttribI4bv(uint index, sbyte* v) {
		((delegate* unmanaged<uint, sbyte*, void>) Context.GetProcAddress("glVertexAttribI4bv"))(index, v);
	}

	internal static unsafe void VertexAttribI4i(uint index, int x, int y, int z, int w) {
		((delegate* unmanaged<uint, int, int, int, int, void>) Context.GetProcAddress("glVertexAttribI4i"))(index, x, y, z, w);
	}

	internal static unsafe void VertexAttribI4iv(uint index, int* v) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glVertexAttribI4iv"))(index, v);
	}

	internal static unsafe void VertexAttribI4sv(uint index, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glVertexAttribI4sv"))(index, v);
	}

	internal static unsafe void VertexAttribI4ubv(uint index, byte* v) {
		((delegate* unmanaged<uint, byte*, void>) Context.GetProcAddress("glVertexAttribI4ubv"))(index, v);
	}

	internal static unsafe void VertexAttribI4ui(uint index, uint x, uint y, uint z, uint w) {
		((delegate* unmanaged<uint, uint, uint, uint, uint, void>) Context.GetProcAddress("glVertexAttribI4ui"))(index, x, y, z, w);
	}

	internal static unsafe void VertexAttribI4uiv(uint index, uint* v) {
		((delegate* unmanaged<uint, uint*, void>) Context.GetProcAddress("glVertexAttribI4uiv"))(index, v);
	}

	internal static unsafe void VertexAttribI4usv(uint index, ushort* v) {
		((delegate* unmanaged<uint, ushort*, void>) Context.GetProcAddress("glVertexAttribI4usv"))(index, v);
	}

	internal static unsafe void VertexAttribIFormat(uint attribindex, int size, uint type, uint relativeoffset) {
		((delegate* unmanaged<uint, int, uint, uint, void>) Context.GetProcAddress("glVertexAttribIFormat"))(attribindex, size, type, relativeoffset);
	}

	internal static unsafe void VertexAttribIPointer(uint index, int size, uint type, int stride, void* pointer) {
		((delegate* unmanaged<uint, int, uint, int, void*, void>) Context.GetProcAddress("glVertexAttribIPointer"))(index, size, type, stride, pointer);
	}

	internal static unsafe void VertexAttribL1d(uint index, double x) {
		((delegate* unmanaged<uint, double, void>) Context.GetProcAddress("glVertexAttribL1d"))(index, x);
	}

	internal static unsafe void VertexAttribL1dv(uint index, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glVertexAttribL1dv"))(index, v);
	}

	internal static unsafe void VertexAttribL2d(uint index, double x, double y) {
		((delegate* unmanaged<uint, double, double, void>) Context.GetProcAddress("glVertexAttribL2d"))(index, x, y);
	}

	internal static unsafe void VertexAttribL2dv(uint index, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glVertexAttribL2dv"))(index, v);
	}

	internal static unsafe void VertexAttribL3d(uint index, double x, double y, double z) {
		((delegate* unmanaged<uint, double, double, double, void>) Context.GetProcAddress("glVertexAttribL3d"))(index, x, y, z);
	}

	internal static unsafe void VertexAttribL3dv(uint index, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glVertexAttribL3dv"))(index, v);
	}

	internal static unsafe void VertexAttribL4d(uint index, double x, double y, double z, double w) {
		((delegate* unmanaged<uint, double, double, double, double, void>) Context.GetProcAddress("glVertexAttribL4d"))(index, x, y, z, w);
	}

	internal static unsafe void VertexAttribL4dv(uint index, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glVertexAttribL4dv"))(index, v);
	}

	internal static unsafe void VertexAttribLFormat(uint attribindex, int size, uint type, uint relativeoffset) {
		((delegate* unmanaged<uint, int, uint, uint, void>) Context.GetProcAddress("glVertexAttribLFormat"))(attribindex, size, type, relativeoffset);
	}

	internal static unsafe void VertexAttribLPointer(uint index, int size, uint type, int stride, void* pointer) {
		((delegate* unmanaged<uint, int, uint, int, void*, void>) Context.GetProcAddress("glVertexAttribLPointer"))(index, size, type, stride, pointer);
	}

	internal static unsafe void VertexAttribP1ui(uint index, uint type, byte normalized, uint value) {
		((delegate* unmanaged<uint, uint, byte, uint, void>) Context.GetProcAddress("glVertexAttribP1ui"))(index, type, normalized, value);
	}

	internal static unsafe void VertexAttribP1uiv(uint index, uint type, byte normalized, uint* value) {
		((delegate* unmanaged<uint, uint, byte, uint*, void>) Context.GetProcAddress("glVertexAttribP1uiv"))(index, type, normalized, value);
	}

	internal static unsafe void VertexAttribP2ui(uint index, uint type, byte normalized, uint value) {
		((delegate* unmanaged<uint, uint, byte, uint, void>) Context.GetProcAddress("glVertexAttribP2ui"))(index, type, normalized, value);
	}

	internal static unsafe void VertexAttribP2uiv(uint index, uint type, byte normalized, uint* value) {
		((delegate* unmanaged<uint, uint, byte, uint*, void>) Context.GetProcAddress("glVertexAttribP2uiv"))(index, type, normalized, value);
	}

	internal static unsafe void VertexAttribP3ui(uint index, uint type, byte normalized, uint value) {
		((delegate* unmanaged<uint, uint, byte, uint, void>) Context.GetProcAddress("glVertexAttribP3ui"))(index, type, normalized, value);
	}

	internal static unsafe void VertexAttribP3uiv(uint index, uint type, byte normalized, uint* value) {
		((delegate* unmanaged<uint, uint, byte, uint*, void>) Context.GetProcAddress("glVertexAttribP3uiv"))(index, type, normalized, value);
	}

	internal static unsafe void VertexAttribP4ui(uint index, uint type, byte normalized, uint value) {
		((delegate* unmanaged<uint, uint, byte, uint, void>) Context.GetProcAddress("glVertexAttribP4ui"))(index, type, normalized, value);
	}

	internal static unsafe void VertexAttribP4uiv(uint index, uint type, byte normalized, uint* value) {
		((delegate* unmanaged<uint, uint, byte, uint*, void>) Context.GetProcAddress("glVertexAttribP4uiv"))(index, type, normalized, value);
	}

	internal static unsafe void VertexAttribPointer(uint index, int size, uint type, byte normalized, int stride, void* pointer) {
		((delegate* unmanaged<uint, int, uint, byte, int, void*, void>) Context.GetProcAddress("glVertexAttribPointer"))(index, size, type, normalized, stride, pointer);
	}

	internal static unsafe void VertexAttribPointerARB(uint index, int size, uint type, byte normalized, int stride, void* pointer) {
		((delegate* unmanaged<uint, int, uint, byte, int, void*, void>) Context.GetProcAddress("glVertexAttribPointerARB"))(index, size, type, normalized, stride, pointer);
	}

	internal static unsafe void VertexBindingDivisor(uint bindingindex, uint divisor) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glVertexBindingDivisor"))(bindingindex, divisor);
	}

	internal static unsafe void Viewport(int x, int y, int width, int height) {
		((delegate* unmanaged<int, int, int, int, void>) Context.GetProcAddress("glViewport"))(x, y, width, height);
	}

	internal static unsafe void ViewportArrayv(uint first, int count, float* v) {
		((delegate* unmanaged<uint, int, float*, void>) Context.GetProcAddress("glViewportArrayv"))(first, count, v);
	}

	internal static unsafe void ViewportIndexedf(uint index, float x, float y, float w, float h) {
		((delegate* unmanaged<uint, float, float, float, float, void>) Context.GetProcAddress("glViewportIndexedf"))(index, x, y, w, h);
	}

	internal static unsafe void ViewportIndexedfv(uint index, float* v) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glViewportIndexedfv"))(index, v);
	}

	internal static unsafe void WaitSync(GLSync sync, uint flags, nint timeout) {
		((delegate* unmanaged<GLSync, uint, nint, void>) Context.GetProcAddress("glWaitSync"))(sync, flags, timeout);
	}
}