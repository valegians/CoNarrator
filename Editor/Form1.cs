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

namespace Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            //openFileDialog.ShowDialog(); //Shows the dialog
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog.FileName.Contains(".txt")) //Checks if it's all ok and if the file name contains .txt  
            {
                string open = File.ReadAllText(openFileDialog.FileName); //Reads the text from file  
                editorField.Text = open; //Shows the reded text in the textbox  
            }
            else //If something goes wrong...  
            {
                MessageBox.Show("The file you've chosen is not a text file");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //saveFileDialog.ShowDialog(); //Opens the Show File Dialog  
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) //Check if it's all ok  
            {
                string name = saveFileDialog.FileName + ".txt"; //Just to make sure the extension is .txt  
                File.WriteAllText(name, editorField.Text); //Writes the text to the file and saves it               
            }
        }
        private void buttonFont_Click(object sender, EventArgs e)
        {
            //fontDialog.ShowDialog(); //Shows the font dialog   
            if (fontDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                editorField.Font = fontDialog.Font; //Sets the font to the one selected in the dialog  
            }
        }

        private void buttonAnalyse_Click(object sender, EventArgs e)
        {
            string inputText = editorField.Text;
            string[] results = new string[2];
            results = Program.GetAnalyse().SentimentAnalysisExample(inputText);

            editorField.Text = results[0];
            analysisField.Text = results[1];
        }

        private void buttonNarrate_Click(object sender, EventArgs e)
        {
            string speech = editorField.Text;
            Program.GetSpeechSynthesis().Synthesize(speech);
        }

        private void buttonVoices_Click(object sender, EventArgs e)
        {
            string output = Program.GetSpeechSynthesis().VoicesInfo();
            MessageBox.Show(output);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Program.Help();
        }

        private void buttonSaveAudio_Click(object sender, EventArgs e)
        {
            Program.GetSpeechSynthesis().saveSynthesis(editorField.Text);
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
