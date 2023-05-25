using System;
using System.Runtime.InteropServices;

namespace DevIL.NET
{
	public static class IL
	{
		private const string dllName = "DevIL.dll";

		[DllImport(dllName, EntryPoint = "ilActiveFace")]
		public static extern bool ActiveFace(int Number);

		[DllImport(dllName, EntryPoint = "ilActiveImage")]
		public static extern bool ActiveImage(int Number);

		[DllImport(dllName, EntryPoint = "ilActiveLayer")]
		public static extern bool ActiveLayer(int Number);

		[DllImport(dllName, EntryPoint = "ilActiveMipmap")]
		public static extern bool ActiveMipmap(int Number);

		[DllImport(dllName, EntryPoint = "ilApplyPal")]
		public static extern bool ApplyPal(string FileName);

		[DllImport(dllName, EntryPoint = "ilApplyProfile")]
		public static extern bool ApplyProfile(string InProfile, string OutProfile);

		[DllImport(dllName, EntryPoint = "ilBindImage")]
		public static extern void BindImage(int Image);

		[DllImport(dllName, EntryPoint = "ilBlit")]
		public static extern bool Blit(int Source, int DestX, int DestY, int DestZ, int SrcX, int SrcY, int SrcZ, int Width, int Height, int Depth);

		[DllImport(dllName, EntryPoint = "ilClampNTSC")]
		public static extern bool ClampNTSC();

		[DllImport(dllName, EntryPoint = "ilClearColour")]
		public static extern void ClearColour(float Red, float Green, float Blue, float Alpha);

		[DllImport(dllName, EntryPoint = "ilClearImage")]
		public static extern bool ClearImage();

		[DllImport(dllName, EntryPoint = "ilCloneCurImage")]
		public static extern int CloneCurImage();

		[DllImport(dllName, EntryPoint = "ilCompressDXT")]
		public static extern IntPtr CompressDXT(IntPtr Data, int Width, int Height, int Depth, CompressedDataFormat DXTCFormat, ref int DXTCSize);

		[DllImport(dllName, EntryPoint = "ilCompressFunc")]
		public static extern bool CompressFunc(CompressMode Mode);

		[DllImport(dllName, EntryPoint = "ilConvertImage")]
		public static extern bool ConvertImage(ChannelFormat DestFormat, ChannelType DestType);

		[DllImport(dllName, EntryPoint = "ilConvertPal")]
		public static extern bool ConvertPal(PaletteType DestFormat);

		[DllImport(dllName, EntryPoint = "ilCopyImage")]
		public static extern bool CopyImage(int Src);

		[DllImport(dllName, EntryPoint = "ilCopyPixels")]
		public static extern int CopyPixels(int XOff, int YOff, int ZOff, int Width, int Height, int Depth, ChannelFormat Format, ChannelType Type, byte[] Data);

		[DllImport(dllName, EntryPoint = "ilCreateSubImage")]
		public static extern int CreateSubImage(SubImageType Type, int Num);

		[DllImport(dllName, EntryPoint = "ilDefaultImage")]
		public static extern bool DefaultImage();

		[DllImport(dllName, EntryPoint = "ilDeleteImage")]
		public static extern void DeleteImage(int Num);

		[DllImport(dllName, EntryPoint = "ilDeleteImages")]
		public static extern void DeleteImages(IntPtr Num, int[] Images);

		[DllImport(dllName, EntryPoint = "ilDetermineType")]
		public static extern ImageType DetermineType(string FileName);

		[DllImport(dllName, EntryPoint = "ilDetermineTypeF")]
		public static extern ImageType DetermineTypeF(byte[] File);

		[DllImport(dllName, EntryPoint = "ilDetermineTypeL")]
		public static extern ImageType DetermineTypeL(byte[] Lump, int Size);

		[DllImport(dllName, EntryPoint = "ilDisable")]
		public static extern bool Disable(EnableCap Mode);

		[DllImport(dllName, EntryPoint = "ilDxtcDataToImage")]
		public static extern bool DxtcDataToImage();

		[DllImport(dllName, EntryPoint = "ilDxtcDataToSurface")]
		public static extern bool DxtcDataToSurface();

		[DllImport(dllName, EntryPoint = "ilEnable")]
		public static extern bool Enable(EnableCap Mode);

		[DllImport(dllName, EntryPoint = "ilFlipSurfaceDxtcData")]
		public static extern void FlipSurfaceDxtcData();

		[DllImport(dllName, EntryPoint = "ilFormatFunc")]
		public static extern bool FormatFunc(ChannelFormat Mode);

		[DllImport(dllName, EntryPoint = "ilGenImages")]
		public static extern void GenImages(IntPtr Num, int[] Images);

		[DllImport(dllName, EntryPoint = "ilGenImage")]
		public static extern int GenImage();

		[DllImport(dllName, EntryPoint = "ilGetAlpha")]
		public static extern IntPtr GetAlpha(ChannelType Type);

		[DllImport(dllName, EntryPoint = "ilGetBoolean")]
		public static extern bool GetBoolean(BooleanName Mode);

		[DllImport(dllName, EntryPoint = "ilGetBooleanv")]
		public static extern void GetBooleanv(BooleanName Mode, bool[] Param);

		[DllImport(dllName, EntryPoint = "ilGetData")]
		public static extern IntPtr GetData();

		[DllImport(dllName, EntryPoint = "ilGetDXTCData")]
		public static extern int GetDXTCData(byte[] Buffer, int BufferSize, CompressedDataFormat DXTCFormat);

		[DllImport(dllName, EntryPoint = "ilGetError")]
		public static extern ErrorCode GetError();

		[DllImport(dllName, EntryPoint = "ilGetInteger")]
		public static extern int GetInteger(IntName Mode);

		[DllImport(dllName, EntryPoint = "ilGetIntegerv")]
		public static extern void GetIntegerv(IntName Mode, int[] Param);

		[DllImport(dllName, EntryPoint = "ilGetLumpPos")]
		public static extern int GetLumpPos();

		[DllImport(dllName, EntryPoint = "ilGetPalette")]
		public static extern IntPtr GetPalette();

		[DllImport(dllName, EntryPoint = "ilGetString")]
		public static extern string GetString(StringName StringName);

		//[DllImport(lib, EntryPoint="ilHint")]
		//public static extern void Hint(ILenum Target, ILenum Mode);

		[DllImport(dllName, EntryPoint = "ilInvertSurfaceDxtcDataAlpha")]
		public static extern bool InvertSurfaceDxtcDataAlpha();

		[DllImport(dllName, EntryPoint = "ilInit")]
		public static extern void Init();

		[DllImport(dllName, EntryPoint = "ilImageToDxtcData")]
		public static extern bool ImageToDxtcData(CompressedDataFormat Format);

		[DllImport(dllName, EntryPoint = "ilIsDisabled")]
		public static extern bool IsDisabled(EnableCap Mode);

		[DllImport(dllName, EntryPoint = "ilIsEnabled")]
		public static extern bool IsEnabled(EnableCap Mode);

		[DllImport(dllName, EntryPoint = "ilIsImage")]
		public static extern bool IsImage(int Image);

		[DllImport(dllName, EntryPoint = "ilIsValid")]
		public static extern bool IsValid(ImageType Type, string FileName);

		[DllImport(dllName, EntryPoint = "ilIsValidF")]
		public static extern bool IsValidF(ImageType Type, byte[] File);

		[DllImport(dllName, EntryPoint = "ilIsValidL")]
		public static extern bool IsValidL(ImageType Type, byte[] Lump, int Size);

		[DllImport(dllName, EntryPoint = "ilKeyColour")]
		public static extern void KeyColour(float Red, float Green, float Blue, float Alpha);

		[DllImport(dllName, EntryPoint = "ilLoad")]
		public static extern bool Load(ImageType Type, string FileName);

		[DllImport(dllName, EntryPoint = "ilLoadF")]
		public static extern bool LoadF(ImageType Type, byte[] File);

		[DllImport(dllName, EntryPoint = "ilLoadImage")]
		public static extern bool LoadImage(string FileName);

		[DllImport(dllName, EntryPoint = "ilLoadL")]
		public static extern bool LoadL(ImageType Type, byte[] Lump, int Size);

		[DllImport(dllName, EntryPoint = "ilLoadPal")]
		public static extern bool LoadPal(string FileName);

		[DllImport(dllName, EntryPoint = "ilModAlpha")]
		public static extern void ModAlpha(float AlphaValue);

		[DllImport(dllName, EntryPoint = "ilOriginFunc")]
		public static extern bool OriginFunc(OriginMode Mode);

		[DllImport(dllName, EntryPoint = "ilOverlayImage")]
		public static extern bool OverlayImage(int Source, int XCoord, int YCoord, int ZCoord);

		[DllImport(dllName, EntryPoint = "ilPopAttrib")]
		public static extern void PopAttrib();

		[DllImport(dllName, EntryPoint = "ilPushAttrib")]
		public static extern void PushAttrib(int Bits);

		[DllImport(dllName, EntryPoint = "ilRegisterFormat")]
		public static extern void RegisterFormat(ChannelFormat Format);

		//[DllImport(lib, EntryPoint="ilRegisterLoad")]
		//public static extern bool RegisterLoad(string Ext, IL_LOADPROC Load);

		[DllImport(dllName, EntryPoint = "ilRegisterMipNum")]
		public static extern bool RegisterMipNum(int Num);

		[DllImport(dllName, EntryPoint = "ilRegisterNumFaces")]
		public static extern bool RegisterNumFaces(int Num);

		[DllImport(dllName, EntryPoint = "ilRegisterNumImages")]
		public static extern bool RegisterNumImages(int Num);

		[DllImport(dllName, EntryPoint = "ilRegisterOrigin")]
		public static extern void RegisterOrigin(OriginMode Origin);

		[DllImport(dllName, EntryPoint = "ilRegisterPal")]
		public static extern void RegisterPal(byte[] Pal, int Size, PaletteType Type);

		//[DllImport(lib, EntryPoint="ilRegisterSave")]
		//public static extern bool RegisterSave(string Ext, IL_SAVEPROC Save);

		[DllImport(dllName, EntryPoint = "ilRegisterType")]
		public static extern void RegisterType(ChannelType Type);

		[DllImport(dllName, EntryPoint = "ilRemoveLoad")]
		public static extern bool RemoveLoad(string Ext);

		[DllImport(dllName, EntryPoint = "ilRemoveSave")]
		public static extern bool RemoveSave(string Ext);

		[DllImport(dllName, EntryPoint = "ilResetMemory")]
		public static extern void ResetMemory(); // Deprecated

		[DllImport(dllName, EntryPoint = "ilResetRead")]
		public static extern void ResetRead();

		[DllImport(dllName, EntryPoint = "ilResetWrite")]
		public static extern void ResetWrite();

		[DllImport(dllName, EntryPoint = "ilSave")]
		public static extern bool Save(ImageType Type, string FileName);

		[DllImport(dllName, EntryPoint = "ilSaveF")]
		public static extern int SaveF(ImageType Type, byte[] File);

		[DllImport(dllName, EntryPoint = "ilSaveImage")]
		public static extern bool SaveImage(string FileName);

		[DllImport(dllName, EntryPoint = "ilSaveL")]
		public static extern int SaveL(ImageType Type, byte[] Lump, int Size);

		[DllImport(dllName, EntryPoint = "ilSavePal")]
		public static extern bool SavePal(string FileName);

		[DllImport(dllName, EntryPoint = "ilSetAlpha")]
		public static extern bool SetAlpha(float AlphaValue);

		[DllImport(dllName, EntryPoint = "ilSetData")]
		public static extern bool SetData(byte[] Data);

		[DllImport(dllName, EntryPoint = "ilSetDuration")]
		public static extern bool SetDuration(int Duration);

		[DllImport(dllName, EntryPoint = "ilSetInteger")]
		public static extern void SetInteger(IntName Mode, int Param);

		//[DllImport(lib, EntryPoint="ilSetMemory")]
		//public static extern void SetMemory(mAlloc, mFree);

		[DllImport(dllName, EntryPoint = "ilSetPixels")]
		public static extern void SetPixels(int XOff, int YOff, int ZOff, int Width, int Height, int Depth, ChannelFormat Format, ChannelType Type, byte[] Data);

		//[DllImport(lib, EntryPoint="ilSetRead")]
		//public static extern void SetRead(fOpenRProc, fCloseRProc, fEofProc, fGetcProc, fReadProc, fSeekRProc, fTellRProc);

		[DllImport(dllName, EntryPoint = "ilSetString")]
		public static extern void SetString(StringName Mode, string String);

		//[DllImport(lib, EntryPoint="ilSetWrite")]
		//public static extern void SetWrite(fOpenWProc, fCloseWProc, fPutcProc, fSeekWProc, fTellWProc, fWriteProc);

		[DllImport(dllName, EntryPoint = "ilShutDown")]
		public static extern void ShutDown();

		[DllImport(dllName, EntryPoint = "ilSurfaceToDxtcData")]
		public static extern bool SurfaceToDxtcData(CompressedDataFormat Format);

		[DllImport(dllName, EntryPoint = "ilTexImage")]
		public static extern bool TexImage(int Width, int Height, int Depth, byte NumChannels, ChannelFormat Format, ChannelType Type, byte[] Data);

		[DllImport(dllName, EntryPoint = "ilTexImageDxtc")]
		public static extern bool TexImageDxtc(int w, int h, int d, CompressedDataFormat DxtFormat, IntPtr data);

		//[DllImport(dllName, EntryPoint = "ilTexImageSurface")]
		//public static extern bool TexImageSurface(int Width, int Height, int Depth, byte NumChannels, ChannelFormat Format, ChannelType Type, byte[] Data);

		[DllImport(dllName, EntryPoint = "ilTypeFromExt")]
		public static extern ImageType TypeFromExt(string FileName);

		[DllImport(dllName, EntryPoint = "ilTypeFunc")]
		public static extern bool TypeFunc(ChannelType Mode);

		[DllImport(dllName, EntryPoint = "ilLoadData")]
		public static extern bool LoadData(string FileName, int Width, int Height, int Depth, byte Bpp);

		[DllImport(dllName, EntryPoint = "ilLoadDataF")]
		public static extern bool LoadDataF(byte[] File, int Width, int Height, int Depth, byte Bpp);

		[DllImport(dllName, EntryPoint = "ilLoadDataL")]
		public static extern bool LoadDataL(byte[] Lump, int Size, int Width, int Height, int Depth, byte Bpp);

		[DllImport(dllName, EntryPoint = "ilSaveData")]
		public static extern bool SaveData(string FileName);
	}
}
