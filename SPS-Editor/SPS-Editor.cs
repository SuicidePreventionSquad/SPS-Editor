using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPS_Editor
{

    public partial class SPSEditor : Form
    {
        public string inputFile = null;
        public string outputFile = null;
        public JData jdata = null;
        public JData temp = null;
        public bool validFile = false;
        public bool fileLoaded = false;
        public bool validObject = false;

        public SPSEditor()
        {
            InitializeComponent();
        }

        private void pageSelectionChanged(object sender, EventArgs e)
        {
            int temp = 0;
            if (inputFile != null)
            {
                if (jdata.Questions != null && jdata.Responses != null && jdata.Contacts != null)
                {
                    if (pagesListBox.SelectedItem.ToString() == "Questions")
                    {
                        temp = 0;
                        pageTextBox.Text = "";
                        jdata = JSONHelper.ReadData(inputFile);
                        
                        foreach (string quest in jdata.Questions)
                        {
                            pageTextBox.AppendText(quest + "\n");
                            pageTextBox.AppendText("\n");
                        }
                        
                    }
                    else if (pagesListBox.SelectedItem.ToString() == "Responses")
                    {
                        temp = 0;
                        pageTextBox.Text = "";
                        jdata = JSONHelper.ReadData(inputFile);
                        foreach (string resp in jdata.Responses)
                        {
                            pageTextBox.AppendText(resp + "\n");
                            pageTextBox.AppendText("\n");
                        }
                    }
                    else if (pagesListBox.SelectedItem.ToString() == "Contacts")
                    {
                        temp = 0;
                        pageTextBox.Text = "";
                        jdata = JSONHelper.ReadData(inputFile);
                        foreach (string con in jdata.Contacts)
                        {
                            pageTextBox.AppendText(con + "\n");
                            temp++;
                            if (temp % 2 == 0)
                            {
                                pageTextBox.AppendText("\n");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a file to open first.");
            }
        }

        private void pageTextBox_TextChanged(object sender, EventArgs e)
        {
            if (fileLoaded && validFile && validObject)
            {
                if(pagesListBox.SelectedItem.ToString() == "Questions")
                {
                    if (pageTextBox.Text != "")
                    {
                        jdata.Questions = pageTextBox.Text.Split('\n');
                        JSONHelper.WriteData(inputFile, jdata);
                    }
                }
                else if (pagesListBox.SelectedItem.ToString() == "Responses")
                {
                    if (pageTextBox.Text != "")
                    {
                        jdata.Responses = pageTextBox.Text.Split('\n');
                        JSONHelper.WriteData(inputFile, jdata);
                    }
                }
                else if (pagesListBox.SelectedItem.ToString() == "Contacts")
                {
                    if (pageTextBox.Text != "")
                    {
                        jdata.Contacts = pageTextBox.Text.Split('\n');
                        JSONHelper.WriteData(inputFile, jdata);
                    }
                }
            }
        }

        private void openMenuItemClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = "C:\\";
            ofd.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            ofd.FilterIndex = 0;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                inputFile = ofd.FileName;
                fileLoaded = true;
            }
            Console.Error.WriteLine("Opened file: {0}", inputFile);

            if (inputFile != null)
            {
                fileLoaded = true;
                jdata = JSONHelper.ReadData(inputFile);

                if (jdata.Questions != null && jdata.Responses != null && 
                    jdata.Error != null && jdata.Contacts != null)
                {
                    validFile = true;
                    validObject = true;

                    temp = jdata;

                    pagesListBox.SelectedItem = "Questions";
                }
                else
                {
                    MessageBox.Show("The selected file is empty or\n not formatted correctly.");
                    inputFile = null;
                    jdata = null;

                    validFile = false;
                    validObject = false;
                }
            }
        }

        private void CloseProgram(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to save changes to the text?", "Save changes",
            MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
              
                if (fileLoaded && validFile && validObject)
                {
                    JSONHelper.WriteData(inputFile, jdata);
                }
            }
            else if (dr == DialogResult.No)
            {
                if (fileLoaded && validFile && validObject)
                {
                    JSONHelper.WriteData(inputFile, temp);
                }
            }
            else if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void aboutMenuItemClick(object sender, EventArgs e)
        {
            MessageBox.Show("SPS Editor\nAuthors: SPS - 2016.", "About");
        }

        private void infoMenuClick(object sender, EventArgs e)
        {
            MessageBox.Show("Open the \"data.json\" file located in \"{Application_Folder}/sps/data.json\"\n Click the categories you wish to modify.\nWhen you are finished, just close the program.",
                "Help");
        }

        private void undoClick(object sender, EventArgs e)
        {
            pageTextBox.Undo();
        }
    }
}
