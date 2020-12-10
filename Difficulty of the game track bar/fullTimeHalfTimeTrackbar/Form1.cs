using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fullTimeHalfTimeTrackbar
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void btnWhatStatus_Click(object sender, EventArgs e)
        {

        }

        private void trkCredits_Scroll(object sender, EventArgs e)
        {
            int credits = trkCredits.Value;

            //Показать значение трекбара в lblCredits
            lblCredits.Text = trkCredits.Value.ToString();

            //Вычисление состояния и отображение в lblStatus
            if (credits >= 12)
            {
                lblStatus.Text = "Сложная игра";
            }
            else if (credits >= 6)
            {
                lblStatus.Text = "Средняя сложность";
            }
            else
            {
                lblStatus.Text = "Простая игра";
            }
        }

        private void form_Load(object sender, EventArgs e)
        {

        }
    }
}
