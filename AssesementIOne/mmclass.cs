using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssesementIOne
{
    public class mmclass
    {
        int Bullet = 0;
        int Chances = 1;
        public void ShootAthead()
        {
            //If bullet is under the gun, shootahead
            if (Bullet == 5)
            {
                MessageBox.Show("Died");
            }
            else
            {
                MessageBox.Show("barrel rotated only");
                Bullet = Bullet + 1;
            }

        }

        public object Skip()
        {
            throw new NotImplementedException();
        }

        public void shootAway()
        {
            //if i get any chance
            if (Chances > 1)
            {
               if (Bullet == 5)
                {
                    MessageBox.Show("not win");

                }
                else
                {
                    //not shooting
                    MessageBox.Show("barrel rotated only");
                    Bullet = Bullet + 1;
                }

            }
            //not opportunity
            else
            {
                MessageBox.Show("losse");
            }
            Chances = Chances - 1;
        }

       

        public int spin()
        {
            Random rand = new Random();
            Bullet = rand.Next(1, 5);
            MessageBox.Show("spin");
            return Bullet;
        }
        public void WeaponLoad()
        {
            Bullet = 0;
            MessageBox.Show("reload");
        }
    }
}
