namespace MessageBox_Display
{
    partial class MainForm
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
            this.TextboxTitle = new System.Windows.Forms.TextBox();
            this.TextboxDesc = new System.Windows.Forms.TextBox();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ComboBoxButtons = new System.Windows.Forms.ComboBox();
            this.ComboBoxIcon = new System.Windows.Forms.ComboBox();
            this.GroupBoxMessage = new System.Windows.Forms.GroupBox();
            this.ButtonShow = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.GroupBoxMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextboxTitle
            // 
            this.TextboxTitle.Location = new System.Drawing.Point(18, 46);
            this.TextboxTitle.Name = "TextboxTitle";
            this.TextboxTitle.Size = new System.Drawing.Size(264, 22);
            this.TextboxTitle.TabIndex = 0;
            // 
            // TextboxDesc
            // 
            this.TextboxDesc.Location = new System.Drawing.Point(18, 90);
            this.TextboxDesc.MaxLength = 2147483647;
            this.TextboxDesc.Multiline = true;
            this.TextboxDesc.Name = "TextboxDesc";
            this.TextboxDesc.Size = new System.Drawing.Size(264, 123);
            this.TextboxDesc.TabIndex = 1;
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Location = new System.Drawing.Point(15, 71);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(78, 16);
            this.LabelDescription.TabIndex = 2;
            this.LabelDescription.Text = "Description:";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Location = new System.Drawing.Point(15, 27);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(36, 16);
            this.LabelTitle.TabIndex = 3;
            this.LabelTitle.Text = "Title:";
            // 
            // ComboBoxButtons
            // 
            this.ComboBoxButtons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxButtons.FormattingEnabled = true;
            this.ComboBoxButtons.Items.AddRange(new object[] {
            "OK",
            "OKCancel",
            "RetryCancel",
            "YesNo",
            "YesNoCancel",
            "AbortRetryIgnore"});
            this.ComboBoxButtons.Location = new System.Drawing.Point(18, 219);
            this.ComboBoxButtons.Name = "ComboBoxButtons";
            this.ComboBoxButtons.Size = new System.Drawing.Size(129, 24);
            this.ComboBoxButtons.TabIndex = 4;
            // 
            // ComboBoxIcon
            // 
            this.ComboBoxIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxIcon.FormattingEnabled = true;
            this.ComboBoxIcon.Items.AddRange(new object[] {
            "None",
            "Hand",
            "Question",
            "Exclamation",
            "Asterisk",
            "Stop",
            "Error",
            "Warning",
            "Information"});
            this.ComboBoxIcon.Location = new System.Drawing.Point(153, 219);
            this.ComboBoxIcon.Name = "ComboBoxIcon";
            this.ComboBoxIcon.Size = new System.Drawing.Size(129, 24);
            this.ComboBoxIcon.TabIndex = 5;
            // 
            // GroupBoxMessage
            // 
            this.GroupBoxMessage.Controls.Add(this.LabelTitle);
            this.GroupBoxMessage.Controls.Add(this.ComboBoxIcon);
            this.GroupBoxMessage.Controls.Add(this.TextboxTitle);
            this.GroupBoxMessage.Controls.Add(this.ComboBoxButtons);
            this.GroupBoxMessage.Controls.Add(this.TextboxDesc);
            this.GroupBoxMessage.Controls.Add(this.LabelDescription);
            this.GroupBoxMessage.Location = new System.Drawing.Point(12, 9);
            this.GroupBoxMessage.Name = "GroupBoxMessage";
            this.GroupBoxMessage.Size = new System.Drawing.Size(304, 268);
            this.GroupBoxMessage.TabIndex = 6;
            this.GroupBoxMessage.TabStop = false;
            this.GroupBoxMessage.Text = "MessageBox Options";
            // 
            // ButtonShow
            // 
            this.ButtonShow.Location = new System.Drawing.Point(12, 283);
            this.ButtonShow.Name = "ButtonShow";
            this.ButtonShow.Size = new System.Drawing.Size(94, 28);
            this.ButtonShow.TabIndex = 7;
            this.ButtonShow.Text = "Display";
            this.ButtonShow.UseVisualStyleBackColor = true;
            this.ButtonShow.Click += new System.EventHandler(this.ButtonShow_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(222, 283);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(94, 28);
            this.ButtonCancel.TabIndex = 8;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 323);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonShow);
            this.Controls.Add(this.GroupBoxMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "MessageBox Display";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GroupBoxMessage.ResumeLayout(false);
            this.GroupBoxMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextboxTitle;
        private System.Windows.Forms.TextBox TextboxDesc;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.ComboBox ComboBoxButtons;
        private System.Windows.Forms.ComboBox ComboBoxIcon;
        private System.Windows.Forms.GroupBox GroupBoxMessage;
        private System.Windows.Forms.Button ButtonShow;
        private System.Windows.Forms.Button ButtonCancel;
    }
}

