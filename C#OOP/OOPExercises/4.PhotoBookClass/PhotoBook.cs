/*
    To start, create a class called PhotoBook with a private attribute numPages of type int. 
    It must also have a public method GetNumberPages that will return the number of photo book pages.

    The default constructor will create an album with 16 pages. There will be an additional constructor, with which we can specify the number of pages we want in the album.
*/

using System;

class PhotoBook
{
    protected int numPages; 

    // public int NumPages { get; set; }

    public int GetNumberPages() {
        return numPages;
    }

    public PhotoBook() {
        numPages = 16;
    }

    public PhotoBook(int numberPages) {
        numPages = numberPages;
    }
}