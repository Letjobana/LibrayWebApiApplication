using LibraryManagementApp.Models;
using LibraryManagementApp.Repository.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementApp.Repository.Concretes
{
    public class PublisherRepository : IPublisherRepository
    {
        private readonly BookStoreDBContext context;

        public PublisherRepository(BookStoreDBContext context)
        {
            this.context = context;
        }
        public Publisher AddPublisher(Publisher publisher, Book book)
        {

            var addNewPublisher = new Publisher
            {
                PublisherName = publisher.PublisherName,
                City = publisher.City,
                State = publisher.State,
                Country = publisher.State

            };
            var addBook = new Book
            {
                Title = book.Title,
                Type = book.Type,
                Price = book.Price,
                Advance = book.Advance,
                Royalty = book.Royalty,
                YtdSales = book.YtdSales,
                Notes = book.Notes,
                PublishedDate = book.PublishedDate,
                Pub = book.Pub
            };

            publisher.Books.Add(addBook);
            var newPlubisher = context.Publishers.Add(publisher);
            context.SaveChanges();
            return newPlubisher.Entity;
        }

        public void DeletePublisher(int Id)
        {
            var deletePublisher = context.Publishers.FirstOrDefault(x => x.PubId == Id);
            if (deletePublisher != null)
            {
                context.Publishers.Remove(deletePublisher);
                context.SaveChanges();
            }
        }

        public IEnumerable<Publisher> GetAllPublishers()
        {
            return context.Publishers.ToList();
        }

        public Publisher GetPublisherById(int Id)
        {
            return context.Publishers.
                            Include(x => x.Books).ThenInclude(x => x.Sales).
                            Include(x => x.Users).
                            Where(x => x.PubId == Id).
                            FirstOrDefault();
        }

        public void UpdatePublisher(Publisher publisher)
        {
            var updatePublisher = context.Publishers.FirstOrDefault(x => x.PubId == publisher.PubId);
            if (updatePublisher != null)
            {

            }
        }
    }
}
