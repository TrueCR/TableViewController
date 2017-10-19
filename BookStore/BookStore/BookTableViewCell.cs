using Foundation;
using System;
using UIKit;

namespace BookStore
{
    public partial class BookTableViewCell : UITableViewCell
    {
        private Book bookData;
        public Book BookData
        {
            get { return bookData; }
            set 
            {
                bookData = value; 
            }
        }

        public BookTableViewCell (IntPtr handle) : base (handle)
        {
        }
    }
}