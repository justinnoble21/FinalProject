using System;
using System.Collections.Generic;

class Patron : Person {

  public string LibraryId { get; set; }
  public DateTime StartDate { get; set; }
  public DateTime EndDate { get; set; }
  public bool IsAccountActive { get; set; }
  public List<Rental> RentalCart = new List<Rental>();
  public int FineAmountDue { get; set; }

  public Patron (string fname, string lname, string id) : base (fname, lname) {
    this.LibraryId = id;

    this.FineAmountDue = 0;
    this.StartDate = DateTime.Today;
    this.IsAccountActive = true;
  }

  public void Display() {
    Console.WriteLine("ID: " + LibraryId);
    Console.WriteLine("Name: " + base.FirstName + " " + base.LastName);
  }

  public void AddToRentalCart(Book book, DateTime dueDate) {
    Rental rental = new Rental(book, DateTime.Today, dueDate);

    RentalCart.Add(rental);

    Console.WriteLine("Added to rental cart '" + book.Title + "' for Patron " + base.FirstName + " " + base.LastName);
  }

  public void RemoveFromRentalCart(Book book) {
    Rental removedRental = RentalCart.Find(b => b.Book == book);
    RentalCart.Remove(removedRental);

    Console.WriteLine("Removed from rental cart '" + removedRental.Book.Title + "' for Patron " + base.FirstName + " " + base.LastName);
  }

}