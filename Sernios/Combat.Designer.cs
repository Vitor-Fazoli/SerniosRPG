namespace Sernios
{
    partial class Combat
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
            this.barPlayerHealth = new System.Windows.Forms.ProgressBar();
            this.barEnemyHealth = new System.Windows.Forms.ProgressBar();
            this.barActionPointsPlayer = new System.Windows.Forms.ProgressBar();
            this.HabilityMenu = new System.Windows.Forms.MenuStrip();
            this.habilidade1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habilidade2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelPlayerHealth = new System.Windows.Forms.Label();
            this.labelActionPointsPlayer = new System.Windows.Forms.Label();
            this.labelEnemyHealth = new System.Windows.Forms.Label();
            this.barActionPointsEnemy = new System.Windows.Forms.ProgressBar();
            this.labelActionPointsEnemy = new System.Windows.Forms.Label();
            this.buttonWeapon1 = new System.Windows.Forms.Button();
            this.buttonWeapon2 = new System.Windows.Forms.Button();
            this.skipTurn = new System.Windows.Forms.Button();
            this.labelNameEnemy = new System.Windows.Forms.Label();
            this.labelLevelEnemy = new System.Windows.Forms.Label();
            this.lvlEnemy = new System.Windows.Forms.Label();
            this.HabilityMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // barPlayerHealth
            // 
            this.barPlayerHealth.Location = new System.Drawing.Point(12, 390);
            this.barPlayerHealth.Name = "barPlayerHealth";
            this.barPlayerHealth.Size = new System.Drawing.Size(335, 23);
            this.barPlayerHealth.Step = 1;
            this.barPlayerHealth.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barPlayerHealth.TabIndex = 0;
            // 
            // barEnemyHealth
            // 
            this.barEnemyHealth.Location = new System.Drawing.Point(347, 12);
            this.barEnemyHealth.Name = "barEnemyHealth";
            this.barEnemyHealth.Size = new System.Drawing.Size(304, 23);
            this.barEnemyHealth.Step = 1;
            this.barEnemyHealth.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barEnemyHealth.TabIndex = 1;
            // 
            // barActionPointsPlayer
            // 
            this.barActionPointsPlayer.Location = new System.Drawing.Point(12, 419);
            this.barActionPointsPlayer.Name = "barActionPointsPlayer";
            this.barActionPointsPlayer.Size = new System.Drawing.Size(111, 23);
            this.barActionPointsPlayer.Step = 1;
            this.barActionPointsPlayer.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barActionPointsPlayer.TabIndex = 2;
            // 
            // HabilityMenu
            // 
            this.HabilityMenu.AutoSize = false;
            this.HabilityMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.HabilityMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HabilityMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.HabilityMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.habilidade1ToolStripMenuItem,
            this.habilidade2ToolStripMenuItem});
            this.HabilityMenu.Location = new System.Drawing.Point(654, 0);
            this.HabilityMenu.Name = "HabilityMenu";
            this.HabilityMenu.Size = new System.Drawing.Size(146, 450);
            this.HabilityMenu.TabIndex = 3;
            this.HabilityMenu.Text = "menuStrip1";
            // 
            // habilidade1ToolStripMenuItem
            // 
            this.habilidade1ToolStripMenuItem.Name = "habilidade1ToolStripMenuItem";
            this.habilidade1ToolStripMenuItem.Size = new System.Drawing.Size(142, 25);
            this.habilidade1ToolStripMenuItem.Text = "Habilidade 1";
            // 
            // habilidade2ToolStripMenuItem
            // 
            this.habilidade2ToolStripMenuItem.Name = "habilidade2ToolStripMenuItem";
            this.habilidade2ToolStripMenuItem.Size = new System.Drawing.Size(142, 25);
            this.habilidade2ToolStripMenuItem.Text = "Habilidade 2";
            // 
            // labelPlayerHealth
            // 
            this.labelPlayerHealth.AutoSize = true;
            this.labelPlayerHealth.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlayerHealth.Location = new System.Drawing.Point(353, 390);
            this.labelPlayerHealth.Name = "labelPlayerHealth";
            this.labelPlayerHealth.Size = new System.Drawing.Size(42, 25);
            this.labelPlayerHealth.TabIndex = 4;
            this.labelPlayerHealth.Text = "100";
            // 
            // labelActionPointsPlayer
            // 
            this.labelActionPointsPlayer.AutoSize = true;
            this.labelActionPointsPlayer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelActionPointsPlayer.Location = new System.Drawing.Point(129, 419);
            this.labelActionPointsPlayer.Name = "labelActionPointsPlayer";
            this.labelActionPointsPlayer.Size = new System.Drawing.Size(22, 25);
            this.labelActionPointsPlayer.TabIndex = 5;
            this.labelActionPointsPlayer.Text = "0";
            // 
            // labelEnemyHealth
            // 
            this.labelEnemyHealth.AutoSize = true;
            this.labelEnemyHealth.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnemyHealth.Location = new System.Drawing.Point(278, 12);
            this.labelEnemyHealth.Name = "labelEnemyHealth";
            this.labelEnemyHealth.Size = new System.Drawing.Size(42, 25);
            this.labelEnemyHealth.TabIndex = 6;
            this.labelEnemyHealth.Text = "100";
            // 
            // barActionPointsEnemy
            // 
            this.barActionPointsEnemy.Location = new System.Drawing.Point(540, 41);
            this.barActionPointsEnemy.Name = "barActionPointsEnemy";
            this.barActionPointsEnemy.Size = new System.Drawing.Size(111, 23);
            this.barActionPointsEnemy.Step = 1;
            this.barActionPointsEnemy.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barActionPointsEnemy.TabIndex = 7;
            // 
            // labelActionPointsEnemy
            // 
            this.labelActionPointsEnemy.AutoSize = true;
            this.labelActionPointsEnemy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelActionPointsEnemy.Location = new System.Drawing.Point(471, 41);
            this.labelActionPointsEnemy.Name = "labelActionPointsEnemy";
            this.labelActionPointsEnemy.Size = new System.Drawing.Size(22, 25);
            this.labelActionPointsEnemy.TabIndex = 8;
            this.labelActionPointsEnemy.Text = "0";
            // 
            // buttonWeapon1
            // 
            this.buttonWeapon1.Location = new System.Drawing.Point(12, 361);
            this.buttonWeapon1.Name = "buttonWeapon1";
            this.buttonWeapon1.Size = new System.Drawing.Size(139, 23);
            this.buttonWeapon1.TabIndex = 9;
            this.buttonWeapon1.Text = "Use Primary Weapon";
            this.buttonWeapon1.UseVisualStyleBackColor = true;
            this.buttonWeapon1.Click += new System.EventHandler(this.buttonWeapon1_Click);
            // 
            // buttonWeapon2
            // 
            this.buttonWeapon2.Location = new System.Drawing.Point(157, 361);
            this.buttonWeapon2.Name = "buttonWeapon2";
            this.buttonWeapon2.Size = new System.Drawing.Size(155, 23);
            this.buttonWeapon2.TabIndex = 10;
            this.buttonWeapon2.Text = "Use Secondary Weapon";
            this.buttonWeapon2.UseVisualStyleBackColor = true;
            this.buttonWeapon2.Click += new System.EventHandler(this.buttonWeapon2_Click);
            // 
            // skipTurn
            // 
            this.skipTurn.Location = new System.Drawing.Point(540, 341);
            this.skipTurn.Name = "skipTurn";
            this.skipTurn.Size = new System.Drawing.Size(111, 43);
            this.skipTurn.TabIndex = 11;
            this.skipTurn.Text = "Skip Turn";
            this.skipTurn.UseVisualStyleBackColor = true;
            this.skipTurn.Click += new System.EventHandler(this.skipTurn_Click);
            // 
            // labelNameEnemy
            // 
            this.labelNameEnemy.AutoSize = true;
            this.labelNameEnemy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNameEnemy.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNameEnemy.Location = new System.Drawing.Point(12, 12);
            this.labelNameEnemy.Name = "labelNameEnemy";
            this.labelNameEnemy.Size = new System.Drawing.Size(131, 47);
            this.labelNameEnemy.TabIndex = 12;
            this.labelNameEnemy.Text = "Inimigo";
            // 
            // labelLevelEnemy
            // 
            this.labelLevelEnemy.AutoSize = true;
            this.labelLevelEnemy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLevelEnemy.Location = new System.Drawing.Point(53, 59);
            this.labelLevelEnemy.Name = "labelLevelEnemy";
            this.labelLevelEnemy.Size = new System.Drawing.Size(42, 25);
            this.labelLevelEnemy.TabIndex = 13;
            this.labelLevelEnemy.Text = "100";
            // 
            // lvlEnemy
            // 
            this.lvlEnemy.AutoSize = true;
            this.lvlEnemy.Location = new System.Drawing.Point(20, 67);
            this.lvlEnemy.Name = "lvlEnemy";
            this.lvlEnemy.Size = new System.Drawing.Size(27, 15);
            this.lvlEnemy.TabIndex = 14;
            this.lvlEnemy.Text = "Lvl: ";
            // 
            // Combat
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvlEnemy);
            this.Controls.Add(this.labelLevelEnemy);
            this.Controls.Add(this.labelNameEnemy);
            this.Controls.Add(this.skipTurn);
            this.Controls.Add(this.buttonWeapon2);
            this.Controls.Add(this.buttonWeapon1);
            this.Controls.Add(this.labelActionPointsEnemy);
            this.Controls.Add(this.barActionPointsEnemy);
            this.Controls.Add(this.labelEnemyHealth);
            this.Controls.Add(this.labelActionPointsPlayer);
            this.Controls.Add(this.labelPlayerHealth);
            this.Controls.Add(this.barActionPointsPlayer);
            this.Controls.Add(this.barEnemyHealth);
            this.Controls.Add(this.barPlayerHealth);
            this.Controls.Add(this.HabilityMenu);
            this.Name = "Combat";
            this.Text = "Combat";
            this.HabilityMenu.ResumeLayout(false);
            this.HabilityMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStripMenuItem habilidade1ToolStripMenuItem;
        private ToolStripMenuItem habilidade2ToolStripMenuItem;
        protected Button skipTurn;
        protected ProgressBar barPlayerHealth;
        protected ProgressBar barEnemyHealth;
        protected ProgressBar barActionPointsPlayer;
        protected MenuStrip HabilityMenu;
        protected Label labelPlayerHealth;
        protected Label labelActionPointsPlayer;
        protected Label labelEnemyHealth;
        protected ProgressBar barActionPointsEnemy;
        protected Label labelActionPointsEnemy;
        protected Button buttonWeapon1;
        protected Button buttonWeapon2;
        protected Label labelNameEnemy;
        protected Label labelLevelEnemy;
        private Label lvlEnemy;
    }
}