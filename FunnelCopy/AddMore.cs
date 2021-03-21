using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunnelCopy
{
    public partial class AddMore : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
     (
         int nLeftRect,     // x-coordinate of upper-left corner
         int nTopRect,      // y-coordinate of upper-left corner
         int nRightRect,    // x-coordinate of lower-right corner
         int nBottomRect,   // y-coordinate of lower-right corner
         int nWidthEllipse, // width of ellipse
         int nHeightEllipse // height of ellipse
     );
        string filepath = AppDomain.CurrentDomain.BaseDirectory;
        string pathfile;
        public AddMore()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            comboBoxCategory.SelectedItem = 0;
            comboBoxCategory.SelectedText = "--Select category--";
            cornerButtonOk.Enabled = false;
        }

        private void cornerButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cornerButtonOk_Click(object sender, EventArgs e)
        {
            if (pathfile.Length > 0)
            {
                var lines = richTextBoxNewword.Text.Split('\n');
                using (StreamWriter sw = File.AppendText(pathfile))
                {
                    foreach (var item in lines)
                    {
                        sw.WriteLine(item);
                    }
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Select category");
            }
           
          
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxCategory.SelectedIndex == 0)
            {
                pathfile = filepath + "\\Headlines.txt";
            }
            else if (comboBoxCategory.SelectedIndex == 1)
            {
                pathfile = filepath + "\\Subheads.txt";
            }
            else if (comboBoxCategory.SelectedIndex == 2)
            {
                pathfile = filepath + "\\Openings.txt";
            }
            else if (comboBoxCategory.SelectedIndex == 3)
            {
                pathfile = filepath + "\\Bullets.txt";
            }
            else if (comboBoxCategory.SelectedIndex == 4)
            {
                pathfile = filepath + "\\Guarantees.txt";
            }
            else if (comboBoxCategory.SelectedIndex == 5)
            {
                pathfile = filepath + "\\close.txt";
            }

            else if (comboBoxCategory.SelectedIndex == 6)
            {
                pathfile = filepath + "\\PS.txt";
            }
            else if (comboBoxCategory.SelectedIndex == 7)
            {
                pathfile = filepath + "\\Similes.txt";
            }
            else if (comboBoxCategory.SelectedIndex == 8)
            {
                pathfile = filepath + "\\Copy_Connectors.txt";
            }
            else if (comboBoxCategory.SelectedIndex == 9)
            {
                pathfile = filepath + "\\power_word.txt";
            }
        }

        private void richTextBoxNewword_TextChanged(object sender, EventArgs e)
        {
            if (richTextBoxNewword.Text.Length > 0)
            {
                cornerButtonOk.Enabled = true;
            }
        }
    }
}
