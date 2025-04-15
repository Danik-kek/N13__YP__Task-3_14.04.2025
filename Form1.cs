using System.Windows.Forms;

namespace N13__YP__Task_3_14._04._2025
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // Обработчик события "Добавить" (кнопка btnAdd)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstMenu.SelectedItem != null)
            {
                lstZakaz.Items.Add(lstMenu.SelectedItem); // Добавляем выбранный элемент в заказ
            }
        }

        // Обработчик события "Убрать" (кнопка btnRemove)
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstZakaz.SelectedItem != null)
            {
                lstZakaz.Items.Remove(lstZakaz.SelectedItem); // Удаляем выбранный элемент из заказа
            }
        }

        // Обработчик события "Заказать" (кнопка btnOk)
        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приятного аппетита!", "Ресторан студент", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Закрываем форму после завершения заказа
        }
    }
}
