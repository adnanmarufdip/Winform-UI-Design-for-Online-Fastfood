using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OnlineFastFoodOrder
{
    public partial class Form1 : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        int TogMove;
        int MValX;
        int MValY;

        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = HomeBtn.Height;
            SidePanel.Top = HomeBtn.Top;
            HomePage.BringToFront();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = HomeBtn.Height;
            SidePanel.Top = HomeBtn.Top;
            HomePage.BringToFront();
        }

        private void EatInBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = EatInBtn.Height;
            SidePanel.Top = EatInBtn.Top;
            EatInPage.BringToFront();
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
                this.Update();
            }
        }

        private void CollectionBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = CollectionBtn.Height;
            SidePanel.Top = CollectionBtn.Top;
        }

        private void DeliveryBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = DeliveryBtn.Height;
            SidePanel.Top = DeliveryBtn.Top;
        }

        private void TakeawayBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = TakeawayBtn.Height;
            SidePanel.Top = TakeawayBtn.Top;
        }

        private void PaymentsBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = PaymentsBtn.Height;
            SidePanel.Top = PaymentsBtn.Top;
        }

        private void CustomersBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = CustomersBtn.Height;
            SidePanel.Top = CustomersBtn.Top;
        }
    }
}
