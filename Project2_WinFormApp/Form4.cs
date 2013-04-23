/**********************************************************************
 * File Name         : Form4.cs
 *                          
 * Author             : Jeremy Musick     E-mail: musickj@goldmail.etsu.edu       
 * Course             : CSCI 2210 - Data Structures
 * Create Date      : October 18, 2012
 * 
 * Modified Date    : October 22, 2012
 * Modified by       : Jeremy Musick
***********************************************************************
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace Project2
{
    public partial class Form4 : Form
    {
        public Form4()
        {            
            InitializeComponent();

            Assembly assembly = Assembly.GetExecutingAssembly();
            AssemblyTitleAttribute assemblyTitle = assembly.GetCustomAttributes(typeof(AssemblyTitleAttribute), false)[0] as AssemblyTitleAttribute;
            AssemblyDescriptionAttribute assemblyDescription = assembly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false)[0] as AssemblyDescriptionAttribute;
            AssemblyCompanyAttribute assemblyCompany = assembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false)[0] as AssemblyCompanyAttribute;
            AssemblyCopyrightAttribute assemblyCopyright = assembly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false)[0] as AssemblyCopyrightAttribute;
            Assembly a = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(a.Location);
            string version = fileVersionInfo.ProductVersion;
            String info = String.Format("Title: {0}\n\nDescription: {1}\n\nCompany: {2}\n\nCopyright: {3}\n\nVersion: {4}",
               assemblyTitle.Title,
               assemblyDescription.Description,
               assemblyCompany.Company,
               assemblyCopyright.Copyright,
               version);
            this.label1.Text = info;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
       
    }
}
