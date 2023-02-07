using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tom_and_jerry_task_2.Properties;

namespace Tom_and_jerry_task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Bitmap tomleft = new Bitmap(Resources.Colyote_image_run_2);
            this.Cursor = new Cursor(tomleft.GetHicon());
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button bt)
            {
                bt.Dispose();
                Button button = new Button();
                button.BackgroundImage = Properties.Resources.Acme_image_2;
                button.FlatStyle = FlatStyle.Flat;
                button.Font = new Font("Comic Sans MS", 20, FontStyle.Regular);
                Random random = new Random();
                var x = random.Next(100, 800);
                var y = random.Next(200, 500);
                button.Location = new Point(x, y);
                button.AutoSize = true;

                button.Size = new Size(162, 148);
                button.MouseEnter += button1_MouseEnter;
                this.Controls.Add(button);
            }
        }
    }
}
