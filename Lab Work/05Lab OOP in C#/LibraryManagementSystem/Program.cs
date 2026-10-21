using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem
{
   
    class Book
    {
        public string Title;
        public string Author;
        public string ISBN;
        public bool IsAvailable;

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsAvailable = true; 
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}, " +
                              $"Status: {(IsAvailable ? "Available" : "Borrowed")}");
        }
    }

    class Member
    {
        public int MemberID;
        public string Name;
        public int MaxBooks;

        private readonly List<Book> borrowedBooks = new List<Book>();
        public IReadOnlyList<Book> BorrowedBooks => borrowedBooks;

        public Member(int memberId, string name, int maxBooks = 5)
        {
            MemberID = memberId;
            Name = name;
            MaxBooks = maxBooks; 
        }

        public bool CanBorrow() => borrowedBooks.Count < MaxBooks;
        public bool HasBorrowed(Book book) => borrowedBooks.Contains(book);
        public void AddBorrowedBook(Book book) => borrowedBooks.Add(book);
        public void RemoveBorrowedBook(Book book) => borrowedBooks.Remove(book);

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {MemberID}, Name: {Name}, Max Books: {MaxBooks}, " +
                              $"Borrowed: {borrowedBooks.Count}" +
                              (borrowedBooks.Count > 0
                                  ? $" ({string.Join(", ", borrowedBooks.Select(b => b.Title))})"
                                  : ""));
        }
    }

    class Student : Member
    {
        public Student(int memberId, string name) : base(memberId, name, 3) { }

        public override void DisplayInfo()
        {
            Console.Write("[Student] ");
            base.DisplayInfo();
        }
    }

    class Faculty : Member
    {
        public Faculty(int memberId, string name) : base(memberId, name, 10) { }

        public override void DisplayInfo()
        {
            Console.Write("[Faculty] ");
            base.DisplayInfo();
        }
    }


    class Library
    {
        private readonly List<Book> books = new List<Book>();
        private readonly List<Member> members = new List<Member>();

        public IReadOnlyList<Book> Books => books;
        public IReadOnlyList<Member> Members => members;

        public void AddBook(Book book)
        {
            if (books.Any(b => b.ISBN == book.ISBN))
            {
                Console.WriteLine($"Error: A book with ISBN {book.ISBN} already exists.");
                return;
            }
            books.Add(book);
            Console.WriteLine($"Book added: {book.Title}");
        }

        public void AddMember(Member member)
        {
            if (members.Any(m => m.MemberID == member.MemberID))
            {
                Console.WriteLine($"Error: A member with ID {member.MemberID} already exists.");
                return;
            }
            members.Add(member);
            Console.WriteLine($"Member added: {member.Name}");
        }

        public void BorrowBook(string isbn, int memberId)
        {
            Book book = books.FirstOrDefault(b => b.ISBN == isbn);
            Member member = members.FirstOrDefault(m => m.MemberID == memberId);

            if (book == null) { Console.WriteLine($"Error: No book with ISBN {isbn}."); return; }
            if (member == null) { Console.WriteLine($"Error: No member with ID {memberId}."); return; }

            if (!book.IsAvailable)
            {
                Console.WriteLine($"Error: \"{book.Title}\" is currently unavailable.");
                return;
            }
            if (!member.CanBorrow())
            {
                Console.WriteLine($"Error: {member.Name} has reached the limit of {member.MaxBooks} books.");
                return;
            }

            book.IsAvailable = false;
            member.AddBorrowedBook(book);
            Console.WriteLine($"{member.Name} borrowed \"{book.Title}\".");
        }

        public void ReturnBook(string isbn, int memberId)
        {
            Book book = books.FirstOrDefault(b => b.ISBN == isbn);
            Member member = members.FirstOrDefault(m => m.MemberID == memberId);

            if (book == null) { Console.WriteLine($"Error: No book with ISBN {isbn}."); return; }
            if (member == null) { Console.WriteLine($"Error: No member with ID {memberId}."); return; }

            if (!member.HasBorrowed(book))
            {
                Console.WriteLine($"Error: {member.Name} has not borrowed \"{book.Title}\".");
                return;
            }

            member.RemoveBorrowedBook(book);
            book.IsAvailable = true;
            Console.WriteLine($"{member.Name} returned \"{book.Title}\".");
        }

        public void DisplayStatus()
        {
            Console.WriteLine("\n===== BOOKS =====");
            foreach (Book b in books) b.DisplayInfo();

            Console.WriteLine("\n===== MEMBERS =====");
            foreach (Member m in members) m.DisplayInfo(); 
        }
    }

    internal class Program
    {
        // Method ask member about ID and book ISBN
        static void BorrowBookFromUser(Library library)
        {
            Console.WriteLine("\n--- Borrow a Book ---");
            Console.Write("Enter book ISBN: ");
            string isbn = (Console.ReadLine() ?? "").Trim();

            int memberId = ReadMemberId();
            if (memberId == -1) return;

            library.BorrowBook(isbn, memberId);
        }

       // ask user input about returning a book
        static void ReturnBookFromUser(Library library)
        {
            Console.WriteLine("\n--- Return a Book ---");
            Console.Write("Enter book ISBN: ");
            string isbn = (Console.ReadLine() ?? "").Trim();

            int memberId = ReadMemberId();
            if (memberId == -1) return;

            library.ReturnBook(isbn, memberId);
        }

        
        static int ReadMemberId()
        {
            Console.Write("Enter Member ID: ");
            if (int.TryParse(Console.ReadLine(), out int memberId))
                return memberId;

            Console.WriteLine("Error: Member ID must be a number.");
            return -1;
        }

        static void Main(string[] args)
        {
            Library library = new Library();
            // i will add the books and members hardcoded
            //and will ask for user input when borrowing or returning a book

            library.AddBook(new Book("Peshawar: Historic City of the Frontier", "Ahmad Hasan Dani", "1001"));
            library.AddBook(new Book("The Pathans", "Olaf Caroe", "1002"));
            library.AddBook(new Book("The Kite Runner", "Khaled Hosseini", "1003"));
            library.AddBook(new Book("A Thousand Splendid Suns", "Khaled Hosseini", "1004"));
            library.AddBook(new Book("The Bookseller of Kabul", "Asne Seierstad", "1005"));
            library.AddBook(new Book("The Places in Between", "Rory Stewart", "1006"));



            library.AddMember(new Student(1, "Hamza Yousafzai"));
            library.AddMember(new Faculty(2, "Dr. Ihsan Afridi"));
            library.AddMember(new Student(3, "Farzana Rahimi"));
            library.AddMember(new Faculty(4, "Prof. Abdul Wahid Noori"));
            library.AddMember(new Student(1, "Duplicate Hamza"));

            library.DisplayStatus();

            //  a repeatitive menu for users
            bool running = true;
            while (running)
            {
                Console.WriteLine("\n===== LIBRARY MENU =====");
                Console.WriteLine("1. Borrow a book");
                Console.WriteLine("2. Return a book");
                Console.WriteLine("3. Display status");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");

                switch (Console.ReadLine())
                {
                    case "1": BorrowBookFromUser(library); break;
                    case "2": ReturnBookFromUser(library); break;
                    case "3": library.DisplayStatus(); break;
                    case "0": running = false; break;
                    default: Console.WriteLine("Invalid option. Please try again."); break;
                }
            }
        }
    }
}