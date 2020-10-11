using System.Windows.Forms;

namespace AssesementIOne
{
    public partial class MainForm
    {
        public class LogicClass
        {
            int Bullet = 0;
            int Chances = 3;
            public void ShootAtHead()
            {
                //If bullet is inside the barrel, shoot ahead
                if (Bullet == 5)
                {
                    MessageBox.Show("died");
                }
                else
                {
                    MessageBox.Show("Revolver Rotate only");
                    Bullet += 1;
                }
            }
        }
    }
}
