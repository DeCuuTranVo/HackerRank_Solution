/*
    Create a C# program to manage a photo book using object-oriented programming.

    Finally create a PhotoBookTest class to perform the following actions:

    Create a default photo book and show the number of pages
    Create a photo book with 24 pages and show the number of pages
    Create a large photo book and show the number of pages

    Problem: https://www.exercisescsharp.com/oop/photo-book-class
*/

class StudentTeacherTest {
    public static void Main(string[] args) {
        PhotoBook book = new PhotoBook();
        Console.WriteLine(book.GetNumberPages());

        PhotoBook book2 = new PhotoBook(24);
        Console.WriteLine(book2.GetNumberPages());

        BigPhotoBook book3 = new BigPhotoBook();
        Console.WriteLine(book3.GetNumberPages()); 
    }
}

/*
    using System;
 
    public class PhotoBookTest
    {
        public static void Main()
        {
            PhotoBook myAlbum1 = new PhotoBook();
            Console.WriteLine(myAlbum1.GetNumberPages());
    
            PhotoBook myAlbum2 = new PhotoBook(24);
            Console.WriteLine(myAlbum2.GetNumberPages());
    
            SuperPhotoBook myBigPhotoAlbum1 = new SuperPhotoBook();
            Console.WriteLine(myBigPhotoAlbum1.GetNumberPages());
        }
    }
    
    public class PhotoBook
    {
        protected int numPages;
    
        public PhotoBook()
        {
            numPages = 16;
        }
    
        public PhotoBook(int numPages)
        {
            this.numPages = numPages;
        }
    
        public int GetNumberPages()
        {
            return numPages;
        }
    }
    
    public class SuperPhotoBook : PhotoBook
    {
        public SuperPhotoBook()
        {
            numPages = 64;
        }
    }
*/