/*
 * Created by SharpDevelop.
 * User: dulce
 * Date: 20/11/2024
 * Time: 18:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace tapetes
{
	/// <summary>
	/// Description of tapetes4.
	/// </summary>
	public partial class tapetes4 : Form
	{
		public tapetes4()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			tapetes3 Form3=new tapetes3();
			Form3.Show();
		}
	}
}
