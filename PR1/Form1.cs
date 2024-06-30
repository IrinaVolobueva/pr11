using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Вычислить_Click(object sender, EventArgs e)
        { 
            if (!String.IsNullOrEmpty(SumChristmasTree.Text) & !String.IsNullOrEmpty(ColdChristmasTree.Text) & !String.IsNullOrEmpty(SumTinsel.Text) & !String.IsNullOrEmpty(ColdTinsel.Text) & 
                !String.IsNullOrEmpty(SumBall.Text) & !String.IsNullOrEmpty(ColdBall.Text) & !String.IsNullOrEmpty(SumGarland.Text) & !String.IsNullOrEmpty(ColdGarland.Text) & !String.IsNullOrEmpty(SumStars.Text) & 
                !String.IsNullOrEmpty(ColdStars.Text))
            {
                if (Double.TryParse(SumChristmasTree.Text, out double sumTree) & Int32.TryParse(ColdChristmasTree.Text, out int coldTree) & Double.TryParse(SumTinsel.Text, out double sumTinsel) & 
                    Int32.TryParse(ColdTinsel.Text, out int coldTinsel) & Double.TryParse(SumBall.Text, out double sumBall) & Int32.TryParse(ColdBall.Text, out int coldBall) & Double.TryParse(SumGarland.Text, out double sumGarland) &
                    Int32.TryParse(ColdGarland.Text, out int coldGarland) & Double.TryParse(SumStars.Text, out double sumStars) & Int32.TryParse(ColdStars.Text, out int coldStars))
                {
                    if (sumTree >= 0 & coldTree >= 0 & sumTinsel >= 0 & coldTinsel >= 0 & sumBall >= 0 & coldTinsel >= 0 & sumBall >= 0 & coldBall >= 0 & sumGarland >= 0 & coldGarland >= 0 & sumStars >= 0 & coldStars >= 0)
                    {
                        double sum = Math.Round((sumTree * coldTree + sumTinsel * coldTinsel + sumBall * coldBall + sumGarland * coldBall + sumStars * coldStars), 3);
                        SumTextBox.Text = $"{sum}";

                        int cold = coldTree + coldTinsel + coldBall + coldGarland + coldStars;
                        ColdTextBox.Text = $"{cold}";
                    }
                    else
                    {
                        MessageBox.Show("Сумма и кол-во украшений для нового года должны быть больше 0!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Проверьте введенность данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Проверьте введенность данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Выход_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColdTinsel.Clear();
            SumBall.Clear();
            ColdBall.Clear();
        }

        private void программаНовогодниеУкрашенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
