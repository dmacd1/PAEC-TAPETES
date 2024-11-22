/*
 * Created by SharpDevelop.
 * User: dulce
 * Date: 20/11/2024
 * Time: 18:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace tapetes
{
	/// <summary>
	/// Description of tapetes3.
	/// </summary>
	public partial class tapetes3 : Form
	{
		public tapetes3()
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
			tapetes2 Form2=new tapetes2();
			Form2.Show();
		}
		void Button2Click(object sender, EventArgs e)
		{
			 double numero1 = double.Parse(textBox1.Text);
			 double numero2 = double.Parse(textBox2.Text);
			 double numero3 = double.Parse(textBox3.Text);
             double numero4 = double.Parse(textBox4.Text);
             double numero5 = double.Parse(textBox5.Text);
             double numero6 = double.Parse(textBox6.Text);
             double numero7 = double.Parse(textBox7.Text);
             double numero8 = double.Parse(textBox8.Text);
             double aserrin;
             aserrin=numero1*100;
             double pintura;
             pintura=numero2*317.02;
             double flores;
             flores=numero3*85;
             double frutos;
             frutos=numero4*636.13;
             double agua;
             agua=numero5*20;
             double mano;
             mano=numero6*225;
             double diseño;
             diseño=0;
             double personas;
             personas=numero6*60;
             double area;
             area=numero7*numero8;
             if(area <= 50)
             {
             	diseño=2000;
             }
             else if (area > 50)
             {
             	diseño=5000;
             }
             
             double resultado=aserrin+pintura+flores+frutos+agua+mano+diseño+personas;
             label11.Text=":"+resultado;
		}
		void Button3Click(object sender, EventArgs e)
		{
			textBox1.Text="";
			textBox2.Text="";
			textBox3.Text="";
			textBox4.Text="";
			textBox5.Text="";
			textBox6.Text="";
			textBox7.Text="";
			textBox8.Text="";
		}
	}
}
