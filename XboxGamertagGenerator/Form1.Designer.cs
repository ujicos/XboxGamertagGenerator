namespace XboxGamertagGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gamertagList = new System.Windows.Forms.ListBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.generatemultiButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gamertagList
            // 
            this.gamertagList.FormattingEnabled = true;
            this.gamertagList.ItemHeight = 15;
            this.gamertagList.Location = new System.Drawing.Point(12, 194);
            this.gamertagList.Name = "gamertagList";
            this.gamertagList.Size = new System.Drawing.Size(373, 244);
            this.gamertagList.TabIndex = 0;
            this.gamertagList.SelectedIndexChanged += new System.EventHandler(this.gamertagList_SelectedIndexChanged);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(12, 53);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(371, 23);
            this.generateButton.TabIndex = 1;
            this.generateButton.Text = "Generate a Singular Random Gamertag";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(12, 140);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(371, 23);
            this.exportButton.TabIndex = 2;
            this.exportButton.Text = "Export Gamertag List";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(176, 28);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(42, 15);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Twitter";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Random Gamertag Generator";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(12, 111);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(371, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear List";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // generatemultiButton
            // 
            this.generatemultiButton.Location = new System.Drawing.Point(12, 82);
            this.generatemultiButton.Name = "generatemultiButton";
            this.generatemultiButton.Size = new System.Drawing.Size(371, 23);
            this.generatemultiButton.TabIndex = 6;
            this.generatemultiButton.Text = "Generate a Set of Random Gamertags";
            this.generatemultiButton.UseVisualStyleBackColor = true;
            this.generatemultiButton.Click += new System.EventHandler(this.generatemultiButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(43, 166);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(309, 15);
            this.infoLabel.TabIndex = 7;
            this.infoLabel.Text = "Double clicking a gamertag will copy it to your clipboard!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.generatemultiButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.gamertagList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "uji\'s Random Xbox Gamertag Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox gamertagList;
        private Button generateButton;
        private Button exportButton;
        private LinkLabel linkLabel1;
        private Label label1;
        private Button clearButton;
        private Button generatemultiButton;
        private Label infoLabel;
    }
}