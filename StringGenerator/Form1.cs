using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace StringGenerator
{
    public partial class Form1 : Form
    {
        private static Version _version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
        private static string _title = "String Generator " + _version.ToString();
        private string _output = "";
        private int _input;

        public Form1()
        {
            InitializeComponent();
            SetTitle(this);
            DisableUnderDevelopmentObjects();
            SetDefaults();
            if (chkAutoClipboard.Checked)
                btnClipboard.Enabled = false;

        }

        private void SetTitle(Form form)
        {
            int precision = 5;
            form.Text = _title;
            //string revisedTitle = _title.Substring((_title.Length-1), -10);
            
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            _output = "";
            lblMessage.Text = "";

            int noOfChars;

            //Data Validation
            bool valid = int.TryParse(txtInput.Text, out noOfChars) && txtInput.Text != "0" && txtInput.Text !="" && noOfChars > 0;
            if (!valid)
            {
                DisplayError("Please enter a valid numeric value for Character Length");
                txtInput.Text = "";
            }
               

            else if (txtInput.Text != "")
            {
                lblError.Text = "";

                //Get chars array
                for (int i=0; i < noOfChars; i++)
                    _output += "a";
                char[] chars = _output.ToCharArray();

                //display output in txtOutput grid (max of 300 chars)
                for (int i = 0; i < _output.Length; i++)
                {
                    if (i % 10 == 0 && i != 0)
                    {
                        txtOutput.AppendText(Environment.NewLine);
                    }
                    txtOutput.Text += chars[i];
                }

                //txtOutput.Text = _output;

                //Auto Copy = Checked
                if (chkAutoClipboard.Checked)
                    CopyToClipboard();

                txtOutput.Enabled = true;
                lblMessage.Visible = true;
                btnClear.Enabled = true;
                txtInput.Text = "";

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                CopyToClipboard();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SetDefaults();

        }

        private void DisplayError(string message)
        {
            lblError.Visible = true;
            lblError.ForeColor = System.Drawing.Color.Red;
            lblError.Text = message;
        }

        private void SetDefaults()
        {
            List<Label> labelsToDisable = this.Controls.OfType<Label>().ToList();
            foreach (Label label in labelsToDisable)
            {
                if (label != lblOutput && label != lblVisualConfirmation)
                {
                    label.Text = "";
                    label.Visible = false;
                }
                
            }

            btnClear.Enabled = false;
            ClearOutput();
            txtOutput.Enabled = false;
            txtInput.Text = "";
            txtOutput.Text = "";
            txtNoOfCharacters.Enabled = false;
 
        }

        private void CopyToClipboard()
        {
            lblMessage.Text = "";
            lblError.Text = "";

            //Validation
            bool valid = _output != "";

            if (!valid)
            {
                lblError.Visible = true;
                lblError.Text = "No input to copy.";
                lblMessage.Visible = true;
                lblMessage.Text = "No data was copied to Clipboard.";
                txtInput.Text = "";
                return;
            }

            string appendText;
            string automaticallyAdded;

            if (_output.Length > 1)
                appendText = "s were";
            else
                appendText = " was";

            if (chkAutoClipboard.Checked)
                automaticallyAdded = "automaticallly";
            else
                automaticallyAdded = "";

            lblMessage.Text = String.Format("{0} character{1} {2} added to the clipboard", _output.Length,appendText, automaticallyAdded);

            Clipboard.SetText(_output);
        }

        private void ClearOutput()
        {
            _output = "";
            txtOutput.Text = "";
            txtInput.Text = "";
        }


        private void chkAutoClipboard_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoClipboard.Checked)
                btnClipboard.Enabled = false;
            else
                btnClipboard.Enabled = true;
        }


        private void DisableUnderDevelopmentObjects()
        {
           

            List<Control> unfinishedControls = new List<Control>()
           {
               radASCII,
               radNumeric,
               radUTF8
           };

            foreach (Control c in unfinishedControls)
                c.Enabled = false;

        }
    }
}
