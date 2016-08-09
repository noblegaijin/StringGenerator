namespace StringGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnClipboard = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.radASCII = new System.Windows.Forms.RadioButton();
            this.radUTF8 = new System.Windows.Forms.RadioButton();
            this.radNumeric = new System.Windows.Forms.RadioButton();
            this.lblError = new System.Windows.Forms.Label();
            this.txtNoOfCharacters = new System.Windows.Forms.TextBox();
            this.chkAutoClipboard = new System.Windows.Forms.CheckBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblVisualConfirmation = new System.Windows.Forms.Label();
            this.chkDelimeter = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(245, 24);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(63, 153);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(119, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate Output";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Enabled = false;
            this.txtOutput.Location = new System.Drawing.Point(387, 65);
            this.txtOutput.MaxLength = 300;
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(231, 190);
            this.txtOutput.TabIndex = 3;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(60, 198);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(49, 13);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "message";
            // 
            // btnClipboard
            // 
            this.btnClipboard.Location = new System.Drawing.Point(226, 232);
            this.btnClipboard.Name = "btnClipboard";
            this.btnClipboard.Size = new System.Drawing.Size(119, 23);
            this.btnClipboard.TabIndex = 5;
            this.btnClipboard.Text = "Copy to Clipboard";
            this.btnClipboard.UseVisualStyleBackColor = true;
            this.btnClipboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(226, 153);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // radASCII
            // 
            this.radASCII.AutoSize = true;
            this.radASCII.Location = new System.Drawing.Point(63, 92);
            this.radASCII.Name = "radASCII";
            this.radASCII.Size = new System.Drawing.Size(52, 17);
            this.radASCII.TabIndex = 7;
            this.radASCII.TabStop = true;
            this.radASCII.Tag = "";
            this.radASCII.Text = "ASCII";
            this.radASCII.UseVisualStyleBackColor = true;
            // 
            // radUTF8
            // 
            this.radUTF8.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.radUTF8.AutoSize = true;
            this.radUTF8.Location = new System.Drawing.Point(168, 92);
            this.radUTF8.Name = "radUTF8";
            this.radUTF8.Size = new System.Drawing.Size(52, 17);
            this.radUTF8.TabIndex = 8;
            this.radUTF8.TabStop = true;
            this.radUTF8.Tag = "";
            this.radUTF8.Text = "UTF8";
            this.radUTF8.UseVisualStyleBackColor = true;
            // 
            // radNumeric
            // 
            this.radNumeric.AutoSize = true;
            this.radNumeric.Location = new System.Drawing.Point(281, 92);
            this.radNumeric.Name = "radNumeric";
            this.radNumeric.Size = new System.Drawing.Size(64, 17);
            this.radNumeric.TabIndex = 9;
            this.radNumeric.TabStop = true;
            this.radNumeric.Tag = "";
            this.radNumeric.Text = "Numeric";
            this.radNumeric.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(60, 121);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(29, 13);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "Error";
            // 
            // txtNoOfCharacters
            // 
            this.txtNoOfCharacters.Enabled = false;
            this.txtNoOfCharacters.Location = new System.Drawing.Point(63, 24);
            this.txtNoOfCharacters.Name = "txtNoOfCharacters";
            this.txtNoOfCharacters.Size = new System.Drawing.Size(158, 20);
            this.txtNoOfCharacters.TabIndex = 11;
            this.txtNoOfCharacters.Text = "Number of Characters:";
            // 
            // chkAutoClipboard
            // 
            this.chkAutoClipboard.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.chkAutoClipboard.AutoSize = true;
            this.chkAutoClipboard.Checked = true;
            this.chkAutoClipboard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoClipboard.Location = new System.Drawing.Point(63, 236);
            this.chkAutoClipboard.Name = "chkAutoClipboard";
            this.chkAutoClipboard.Size = new System.Drawing.Size(134, 17);
            this.chkAutoClipboard.TabIndex = 14;
            this.chkAutoClipboard.Text = "Auto Copy to Clipboard";
            this.chkAutoClipboard.UseVisualStyleBackColor = true;
            this.chkAutoClipboard.CheckedChanged += new System.EventHandler(this.chkAutoClipboard_CheckedChanged);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(384, 49);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(234, 13);
            this.lblOutput.TabIndex = 15;
            this.lblOutput.Text = "Output in Lines of 10 Characters (300 Char Max)";
            // 
            // lblVisualConfirmation
            // 
            this.lblVisualConfirmation.AutoSize = true;
            this.lblVisualConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualConfirmation.Location = new System.Drawing.Point(442, 24);
            this.lblVisualConfirmation.Name = "lblVisualConfirmation";
            this.lblVisualConfirmation.Size = new System.Drawing.Size(115, 13);
            this.lblVisualConfirmation.TabIndex = 16;
            this.lblVisualConfirmation.Text = "Visual Confirmation";
            // 
            // chkDelimeter
            // 
            this.chkDelimeter.AutoSize = true;
            this.chkDelimeter.Location = new System.Drawing.Point(141, 65);
            this.chkDelimeter.Name = "chkDelimeter";
            this.chkDelimeter.Size = new System.Drawing.Size(127, 17);
            this.chkDelimeter.TabIndex = 17;
            this.chkDelimeter.Text = "Add comma delimeter";
            this.chkDelimeter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 290);
            this.Controls.Add(this.chkDelimeter);
            this.Controls.Add(this.lblVisualConfirmation);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.chkAutoClipboard);
            this.Controls.Add(this.txtNoOfCharacters);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.radNumeric);
            this.Controls.Add(this.radUTF8);
            this.Controls.Add(this.radASCII);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClipboard);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "StringGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnClipboard;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton radASCII;
        private System.Windows.Forms.RadioButton radUTF8;
        private System.Windows.Forms.RadioButton radNumeric;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtNoOfCharacters;
        private System.Windows.Forms.CheckBox chkAutoClipboard;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblVisualConfirmation;
        private System.Windows.Forms.CheckBox chkDelimeter;
    }
}

