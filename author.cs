using System;
using System.Collections.Generic;

class Author : Person {
  private List<Book> books = new List<Book>();

  public Author(string fname, string lname) : base(fname, lname) {
    
  }

  public void DisplayInfo() {
    Console.WriteLine("First Name: '" + base.FirstName + "'");
    Console.WriteLine("Last Name: '" + base.LastName + "'");
    Console.WriteLine("Email: '" + this.Email + "'");
  }

  public void DisplayBooks() {
    foreach(Book book in books) {
      book.Display();
    }
  }

  public void AddBook(Book book) {
    book.AuthorInfo.FirstName = base.FirstName;
    book.AuthorInfo.LastName = base.LastName;

    this.books.Add(book);
  }

  public void RemoveBook(Book book) {
    Book removedBook = books.Find(b => b.ISBN == book.ISBN);
    books.Remove(removedBook);
  }

}