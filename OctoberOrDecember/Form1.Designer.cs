
namespace OctoberOrDecember
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
            this.tabControlLearningOrTesting = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.textBoxLowTempInput = new System.Windows.Forms.TextBox();
            this.labelLowTemp = new System.Windows.Forms.Label();
            this.textBoxHighTempInput = new System.Windows.Forms.TextBox();
            this.labelHighTemp = new System.Windows.Forms.Label();
            this.buttonDecember = new System.Windows.Forms.Button();
            this.buttonOctober = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonIncorrect = new System.Windows.Forms.Button();
            this.buttonCorrect = new System.Windows.Forms.Button();
            this.labelAIThouthsOutput = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxEnterLowTempInput = new System.Windows.Forms.TextBox();
            this.labelEnterLowTemp = new System.Windows.Forms.Label();
            this.textBoxEnterHighTempInput = new System.Windows.Forms.TextBox();
            this.labelEnterHighTemp = new System.Windows.Forms.Label();
            this.tabControlLearningOrTesting.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlLearningOrTesting
            // 
            this.tabControlLearningOrTesting.Controls.Add(this.tabPage1);
            this.tabControlLearningOrTesting.Controls.Add(this.tabPage2);
            this.tabControlLearningOrTesting.Location = new System.Drawing.Point(23, 30);
            this.tabControlLearningOrTesting.Name = "tabControlLearningOrTesting";
            this.tabControlLearningOrTesting.SelectedIndex = 0;
            this.tabControlLearningOrTesting.Size = new System.Drawing.Size(731, 340);
            this.tabControlLearningOrTesting.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonLoadData);
            this.tabPage1.Controls.Add(this.textBoxLowTempInput);
            this.tabPage1.Controls.Add(this.labelLowTemp);
            this.tabPage1.Controls.Add(this.textBoxHighTempInput);
            this.tabPage1.Controls.Add(this.labelHighTemp);
            this.tabPage1.Controls.Add(this.buttonDecember);
            this.tabPage1.Controls.Add(this.buttonOctober);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(723, 312);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Learning";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Location = new System.Drawing.Point(114, 266);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(176, 23);
            this.buttonLoadData.TabIndex = 6;
            this.buttonLoadData.Text = "Load Data";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadHighDec_Click);
            // 
            // textBoxLowTempInput
            // 
            this.textBoxLowTempInput.Location = new System.Drawing.Point(266, 110);
            this.textBoxLowTempInput.Name = "textBoxLowTempInput";
            this.textBoxLowTempInput.Size = new System.Drawing.Size(100, 23);
            this.textBoxLowTempInput.TabIndex = 5;
            // 
            // labelLowTemp
            // 
            this.labelLowTemp.AutoSize = true;
            this.labelLowTemp.Location = new System.Drawing.Point(79, 118);
            this.labelLowTemp.Name = "labelLowTemp";
            this.labelLowTemp.Size = new System.Drawing.Size(156, 15);
            this.labelLowTemp.TabIndex = 4;
            this.labelLowTemp.Text = "Low temperature of the day:";
            // 
            // textBoxHighTempInput
            // 
            this.textBoxHighTempInput.Location = new System.Drawing.Point(266, 44);
            this.textBoxHighTempInput.Name = "textBoxHighTempInput";
            this.textBoxHighTempInput.Size = new System.Drawing.Size(100, 23);
            this.textBoxHighTempInput.TabIndex = 3;
            // 
            // labelHighTemp
            // 
            this.labelHighTemp.AutoSize = true;
            this.labelHighTemp.Location = new System.Drawing.Point(79, 52);
            this.labelHighTemp.Name = "labelHighTemp";
            this.labelHighTemp.Size = new System.Drawing.Size(160, 15);
            this.labelHighTemp.TabIndex = 2;
            this.labelHighTemp.Text = "High temperature of the day:";
            // 
            // buttonDecember
            // 
            this.buttonDecember.Location = new System.Drawing.Point(266, 196);
            this.buttonDecember.Name = "buttonDecember";
            this.buttonDecember.Size = new System.Drawing.Size(75, 23);
            this.buttonDecember.TabIndex = 1;
            this.buttonDecember.Text = "December";
            this.buttonDecember.UseVisualStyleBackColor = true;
            this.buttonDecember.Click += new System.EventHandler(this.buttonDecember_Click);
            // 
            // buttonOctober
            // 
            this.buttonOctober.Location = new System.Drawing.Point(114, 196);
            this.buttonOctober.Name = "buttonOctober";
            this.buttonOctober.Size = new System.Drawing.Size(75, 23);
            this.buttonOctober.TabIndex = 0;
            this.buttonOctober.Text = "October";
            this.buttonOctober.UseVisualStyleBackColor = true;
            this.buttonOctober.Click += new System.EventHandler(this.buttonOctober_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.buttonIncorrect);
            this.tabPage2.Controls.Add(this.buttonCorrect);
            this.tabPage2.Controls.Add(this.labelAIThouthsOutput);
            this.tabPage2.Controls.Add(this.buttonCalculate);
            this.tabPage2.Controls.Add(this.textBoxEnterLowTempInput);
            this.tabPage2.Controls.Add(this.labelEnterLowTemp);
            this.tabPage2.Controls.Add(this.textBoxEnterHighTempInput);
            this.tabPage2.Controls.Add(this.labelEnterHighTemp);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(723, 312);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Testing";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "middle points";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonIncorrect
            // 
            this.buttonIncorrect.Enabled = false;
            this.buttonIncorrect.Location = new System.Drawing.Point(496, 243);
            this.buttonIncorrect.Name = "buttonIncorrect";
            this.buttonIncorrect.Size = new System.Drawing.Size(75, 23);
            this.buttonIncorrect.TabIndex = 7;
            this.buttonIncorrect.Text = "Incorrect";
            this.buttonIncorrect.UseVisualStyleBackColor = true;
            this.buttonIncorrect.Click += new System.EventHandler(this.buttonIncorrect_Click);
            // 
            // buttonCorrect
            // 
            this.buttonCorrect.Enabled = false;
            this.buttonCorrect.Location = new System.Drawing.Point(395, 243);
            this.buttonCorrect.Name = "buttonCorrect";
            this.buttonCorrect.Size = new System.Drawing.Size(75, 23);
            this.buttonCorrect.TabIndex = 6;
            this.buttonCorrect.Text = "Correct";
            this.buttonCorrect.UseVisualStyleBackColor = true;
            this.buttonCorrect.Click += new System.EventHandler(this.buttonCorrect_Click);
            // 
            // labelAIThouthsOutput
            // 
            this.labelAIThouthsOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAIThouthsOutput.Location = new System.Drawing.Point(395, 140);
            this.labelAIThouthsOutput.Name = "labelAIThouthsOutput";
            this.labelAIThouthsOutput.Size = new System.Drawing.Size(176, 44);
            this.labelAIThouthsOutput.TabIndex = 5;
            this.labelAIThouthsOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Enabled = false;
            this.buttonCalculate.Location = new System.Drawing.Point(395, 49);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(176, 52);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Find out the month";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxEnterLowTempInput
            // 
            this.textBoxEnterLowTempInput.Location = new System.Drawing.Point(225, 114);
            this.textBoxEnterLowTempInput.Name = "textBoxEnterLowTempInput";
            this.textBoxEnterLowTempInput.Size = new System.Drawing.Size(100, 23);
            this.textBoxEnterLowTempInput.TabIndex = 3;
            // 
            // labelEnterLowTemp
            // 
            this.labelEnterLowTemp.AutoSize = true;
            this.labelEnterLowTemp.Location = new System.Drawing.Point(70, 122);
            this.labelEnterLowTemp.Name = "labelEnterLowTemp";
            this.labelEnterLowTemp.Size = new System.Drawing.Size(128, 15);
            this.labelEnterLowTemp.TabIndex = 2;
            this.labelEnterLowTemp.Text = "Enter Low Temperature";
            // 
            // textBoxEnterHighTempInput
            // 
            this.textBoxEnterHighTempInput.Location = new System.Drawing.Point(225, 60);
            this.textBoxEnterHighTempInput.Name = "textBoxEnterHighTempInput";
            this.textBoxEnterHighTempInput.Size = new System.Drawing.Size(100, 23);
            this.textBoxEnterHighTempInput.TabIndex = 1;
            // 
            // labelEnterHighTemp
            // 
            this.labelEnterHighTemp.AutoSize = true;
            this.labelEnterHighTemp.Location = new System.Drawing.Point(70, 68);
            this.labelEnterHighTemp.Name = "labelEnterHighTemp";
            this.labelEnterHighTemp.Size = new System.Drawing.Size(132, 15);
            this.labelEnterHighTemp.TabIndex = 0;
            this.labelEnterHighTemp.Text = "Enter High Temperature";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 393);
            this.Controls.Add(this.tabControlLearningOrTesting);
            this.Name = "Form1";
            this.Text = "November or December?";
            this.tabControlLearningOrTesting.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlLearningOrTesting;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxLowTempInput;
        private System.Windows.Forms.Label labelLowTemp;
        private System.Windows.Forms.TextBox textBoxHighTempInput;
        private System.Windows.Forms.Label labelHighTemp;
        private System.Windows.Forms.Button buttonDecember;
        private System.Windows.Forms.Button buttonOctober;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxEnterLowTempInput;
        private System.Windows.Forms.Label labelEnterLowTemp;
        private System.Windows.Forms.TextBox textBoxEnterHighTempInput;
        private System.Windows.Forms.Label labelEnterHighTemp;
        private System.Windows.Forms.Label labelAIThouthsOutput;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.Button buttonIncorrect;
        private System.Windows.Forms.Button buttonCorrect;
        private System.Windows.Forms.Button button1;
    }
}

