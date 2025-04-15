using System.Windows.Forms;

namespace N13__YP__Task_3_14._04._2025
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // ���������� ������� "��������" (������ btnAdd)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstMenu.SelectedItem != null)
            {
                lstZakaz.Items.Add(lstMenu.SelectedItem); // ��������� ��������� ������� � �����
            }
        }

        // ���������� ������� "������" (������ btnRemove)
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstZakaz.SelectedItem != null)
            {
                lstZakaz.Items.Remove(lstZakaz.SelectedItem); // ������� ��������� ������� �� ������
            }
        }

        // ���������� ������� "��������" (������ btnOk)
        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��������� ��������!", "�������� �������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // ��������� ����� ����� ���������� ������
        }
    }
}
