using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_lab_3_
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        Form1 f1;
        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f1 == null)
            {
                f1 = new Form1();
                f1.MdiParent = this;
                f1.FormClosed += new FormClosedEventHandler(f1_FormClosed);
                f1.Show();
            }
            else
            {
                f1.Activate();
            }
        }
        void f1_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1 = null;
        }
        Form2 f2;
        private void sTUInfoFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f2 == null)
            {
                f2 = new Form2();
                f2.MdiParent = this;
                f2.FormClosed += new FormClosedEventHandler(f2_FormClosed);
                f2.Show();
            }
            else
            {
                f2.Activate();
            }
        }
        void f2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f2 = null;
        }
        Form3 f3;
        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f3 == null)
            {
                f3 = new Form3();
                f3.MdiParent = this;
                f3.FormClosed += new FormClosedEventHandler(f3_FormClosed);
                f3.Show();
            }
            else
            {
                f3.Activate();
            }
        }
        void f3_FormClosed(object sender, FormClosedEventArgs e)
        {
            f3 = null;
        }
        Form4 f4;
        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f4 == null)
            {
                f4 = new Form4();
                f4.MdiParent = this;
                f4.FormClosed += new FormClosedEventHandler(f4_FormClosed);
                f4.Show();

            }
            else
            {
                f4.Activate();
            }
        }
        void f4_FormClosed(object sender, FormClosedEventArgs e)
        {
            f4 = null;
        }
    }
}
