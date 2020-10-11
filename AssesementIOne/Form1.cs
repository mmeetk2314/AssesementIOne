using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssesementIOne
{
 
    public partial class MainForm : Form
    {
        mmclass mmclass = new mmclass();
        private object mygameplay;

        public MainForm()
        {
            InitializeComponent();
        }

        public object SoundPlayer { get; private set; }
        public object Sound { get; private set; }
        public object Public { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            mmclass.ShootAthead();
            //I am palying the audio in the shooting time
            SoundPlayer sound = new SoundPlayer(AssesementIOne.Properties.Resources.GunVoice);
            sound.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mmclass.shootAway();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            mmclass.spin();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            mmclass.WeaponLoad();
        }

        private void Score_Click(object sender, EventArgs e)
        {
        }

        private void SpinningButton_Click(object sender, EventArgs e)
        {
            mmclass.spin();
        }
    }
}
