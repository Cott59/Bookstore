using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Bookstore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Settings();
            
        }
        List<string> Selectvalues = new List<string>() {"Все", "Артикул" };
        private string ItemSerch = "";
        private string ColumnSerch = "Все";
        private void Settings()
        {
            dgrShowBooks.AutoGenerateColumns=true;            
            cboxShowSelect.DataSource = Selectvalues;
            this.dgrShowBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnSaveEditBook.Enabled = false;
            btnEditBook.Enabled = false;
            btnDeleteBook.Enabled = false;
            btnSale.Enabled = false;
            btnDelSale.Enabled = false;
            btnAddSale.Enabled = false;
        }

        private void btAddBook_Click_1(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.Show();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ColumnSerch =  cboxShowSelect.Text;
            ItemSerch = tboxInputSearch.Text;   
            if(ColumnSerch == "Артикул")
            {
                dgrShowBooks.DataSource = DataProcessing.GetBooks(ItemSerch);
            }
            else
            {
                dgrShowBooks.DataSource = DataProcessing.RefreshTable(ColumnSerch, ItemSerch);
            }
            
        }    

        private void cboxShowSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            tboxInputSearch.Text = "";
            if (cboxShowSelect.Text == "Все")
            {
                tboxInputSearch.Enabled = false;
            }
            else
            {
                tboxInputSearch.Enabled = true;
            }
        }

        private void GetCurrentRow()//возвращает выбранную строку(книгу) из таблицы Датагрид
        {
            for (int i = 0; i < dgrShowBooks.ColumnCount; i++)
            {
                if(i==1)
                {
                    DataProcessing._selectItem= $"{dgrShowBooks[i, dgrShowBooks.CurrentCellAddress.Y].Value}";
                    tbArticul.Text= $"{dgrShowBooks[i, dgrShowBooks.CurrentCellAddress.Y].Value}";
                }
                if (i == 2)
                {                    
                    tbNameBook.Text = $"{dgrShowBooks[i, dgrShowBooks.CurrentCellAddress.Y].Value}";
                }
                if (i == 3)
                {
                    tbAutor.Text = $"{dgrShowBooks[i, dgrShowBooks.CurrentCellAddress.Y].Value}";
                }
                if (i == 4)
                {
                    tbPublisher.Text = $"{dgrShowBooks[i, dgrShowBooks.CurrentCellAddress.Y].Value}";
                }
                if (i == 5)
                {
                    tbNumberOfPages.Text = $"{dgrShowBooks[i, dgrShowBooks.CurrentCellAddress.Y].Value}";
                }
                if (i == 6)
                {
                    tbGanre.Text = $"{dgrShowBooks[i, dgrShowBooks.CurrentCellAddress.Y].Value}";
                }
                if (i == 7)
                {
                    tbYear.Text = $"{dgrShowBooks[i, dgrShowBooks.CurrentCellAddress.Y].Value}";
                }
                if (i == 8)
                {
                    tbCostPrice.Text = $"{dgrShowBooks[i, dgrShowBooks.CurrentCellAddress.Y].Value}";
                }
                if (i == 9)
                {
                    tbSellingPrice.Text = $"{dgrShowBooks[i, dgrShowBooks.CurrentCellAddress.Y].Value}";
                }
                if (i == 10)
                {
                    tboxSerialsBook.Text = $"{dgrShowBooks[i, dgrShowBooks.CurrentCellAddress.Y].Value}";
                }
                if (i == 11)
                {
                    tboxQuality.Text = $"{dgrShowBooks[i, dgrShowBooks.CurrentCellAddress.Y].Value}";
                }
                DataProcessing.GetbookEdit(DataProcessing._selectItem);
            }                      
        }
        
        private void btnSetEdit_Click(object sender, EventArgs e)
        {
            GetCurrentRow();
            btnSaveEditBook.Enabled = true;
            btnEditBook.Enabled = true;
            btnDeleteBook.Enabled = true;
            btnSale.Enabled = true;
            btnDelSale.Enabled = true;
            btnAddSale.Enabled = true;
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            DataProcessing.DeleteOrder(DataProcessing._selectItem);
            
            ItemSerch = "";
            cboxShowSelect.Text= "Все";
            dgrShowBooks.DataSource = DataProcessing.RefreshTable(ColumnSerch, ItemSerch);
        }



        private void btnSale_Click(object sender, EventArgs e)
        {
            DataProcessing.EditSaleBook(DataProcessing._selectItem, numSaleQuantity.Value);
            btnUpdate_Click(sender, e);
        }
                

        private void btnDelSale_Click(object sender, EventArgs e)
        {
            DataProcessing.DelSalebook(DataProcessing._selectItem);
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            DataProcessing.AddSalebook(DataProcessing._selectItem, numPrSale.Value);
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            //tbArticul.ReadOnly = false; tbArticul.Enabled = true;
            //tbNameBook.ReadOnly = false; tbNameBook.Enabled = true;
            //tbAutor.ReadOnly = false; tbAutor.Enabled = true;
            //tbGanre.ReadOnly = false ; tbGanre.Enabled = true;
            //tbYear.ReadOnly = false ; tbYear.Enabled = true;
            //tboxSerialsBook.ReadOnly = false ; tboxSerialsBook.Enabled = true;
            //tbCostPrice.ReadOnly = false; tbCostPrice.Enabled = true;
            //tbSellingPrice.ReadOnly = false; tbSellingPrice.Enabled = true;
            tboxQuality.ReadOnly = false; tboxQuality.Enabled = true;
        }

        private void btnSaveEditBook_Click(object sender, EventArgs e)
        {
            tboxQuality.ReadOnly = false; tboxQuality.Enabled = false;
            DataProcessing.SetEditBook(tboxQuality.Text);
            
            btnUpdate_Click(sender, e);
            
        }
    }
}
