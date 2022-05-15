namespace Sernios
{
    partial class Menu
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
            System.Windows.Forms.Label labelTitle;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonOpenCharacter = new System.Windows.Forms.Button();
            this.buttonNewCharacter = new System.Windows.Forms.Button();
            labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            resources.ApplyResources(labelTitle, "labelTitle");
            labelTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            labelTitle.Name = "labelTitle";
            labelTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonOpenCharacter
            // 
            resources.ApplyResources(this.buttonOpenCharacter, "buttonOpenCharacter");
            this.buttonOpenCharacter.Name = "buttonOpenCharacter";
            this.buttonOpenCharacter.UseVisualStyleBackColor = true;
            // 
            // buttonNewCharacter
            // 
            resources.ApplyResources(this.buttonNewCharacter, "buttonNewCharacter");
            this.buttonNewCharacter.Name = "buttonNewCharacter";
            this.buttonNewCharacter.UseVisualStyleBackColor = true;
            this.buttonNewCharacter.Click += new System.EventHandler(this.buttonNewCharacter_Click);
            // 
            // Menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.buttonNewCharacter);
            this.Controls.Add(this.buttonOpenCharacter);
            this.Controls.Add(labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonOpenCharacter;
        private Button buttonNewCharacter;
    }
}