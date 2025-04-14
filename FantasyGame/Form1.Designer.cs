namespace FantasyGame
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
            btnChoose = new Button();
            btnAttack = new Button();
            txtName = new TextBox();
            txtBranch = new TextBox();
            txtPhylo = new TextBox();
            txtWeapon = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblEnemySoul = new Label();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnChoose
            // 
            btnChoose.BackColor = SystemColors.ActiveCaption;
            btnChoose.Location = new Point(319, 29);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(136, 45);
            btnChoose.TabIndex = 0;
            btnChoose.Text = "Choose";
            btnChoose.UseVisualStyleBackColor = false;
            btnChoose.Click += btnChoose_Click;
            // 
            // btnAttack
            // 
            btnAttack.BackColor = SystemColors.ActiveCaption;
            btnAttack.Location = new Point(110, 275);
            btnAttack.Name = "btnAttack";
            btnAttack.Size = new Size(270, 81);
            btnAttack.TabIndex = 1;
            btnAttack.Text = "Attack";
            btnAttack.UseVisualStyleBackColor = false;
            btnAttack.Click += btnAttack_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(168, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(124, 23);
            txtName.TabIndex = 2;
            // 
            // txtBranch
            // 
            txtBranch.Location = new Point(168, 41);
            txtBranch.Name = "txtBranch";
            txtBranch.Size = new Size(124, 23);
            txtBranch.TabIndex = 3;
            // 
            // txtPhylo
            // 
            txtPhylo.Location = new Point(168, 70);
            txtPhylo.Name = "txtPhylo";
            txtPhylo.Size = new Size(124, 23);
            txtPhylo.TabIndex = 4;
            // 
            // txtWeapon
            // 
            txtWeapon.Location = new Point(168, 99);
            txtWeapon.Name = "txtWeapon";
            txtWeapon.Size = new Size(124, 23);
            txtWeapon.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 15);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 6;
            label1.Text = "Player Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 44);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 7;
            label2.Text = "Branch :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 73);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 8;
            label3.Text = "Phylo :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 102);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 9;
            label4.Text = "Weapon :";
            // 
            // lblEnemySoul
            // 
            lblEnemySoul.BackColor = Color.DarkRed;
            lblEnemySoul.Location = new Point(506, 128);
            lblEnemySoul.Name = "lblEnemySoul";
            lblEnemySoul.Size = new Size(300, 24);
            lblEnemySoul.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.wolf_man__by_ivizianmedia_dfy5t9b_pre;
            pictureBox1.Location = new Point(506, 171);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 215);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Wizard", "Dwarf", "Elf" });
            comboBox1.Location = new Point(319, 85);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(136, 23);
            comboBox1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 450);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(lblEnemySoul);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtWeapon);
            Controls.Add(txtPhylo);
            Controls.Add(txtBranch);
            Controls.Add(txtName);
            Controls.Add(btnAttack);
            Controls.Add(btnChoose);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChoose;
        private Button btnAttack;
        private TextBox txtName;
        private TextBox txtBranch;
        private TextBox txtPhylo;
        private TextBox txtWeapon;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblEnemySoul;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
    }
}
