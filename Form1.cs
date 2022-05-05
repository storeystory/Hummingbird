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

namespace Hummingbird
{
    public partial class frmMain : Form
    {
        String name = "";
        String path = Environment.CurrentDirectory;

        int charsTyped = 0;
        int autosaveInterval = 50;

        int newBoxX = 12;
        int newBoxY = 144;
        int twtrLimit = 280;
        TextBox newTweet;
        List<TextBox> tweetList = new List<TextBox>();

        public frmMain() => InitializeComponent();

        private void frmMain_Load(object sender, EventArgs e)
        {
            AddBox();
        }

        private void AddBox()
        {
            newTweet = new TextBox();
           
            newTweet.Width = 748;
            newTweet.Height = 80;
            newTweet.Location = new Point(newBoxX, newBoxY);
            newTweet.Multiline = true;
            
            newTweet.GotFocus += newTweet_Focus;
            newTweet.TextChanged += newTweet_TextChanged;

            this.Controls.Add(newTweet);
            tweetList.Add(newTweet);

            newBoxY += 86;
        }

        private void AddBox(String boxText)
        {
            newTweet = new TextBox();
            newTweet.Width = 748;
            newTweet.Height = 80;
            newTweet.Location = new Point(newBoxX, newBoxY);
            newTweet.Multiline = true;
            newTweet.Text = boxText;
            newTweet.TextChanged += newTweet_TextChanged;

            this.Controls.Add(newTweet);
            tweetList.Add(newTweet);

            newBoxY += 86;
        }

        public static Control FindFocusedControl(Control control)
        {
            var container = control as IContainerControl;
            
            while (container != null)
            {
                control = container.ActiveControl;
                container = control as IContainerControl;
            }

            return control;
        }

        public void Open(String FileContents)
        {
            Save();

            Controls.Remove(newTweet);

            String currentTweet = "";

            foreach (char c in FileContents)
            {
                if(c != '^')
                {
                    currentTweet += c;
                }
                else
                {
                    AddBox(currentTweet);
                    currentTweet = "";
                    FileContents = FileContents.TrimStart(currentTweet.ToCharArray());
                }
            }
        }

        public void Save()
        {
            lblAutosaveStatus.Text = "Saving...";
            String filename = "";

            if (name.Equals(""))
            {
                filename = DateTime.Now.ToString();
            }

            foreach (char c in filename)
            {
                if(c == '/' || c == '\\' || c == '?' || c == '%' || c == '*' || c == ':' || c == '|' || c == '"' || c == '<' || c == '>')
                {
                    filename += "-";
                }
                else
                {
                    filename += c;
                }
            }

            try
            {
                using (StreamWriter sr = new StreamWriter(path + "\\" + filename + ".txt"))
                {
                    foreach (var tweet in tweetList)
                    {
                        sr.WriteLine(tweet.Text);
                        sr.WriteLine("^");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry, an error occured: " + ex.Message);
            }

            lblAutosaveStatus.Text = "Saved: " + DateTime.Now.ToString();
        }

        private void boxName_TextChanged(object sender, EventArgs e)
        {
            name = boxName.Text;
        }

        private void newTweet_Focus(object sender, EventArgs e)
        {
            lblChars.Text = "Characters: " + FindFocusedControl(this).Text.Length.ToString() + "/" + twtrLimit;
            charsTyped++;

            if (charsTyped % autosaveInterval == 0)
            {
                Save();
            }
        }

        private void newTweet_TextChanged(object sender, EventArgs e)
        {
            lblChars.Text = "Characters: " + FindFocusedControl(this).Text.Length.ToString() + "/" + twtrLimit;
            charsTyped++;

            if (charsTyped % autosaveInterval == 0)
            {
                Save();
            }
        }

        private void strpBtnAddTweet_Click(object sender, EventArgs e)
        {
            AddBox();
        }

        private void strpBtnImport_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            String FileCont;
            using (StreamReader sr = new StreamReader(e.ClickedItem.ToString()))
            {
                FileCont = sr.ReadToEnd();
            }
             
            Open(FileCont);
        }

        private void strpBtnImport_Click(object sender, EventArgs e)
        {
            foreach (String s in Directory.GetFiles(path, "*.txt"))
            {
                strpBtnImport.DropDownItems.Add(s);
            }

            strpBtnImport.ShowDropDown();
        }

        private void strpBtnImport_DropDownClosed(object sender, EventArgs e)
        {
            strpBtnImport.DropDownItems.Clear();
        }
    }
}
