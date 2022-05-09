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
        String path = Environment.CurrentDirectory;

        int charsTyped = 0;
        int autosaveInterval = 50;

        int newBoxX = 6;
        int newBoxY = 30;
        int twtrLimit = 280;
        TextBox newTweet;
        List<TextBox> tweetList = new List<TextBox>();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmMain()
        {
            InitializeComponent();
        }

        private void AddBox()
        {
            newTweet = new TextBox();

            newTweet.Width = 720;
            newTweet.Height = 160;
            newTweet.BackColor = Color.FromArgb(25, 39, 52);
            newTweet.Location = new Point(newBoxX, newBoxY);
            newTweet.ForeColor = Color.White;
            newTweet.Multiline = true;

            newTweet.GotFocus += newTweet_Focus;
            newTweet.TextChanged += newTweet_TextChanged;

            pnlTwtBoxes.Controls.Add(newTweet);
            tweetList.Add(newTweet);

            btmStrpLblNumTweets.Text = "Number of Tweets: " + tweetList.Count;

            newBoxY += 166;
        }

        private void AddBox(String boxText)
        {
            newTweet = new TextBox();

            newTweet.Width = 720;
            newTweet.Height = 160;
            newTweet.BackColor = Color.FromArgb(25, 39, 52);
            newTweet.Location = new Point(newBoxX, newBoxY);
            newTweet.ForeColor = Color.White;
            newTweet.Multiline = true;

            newTweet.Text = boxText;
            newTweet.GotFocus += newTweet_Focus;
            newTweet.TextChanged += newTweet_TextChanged;

            pnlTwtBoxes.Controls.Add(newTweet);
            tweetList.Add(newTweet);
            pnlTwtBoxes.Controls.Add(newTweet);

            btmStrpLblNumTweets.Text = "Number of Tweets: " + tweetList.Count;

            newBoxY += 166;
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

        public void Open(String FileContents, String FileName)
        {
            Save();
            lblAutosaveStatus.Text = "Opening...";
            newBoxX = 6;
            newBoxY = 6;
            charsTyped = 0;

            pnlTwtBoxes.Controls.Clear();

            boxName.Text = FileName;
            String currentTweet = "";
            String path = Environment.CurrentDirectory;

            foreach (char c in FileContents)
            {
                if (c != '^')
                {
                    currentTweet += c;
                }
                else
                {
                    AddBox(currentTweet);
                    currentTweet = "";
                }
            }

            lblAutosaveStatus.Text = "Successfully imported.";
        }

        public void Save()
        {
            lblAutosaveStatus.Text = "Saving...";
            String filename;

            if (boxName.Text == "")
            {
                filename = DateTime.Now.ToString("yyyy-dd-M HH-mm-ss");
            }
            else
            {
                filename = boxName.Text;
            }


            if (filename.IndexOfAny(Path.GetInvalidFileNameChars()) > -1)
            {
                MessageBox.Show("Invalid characters in filename");
            }
            else
            {
                try
                {
                    using (StreamWriter sr = new StreamWriter(path + "\\" + filename + ".txt"))
                    {
                        foreach (var tweet in tweetList)
                        {
                            sr.Write(tweet.Text + "^");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sorry, an error occured: " + ex.Message);
                }
            }

            lblAutosaveStatus.Text = "Saved: " + DateTime.Now.ToString();
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
            String PathString = e.ClickedItem.ToString();
            String FileCont;

            List<char> PathStringReversed = PathString.ToCharArray().ToList();
            PathStringReversed.Reverse();

            String FileNameReversed = "";

            foreach (char c in PathStringReversed)
            {
                if (c != '\\')
                {
                    FileNameReversed += c;
                }
                else
                {
                    break;
                }
            }

            char[] FileNameArray = FileNameReversed.ToCharArray();
            Array.Reverse(FileNameArray);
            String FileName = new string(FileNameArray);

            using (StreamReader sr = new StreamReader(PathString))
            {
                FileCont = sr.ReadToEnd();
            }

            Open(FileCont, FileName);
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

        private void strpBtnExport_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void strpBtnRemove_Click(object sender, EventArgs e)
        {
            pnlTwtBoxes.Controls.RemoveAt(pnlTwtBoxes.Controls.Count - 1);
            newBoxY -= 166;
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && tweetList.Count >= 1)
            {
                Save();
                this.Dispose();
                this.Close();
            }
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && tweetList.Count >= 1)
            {
                Save();
                this.Dispose();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}