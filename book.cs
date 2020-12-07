using System;

class Book {
  public string ISBN { get; set; }
  public string Title { get; set; }
  public Author AuthorInfo { get; set; }
  public DateTime PublishedOn { get; set; }
  public string PublishedBy { get; set; }

  public Book(string ISBN, string Title, Author AuthorInfo) {
    this.ISBN = ISBN;
    this.Title = Title;
    this.AuthorInfo = AuthorInfo;

    this.PublishedOn = DateTime.Today;
    this.PublishedBy = "Unknown";
  }

  public Book(string ISBN, string Title, Author AuthorInfo, DateTime PublishedOn, string PublishedBy) : this(ISBN, Title, AuthorInfo) {
    this.PublishedOn = PublishedOn;
    this.PublishedBy = PublishedBy;
  }

  public void Display() {
    Console.WriteLine("Book '" + Title + "' was written by " + AuthorInfo.FirstName + " " + AuthorInfo.LastName + "and published on " + PublishedOn);
  }
}