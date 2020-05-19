using System;

namespace ImageManipulation
{
	/// <summary>
	/// Represents a data structure that contains a collection of RGB points
	/// in RGB space. Any modifications of the ColorData properties require
	/// a call to Recalculate to update the min, max, length, and size values.
	/// </summary>
	public class ColorDataBox
	{
		/** The size diagonal size of the RGB box */
		private int size = -1;
		
		public ColorDataBox(ColorData[] colorData)
		{
			if (colorData.Length > 0)
				ColorData = colorData;
			
			Recalculate();
		}
		
		/// <summary>
		/// The colors currently contained within the box.
		/// </summary>
		public ColorData[] ColorData { get; set; }
		
		/// <summary>
		/// The smallest R value within the box.
		/// </summary>
		public int MinR { get; set; }
		
		/// <summary>
		/// The largest R value within the box.
		/// </summary>
		public int MaxR { get; set; }
		
		/// <summary>
		/// The smallest G value within the box.
		/// </summary>
		public int MinG { get; set; }
		
		/// <summary>
		/// The largest G value within the box.
		/// </summary>
		public int MaxG { get; set; }
		
		/// <summary>
		/// The smallest B value within the box.
		/// </summary>
		public int MinB { get; set; }
		
		/// <summary>
		/// The largest B value within the box.
		/// </summary>
		public int MaxB { get; set; }
		
		/// <summary>
		/// The length from maxR to minR.
		/// </summary>
		public int LengthR { get; private set; }
		
		/// <summary>
		/// The length from maxG to minG.
		/// </summary>
		public int LengthG { get; private set; }
		
		/// <summary>
		/// The length from maxB to minB.
		/// </summary>
		public int LengthB { get; private set; }
		
		/// <summary>
		/// The length of the longest diagonal of the box.
		/// </summary>
		public int Size
		{
			get { return size; }
		}
		
		/// <summary>
		/// Determines whether a given color falls within the range of the box.
		/// </summary>
		/// <param name="colorData">The color to check.</param>
		/// <returns>True if it falls within the box.</returns>
		public bool Contains(ColorData colorData)
		{
			return (MinR <= colorData.Red && MaxR >= colorData.Red &&
			    	MinG <= colorData.Green && MaxG >= colorData.Green &&
			    	MinB <= colorData.Blue && MaxB >= colorData.Blue);
		}
		
		/// <summary>
		/// Recalculates the max, min, length, and size values of the box.
		/// </summary>
		public void Recalculate()
		{
			int minR = int.MaxValue;
			int maxR = int.MinValue;
			int minG = int.MaxValue;
			int maxG = int.MinValue;
			int minB = int.MaxValue;
			int maxB = int.MinValue;
			
			foreach (ColorData data in ColorData)
			{
				if (data.Red < minR)
					minR = data.Red;
				if (data.Red > maxR)
					maxR = data.Red;
				
				if (data.Green < minG)
					minG = data.Green;
				if (data.Green > maxG)
					maxG = data.Green;
				
				if (data.Blue < minB)
					minB = data.Blue;
				if (data.Blue > maxB)
					maxB = data.Blue;
				
				
			}
			
			MinR = minR;
			MaxR = maxR;
			MinG = minG;
			MaxG = maxG;
			MinB = minB;
			MaxB = maxB;
				
			LengthR = maxR - minR;
			LengthG = maxG - minG;
			LengthB = maxB - minB;
			size = LengthR * LengthR + LengthG * LengthG + LengthB * LengthB;
		}
	}
}
