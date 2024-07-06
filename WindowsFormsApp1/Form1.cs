using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            wplayer.URL = (@"C:\Users\adria\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\bling-bang-bang-born-made-with-Voicemod.mp3");
            wplayer.controls.play();
            axWindowsMediaPlayer1.Hide();   
        }

        public static WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
        private void btn_Start_MouseHover(object sender, EventArgs e)
        {
            btn_Start.Image = Properties.Resources.start_hover;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\adria\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\background sound.wav");
            sound.Play();
        }

        private void btn_Option_MouseHover(object sender, EventArgs e)
        {
            btn_Option.Image = Properties.Resources.option_hover;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\adria\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\background sound.wav");
            sound.Play();
        }

        private void btn_Exit_MouseHover(object sender, EventArgs e)
        {
            btn_Exit.Image = Properties.Resources.exit_hover;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\adria\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\background sound.wav");
            sound.Play();
        }

        private void btn_Option_MouseLeave(object sender, EventArgs e)
        {
            btn_Option.Image = Properties.Resources.option_normal;
        }

        private void btn_Exit_MouseLeave(object sender, EventArgs e)
        {
            btn_Exit.Image = Properties.Resources.exit_normal;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Menu.Hide();
        }

        private void Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Option_Click(object sender, EventArgs e)
        {
            OptionMenu option = new OptionMenu();
            option.ShowDialog();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
