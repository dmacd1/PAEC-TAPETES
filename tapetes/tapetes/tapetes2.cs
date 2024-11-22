/*
 * Created by SharpDevelop.
 * User: dulce
 * Date: 20/11/2024
 * Time: 17:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace tapetes
{
	/// <summary>
	/// Description of tapetes2.
	/// </summary>
	public partial class tapetes2 : Form
	{
		public tapetes2()
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
			tapetes4 Form4=new tapetes4();
			Form4.Show();
		}
	}
}
