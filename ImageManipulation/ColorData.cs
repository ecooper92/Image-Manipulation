using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageManipulation
{
	/** A container of RGB colors **/
    public class ColorData
    {
    	/** The red component **/
    	private int red = 0;
    	
    	/** The green component **/
    	private int green = 0;
    	
    	/** The blue component **/
    	private int blue = 0;
    	
        public ColorData(int red, int green, int blue)
        {
        	Red = red;
        	Green = green;
        	Blue = blue;
        }

        /// <summary>
        /// The Red color value, must be between 0 and 255.
        /// </summary>
        public int Red 
        { 
        	get { return red; }
        	set
        	{
            	if (value < 0 || value > 255)
                	throw new ArgumentOutOfRangeException("Red must be between 0 and 255");
            	
            	red = value;
        	}
        }

        /// <summary>
        /// The Green color value, must be between 0 and 255.
        /// </summary>
        public int Green 
        { 
        	get { return green; }
        	set
        	{
            	if (value < 0 || value > 255)
                	throw new ArgumentOutOfRangeException("Green must be between 0 and 255");
            	
            	green = value;
        	}
        }

        /// <summary>
        /// The Blue color value, must be between 0 and 255.
        /// </summary>
        public int Blue 
        { 
        	get { return blue; }
        	set
        	{
            	if (value < 0 || value > 255)
                	throw new ArgumentOutOfRangeException("Blue must be between 0 and 255");
            	
            	blue = value;
        	}
        }
        
        /// <summary>
        /// Gets a given color value based off the color channel enum.
        /// </summary>
        /// <param name="cc">The color value to get.</param>
        /// <returns>The color value specified by the color channel.</returns>
        public int GetValue(ColorChannel cc)
        {
        	if (cc == ColorChannel.Red)
        		return Red;
        	else if (cc == ColorChannel.Green)
        		return Green;
        	else if (cc == ColorChannel.Blue)
        		return Blue;
        	
        	return -1;
        }
        
		public override bool Equals(object obj)
		{
			ColorData other = obj as ColorData;
			if (other == null)
				return false;
			
			return this.red == other.red && this.green == other.green && this.blue == other.blue;
		}

		public override int GetHashCode()
		{
			int	hashCode = red.GetHashCode() << 4;
			hashCode |= green.GetHashCode() << 2;
			hashCode |= blue.GetHashCode();
			return hashCode;
		}
    }
}
