using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regression_manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Left_Menu_Button_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 45)
                panel1.Width = 200;
            else
                panel1.Width = 45;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            pictureBox1_Click(sender,e);
        }

        private void Resize_Menu(dynamic sender, bool bToBIG)
        {
            if(bToBIG)
                sender.Size = new System.Drawing.Size(32, 29);
            else
                sender.Size = new System.Drawing.Size(40, 37);
        }

        #region Animated icons in left menu

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            Resize_Menu(sender, false);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Resize_Menu(sender, true);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            Resize_Menu(sender, true);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            Resize_Menu(sender, true);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Resize_Menu(sender, true);
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            Resize_Menu(sender, false);
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            Resize_Menu(sender, false);
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            Resize_Menu(sender, false);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Resize_Menu(sender, false);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox1_Click(sender, e);
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            Resize_Menu(sender, false);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            Resize_Menu(sender, true);
        }

        #endregion

        #region DragDrop Form without top bar
        private bool mouseDown;
        private Point lastLocation;


        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        #endregion

    }
}
