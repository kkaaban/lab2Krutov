namespace lab2Krutov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDefaultMessage_Click(object sender, EventArgs e)
        {
            textBoxMessage.Text = "Enter a message here";
        }

        private void checkBoxShowProgramAction_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; 
            if (checkBox.Checked == true)
            {
                comboBoxPrograms.Visible = true;
                buttonRunProgram.Visible = true;
                buttonAddProgram.Visible = true;
                textBoxNameProgram.Visible = true;
            }
            else
            {
                comboBoxPrograms.Visible = false;
                buttonRunProgram.Visible = false;
                buttonAddProgram.Visible = false;
                textBoxNameProgram.Visible = false;
            }
        }

        private void buttonAddProgram_Click(object sender, EventArgs e)
        {
            comboBoxPrograms.Items.Add(textBoxNameProgram.Text);
        }

        private void buttonGet_Windows_Directory_Click(object sender, EventArgs e)
        {
            Environment.SpecialFolder win = Environment.SpecialFolder.Windows;
            textBoxGet_Windows_Directory.Text = Environment.GetFolderPath(win);
        }

        private void buttonGet_System_Directory_Click(object sender, EventArgs e)
        {
            Environment.SpecialFolder win = Environment.SpecialFolder.System;
            textBoxGet_System_Directory.Text = Environment.GetFolderPath(win);
        }
    }
}