using System;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Lab6 : Form
    {
        public Lab6()
        {
            InitializeComponent();
        }

        private void tmrSecundomer_Tick(object sender, System.EventArgs e)
        {
            // Преобразуем текст в число
            int seconds = int.Parse(txtSeconds.Text);
            int minutes = int.Parse(txtMinutes.Text);

            // Увеличиваем секунды
            seconds++;

            // Если секунд стало 60, увеличиваем минуты
            if (seconds == 60)
            {
                seconds = 0;
                minutes++;
            }

            // Обновляем текстовые поля
            txtSeconds.Text = seconds.ToString();
            txtMinutes.Text = minutes.ToString();
        }

        private void btnStart_Click(object sender, System.EventArgs e)
        {
            // Переключаем состояние таймера
            tmrSecundomer.Enabled = !tmrSecundomer.Enabled;

            // Меняем текст кнопки
            if (tmrSecundomer.Enabled)
            {
                btnStart.Text = "Пауза";
            }
            else
            {
                btnStart.Text = "Старт";
            }

        }

        private void btnReset_Click(object sender, System.EventArgs e)
        {
            // Останавливаем таймер и сбрасываем время
            tmrSecundomer.Enabled = false;
            btnStart.Text = "Старт";
            txtSeconds.Text = "0";
            txtMinutes.Text = "0";
        }

        private void btnShowTime_Click(object sender, System.EventArgs e)
        {
            txtCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
