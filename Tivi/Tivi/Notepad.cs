using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tivi
{
    public partial class Notepad : Form
    {
        private User user;
        public Notepad(User user)
        {
            InitializeComponent();
            this.user = user;
            this.BackColor = ColorTranslator.FromHtml(user.Colour);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notepadRichTextBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notepadRichTextBox.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notepadRichTextBox.SelectedText = "";
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notepadRichTextBox.Redo();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notepadRichTextBox.Undo();
        }

        private void returnToMainMenu_Click(object sender, EventArgs e)
        {
            OldUserForm form = new OldUserForm(this.user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notepadSaveFileDialog.DefaultExt = ".txt";
            notepadSaveFileDialog.Filter = "Text File|*.txt|PDF file|*.pdf|Word File|*.doc";
            DialogResult dr = notepadSaveFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                File.WriteAllText(notepadSaveFileDialog.FileName, notepadRichTextBox.Text);
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notepadRichTextBox.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notepadOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                notepadRichTextBox.Text = File.ReadAllText(notepadOpenFileDialog.FileName);
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notepadRichTextBox.Cut();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
           notepadRichTextBox.Text = System.DateTime.Now.ToString();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notepadFontDialog.ShowDialog() == DialogResult.OK)
            {
              notepadRichTextBox.Font = notepadFontDialog.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notepadColorDialog.ShowDialog() == DialogResult.OK)
            {
                notepadRichTextBox.ForeColor = notepadColorDialog.Color;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            OldUserForm form = new OldUserForm(this.user);

        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notepadRichTextBox.Text = System.DateTime.Now.ToString();
        }
    }
}
