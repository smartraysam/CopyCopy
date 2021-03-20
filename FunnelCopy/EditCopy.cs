using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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

        private void cornerButtonOk_Click(object sender, EventArgs e)
        {
            string edit = textBoxCopy.Text.ToString();
            string[] stringsplit = edit.Split(new string[] { "_____" }, StringSplitOptions.None);
            var lines = copyReplaceword.Text.Split('\n');
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in lines)
            {
                Debug.WriteLine(item);
            }
            foreach (var item in stringsplit)
            {
                Debug.WriteLine(item);
            }

            //for (int i = 0; i < stringsplit.Length; i++)
            //{
            //    Debug.WriteLine(stringsplit[i]);
            //    stringBuilder.Append(stringsplit[i]);
            //    if (i <= lines.Length)
            //    {
            //        stringBuilder.Append(" " + lines[i] + " ");
            //    }
            //    else
            //    {
            //        stringBuilder.Append(" _____ ");
            //    }


            //}
            editText = stringBuilder.ToString();
            this.Close();
        }

        private void cornerButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
