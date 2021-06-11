
namespace CS056Semafor
{
    partial class SemaforForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.semaforTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.zapnoutButton = new System.Windows.Forms.Button();
            this.vypnoutButton = new System.Windows.Forms.Button();
            this.rizeniZapnoutButton = new System.Windows.Forms.Button();
            this.rizeniVypnoutButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // semaforTimer
            // 
            this.semaforTimer.Enabled = true;
            this.semaforTimer.Interval = 50;
            this.semaforTimer.Tick += new System.EventHandler(this.semaforTimer_Tick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CS056Semafor.Properties.Resources.svetloVypnute;
            this.pictureBox4.Location = new System.Drawing.Point(78, 286);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CS056Semafor.Properties.Resources.svetloVypnute;
            this.pictureBox2.Location = new System.Drawing.Point(78, 161);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CS056Semafor.Properties.Resources.svetloVypnute;
            this.pictureBox1.Location = new System.Drawing.Point(78, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // zapnoutButton
            // 
            this.zapnoutButton.Location = new System.Drawing.Point(343, 173);
            this.zapnoutButton.Name = "zapnoutButton";
            this.zapnoutButton.Size = new System.Drawing.Size(75, 23);
            this.zapnoutButton.TabIndex = 5;
            this.zapnoutButton.Text = "Zapnout";
            this.zapnoutButton.UseVisualStyleBackColor = true;
            this.zapnoutButton.Click += new System.EventHandler(this.zapnoutButton_Click);
            // 
            // vypnoutButton
            // 
            this.vypnoutButton.Location = new System.Drawing.Point(474, 173);
            this.vypnoutButton.Name = "vypnoutButton";
            this.vypnoutButton.Size = new System.Drawing.Size(75, 23);
            this.vypnoutButton.TabIndex = 6;
            this.vypnoutButton.Text = "Vypnout";
            this.vypnoutButton.UseVisualStyleBackColor = true;
            this.vypnoutButton.Click += new System.EventHandler(this.vypnoutButton_Click);
            // 
            // rizeniZapnoutButton
            // 
            this.rizeniZapnoutButton.Location = new System.Drawing.Point(343, 241);
            this.rizeniZapnoutButton.Name = "rizeniZapnoutButton";
            this.rizeniZapnoutButton.Size = new System.Drawing.Size(75, 38);
            this.rizeniZapnoutButton.TabIndex = 7;
            this.rizeniZapnoutButton.Text = "Řízení Zapnout";
            this.rizeniZapnoutButton.UseVisualStyleBackColor = true;
            this.rizeniZapnoutButton.Click += new System.EventHandler(this.rizeniZapnoutButton_Click);
            // 
            // rizeniVypnoutButton
            // 
            this.rizeniVypnoutButton.Location = new System.Drawing.Point(474, 241);
            this.rizeniVypnoutButton.Name = "rizeniVypnoutButton";
            this.rizeniVypnoutButton.Size = new System.Drawing.Size(75, 38);
            this.rizeniVypnoutButton.TabIndex = 9;
            this.rizeniVypnoutButton.Text = "Řízení Vypnout";
            this.rizeniVypnoutButton.UseVisualStyleBackColor = true;
            this.rizeniVypnoutButton.Click += new System.EventHandler(this.rizeniVypnoutButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CS056Semafor.Properties.Resources.svetloVypnute;
            this.pictureBox3.Location = new System.Drawing.Point(632, 286);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CS056Semafor.Properties.Resources.svetloVypnute;
            this.pictureBox5.Location = new System.Drawing.Point(632, 161);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 100);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CS056Semafor.Properties.Resources.svetloVypnute;
            this.pictureBox6.Location = new System.Drawing.Point(632, 35);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 100);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // SemaforForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.rizeniVypnoutButton);
            this.Controls.Add(this.rizeniZapnoutButton);
            this.Controls.Add(this.vypnoutButton);
            this.Controls.Add(this.zapnoutButton);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SemaforForm";
            this.Text = "CS058 Semafor - Trnobranský Tomáš";
            this.Load += new System.EventHandler(this.CS056Semafor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer semaforTimer;
        private System.Windows.Forms.Button zapnoutButton;
        private System.Windows.Forms.Button vypnoutButton;
        private System.Windows.Forms.Button rizeniZapnoutButton;
        private System.Windows.Forms.Button rizeniVypnoutButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

