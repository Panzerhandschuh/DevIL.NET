using System.Runtime.InteropServices;

namespace DevIL.NET
{
	public static class ILU
	{
		private const string dllName = "ILU.dll";

		public class Info
		{
			/// <summary> the image's id </summary>
			public int Id;

			/// <summary> the image's data </summary>
			public IntPtr Data;

			/// <summary> the image's width </summary>
			public int Width;

			/// <summary> the image's height </summary>
			public int Height;

			/// <summary> the image's depth </summary>
			public int Depth;

			/// <summary> bytes per pixel (not bits) of the image </summary>
			public byte Bpp;

			/// <summary> the total size of the data (in bytes) </summary>
			public int SizeOfData;

			/// <summary> image format (in IL enum style) </summary>
			public ChannelFormat Format;

			/// <summary> image type (in IL enum style) </summary>
			public ChannelType Type;

			/// <summary> origin of the image </summary>
			public OriginMode Origin;

			/// <summary> the image's palette </summary>
			public IntPtr Palette;

			/// <summary> palette type </summary>
			public PaletteType PalType;

			/// <summary> palette size </summary>
			public int PalSize;

			/// <summary> flags for what cube map sides are present </summary>
			public CubeFace CubeFlags;

			/// <summary> number of images following </summary>
			public int NumNext;

			/// <summary> number of mipmaps </summary>
			public int NumMips;

			/// <summary> number of layers </summary>
			public int NumLayers;

			public override string ToString()
			{
				var str = string.Join("; ",
					$"Id = {Id}",
					$"Width = {Width}",
					$"Height = {Height}",
					$"Depth = {Depth}",
					$"Bpp = {Bpp}",
					$"SizeOfData = {SizeOfData}",
					$"Type = {Type}",
					$"Origin = {Origin}",
					$"PalType = {PalType}",
					$"PalSize = {PalSize}",
					$"CubeFlags = {CubeFlags}",
					$"NumNext = {NumNext}",
					$"NumMips = {NumMips}",
					$"NumLayers = {NumLayers}"
				);

				return $"ILU.Info {str}";
			}
		}

		public class P2f
		{
			public float x;
			public float y;

			public P2f(float x, float y)
			{
				this.x = x;
				this.y = y;
			}
		}

		public class P2i
		{
			public int x;
			public int y;

			public P2i(int x, int y)
			{
				this.x = x;
				this.y = y;
			}
		}

		[DllImport(dllName, EntryPoint = "iluAlienify")]
		public static extern bool Alienify();

		[DllImport(dllName, EntryPoint = "iluBlurAvg")]
		public static extern bool BlurAvg(int Iter);

		[DllImport(dllName, EntryPoint = "iluBlurGaussian")]
		public static extern bool BlurGaussian(int Iter);

		[DllImport(dllName, EntryPoint = "iluBuildMipmaps")]
		public static extern bool BuildMipmaps();

		[DllImport(dllName, EntryPoint = "iluColoursUsed")]
		public static extern int ColoursUsed();

		[DllImport(dllName, EntryPoint = "iluCompareImage")]
		public static extern bool CompareImage(int Comp);

		[DllImport(dllName, EntryPoint = "iluContrast")]
		public static extern bool Contrast(float Contrast);

		[DllImport(dllName, EntryPoint = "iluCrop")]
		public static extern bool Crop(int XOff, int YOff, int ZOff, int Width, int Height, int Depth);

		[DllImport(dllName, EntryPoint = "iluDeleteImage")]
		public static extern void DeleteImage(int Id); // Deprecated

		[DllImport(dllName, EntryPoint = "iluEdgeDetectE")]
		public static extern bool EdgeDetectE();

		[DllImport(dllName, EntryPoint = "iluEdgeDetectP")]
		public static extern bool EdgeDetectP();

		[DllImport(dllName, EntryPoint = "iluEdgeDetectS")]
		public static extern bool EdgeDetectS();

		[DllImport(dllName, EntryPoint = "iluEmboss")]
		public static extern bool Emboss();

		[DllImport(dllName, EntryPoint = "iluEnlargeCanvas")]
		public static extern bool EnlargeCanvas(int Width, int Height, int Depth);

		[DllImport(dllName, EntryPoint = "iluEnlargeImage")]
		public static extern bool EnlargeImage(float XDim, float YDim, float ZDim);

		[DllImport(dllName, EntryPoint = "iluEqualize")]
		public static extern bool Equalize();

		[DllImport(dllName, EntryPoint = "iluEqualize2")]
		public static extern bool Equalize2();

		[DllImport(dllName, EntryPoint = "iluErrorString")]
		public static extern IntPtr ErrorString(ErrorCode Error);

		[DllImport(dllName, EntryPoint = "iluConvolution")]
		public static extern bool Convolution(int[] matrix, int scale, int bias);

		[DllImport(dllName, EntryPoint = "iluFlipImage")]
		public static extern bool FlipImage();

		[DllImport(dllName, EntryPoint = "iluGammaCorrect")]
		public static extern bool GammaCorrect(float Gamma);

		[DllImport(dllName, EntryPoint = "iluGenImage")]
		public static extern int GenImage(); // Deprecated

		[DllImport(dllName, EntryPoint = "iluGetImageInfo")]
		public static extern void GetImageInfo(ref Info Info);

		[DllImport(dllName, EntryPoint = "iluGetInteger")]
		public static extern int GetInteger(IntName Mode);

		[DllImport(dllName, EntryPoint = "iluGetIntegerv")]
		public static extern void GetIntegerv(IntName Mode, int[] Param);

		[DllImport(dllName, EntryPoint = "iluGetString")]
		public static extern string GetString(StringName StringName);

		[DllImport(dllName, EntryPoint = "iluImageParameter")]
		public static extern void ImageParameter(ImageParameterName PName, int Param);

		[DllImport(dllName, EntryPoint = "iluInit")]
		public static extern void Init();

		[DllImport(dllName, EntryPoint = "iluInvertAlpha")]
		public static extern bool InvertAlpha();

		[DllImport(dllName, EntryPoint = "iluLoadImage")]
		public static extern int LoadImage(string FileName);

		[DllImport(dllName, EntryPoint = "iluMirror")]
		public static extern bool Mirror();

		[DllImport(dllName, EntryPoint = "iluNegative")]
		public static extern bool Negative();

		[DllImport(dllName, EntryPoint = "iluNoisify")]
		public static extern bool Noisify(float Tolerance);

		[DllImport(dllName, EntryPoint = "iluPixelize")]
		public static extern bool Pixelize(int PixSize);

		[DllImport(dllName, EntryPoint = "iluRegionfv")]
		public static extern void Regionfv(P2f[] Points, int n);

		[DllImport(dllName, EntryPoint = "iluRegioniv")]
		public static extern void Regioniv(P2i[] Points, int n);

		[DllImport(dllName, EntryPoint = "iluReplaceColour")]
		public static extern bool ReplaceColour(byte Red, byte Green, byte Blue, float Tolerance);

		[DllImport(dllName, EntryPoint = "iluRotate")]
		public static extern bool Rotate(float Angle);

		[DllImport(dllName, EntryPoint = "iluRotate3D")]
		public static extern bool Rotate3D(float x, float y, float z, float Angle);

		[DllImport(dllName, EntryPoint = "iluSaturate1f")]
		public static extern bool Saturate1f(float Saturation);

		[DllImport(dllName, EntryPoint = "iluSaturate4f")]
		public static extern bool Saturate4f(float r, float g, float b, float Saturation);

		[DllImport(dllName, EntryPoint = "iluScale")]
		public static extern bool Scale(int Width, int Height, int Depth);

		[DllImport(dllName, EntryPoint = "iluScaleAlpha")]
		public static extern bool ScaleAlpha(float scale);

		[DllImport(dllName, EntryPoint = "iluScaleColours")]
		public static extern bool ScaleColours(float r, float g, float b);

		[DllImport(dllName, EntryPoint = "iluSepia")]
		public static extern bool Sepia();

		[DllImport(dllName, EntryPoint = "iluSetLanguage")]
		public static extern bool SetLanguage(Language Language);

		[DllImport(dllName, EntryPoint = "iluSharpen")]
		public static extern bool Sharpen(float Factor, int Iter);

		[DllImport(dllName, EntryPoint = "iluSwapColours")]
		public static extern bool SwapColours();

		[DllImport(dllName, EntryPoint = "iluWave")]
		public static extern bool Wave(float Angle);
	}
}
