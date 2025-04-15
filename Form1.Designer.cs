namespace N13__YP__Task_3_14._04._2025
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstMenu = new ListBox();
            lstZakaz = new ListBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnOk = new Button();
            SuspendLayout();
            // 
            // lstMenu
            // 
            lstMenu.Items.AddRange(new object[] { "Пицца", "Спагетти", "Салат Цезарь", "Бургер" });
            lstMenu.Location = new Point(50, 50);
            lstMenu.Name = "lstMenu";
            lstMenu.Size = new Size(200, 184);
            lstMenu.TabIndex = 0;
            // 
            // lstZakaz
            // 
            lstZakaz.Location = new Point(300, 50);
            lstZakaz.Name = "lstZakaz";
            lstZakaz.Size = new Size(200, 184);
            lstZakaz.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(270, 260);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 30);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Добавить";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(390, 260);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(100, 30);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Убрать";
            btnRemove.Click += btnRemove_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(330, 300);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(100, 30);
            btnOk.TabIndex = 4;
            btnOk.Text = "Заказать";
            btnOk.Click += btnOk_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstMenu);
            Controls.Add(lstZakaz);
            Controls.Add(btnAdd);
            Controls.Add(btnRemove);
            Controls.Add(btnOk);
            Name = "Form4";
            Text = "Задание 3: Ресторан \"Голодный студент \"";
            ResumeLayout(false);
        }

        #endregion

        // Декларация элементов управления
        private System.Windows.Forms.ListBox lstMenu;
        private System.Windows.Forms.ListBox lstZakaz;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnOk;
    }
}
