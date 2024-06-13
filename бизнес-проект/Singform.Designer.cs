namespace бизнес_проект
{
    partial class Singform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Singform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sing_button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pass_singtext = new System.Windows.Forms.TextBox();
            this.user_singtext = new System.Windows.Forms.TextBox();
            this.user_image = new System.Windows.Forms.PictureBox();
            this.close_button = new System.Windows.Forms.Label();
            this.authorization = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(95)))), ((int)(((byte)(187)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 583);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(133, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.sing_button);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pass_singtext);
            this.panel2.Controls.Add(this.user_singtext);
            this.panel2.Controls.Add(this.user_image);
            this.panel2.Controls.Add(this.close_button);
            this.panel2.Controls.Add(this.authorization);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(128, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 429);
            this.panel2.TabIndex = 0;
            // 
            // sing_button
            // 
            this.sing_button.BackColor = System.Drawing.Color.White;
            this.sing_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sing_button.FlatAppearance.BorderSize = 0;
            this.sing_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.sing_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.sing_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sing_button.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sing_button.Location = new System.Drawing.Point(182, 335);
            this.sing_button.Name = "sing_button";
            this.sing_button.Size = new System.Drawing.Size(183, 54);
            this.sing_button.TabIndex = 1;
            this.sing_button.Text = "Создать аккаунт";
            this.sing_button.UseVisualStyleBackColor = false;
            this.sing_button.Click += new System.EventHandler(this.sing_button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(86, 200);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pass_singtext
            // 
            this.pass_singtext.BackColor = System.Drawing.Color.White;
            this.pass_singtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass_singtext.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_singtext.Location = new System.Drawing.Point(135, 200);
            this.pass_singtext.Multiline = true;
            this.pass_singtext.Name = "pass_singtext";
            this.pass_singtext.Size = new System.Drawing.Size(345, 50);
            this.pass_singtext.TabIndex = 6;
            // 
            // user_singtext
            // 
            this.user_singtext.BackColor = System.Drawing.Color.White;
            this.user_singtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_singtext.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_singtext.Location = new System.Drawing.Point(135, 113);
            this.user_singtext.Multiline = true;
            this.user_singtext.Name = "user_singtext";
            this.user_singtext.Size = new System.Drawing.Size(345, 50);
            this.user_singtext.TabIndex = 1;
            // 
            // user_image
            // 
            this.user_image.BackColor = System.Drawing.Color.WhiteSmoke;
            this.user_image.Image = ((System.Drawing.Image)(resources.GetObject("user_image.Image")));
            this.user_image.Location = new System.Drawing.Point(86, 113);
            this.user_image.Name = "user_image";
            this.user_image.Size = new System.Drawing.Size(50, 50);
            this.user_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_image.TabIndex = 2;
            this.user_image.TabStop = false;
            // 
            // close_button
            // 
            this.close_button.AutoSize = true;
            this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.close_button.Location = new System.Drawing.Point(524, 0);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(28, 31);
            this.close_button.TabIndex = 1;
            this.close_button.Text = "х";
            this.close_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            this.close_button.MouseEnter += new System.EventHandler(this.close_button_MouseEnter);
            this.close_button.MouseLeave += new System.EventHandler(this.close_button_MouseLeave);
            // 
            // authorization
            // 
            this.authorization.Dock = System.Windows.Forms.DockStyle.Top;
            this.authorization.Font = new System.Drawing.Font("Century Gothic", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorization.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.authorization.Location = new System.Drawing.Point(0, 0);
            this.authorization.Name = "authorization";
            this.authorization.Size = new System.Drawing.Size(552, 83);
            this.authorization.TabIndex = 0;
            this.authorization.Text = "Регистрация";
            this.authorization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(179, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Сервис разработки бизнес-планов";
            // 
            // Singform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.panel1);
            this.Name = "Singform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Singform";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button sing_button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox pass_singtext;
        private System.Windows.Forms.TextBox user_singtext;
        private System.Windows.Forms.PictureBox user_image;
        private System.Windows.Forms.Label close_button;
        private System.Windows.Forms.Label authorization;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}