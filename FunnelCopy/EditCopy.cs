using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunnelCopy
{
    public partial class EditCopy : Form
    {
        public static string editText = "";
        public EditCopy()
        {
            InitializeComponent();

        }

        private void EditCopy_Load(object sender, EventArgs e)
        {
            textBoxCopy.Text = Main.copyText;
        }
        private string TruncatePercents(string input)
        {
            return Regex.Replace(input, @"_+", "____");
        }


        private void cornerButtonOk_Click(object sender, EventArgs e)
        {
            var underscore = "____";
            string edit = textBoxCopy.Text.ToString();
            edit = TruncatePercents(edit);
        
            StringBuilder stringBuilder = new StringBuilder(edit);
            var lines = copyReplaceword.Text.Split('\n');
            int count = 0;
            foreach (var item in lines)
            {
                if (item.Length > 0)
                {
                    if (stringBuilder.ToString().Contains(underscore))
                    {
                        int startIndex = stringBuilder.ToString().IndexOf(underscore);
                        stringBuilder.Replace(underscore, lines[count], startIndex, underscore.Length);
                        count++;
                    }
              
                }
              
            }
            editText = stringBuilder.ToString();
            this.Close();
        }

        private void cornerButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
