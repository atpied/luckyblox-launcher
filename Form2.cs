using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2017Launcher
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            // Привязываем событие потери фокуса программно
            this.Deactivate += Form2_Deactivate;
        }

        private void Form2_Deactivate(object sender, EventArgs e)
        {
            // Автоматически закрываем форму, когда пользователь переключается на другую форму
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
