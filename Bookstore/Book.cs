using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bookstore
{
    internal class Book
    {
        
        public int BookId { get; set; }
        
        //[Column(TypeName = "Артикул")]
        //[Key]
        public string Number { get; set; }

        //[Column(TypeName = "Название")]
        public string NameBook {  get; set; }

        //[Column(TypeName = "Автор")]
        public string AuthorFullName { get; set; }

        //[Column(TypeName = "Издательство")]
        public string PublisherName { get; set; }

        //[Column(TypeName = "Количество страниц")]
        public string NumberOfPages { get; set; }

        //[Column(TypeName = "Жанр")]
        public string Genre { get; set; }

        //[Column(TypeName = "Год издания")]
        public string YearOfPublication { get; set; }

        //[Column(TypeName = "Себестоимость")]
        public string CostPrice { get; set; }

        //[Column(TypeName = "Цена в продаже")]
        public string SellingPrice { get; set; }

        //[Column(TypeName = "Серийность")]
        public string BookASequel { get; set; }

        
        public decimal Quantity { get; set; }


    }

    //internal class Store
    //{
    //    public int StoreId { get; set; }

    //    [Column(TypeName = "Количество")]
    //    public decimal Quantity { get; set; }

    //    public string bookNumber {  get; set; }

    //    [ForeignKey("bookNumber")]
    //    public Book Book { get; set; }

    //}
}
