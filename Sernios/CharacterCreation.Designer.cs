namespace Sernios
{
    partial class CharacterCreation
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
            this.components = new System.ComponentModel.Container();
            this.labelNameTitle = new System.Windows.Forms.Label();
            this.labelLoreTitle = new System.Windows.Forms.Label();
            this.labelAncestorTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.VitalityTrackBar = new System.Windows.Forms.TrackBar();
            this.InteligenceTrackBar = new System.Windows.Forms.TrackBar();
            this.MetabolsimTrackBar = new System.Windows.Forms.TrackBar();
            this.labelPlagueTitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelInteligenceShow = new System.Windows.Forms.Label();
            this.labelMetabolismShow = new System.Windows.Forms.Label();
            this.labelVitalityShow = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.labelControlVitality = new System.Windows.Forms.Label();
            this.labelControlMetabolism = new System.Windows.Forms.Label();
            this.labelControlnteligence = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelPointsAtr = new System.Windows.Forms.Label();
            this.UpdateData = new System.Windows.Forms.Timer(this.components);
            this.checkboxListPlagues = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SaveButton = new System.Windows.Forms.Button();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.labelClassTitle = new System.Windows.Forms.Label();
            this.labelHelpClass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VitalityTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InteligenceTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MetabolsimTrackBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNameTitle
            // 
            this.labelNameTitle.AutoSize = true;
            this.labelNameTitle.Location = new System.Drawing.Point(3, 13);
            this.labelNameTitle.Name = "labelNameTitle";
            this.labelNameTitle.Size = new System.Drawing.Size(40, 15);
            this.labelNameTitle.TabIndex = 0;
            this.labelNameTitle.Text = "Nome";
            // 
            // labelLoreTitle
            // 
            this.labelLoreTitle.AutoSize = true;
            this.labelLoreTitle.Location = new System.Drawing.Point(12, 299);
            this.labelLoreTitle.Name = "labelLoreTitle";
            this.labelLoreTitle.Size = new System.Drawing.Size(48, 15);
            this.labelLoreTitle.TabIndex = 2;
            this.labelLoreTitle.Text = "História";
            // 
            // labelAncestorTitle
            // 
            this.labelAncestorTitle.AutoSize = true;
            this.labelAncestorTitle.Location = new System.Drawing.Point(12, 104);
            this.labelAncestorTitle.Name = "labelAncestorTitle";
            this.labelAncestorTitle.Size = new System.Drawing.Size(86, 15);
            this.labelAncestorTitle.TabIndex = 3;
            this.labelAncestorTitle.Text = "Antescendente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Atributos";
            // 
            // VitalityTrackBar
            // 
            this.VitalityTrackBar.Location = new System.Drawing.Point(96, 65);
            this.VitalityTrackBar.Maximum = 75;
            this.VitalityTrackBar.Name = "VitalityTrackBar";
            this.VitalityTrackBar.Size = new System.Drawing.Size(130, 45);
            this.VitalityTrackBar.TabIndex = 5;
            this.VitalityTrackBar.Scroll += new System.EventHandler(this.VitalityTrackBar_Scroll);
            // 
            // InteligenceTrackBar
            // 
            this.InteligenceTrackBar.Location = new System.Drawing.Point(96, 167);
            this.InteligenceTrackBar.Maximum = 75;
            this.InteligenceTrackBar.Name = "InteligenceTrackBar";
            this.InteligenceTrackBar.Size = new System.Drawing.Size(130, 45);
            this.InteligenceTrackBar.TabIndex = 6;
            this.InteligenceTrackBar.Scroll += new System.EventHandler(this.InteligenceTrackBar_Scroll);
            // 
            // MetabolsimTrackBar
            // 
            this.MetabolsimTrackBar.Location = new System.Drawing.Point(96, 116);
            this.MetabolsimTrackBar.Maximum = 75;
            this.MetabolsimTrackBar.Name = "MetabolsimTrackBar";
            this.MetabolsimTrackBar.Size = new System.Drawing.Size(130, 45);
            this.MetabolsimTrackBar.TabIndex = 7;
            this.MetabolsimTrackBar.Scroll += new System.EventHandler(this.MetabolsimTrackBar_Scroll);
            // 
            // labelPlagueTitle
            // 
            this.labelPlagueTitle.AutoSize = true;
            this.labelPlagueTitle.Location = new System.Drawing.Point(12, 201);
            this.labelPlagueTitle.Name = "labelPlagueTitle";
            this.labelPlagueTitle.Size = new System.Drawing.Size(52, 15);
            this.labelPlagueTitle.TabIndex = 12;
            this.labelPlagueTitle.Text = "Infecção";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(52, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(12, 317);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(482, 140);
            this.textBox2.TabIndex = 18;
            // 
            // labelInteligenceShow
            // 
            this.labelInteligenceShow.AutoSize = true;
            this.labelInteligenceShow.Location = new System.Drawing.Point(22, 167);
            this.labelInteligenceShow.Name = "labelInteligenceShow";
            this.labelInteligenceShow.Size = new System.Drawing.Size(68, 15);
            this.labelInteligenceShow.TabIndex = 19;
            this.labelInteligenceShow.Text = "Intêligencia";
            this.labelInteligenceShow.MouseHover += new System.EventHandler(this.labelInteligenceShow_MouseHover);
            // 
            // labelMetabolismShow
            // 
            this.labelMetabolismShow.AutoSize = true;
            this.labelMetabolismShow.Location = new System.Drawing.Point(13, 116);
            this.labelMetabolismShow.Name = "labelMetabolismShow";
            this.labelMetabolismShow.Size = new System.Drawing.Size(77, 15);
            this.labelMetabolismShow.TabIndex = 20;
            this.labelMetabolismShow.Text = "Metabolismo";
            this.labelMetabolismShow.MouseHover += new System.EventHandler(this.labelMetabolismShow_MouseHover);
            // 
            // labelVitalityShow
            // 
            this.labelVitalityShow.AutoSize = true;
            this.labelVitalityShow.Location = new System.Drawing.Point(31, 65);
            this.labelVitalityShow.Name = "labelVitalityShow";
            this.labelVitalityShow.Size = new System.Drawing.Size(59, 15);
            this.labelVitalityShow.TabIndex = 21;
            this.labelVitalityShow.Text = "Vitalidade";
            this.labelVitalityShow.MouseHover += new System.EventHandler(this.labelVitalityShow_MouseHover);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(194, 207);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 22;
            this.ResetButton.Text = "Resetar";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelControlVitality
            // 
            this.labelControlVitality.AutoSize = true;
            this.labelControlVitality.Location = new System.Drawing.Point(228, 65);
            this.labelControlVitality.Name = "labelControlVitality";
            this.labelControlVitality.Size = new System.Drawing.Size(13, 15);
            this.labelControlVitality.TabIndex = 23;
            this.labelControlVitality.Text = "0";
            // 
            // labelControlMetabolism
            // 
            this.labelControlMetabolism.AutoSize = true;
            this.labelControlMetabolism.Location = new System.Drawing.Point(228, 116);
            this.labelControlMetabolism.Name = "labelControlMetabolism";
            this.labelControlMetabolism.Size = new System.Drawing.Size(13, 15);
            this.labelControlMetabolism.TabIndex = 24;
            this.labelControlMetabolism.Text = "0";
            // 
            // labelControlnteligence
            // 
            this.labelControlnteligence.AutoSize = true;
            this.labelControlnteligence.Location = new System.Drawing.Point(228, 167);
            this.labelControlnteligence.Name = "labelControlnteligence";
            this.labelControlnteligence.Size = new System.Drawing.Size(13, 15);
            this.labelControlnteligence.TabIndex = 25;
            this.labelControlnteligence.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "Pontos disponíveis: ";
            // 
            // labelPointsAtr
            // 
            this.labelPointsAtr.AutoSize = true;
            this.labelPointsAtr.Location = new System.Drawing.Point(228, 17);
            this.labelPointsAtr.Name = "labelPointsAtr";
            this.labelPointsAtr.Size = new System.Drawing.Size(13, 15);
            this.labelPointsAtr.TabIndex = 27;
            this.labelPointsAtr.Text = "0";
            // 
            // UpdateData
            // 
            this.UpdateData.Enabled = true;
            this.UpdateData.Tick += new System.EventHandler(this.UpdateData_Tick);
            // 
            // checkboxListPlagues
            // 
            this.checkboxListPlagues.BackColor = System.Drawing.SystemColors.Window;
            this.checkboxListPlagues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkboxListPlagues.CheckOnClick = true;
            this.checkboxListPlagues.FormattingEnabled = true;
            this.checkboxListPlagues.Items.AddRange(new object[] {
            "Sem Infecção",
            "Doença do Crocodilo",
            "Morcego",
            "Licantropia"});
            this.checkboxListPlagues.Location = new System.Drawing.Point(12, 219);
            this.checkboxListPlagues.Name = "checkboxListPlagues";
            this.checkboxListPlagues.Size = new System.Drawing.Size(140, 74);
            this.checkboxListPlagues.TabIndex = 28;
            this.checkboxListPlagues.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkboxListPlagues_ItemCheck);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BackColor = System.Drawing.SystemColors.Window;
            this.checkedListBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Nascido nas ruas",
            "O poder da alta patente",
            "Vivência de um orfão",
            "Trabalhando desde muito cedo"});
            this.checkedListBox2.Location = new System.Drawing.Point(12, 122);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(192, 74);
            this.checkedListBox2.TabIndex = 29;
            this.checkedListBox2.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox2_ItemCheck);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ResetButton);
            this.panel1.Controls.Add(this.MetabolsimTrackBar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.VitalityTrackBar);
            this.panel1.Controls.Add(this.labelPointsAtr);
            this.panel1.Controls.Add(this.InteligenceTrackBar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.labelInteligenceShow);
            this.panel1.Controls.Add(this.labelControlnteligence);
            this.panel1.Controls.Add(this.labelMetabolismShow);
            this.panel1.Controls.Add(this.labelControlMetabolism);
            this.panel1.Controls.Add(this.labelVitalityShow);
            this.panel1.Controls.Add(this.labelControlVitality);
            this.panel1.Location = new System.Drawing.Point(210, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 248);
            this.panel1.TabIndex = 30;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(419, 463);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 28;
            this.SaveButton.Text = "Salvar";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Items.AddRange(new object[] {
            "Assassino",
            "Bispo",
            "Ex-Piloto",
            "Patrulheiro",
            "Policial",
            "Religioso",
            "Andarilho",
            "Monge"});
            this.comboBoxClass.Location = new System.Drawing.Point(52, 41);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(121, 23);
            this.comboBoxClass.TabIndex = 31;
            // 
            // labelClassTitle
            // 
            this.labelClassTitle.AutoSize = true;
            this.labelClassTitle.Location = new System.Drawing.Point(3, 44);
            this.labelClassTitle.Name = "labelClassTitle";
            this.labelClassTitle.Size = new System.Drawing.Size(40, 15);
            this.labelClassTitle.TabIndex = 32;
            this.labelClassTitle.Text = "Classe";
            // 
            // labelHelpClass
            // 
            this.labelHelpClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHelpClass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHelpClass.Location = new System.Drawing.Point(179, 41);
            this.labelHelpClass.Name = "labelHelpClass";
            this.labelHelpClass.Size = new System.Drawing.Size(23, 23);
            this.labelHelpClass.TabIndex = 33;
            this.labelHelpClass.Text = " ? ";
            this.labelHelpClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHelpClass.Click += new System.EventHandler(this.labelHelpClass_Click);
            // 
            // CharacterCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(510, 492);
            this.Controls.Add(this.labelHelpClass);
            this.Controls.Add(this.labelClassTitle);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkboxListPlagues);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelPlagueTitle);
            this.Controls.Add(this.labelAncestorTitle);
            this.Controls.Add(this.labelLoreTitle);
            this.Controls.Add(this.labelNameTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CharacterCreation";
            this.ShowIcon = false;
            this.Text = "Character Creator";
            ((System.ComponentModel.ISupportInitialize)(this.VitalityTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InteligenceTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MetabolsimTrackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNameTitle;
        private Label labelLoreTitle;
        private Label labelAncestorTitle;
        private Label label5;
        private Label labelPlagueTitle;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label labelInteligenceShow;
        private Label labelMetabolismShow;
        private Label labelVitalityShow;
        private Button ResetButton;
        protected TrackBar VitalityTrackBar;
        protected TrackBar InteligenceTrackBar;
        protected TrackBar MetabolsimTrackBar;
        protected Label labelControlVitality;
        protected Label labelControlMetabolism;
        protected Label labelControlnteligence;
        private Label label9;
        private Label labelPointsAtr;
        protected System.Windows.Forms.Timer UpdateData;
        private CheckedListBox checkedListBox2;
        protected CheckedListBox checkboxListPlagues;
        private Panel panel1;
        private ToolTip toolTip1;
        private Label labelPointsNeg;
        private Label labelTextNeg;
        private Button SaveButton;
        private ComboBox comboBoxClass;
        private Label labelClassTitle;
        private Label labelHelpClass;
    }
}