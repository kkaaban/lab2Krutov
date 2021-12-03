namespace lab2Krutov
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDefaultMessage = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPrograms = new System.Windows.Forms.ComboBox();
            this.buttonRunProgram = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBoxShowProgramAction = new System.Windows.Forms.CheckBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAddProgram = new System.Windows.Forms.Button();
            this.textBoxNameProgram = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGet_Windows_Directory = new System.Windows.Forms.TextBox();
            this.textBoxGet_System_Directory = new System.Windows.Forms.TextBox();
            this.buttonGet_Windows_Directory = new System.Windows.Forms.Button();
            this.buttonGet_System_Directory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(57, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a message";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(135, 56);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(299, 27);
            this.textBoxMessage.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show Message";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonDefaultMessage
            // 
            this.buttonDefaultMessage.Location = new System.Drawing.Point(135, 108);
            this.buttonDefaultMessage.Name = "buttonDefaultMessage";
            this.buttonDefaultMessage.Size = new System.Drawing.Size(129, 29);
            this.buttonDefaultMessage.TabIndex = 3;
            this.buttonDefaultMessage.Text = "Default Message";
            this.buttonDefaultMessage.UseVisualStyleBackColor = true;
            this.buttonDefaultMessage.Click += new System.EventHandler(this.buttonDefaultMessage_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(305, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "Clear Message";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(57, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 44);
            this.label2.TabIndex = 5;
            this.label2.Text = "Run a Program";
            // 
            // comboBoxPrograms
            // 
            this.comboBoxPrograms.FormattingEnabled = true;
            this.comboBoxPrograms.Location = new System.Drawing.Point(135, 199);
            this.comboBoxPrograms.Name = "comboBoxPrograms";
            this.comboBoxPrograms.Size = new System.Drawing.Size(299, 28);
            this.comboBoxPrograms.TabIndex = 6;
            // 
            // buttonRunProgram
            // 
            this.buttonRunProgram.Location = new System.Drawing.Point(440, 199);
            this.buttonRunProgram.Name = "buttonRunProgram";
            this.buttonRunProgram.Size = new System.Drawing.Size(145, 29);
            this.buttonRunProgram.TabIndex = 7;
            this.buttonRunProgram.Text = "Run a Program";
            this.buttonRunProgram.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(32, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enable Actions";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(339, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Show Actions";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(57, 387);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(185, 24);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Enable Message Action";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(57, 431);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(184, 24);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Enable Program Action";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(382, 387);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(176, 24);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "Show Message Action";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowProgramAction
            // 
            this.checkBoxShowProgramAction.AutoSize = true;
            this.checkBoxShowProgramAction.Checked = true;
            this.checkBoxShowProgramAction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowProgramAction.Location = new System.Drawing.Point(382, 431);
            this.checkBoxShowProgramAction.Name = "checkBoxShowProgramAction";
            this.checkBoxShowProgramAction.Size = new System.Drawing.Size(175, 24);
            this.checkBoxShowProgramAction.TabIndex = 13;
            this.checkBoxShowProgramAction.Text = "Show Program Action";
            this.checkBoxShowProgramAction.UseVisualStyleBackColor = true;
            this.checkBoxShowProgramAction.CheckedChanged += new System.EventHandler(this.checkBoxShowProgramAction_CheckedChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(251, 608);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(77, 29);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonAddProgram
            // 
            this.buttonAddProgram.Location = new System.Drawing.Point(440, 256);
            this.buttonAddProgram.Name = "buttonAddProgram";
            this.buttonAddProgram.Size = new System.Drawing.Size(145, 29);
            this.buttonAddProgram.TabIndex = 15;
            this.buttonAddProgram.Text = "Add Program";
            this.buttonAddProgram.UseVisualStyleBackColor = true;
            this.buttonAddProgram.Click += new System.EventHandler(this.buttonAddProgram_Click);
            // 
            // textBoxNameProgram
            // 
            this.textBoxNameProgram.Location = new System.Drawing.Point(135, 258);
            this.textBoxNameProgram.Name = "textBoxNameProgram";
            this.textBoxNameProgram.Size = new System.Drawing.Size(299, 27);
            this.textBoxNameProgram.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(57, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 44);
            this.label5.TabIndex = 17;
            this.label5.Text = "Name Program";
            // 
            // textBoxGet_Windows_Directory
            // 
            this.textBoxGet_Windows_Directory.Location = new System.Drawing.Point(32, 498);
            this.textBoxGet_Windows_Directory.Name = "textBoxGet_Windows_Directory";
            this.textBoxGet_Windows_Directory.Size = new System.Drawing.Size(232, 27);
            this.textBoxGet_Windows_Directory.TabIndex = 18;
            // 
            // textBoxGet_System_Directory
            // 
            this.textBoxGet_System_Directory.Location = new System.Drawing.Point(305, 498);
            this.textBoxGet_System_Directory.Name = "textBoxGet_System_Directory";
            this.textBoxGet_System_Directory.Size = new System.Drawing.Size(264, 27);
            this.textBoxGet_System_Directory.TabIndex = 19;
            // 
            // buttonGet_Windows_Directory
            // 
            this.buttonGet_Windows_Directory.Location = new System.Drawing.Point(32, 549);
            this.buttonGet_Windows_Directory.Name = "buttonGet_Windows_Directory";
            this.buttonGet_Windows_Directory.Size = new System.Drawing.Size(232, 29);
            this.buttonGet_Windows_Directory.TabIndex = 20;
            this.buttonGet_Windows_Directory.Text = "Get_Windows_Directory";
            this.buttonGet_Windows_Directory.UseVisualStyleBackColor = true;
            this.buttonGet_Windows_Directory.Click += new System.EventHandler(this.buttonGet_Windows_Directory_Click);
            // 
            // buttonGet_System_Directory
            // 
            this.buttonGet_System_Directory.Location = new System.Drawing.Point(305, 549);
            this.buttonGet_System_Directory.Name = "buttonGet_System_Directory";
            this.buttonGet_System_Directory.Size = new System.Drawing.Size(264, 29);
            this.buttonGet_System_Directory.TabIndex = 21;
            this.buttonGet_System_Directory.Text = "Get_System_Directory";
            this.buttonGet_System_Directory.UseVisualStyleBackColor = true;
            this.buttonGet_System_Directory.Click += new System.EventHandler(this.buttonGet_System_Directory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 649);
            this.Controls.Add(this.buttonGet_System_Directory);
            this.Controls.Add(this.buttonGet_Windows_Directory);
            this.Controls.Add(this.textBoxGet_System_Directory);
            this.Controls.Add(this.textBoxGet_Windows_Directory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNameProgram);
            this.Controls.Add(this.buttonAddProgram);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.checkBoxShowProgramAction);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRunProgram);
            this.Controls.Add(this.comboBoxPrograms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonDefaultMessage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Laboratory work 1_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxMessage;
        private Button button1;
        private Button buttonDefaultMessage;
        private Button button3;
        private Label label2;
        private ComboBox comboBoxPrograms;
        private Button buttonRunProgram;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBoxShowProgramAction;
        private Button buttonExit;
        private Button buttonAddProgram;
        private TextBox textBoxNameProgram;
        private Label label5;
        private TextBox textBoxGet_Windows_Directory;
        private TextBox textBoxGet_System_Directory;
        private Button buttonGet_Windows_Directory;
        private Button buttonGet_System_Directory;
    }
}