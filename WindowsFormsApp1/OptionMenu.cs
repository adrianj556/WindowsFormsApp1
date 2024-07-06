using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class OptionMenu : Form
    {
        public OptionMenu()
        {
            InitializeComponent();
        }

        private void OptionMenu_Load(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Form1.wplayer.controls.play();
            btn_sound.Image = Properties.Resources.sound_on;
            Form1.wplayer.settings.volume = trackBar2.Value;

            if (trackBar2.Value == 0)
            {
                btn_sound.Image = Properties.Resources.sound_off;
            }
           
        }

        private void btn_sound_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_sound_Click_1(object sender, EventArgs e)
        {

        }
    }
        
}
