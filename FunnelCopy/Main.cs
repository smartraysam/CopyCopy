
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Color = System.Drawing.Color;
using Font = System.Drawing.Font;

namespace FunnelCopy
{
    public partial class Main : Form
    {
        public static string copyText = "";
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
        string filepath = AppDomain.CurrentDomain.BaseDirectory ;

        Dictionary<Panel, Button> navItems = new Dictionary<Panel, Button>();

        public Main()
        {
            InitializeComponent();
            cornerButtonAdd.Enabled = false;
            Butpicture.Enabled = false;
            cornerButtonSave.Enabled = false;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void listCopies_SelectedIndexChanged(object sender, EventArgs e)
        {
            copyText = listCopies.SelectedItem.ToString();
            cornerButtonAdd.Enabled = true;
            Butpicture.Enabled = true;
        }
       
        public void setActiveNav(Button but, Panel pan)
        {

            foreach (var item in navItems)
            {
              if(item.Key == pan)
                {
                    item.Key.BackColor = Color.DodgerBlue;
                    item.Value.BackColor = Color.White; 
                }
                else
                {
                    item.Key.BackColor = Color.Transparent;
                    item.Value.BackColor = Color.Transparent;
                }
            }
            
        }

        public void loadCopies(string name)
        {
            listCopies.Items.Clear();
            string path = filepath + "\\"+name;
            using (StreamReader r = new StreamReader(path))
            {
                listCopies.Items.Add(Environment.NewLine);

                string line;
                while ((line = r.ReadLine()) != null)
                {
                    if (line.Length > 0)
                    {
                         listCopies.Items.Add("     " + line.Trim()+"       ");
                    }


                }
                listCopies.Items.Add(Environment.NewLine);
            }
        }

        private void butHL_Click(object sender, EventArgs e)
        {
            setActiveNav(butHL, hlind);
            loadCopies("Headlines.txt");
        }

        private void butSHL_Click(object sender, EventArgs e)
        {

            setActiveNav(butSHL, shlind);
            loadCopies("Subheads.txt");
        }
        private void butCP_Click(object sender, EventArgs e)
        {
            setActiveNav(butCP, copind);
            loadCopies("Openings.txt");
        }

        private void butPW_Click(object sender, EventArgs e)
        {
          

            setActiveNav(butPW, pwind);
            loadCopies("power_word.txt");
        }

        private void butCOPYC_Click(object sender, EventArgs e)
        {
          
            setActiveNav(butCOPYC, cconind);
            loadCopies("Copy_Connectors.txt");
        }

        private void butSM_Click(object sender, EventArgs e)
        {
      
            setActiveNav(butSM, smind);
            loadCopies("Similes.txt");
        }

        private void butPS_Click(object sender, EventArgs e)
        {
            setActiveNav(butPS, psind);
            loadCopies("PS.txt");
        }

        private void butCC_Click(object sender, EventArgs e)
        {
           
            setActiveNav(butCC, ccind);
            loadCopies("close.txt");
        }

        private void butGUA_Click(object sender, EventArgs e)
        {
       
            setActiveNav(butGUA, gurind);
            loadCopies("Guarantees.txt");
        }

        private void butBP_Click(object sender, EventArgs e)
        {
         
            setActiveNav(butBP, bpind);
            loadCopies("Bullets.txt");
        }

        private void cornerButtonAdd_Click(object sender, EventArgs e)
        {
            copyText = listCopies.SelectedItem.ToString();
            if (copyText.Contains("__"))
            {
                EditCopy edit = new EditCopy();
                edit.FormClosed += Edit_FormClosed;
                edit.ShowDialog();
            }
            else
            {
                richTextprocess.AppendText(copyText.Trim());
                richTextprocess.AppendText(Environment.NewLine);
            }
        }

        private void cornerButtonSave_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\funnelcopy.docx";
            if ((File.Exists(path)))
            {
                File.Delete(path);

            }
            string dataToInsert = richTextprocess.Text;
            using (WordprocessingDocument doc = WordprocessingDocument.Create
            (path, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
            {
                // Add a main document part.
                MainDocumentPart mainPart = doc.AddMainDocumentPart();

                // Create the document structure and add some text.
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());
                Paragraph para = body.AppendChild(new Paragraph());
                Run run = para.AppendChild(new Run());

                // String msg contains the text, "Hello, Word!"
                run.AppendChild(new Text(dataToInsert   ));
                doc.Close();
            }
            Process.Start("WINWORD.EXE", path);
        }
      
        private void cornerButtonDelete_Click(object sender, EventArgs e)
        {
            
            richTextprocess.Clear();
        }

        private void cornerButtonCopyClip_Click(object sender, EventArgs e)
        {
            string text = richTextprocess.Text;
            Clipboard.SetText(text);
            MessageBox.Show("Content copy to clipboard successfully");
        }

        private void cornerButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butGenLink_Click(object sender, EventArgs e)
        {
            butGenLink.Font = new Font(butGenLink.Font.Name, butGenLink.Font.Size, FontStyle.Bold);
            butAbt.Font = new Font(butAbt.Font.Name, butAbt.Font.Size, FontStyle.Regular);
            butTutorial.Font = new Font(butTutorial.Font.Name, butTutorial.Font.Size, FontStyle.Regular);
            butCommunity.Font = new Font(butCommunity.Font.Name, butCommunity.Font.Size, FontStyle.Regular);
        }

        private void butAbt_Click(object sender, EventArgs e) { 

            butAbt.Font = new Font(butAbt.Font.Name, butAbt.Font.Size, FontStyle.Bold);
            butTutorial.Font = new Font(butTutorial.Font.Name, butTutorial.Font.Size, FontStyle.Regular);
            butCommunity.Font = new Font(butCommunity.Font.Name, butCommunity.Font.Size, FontStyle.Regular);
            butGenLink.Font = new System.Drawing.Font(butGenLink.Font.Name, butGenLink.Font.Size, FontStyle.Regular);
        }

        private void butTutorial_Click(object sender, EventArgs e)
        {
            butTutorial.Font = new Font(butTutorial.Font.Name, butTutorial.Font.Size, FontStyle.Bold);
            butCommunity.Font = new Font(butCommunity.Font.Name, butCommunity.Font.Size, FontStyle.Regular);
            butGenLink.Font = new Font(butGenLink.Font.Name, butGenLink.Font.Size, FontStyle.Regular);
            butAbt.Font = new Font(butAbt.Font.Name, butAbt.Font.Size, FontStyle.Regular);
        }

        private void butCommunity_Click(object sender, EventArgs e)
        {
            butCommunity.Font = new Font(butCommunity.Font.Name, butCommunity.Font.Size, FontStyle.Bold);
            butGenLink.Font = new Font(butGenLink.Font.Name, butGenLink.Font.Size, FontStyle.Regular);
            butTutorial.Font = new Font(butTutorial.Font.Name, butTutorial.Font.Size, FontStyle.Regular);
            butAbt.Font = new Font(butAbt.Font.Name, butAbt.Font.Size, FontStyle.Regular);
        }

        private void butReport_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            loadCopies("Headlines.txt");
            navItems.Add(hlind, butHL);
            navItems.Add(shlind, butSHL);
            navItems.Add(copind, butCP);
            navItems.Add(bpind, butBP);
            navItems.Add(gurind, butGUA);
            navItems.Add(ccind, butCC);
            navItems.Add(psind, butPS);
            navItems.Add(smind, butSM);
            navItems.Add(cconind, butCOPYC);
            navItems.Add(pwind, butPW);
       
        }

        private void Butpicture_Click(object sender, EventArgs e)
        {
            copyText = listCopies.SelectedItem.ToString();
            if (copyText.Contains("__"))
            {
                EditCopy edit = new EditCopy();
                edit.FormClosed += Edit_FormClosed;
                edit.ShowDialog();
            }
            else
            {
                richTextprocess.AppendText(copyText.Trim());
                richTextprocess.AppendText(Environment.NewLine);
            }
        

        }
        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (EditCopy.editText.Length > 0)
            {
                richTextprocess.AppendText(EditCopy.editText.Trim());
                richTextprocess.AppendText(Environment.NewLine);
            }
        
        }
   
        private void buttonAddnew_Click(object sender, EventArgs e)
        {
            AddMore more = new AddMore();
            more.ShowDialog();
        }

        private void richTextprocess_TextChanged(object sender, EventArgs e)
        {
            cornerButtonSave.Enabled = true;
        }
    }
}
