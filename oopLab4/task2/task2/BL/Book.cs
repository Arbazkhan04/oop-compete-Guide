using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.BL
{
    class Book
    {
        public String author;
        public int pages;
        public List<String> chapters;
        public int bookMark;
        public int price;

        public Book(String author,int pages, List<String> chapters, int bookMark, int price)
        {
            this.author = author;
            this.pages = pages;
            this.chapters = chapters;
            this.bookMark = bookMark;
            this.price = price;
        }
        public String getChapter(int chapterNmber)
        {
            return this.chapters[chapterNmber - 1];
        }
        public int getBoolMArk()
        {
           return this.bookMark;
        }
        public void setBookMarkNumber(int pageNumber)
        {
            this.bookMark = pageNumber;
        }

        public int getBookPrice()
        {
            return this.price;
        }

        public void setBookPrice(int bookPrice)
        {
            this.price = bookPrice;
        }
    }
}
