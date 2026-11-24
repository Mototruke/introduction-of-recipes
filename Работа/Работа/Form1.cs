using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Работа
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1DataSet.Рецепты". При необходимости она может быть перемещена или удалена.
            this.рецептыTableAdapter.Fill(this._1DataSet.Рецепты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1DataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this._1DataSet.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1DataSet.Категории". При необходимости она может быть перемещена или удалена.
            this.категорииTableAdapter.Fill(this._1DataSet.Категории);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1DataSet.Ингредиенты". При необходимости она может быть перемещена или удалена.
            this.ингредиентыTableAdapter.Fill(this._1DataSet.Ингредиенты);

        }
    }
}
