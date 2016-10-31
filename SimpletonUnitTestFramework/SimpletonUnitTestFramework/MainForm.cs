/*
 * Created by SharpDevelop.
 * User: Michael_Huynh2
 * Date: 31/10/2016
 * Time: 5:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SimpletonUnitTestFramework
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			var a = new int[3] { 0, 1, 2 };
			
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 4, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
			Assert("isLength3", 3, a.Length);
						
			textBox1.Text += string.Format("PassCount: {0}, FailCount: {1}" + Environment.NewLine, PassCount, FailCount);
			
			textBox1.SelectionStart = textBox1.Text.Length;
		}
		
		public int FailCount = 0;
		public int PassCount = 0;
		
		public void Assert(string testname, string expected, string actual)
		{
			string result;
			if (expected == actual){
				result = "Pass";
				PassCount++;
			} else {
				result = "Fail";
				FailCount++;
			}
			textBox1.Text += string.Format("{0}, {1}, Expected: {2}, Actual: {3}" + Environment.NewLine, result, testname, expected, actual);
		}
		
		public void Assert(string testname, int expected, int actual)
		{
			string result;
			if (expected == actual){
				result = "Pass";
				PassCount++;
			} else {
				result = "Fail";
				FailCount++;
			}
			textBox1.Text += string.Format("Result: {0}, TestName: {1}, Expected: {2}, Actual: {3}" + Environment.NewLine, result, testname, expected, actual);
		}
		
		
	}
}
