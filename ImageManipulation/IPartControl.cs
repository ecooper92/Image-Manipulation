/*
 * Created by SharpDevelop.
 * User: J01599
 * Date: 1/21/2015
 * Time: 11:09 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace ImageManipulation
{
	/// <summary>
	/// Description of PartControl.
	/// </summary>
	public interface IPartControl
	{
		Bitmap Image { get; set; }
		
		void Generate();
	}
}
