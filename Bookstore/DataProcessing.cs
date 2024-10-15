using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace Bookstore
{
    internal class DataProcessing
    {

        private static BookStoreContext _context;
        public static string _selectItem = "";
        public static Book bookTmp = new Book();

        public static void Addbook(string articul, string nameBook, string autor, string publisher, string numberOfPages,
            string ganre, string year, string costPrice, string sellingPrice, string bookASequel, Decimal counter)
        {
            BookStoreContext context = new BookStoreContext();
            _context = context;
            Book Instance = new Book();
           
            Instance.Number = articul;
            Instance.NameBook = nameBook;
            Instance.AuthorFullName = autor;
            Instance.PublisherName = publisher;
            Instance.NumberOfPages = numberOfPages;
            Instance.Genre = ganre;
            Instance.YearOfPublication = year;
            Instance.CostPrice = costPrice;
            Instance.SellingPrice = sellingPrice;
            Instance.BookASequel = bookASequel;
            Instance.Quantity = counter;
            context.Books.Add(Instance);            
            context.SaveChanges();

        }

        public static List<Book> RefreshTable(string ColumnSerch, string ItemSerch="")
        {
            BookStoreContext context = new BookStoreContext();
            _context = context;
            DbSet<Book> expenses = _context.Books;
            List<Book> result = new List<Book>();
            if(ColumnSerch=="Все")
            {
                result = expenses.ToList();
                
            }    
            
            return result;
        }


      

        public static void DeleteOrder(string nameItem)//Удаление книги
        {
            BookStoreContext context = new BookStoreContext();
            
            Book book = context.Books
                .Where(o => o.Number == nameItem)
                .FirstOrDefault();

            context.Books.Remove(book);
            context.SaveChanges();
        }

        public static void EditSaleBook(string nameItem, Decimal numSale)//продажа книг
        {
            BookStoreContext context = new BookStoreContext();

            Book book = context.Books
                .Where(o => o.Number == nameItem)
                .FirstOrDefault();
            if (book.Quantity < numSale)
            {
                MessageBox.Show(
                    "Неверное количество книг",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            else 
            {
                book.Quantity -= numSale;
            }  
                                    
            context.SaveChanges();
        }

        public static void AddSalebook(string nameItem, decimal proc )//Добавление книг в акцию
        {
            BookStoreContext context = new BookStoreContext();

            Book book = context.Books
                .Where(o => o.Number == nameItem)
                .FirstOrDefault();

            int t = Int32.TryParse(book.SellingPrice, out int val) ? val : 0;
            t-=(t/100)*(int)proc;
            book.SellingPrice = $"{t}  -{proc}%";          
            context.SaveChanges();
        }

        public static void DelSalebook(string nameItem)//возврат книги из акции
        {
            BookStoreContext context = new BookStoreContext();

            Book book = context.Books
                .Where(o => o.Number == nameItem)
                .FirstOrDefault();            
            string[] list = book.SellingPrice.Split(' ');
            string rr = list[2].Trim('-', '%');
            decimal t = Int32.TryParse(list[0], out int val) ? val : 0;
            decimal tt = Int32.TryParse(rr, out val) ? val : 0;
            t /= ((100 - tt) / 100);
            string n = t.ToString();
            list = n.Split(',');
            book.SellingPrice = $"{list[0]}";
            context.SaveChanges();
        }

        public static void GetbookEdit(string nameItem)
        {
            BookStoreContext context = new BookStoreContext();

            bookTmp = context.Books
                .Where(o => o.Number == nameItem)
                .FirstOrDefault();
        }
        public static List<Book> GetBooks(string name)//Выборка из книг по артикулу, полному и не полному
        {
            BookStoreContext context = new BookStoreContext();      
            IQueryable<Book> selectedBooks = from p in context.Books 
                                 where (p.Number).StartsWith(name)   //фильтрация по критерию                                 
                                 select p; // выбираем объект в создаваемую коллекцию
            var dd = selectedBooks.ToList();
            return dd;
        }

        public static void SetEditBook(string quality)//Запись в БД отредактированной книги
        {
            BookStoreContext context = new BookStoreContext();           
            var s = quality.Split(',');
            decimal dec = Int32.Parse(s[0]);
            bookTmp.Quantity = dec;
            context.Books.AddOrUpdate<Book>(bookTmp);            
            context.SaveChanges();
        }




    }
}
