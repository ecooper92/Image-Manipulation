using System;

namespace ImageManipulation
{
	/// <summary>
	/// A color channel of an RGB image.
	/// </summary>
	public enum ColorChannel { Red = 2, Green = 1, Blue = 0 }
	
	/// <summary>
	/// The mode for palette animation.
	/// </summary>
	public enum PaletteMode { RGB = 0, BRG = 1, GBR = 2 }
}
