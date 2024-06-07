using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MessageBox_Display
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        MessageBoxButtons Buttons;
        MessageBoxIcon Icons;
        private void ButtonShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TextboxDesc.Text, TextboxTitle.Text, Buttons, Icons);
            switch (ComboBoxButtons.Text)
            {
                case "OK":
                    Buttons = MessageBoxButtons.OK;
                    break;
                case "OKCancel":
                    Buttons = MessageBoxButtons.OKCancel;
                    break;
                case "RetryCancel":
                    Buttons = MessageBoxButtons.RetryCancel;
                    break;
                case "YesNo":
                    Buttons = MessageBoxButtons.YesNo;
                    break;
                case "YesNoCancel":
                    Buttons = MessageBoxButtons.YesNoCancel;
                    break;
                case "AbortRetryIgnore":
                    Buttons = MessageBoxButtons.AbortRetryIgnore;
                    break;
            }
            switch (ComboBoxIcon.Text)
            {
                case "None":
                    Icons = MessageBoxIcon.None;
                    break;
                case "Hand":
                    Icons = MessageBoxIcon.Hand;
                    break;
                case "Question":
                    Icons = MessageBoxIcon.Question;
                    break;
                case "Exclamation":
                    Icons = MessageBoxIcon.Exclamation;
                    break;
                case "Asterisk":
                    Icons = MessageBoxIcon.Asterisk;
                    break;
                case "Stop":
                    Icons = MessageBoxIcon.Stop;
                    break;
                case "Error":
                    Icons = MessageBoxIcon.Error;
                    break;
                case "Warning":
                    Icons = MessageBoxIcon.Warning;
                    break;
                case "Information":
                    Icons = MessageBoxIcon.Information;
                    break;
            }
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
