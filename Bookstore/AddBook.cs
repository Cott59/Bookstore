using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
            cBoxSerialBook.DataSource = SerialBook;
        }

        List<string> SerialBook = new List<string>() { "Нет", "Да" };
        private void btnAddBookDbase_Click(object sender, EventArgs e)
        {
            DataProcessing.Addbook
           (
            tbArticul.Text,
            tbNameBook.Text,
            tbAutor.Text,
            tbPublisher.Text,
            tbNumberOfPages.Text,
            tbGanre.Text,
            tbYear.Text,
            tbCostPrice.Text,
            tbSellingPrice.Text,
            cBoxSerialBook.Text,
            numQuantity.Value
            );
            this.Close();
        }
    }
}
