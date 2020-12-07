using System;

class Rental {

  public Book Book;
  public DateTime DateRented;
  public DateTime DateDue;

  public Rental(Book book, DateTime dateRented, DateTime dateDue) {
    this.Book = book;
    this.DateRented = dateRented;
    this.DateDue = dateDue;
  }

}