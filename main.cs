using System;

class MainClass {
  public static void Main (string[] args) {
    Book book1 = new Book("ISBN1", "Title1", new Author("First", "Last"));
    Book book2 = new Book("ISBN2", "Title2", new Author("First", "Last"));
    Book book3 = new Book("ISBN3", "Title3", new Author("First", "Last"));
    Book book4 = new Book("ISBN4", "Title4", new Author("First", "Last"), new DateTime(2011, 02, 21), "John Smith");
    Book book5 = new Book("ISBN5", "Title5", new Author("First", "Last"), new DateTime(1845, 03, 18), "John Appleseed");
    Book book6 = new Book("ISBN6", "Title6", new Author("First", "Last"), new DateTime(2020, 12, 06), "Justin Noble");

    Author author1 = new Author("Gary", "Miles");
    Author author2 = new Author("Abraham", "Lincoln");

    author1.DisplayInfo();
    author2.DisplayInfo();

    author1.AddBook(book1);
    author1.AddBook(book3);
    author1.AddBook(book4);
    author1.DisplayBooks();

    author2.AddBook(book2);
    author2.AddBook(book4);
    author2.AddBook(book6);
    author2.DisplayBooks();

    author1.RemoveBook(book1);
    author1.DisplayBooks();
  }
}