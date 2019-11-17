using System;
using System.Windows.Forms;

namespace Lab11_Alekseev_Igor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNow_Click(object sender, EventArgs e)
        {//сегодня
            textBoxNow.SelectAll();
            textBoxNow.Cut();
            textBoxNow.Text = $"Сегодня {DateTime.Now.ToString()}";
        }

        private void btnSplitUp_Click(object sender, EventArgs e)
        {// разделить день месяц год по отдельности
            DateTime sDay = DateTime.Today;
            labelDay.Text = $"День {sDay.Day}";
            labelMonth.Text = $"Месяц {sDay.Month}";
            labelYear.Text = $"Год {sDay.Year}";
            labelDayOfWeek.Text = Convert.ToString(sDay.DayOfWeek);
        }

        private void btnClearNow_Click(object sender, EventArgs e)
        {//очистить
            textBoxNow.SelectAll();
            textBoxNow.Cut();
        }

        private void btnClearSplitUp_Click(object sender, EventArgs e)
        {//очистить
            labelDay.Text = ""; labelMonth.Text = ""; labelYear.Text = ""; labelDayOfWeek.Text = "";
        }

        private void btnNextDay_Click(object sender, EventArgs e)
        { //прибавить число к дню
            DateTime sDay = DateTime.Now;
            richTextBox.Text += $"Завтра {sDay.AddDays(1)}\nЧерез неделю {sDay.AddDays(7)}";

        }

        private void btnCalculateAge_Click(object sender, EventArgs e)
        {//вычислить возраст
            DateTime nowDate = DateTime.Today;
            DateTime dt = Convert.ToDateTime(textBoxEnterBirthday.Text);
            richTextBox.Text = Convert.ToString(nowDate.Year - dt.Year) + " лет";
        }
    }
}