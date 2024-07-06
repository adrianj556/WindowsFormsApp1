namespace WindowsFormsApp1
{
    partial class OptionMenu
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
            this.Option = new System.Windows.Forms.Panel();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.btn_sound = new System.Windows.Forms.PictureBox();
            this.Option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sound)).BeginInit();
            this.SuspendLayout();
            // 
            // Option
            // 
            this.Option.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.option_menu;
            this.Option.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Option.Controls.Add(this.btn_sound);
            this.Option.Controls.Add(this.trackBar2);
            this.Option.Location = new System.Drawing.Point(129, 12);
            this.Option.Name = "Option";
            this.Option.Size = new System.Drawing.Size(300, 237);
            this.Option.TabIndex = 0;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(89, 99);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(122, 45);
            this.trackBar2.TabIndex = 2;
            this.trackBar2.Value = 50;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // btn_sound
            // 
            this.btn_sound.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_sound.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.sound_on;
            this.btn_sound.Location = new System.Drawing.Point(127, 150);
            this.btn_sound.Name = "btn_sound";
            this.btn_sound.Size = new System.Drawing.Size(50, 50);
            this.btn_sound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_sound.TabIndex = 1;
            this.btn_sound.TabStop = false;
            this.btn_sound.Click += new System.EventHandler(this.btn_sound_Click_1);
            // 
            // OptionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.Option);
            this.Name = "OptionMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OptionMenu";
            this.Load += new System.EventHandler(this.OptionMenu_Load);
            this.Option.ResumeLayout(false);
            this.Option.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sound)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Option;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.PictureBox btn_sound;
    }
}