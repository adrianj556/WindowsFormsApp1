namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Menu = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.PictureBox();
            this.btn_Option = new System.Windows.Forms.PictureBox();
            this.btn_Start = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Option)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Menu.BackgroundImage")));
            this.Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Menu.Controls.Add(this.btn_Exit);
            this.Menu.Controls.Add(this.btn_Option);
            this.Menu.Controls.Add(this.btn_Start);
            this.Menu.Location = new System.Drawing.Point(129, 12);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(300, 237);
            this.Menu.TabIndex = 0;
            this.Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.Menu_Paint);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.BackgroundImage")));
            this.btn_Exit.Location = new System.Drawing.Point(95, 149);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(100, 45);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            this.btn_Exit.MouseLeave += new System.EventHandler(this.btn_Exit_MouseLeave);
            this.btn_Exit.MouseHover += new System.EventHandler(this.btn_Exit_MouseHover);
            // 
            // btn_Option
            // 
            this.btn_Option.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Option.BackgroundImage")));
            this.btn_Option.Location = new System.Drawing.Point(95, 102);
            this.btn_Option.Name = "btn_Option";
            this.btn_Option.Size = new System.Drawing.Size(100, 50);
            this.btn_Option.TabIndex = 1;
            this.btn_Option.TabStop = false;
            this.btn_Option.Click += new System.EventHandler(this.btn_Option_Click);
            this.btn_Option.MouseLeave += new System.EventHandler(this.btn_Option_MouseLeave);
            this.btn_Option.MouseHover += new System.EventHandler(this.btn_Option_MouseHover);
            // 
            // btn_Start
            // 
            this.btn_Start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Start.BackgroundImage")));
            this.btn_Start.Location = new System.Drawing.Point(95, 57);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(100, 50);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.TabStop = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            this.btn_Start.MouseHover += new System.EventHandler(this.btn_Start_MouseHover);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(447, 59);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.Menu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Option)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.PictureBox btn_Exit;
        private System.Windows.Forms.PictureBox btn_Option;
        private System.Windows.Forms.PictureBox btn_Start;
        private System.Windows.Forms.BindingSource bindingSource1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

