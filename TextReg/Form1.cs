using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace TextReg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            menuStrip1.Visible = true;
            menuStrip2.Visible = false;

        }
           
        string failname ;
        ToolStripMenuItem tsmObsidian;
        ToolStripMenuItem tsmSparing;        
        ToolStripMenuItem tsmStandart;
        ToolStripMenuItem tsmEnglish;
        ToolStripMenuItem tsmRuss;

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "All File (*.*)|*.*|Text files (*.txt)|*.txt||";
            of.FilterIndex = 1;
            if (of.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = File.OpenText(of.FileName))
                {
                    failname = of.FileName;
                    richTextBox1.Text = reader.ReadToEnd();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();

            sf.Filter = "Text files (*.txt)|*.txt|All File (*.*)|*.*||";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(sf.FileName))
                {
                    writer.Write(richTextBox1.Text);
                }
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (failname == null)
            {
                MessageBox.Show("Вы не открывали файл а создали свой", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(failname))
                {
                    writer.Write(richTextBox1.Text);
                }
            }
           
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sparingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsmSparing = (ToolStripMenuItem)sender;
            tsmStandart = (ToolStripMenuItem)sender;
            tsmObsidian = (ToolStripMenuItem)sender;
            if (tsmSparing.Checked == true)
            {
                tsmStandart.Checked = false;
                tsmObsidian.Checked = false;
                richTextBox1.BackColor = Color.Yellow;
                richTextBox1.ForeColor = Color.Green;
            }
        }


        private void obsidianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsmObsidian = (ToolStripMenuItem)sender;
            tsmSparing = (ToolStripMenuItem)sender;
            tsmStandart = (ToolStripMenuItem)sender;
            if (tsmObsidian.Checked == true)
            {
                tsmStandart.Checked = false;
                tsmSparing.Checked = false;
                richTextBox1.BackColor = Color.Black;
                richTextBox1.ForeColor = Color.Blue;
            }
        }


        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsmStandart = (ToolStripMenuItem)sender;
            tsmObsidian = (ToolStripMenuItem)sender;
            tsmSparing = (ToolStripMenuItem)sender;
            if (tsmStandart.Checked == true)
            {
               tsmSparing.Checked = false;
                tsmObsidian.Checked = false;
                richTextBox1.BackColor = Color.White;
                richTextBox1.ForeColor = Color.Black;
            } 
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(richTextBox1.SelectedText);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(richTextBox1.SelectedText);
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Clipboard.GetText();
        }

        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = richTextBox1.SelectionColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }
        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {            
            fontDialog1.Font = richTextBox1.SelectionFont;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;               
            }
        }

        private void englisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsmEnglish = (ToolStripMenuItem)sender;
            tsmRuss = (ToolStripMenuItem)sender;
            if (tsmEnglish.Checked == true)
            {
                tsmRuss.Checked = false;
                menuStrip2.Visible = false;
                menuStrip1.Visible = true;
                MainMenuStrip = menuStrip1;
            }
        }

        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsmEnglish = (ToolStripMenuItem)sender;
            tsmRuss = (ToolStripMenuItem)sender;
            if (tsmRuss.Checked == true)
            {
                tsmEnglish.Checked = false;
                menuStrip2.Visible = true;
                menuStrip1.Visible = false;
                MainMenuStrip = menuStrip2;
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "All File (*.*)|*.*|Text files (*.txt)|*.txt||";
            of.FilterIndex = 1;
            if (of.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = File.OpenText(of.FileName))
                {
                    failname = of.FileName;
                    richTextBox1.Text = reader.ReadToEnd();
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (failname == null)
            {
                MessageBox.Show("Вы не открывали файл а создали свой", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(failname))
                {
                    writer.Write(richTextBox1.Text);
                }
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();

            sf.Filter = "Text files (*.txt)|*.txt|All File (*.*)|*.*||";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(sf.FileName))
                {
                    writer.Write(richTextBox1.Text);
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsmEnglish = (ToolStripMenuItem)sender;
            tsmRuss = (ToolStripMenuItem)sender;
            if (tsmEnglish.Checked == true)
            {
                tsmRuss.Checked = false;
                menuStrip2.Visible = false;
                menuStrip1.Visible = true;
                MainMenuStrip = menuStrip1;
            }
        }

        private void русскийToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tsmEnglish = (ToolStripMenuItem)sender;
            tsmRuss = (ToolStripMenuItem)sender;
            if (tsmRuss.Checked == true)
            {
                tsmEnglish.Checked = false;
                menuStrip2.Visible = true;
                menuStrip1.Visible = false;
                MainMenuStrip = menuStrip2;
            }
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(richTextBox1.SelectedText);
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(richTextBox1.SelectedText);
            richTextBox1.Cut();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Clipboard.GetText();
        }

        private void деньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsmStandart = (ToolStripMenuItem)sender;
            tsmObsidian = (ToolStripMenuItem)sender;
            tsmSparing = (ToolStripMenuItem)sender;
            if (tsmStandart.Checked == true)
            {
                tsmSparing.Checked = false;
                tsmObsidian.Checked = false;
                richTextBox1.BackColor = Color.White;
                richTextBox1.ForeColor = Color.Black;
            }
        }

        private void ночьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsmObsidian = (ToolStripMenuItem)sender;
            tsmSparing = (ToolStripMenuItem)sender;
            tsmStandart = (ToolStripMenuItem)sender;
            if (tsmObsidian.Checked == true)
            {
                tsmStandart.Checked = false;
                tsmSparing.Checked = false;
                richTextBox1.BackColor = Color.Black;
                richTextBox1.ForeColor = Color.Blue;
            }
        }

        private void щядяшийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsmSparing = (ToolStripMenuItem)sender;
            tsmStandart = (ToolStripMenuItem)sender;
            tsmObsidian = (ToolStripMenuItem)sender;
            if (tsmSparing.Checked == true)
            {
                tsmStandart.Checked = false;
                tsmObsidian.Checked = false;
                richTextBox1.BackColor = Color.Yellow;
                richTextBox1.ForeColor = Color.Green;
            }
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = richTextBox1.SelectionColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void тестToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = richTextBox1.SelectionFont;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }
    }
}
