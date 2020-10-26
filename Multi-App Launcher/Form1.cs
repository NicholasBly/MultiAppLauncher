using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_App_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (!System.IO.File.Exists("apps.ini"))
                {
                    var file = System.IO.File.Create("apps.ini");
                    MessageBox.Show("apps.ini was not found, file was now created", "Created apps.ini", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    file.Close();
                }
                string str = System.IO.File.ReadAllText("apps.ini");
                if (System.IO.File.Exists("apps.ini") && str.Length == 0)
                {
                    MessageBox.Show("No Apps Saved in apps.ini!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (System.IO.File.Exists("apps.ini") && str.Length != 0)
                {
                    if (System.IO.File.ReadLines("apps.ini").Skip(0).Take(1).FirstOrDefault() != null && System.IO.File.ReadLines("apps.ini").Skip(0).Take(1).FirstOrDefault() != "ExecuteThenClose = 1" && System.IO.File.ReadLines("apps.ini").Skip(0).Take(1).FirstOrDefault() != "ExecuteThenClose = 0")
                        textBox1.Text = System.IO.File.ReadLines("apps.ini").Skip(0).Take(1).FirstOrDefault();
                    if (System.IO.File.ReadLines("apps.ini").Skip(1).Take(2).FirstOrDefault() != null && System.IO.File.ReadLines("apps.ini").Skip(1).Take(1).FirstOrDefault() != "ExecuteThenClose = 1" && System.IO.File.ReadLines("apps.ini").Skip(1).Take(1).FirstOrDefault() != "ExecuteThenClose = 0")
                        textBox2.Text = System.IO.File.ReadLines("apps.ini").Skip(1).Take(1).FirstOrDefault();
                    if (System.IO.File.ReadLines("apps.ini").Skip(0).Take(3).FirstOrDefault() != null && System.IO.File.ReadLines("apps.ini").Skip(2).Take(1).FirstOrDefault() != "ExecuteThenClose = 1" && System.IO.File.ReadLines("apps.ini").Skip(2).Take(1).FirstOrDefault() != "ExecuteThenClose = 0")
                        textBox3.Text = System.IO.File.ReadLines("apps.ini").Skip(2).Take(1).FirstOrDefault();
                    if (System.IO.File.ReadLines("apps.ini").Skip(0).Take(4).FirstOrDefault() != null && System.IO.File.ReadLines("apps.ini").Skip(3).Take(1).FirstOrDefault() != "ExecuteThenClose = 1" && System.IO.File.ReadLines("apps.ini").Skip(3).Take(1).FirstOrDefault() != "ExecuteThenClose = 0")
                        textBox4.Text = System.IO.File.ReadLines("apps.ini").Skip(3).Take(1).FirstOrDefault();
                    if (System.IO.File.ReadLines("apps.ini").Skip(0).Take(5).FirstOrDefault() != null && System.IO.File.ReadLines("apps.ini").Skip(4).Take(1).FirstOrDefault() != "ExecuteThenClose = 1" && System.IO.File.ReadLines("apps.ini").Skip(4).Take(1).FirstOrDefault() != "ExecuteThenClose = 0")
                        textBox5.Text = System.IO.File.ReadLines("apps.ini").Skip(4).Take(1).FirstOrDefault();
                    if (System.IO.File.ReadLines("apps.ini").Skip(0).Take(6).FirstOrDefault() != null && System.IO.File.ReadLines("apps.ini").Skip(5).Take(1).FirstOrDefault() != "ExecuteThenClose = 1" && System.IO.File.ReadLines("apps.ini").Skip(5).Take(1).FirstOrDefault() != "ExecuteThenClose = 0")
                        textBox6.Text = System.IO.File.ReadLines("apps.ini").Skip(5).Take(1).FirstOrDefault();
                    if (System.IO.File.ReadLines("apps.ini").Skip(0).Take(7).FirstOrDefault() != null && System.IO.File.ReadLines("apps.ini").Skip(6).Take(1).FirstOrDefault() != "ExecuteThenClose = 1" && System.IO.File.ReadLines("apps.ini").Skip(6).Take(1).FirstOrDefault() != "ExecuteThenClose = 0")
                        textBox7.Text = System.IO.File.ReadLines("apps.ini").Skip(6).Take(1).FirstOrDefault();
                    if (System.IO.File.ReadLines("apps.ini").Skip(0).Take(8).FirstOrDefault() != null && System.IO.File.ReadLines("apps.ini").Skip(7).Take(1).FirstOrDefault() != "ExecuteThenClose = 1" && System.IO.File.ReadLines("apps.ini").Skip(7).Take(1).FirstOrDefault() != "ExecuteThenClose = 0")
                        textBox8.Text = System.IO.File.ReadLines("apps.ini").Skip(7).Take(1).FirstOrDefault();
                    if (System.IO.File.ReadLines("apps.ini").Skip(0).Take(9).FirstOrDefault() != null && System.IO.File.ReadLines("apps.ini").Skip(8).Take(1).FirstOrDefault() != "ExecuteThenClose = 1" && System.IO.File.ReadLines("apps.ini").Skip(8).Take(1).FirstOrDefault() != "ExecuteThenClose = 0")
                        textBox9.Text = System.IO.File.ReadLines("apps.ini").Skip(8).Take(1).FirstOrDefault();
                }
                if(str.Contains("ExecuteThenClose = 1"))
                {
                    checkBox1.Checked = true;
                }
                else if (!str.Contains("ExecuteThenClose = 1"))
                {
                    checkBox1.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }

        void launch()
        {
            try
            {
            if (System.IO.File.ReadLines("apps.ini").Skip(0).Take(1).FirstOrDefault() != null && System.IO.File.ReadLines("apps.ini").Skip(0).Take(1).FirstOrDefault() != "ExecuteThenClose = 1" && System.IO.File.ReadLines("apps.ini").Skip(0).Take(1).FirstOrDefault() != "ExecuteThenClose = 0")
                System.Diagnostics.Process.Start(System.IO.File.ReadLines("apps.ini").Skip(0).Take(1).FirstOrDefault());

            if (System.IO.File.ReadLines("apps.ini").Skip(1).Take(1).FirstOrDefault() != null && System.IO.File.ReadLines("apps.ini").Skip(1).Take(1).FirstOrDefault() != "ExecuteThenClose = 1" && System.IO.File.ReadLines("apps.ini").Skip(1).Take(1).FirstOrDefault() != "ExecuteThenClose = 0")
                System.Diagnostics.Process.Start(System.IO.File.ReadLines("apps.ini").Skip(1).Take(1).FirstOrDefault());

            if (System.IO.File.ReadLines("apps.ini").Skip(2).Take(1).FirstOrDefault() != null && System.IO.File.ReadLines("apps.ini").Skip(2).Take(1).FirstOrDefault() != "ExecuteThenClose = 1" && System.IO.File.ReadLines("apps.ini").Skip(2).Take(1).FirstOrDefault() != "ExecuteThenClose = 0")
                System.Diagnostics.Process.Start(System.IO.File.ReadLines("apps.ini").Skip(2).Take(1).FirstOrDefault());

            if (System.IO.File.ReadLines("apps.ini").Skip(3).Take(1).FirstOrDefault() != null && System.IO.File.ReadLines("apps.ini").Skip(3).Take(1).FirstOrDefault() != "ExecuteThenClose = 1" && System.IO.File.ReadLines("apps.ini").Skip(3).Take(1).FirstOrDefault() != "ExecuteThenClose = 0")
                System.Diagnostics.Process.Start(System.IO.File.ReadLines("apps.ini").Skip(3).Take(1).FirstOrDefault());

            if (System.IO.File.ReadLines("apps.ini").Skip(4).Take(1).FirstOrDefault() != null && System.IO.File.ReadLines("apps.ini").Skip(4).Take(1).FirstOrDefault() != "ExecuteThenClose = 1" && System.IO.File.ReadLines("apps.ini").Skip(4).Take(1).FirstOrDefault() != "ExecuteThenClose = 0")
                System.Diagnostics.Process.Start(System.IO.File.ReadLines("apps.ini").Skip(4).Take(1).FirstOrDefault());

            if (System.IO.File.ReadLines("apps.ini").Skip(5).Take(1).FirstOrDefault() != null && System.IO.File.ReadLines("apps.ini").Skip(5).Take(1).FirstOrDefault() != "ExecuteThenClose = 1" && System.IO.File.ReadLines("apps.ini").Skip(5).Take(1).FirstOrDefault() != "ExecuteThenClose = 0")
                System.Diagnostics.Process.Start(System.IO.File.ReadLines("apps.ini").Skip(5).Take(1).FirstOrDefault());

            if (System.IO.File.ReadLines("apps.ini").Skip(6).Take(1).FirstOrDefault() != null && System.IO.File.ReadLines("apps.ini").Skip(6).Take(1).FirstOrDefault() != "ExecuteThenClose = 1" && System.IO.File.ReadLines("apps.ini").Skip(6).Take(1).FirstOrDefault() != "ExecuteThenClose = 0")
                System.Diagnostics.Process.Start(System.IO.File.ReadLines("apps.ini").Skip(6).Take(1).FirstOrDefault());

            if (System.IO.File.ReadLines("apps.ini").Skip(7).Take(1).FirstOrDefault() != null && System.IO.File.ReadLines("apps.ini").Skip(7).Take(1).FirstOrDefault() != "ExecuteThenClose = 1" && System.IO.File.ReadLines("apps.ini").Skip(7).Take(1).FirstOrDefault() != "ExecuteThenClose = 0")
                System.Diagnostics.Process.Start(System.IO.File.ReadLines("apps.ini").Skip(7).Take(1).FirstOrDefault());

            if (System.IO.File.ReadLines("apps.ini").Skip(8).Take(1).FirstOrDefault() != null && System.IO.File.ReadLines("apps.ini").Skip(8).Take(1).FirstOrDefault() != "ExecuteThenClose = 1" && System.IO.File.ReadLines("apps.ini").Skip(8).Take(1).FirstOrDefault() != "ExecuteThenClose = 0")
                    System.Diagnostics.Process.Start(System.IO.File.ReadLines("apps.ini").Skip(8).Take(1).FirstOrDefault());
            }
            catch
            {
                MessageBox.Show("Error, you probably didn't add the path correctly. Fix it and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            launch();
            var textx = System.IO.File.ReadAllText("apps.ini");
            if (textx.Contains("ExecuteThenClose = 1"))
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                if (!System.IO.File.ReadAllText("apps.ini").Contains("ExecuteThenClose = 1"))
                {
                    using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter("apps.ini", true))
                    {
                        file.WriteLine("");
                        file.WriteLine("ExecuteThenClose = 1");
                        file.Close();
                        file.Dispose();
                    }
                }
            }
            if (checkBox1.CheckState == CheckState.Unchecked)
            {
                if (System.IO.File.ReadAllText("apps.ini").Contains("ExecuteThenClose = 1"))
                {
                    MessageBox.Show("Unchecked: please change the 1 to a 0 in the ini.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("To Add Paths, Edit the apps.ini file directly. Shall I open the file for you?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("apps.ini");
            }
            else if(result == DialogResult.No)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1_Load(this, null);
        }
    }
}
