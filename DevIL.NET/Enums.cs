﻿namespace DevIL.NET
{
	public enum IntName
	{
		CurrentImage = 0x0DF7,
		MaxQuantizationIndices = 0x0644,
		NeuQuantizationSample = 0x0643,
		VersionNumber = 0x0DE2,
		VTFCompression = 0x0726,
		JpgQuality = 0x0711,
		PcdPicNumber = 0x0723,
		PngAlphaIndex = 0x0724,
		ActiveImage = 0x0DF4,
		ActiveMipMap = 0x0DF5,
		ActiveLayer = 0x0DF6,
		ImageDuration = 0x0DF8,
		ImageOffsetX = 0x0DFB,
		ImageOffsetY = 0x0DFC,
		ImageWidth = 0x0DE4,
		ImageHeight = 0x0DE5,
		ImageDepth = 0x0DE6,
		ImageBitsPerPixel = 0x0DE9,
		ImageBytesPerPixel = 0x0DE8,
		ImageChannels = 0x0DFF,
		ImageSizeOfData = 0x0DE7,
		ImagePlaneSize = 0x0DF9,
		ImageFaceCount = 0x0DE1,
		ImageArrayCount = 0x0DF1,
		ImageLayerCount = 0x0DF3,
		ImageMipMapCount = 0x0DF2,
		ImagePaletteBytesPerPixel = 0x0DEE,
		ImagePaletteColumnCount = 0x0DEF,
		ImageFormat = 0x0DEA,
		ImageType = 0x0DEB,
		Filter = 0x2600,
	}

	public enum BooleanName
	{
		KeepDxtData = 0x070C,
		BitmapRle = 0x0714,
		PngInterlace = 0x0712,
		SgiRle = 0x0715,
		TgaCreateStamp = 0x0710,
		TgaRle = 0x0713,
	}

	public enum StringName
	{
		TgaID = 0x0717,
		TgaAuthorName = 0x0718,
		TgaAuthorComment = 0x0719,
		PngAuthorName = 0x071A,
		PngTitle = 0x071B,
		PngDescription = 0x071C,
		TifDescription = 0x071D,
		TifHostComputer = 0x071E,
		TifDocumentName = 0x071F,
		TifAuthorName = 0x0720,
		CHeadHeader = 0x0722,
	}

	public enum ChannelFormat
	{
		ColorIndex = 0x1900,
		Alpha = 0x1906,
		RGB = 0x1907,
		RGBA = 0x1908,
		BGR = 0x80E0,
		BGRA = 0x80E1,
		Luminance = 0x1909,
		LuminanceAlpha = 0x190A
	}

	public enum ChannelType
	{
		Byte = 0x1400,
		UnsignedByte = 0x1401,
		Short = 0x1402,
		UnsignedShort = 0x1403,
		Int = 0x1404,
		UnsignedInt = 0x1405,
		Float = 0x1406,
		Double = 0x140A,
		Half = 0x140B
	}

	public enum PaletteType
	{
		None = 0x0400,
		Rgb24 = 0x0401,
		Rgb32 = 0x0402,
		Rgba32 = 0x0403,
		Bgr24 = 0x0404,
		Bgr32 = 0x0405,
		Bgra32 = 0x0406,
	}

	public enum AttributeBits
	{
		OriginBit = 0x00000001,
		FileBit = 0x00000002,
		PalletteBit = 0x00000004,
		FormatBit = 0x00000008,
		TypeBit = 0x00000010,
		CompressBit = 0x00000020,
		LoadFailBit = 0x00000040,
		FormatSpecificBit = 0x00000080,
		All = 0x000FFFFF
	}

	public enum ImageType
	{
		Unknown = 0x0000,
		Bmp = 0x0420,  //!< Microsoft Windows Bitmap - .bmp extension
		Cut = 0x0421,  //!< Dr. Halo - .cut extension
		Doom = 0x0422,  //!< DooM walls - no specific extension
		DoomFlat = 0x0423,  //!< DooM flats - no specific extension
		Ico = 0x0424,  //!< Microsoft Windows Icons and Cursors - .ico and .cur extensions
		Jpg = 0x0425,  //!< JPEG - .jpg, .jpe and .jpeg extensions
		Jfif = 0x0425,  //!<
		Ilbm = 0x0426,  //!< Amiga IFF (FORM ILBM) - .iff, .ilbm, .lbm extensions
		Pcd = 0x0427,  //!< Kodak PhotoCD - .pcd extension
		Pcx = 0x0428,  //!< ZSoft PCX - .pcx extension
		Pic = 0x0429,  //!< PIC - .pic extension
		Png = 0x042A,  //!< Portable Network Graphics - .png extension
		Pnm = 0x042B,  //!< Portable Any Map - .pbm, .pgm, .ppm and .pnm extensions
		Sgi = 0x042C,  //!< Silicon Graphics - .sgi, .bw, .rgb and .rgba extensions
		Tga = 0x042D,  //!< TrueVision Targa File - .tga, .vda, .icb and .vst extensions
		Tif = 0x042E,  //!< Tagged Image File Format - .tif and .tiff extensions
		CHead = 0x042F,  //!< C-Style Header - .h extension
		Raw = 0x0430,  //!< Raw Image Data - any extension
		Mdl = 0x0431,  //!< Half-Life Model Texture - .mdl extension
		Wal = 0x0432,  //!< Quake 2 Texture - .wal extension
		Lif = 0x0434,  //!< Homeworld Texture - .lif extension
		Mng = 0x0435,  //!< Multiple-image Network Graphics - .mng extension
		Jng = 0x0435,  //!< 
		Gif = 0x0436,  //!< Graphics Interchange Format - .gif extension
		Dds = 0x0437,  //!< DirectDraw Surface - .dds extension
		Dcx = 0x0438,  //!< ZSoft Multi-PCX - .dcx extension
		Psd = 0x0439,  //!< Adobe PhotoShop - .psd extension
		Exif = 0x043A,  //!< 
		Psp = 0x043B,  //!< PaintShop Pro - .psp extension
		Pix = 0x043C,  //!< PIX - .pix extension
		Pxr = 0x043D,  //!< Pixar - .pxr extension
		Xpm = 0x043E,  //!< X Pixel Map - .xpm extension
		Hdr = 0x043F,  //!< Radiance High Dynamic Range - .hdr extension
		Icns = 0x0440,  //!< Macintosh Icon - .icns extension
		Jp20 = 0x0441,  //!< Jpeg 2000 - .jp2 extension
		Exr0 = 0x0442,  //!< OpenEXR - .exr extension
		Wdp0 = 0x0443,  //!< Microsoft HD Photo - .wdp and .hdp extension
		Vtf0 = 0x0444,  //!< Valve Texture Format - .vtf extension
		WBmp = 0x0445,  //!< Wireless Bitmap - .wbmp extension
		Sun0 = 0x0446,  //!< Sun Raster - .sun, .ras, .rs, .im1, .im8, .im24 and .im32 extensions
		Iff0 = 0x0447,  //!< Interchange File Format - .iff extension
		Tpl0 = 0x0448,  //!< Gamecube Texture - .tpl extension
		Fits = 0x0449,  //!< Flexible Image Transport System - .fit and .fits extensions
		DiCom = 0x044A,  //!< Digital Imaging and Communications in Medicine (DICOM) - .dcm and .dicom extensions
		Iwi = 0x044B,  //!< Call of Duty Infinity Ward Image - .iwi extension
		Blp = 0x044C,  //!< Blizzard Texture Format - .blp extension
		Ftx = 0x044D,  //!< Heavy Metal: FAKK2 Texture - .ftx extension
		Rot = 0x044E,  //!< Homeworld 2 - Relic Texture - .rot extension
		Texture = 0x044F,  //!< Medieval II: Total War Texture - .texture extension
		Dpx = 0x0450,  //!< Digital Picture Exchange - .dpx extension
		Utx = 0x0451,  //!< Unreal (and Unreal Tournament) Texture - .utx extension
		Mp3 = 0x0452,  //!< MPEG-1 Audio Layer 3 - .mp3 extension
	}

	public enum ErrorCode
	{
		NoError = 0x0000,
		InvalidEnum = 0x0501,
		OutOfMemory = 0x0502,
		FormatNotSupported = 0x0503,
		InternalError = 0x0504,
		InvalidValue = 0x0505,
		IllegalOperation = 0x0506,
		IllegalFileValue = 0x0507,
		InvalidFileHeader = 0x0508,
		InvalidParam = 0x0509,
		CouldNotOpenFile = 0x050A,
		InvalidExtension = 0x050B,
		FileAlreadyExists = 0x050C,
		OutFormatSame = 0x050D,
		StackOverflow = 0x050E,
		StackUnderflow = 0x050F,
		InvalidConversion = 0x0510,
		BadDimensions = 0x0511,
		FileReadError = 0x0512,  // 05/12/2002: Addition by Sam.
		FileWriteError = 0x0512,
		LibGifError = 0x05E1,
		LibJpegError = 0x05E2,
		LibPngError = 0x05E3,
		LibTiffError = 0x05E4,
		LibMngError = 0x05E5,
		LibJp2Error = 0x05E6,
		LibExrError = 0x05E7,
		Unkwown = 0x05FF
	}

	public enum WriteFlags
	{
		TgaCreateStamp = 0x0710,
		JpgQuality = 0x0711,
		PngInterlace = 0x0712,
		TgaRle = 0x0713,
		BmpRle = 0x0714,
		SgiRle = 0x0715,
		TgaIdString = 0x0717,
		TgaAuthnameString = 0x0718,
		TgaAuthcommentString = 0x0719,
		PngAuthnameString = 0x071A,
		PngTitleString = 0x071B,
		PngDescriptionString = 0x071C,
		TifDescriptionString = 0x071D,
		TifHostcomputerString = 0x071E,
		TifDocumentnameString = 0x071F,
		TifAuthnameString = 0x0720,
		JpgSaveFormat = 0x0721,
		CheadHeaderString = 0x0722,
		PcdPicnum = 0x0723,
		PngAlphaIndex = 0x0724,
		JpgProgressive = 0x0725,
		VtfComp = 0x0726,
	}

	public enum CubeFace
	{
		PositiveX = 0x00000400,
		NegativeX = 0x00000800,
		PositiveY = 0x00001000,
		NegativeY = 0x00002000,
		PositiveZ = 0x00004000,
		NegativeZ = 0x00008000,
		SphereMap = 0x00010000,
	}

	public enum CompressedDataFormat
	{
		DxtcFormat = 0x0705,
		Dxt1 = 0x0706,
		Dxt2 = 0x0707,
		Dxt3 = 0x0708,
		Dxt4 = 0x0709,
		Dxt5 = 0x070A,
		DxtNoCompression = 0x070B,
		KeepDxtData = 0x070C,
		DxtcDataFormat = 0x070D,
		ThreeDC = 0x070E,
		RXGB = 0x070F,
		ATI1N = 0x0710,
		Dxt1A = 0x0711,
	}

	public enum CompressMode
	{
		None = 0x0701,
		Rle = 0x0702,
		Lzo = 0x0703,
		Zlib = 0x0704,
	}

	public enum SubImageType
	{
		Next = 0x0680,
		MipMap = 0x0681,
		Layer = 0x0682,
	}

	public enum EnableCap
	{
		AbsoluteFormat = 0x0610,
		AbsoluteType = 0x0612,
		AbsoluteOrigin = 0x0600,
		OverwriteExistingFile = 0x0620,
		ConvertPalette = 0x0630,
		NvidiaCompression = 0x0670,
		SquishCompression = 0x0671,
		DefaultOnFail = 0x0632,
		UseColorKey = 0x0635,
		BlitBlend = 0x0636,
		SaveInterlaced = 0x0639,
		JpgProgressive = 0x0725,
	}

	public enum OriginMode
	{
		LowerLeft = 0x0601,
		UpperLeft = 0x0602,
	}

	public enum Language
	{
		English = 0x0800,
		Arabic = 0x0801,
		Dutch = 0x0802,
		Japanese = 0x0803,
		Spanish = 0x0804,
		German = 0x0805,
		French = 0x0806,
	}

	public enum ImageParameterName
	{
		Filter = 0x2600,
		Placement = 0x0700,
	}

	public enum Placement
	{
		LowerLeft = 0x0701,
		LowerRight = 0x0702,
		UpperLeft = 0x0703,
		UpperRight = 0x0704,
		Center = 0x0705,
	}

	public enum Filter
	{
		Nearest = 0x2601,
		Linear = 0x2602,
		Bilinear = 0x2603,
		Box = 0x2604,
		Triangle = 0x2605,
		Bell = 0x2606,
		BSpline = 0x2607,
		Lanczos3 = 0x2608,
		Mitchell = 0x2609,
	}
}