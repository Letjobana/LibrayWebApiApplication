using LibraryManagementApp.Models;
using System.Collections.Generic;

namespace LibraryManagementApp.Repository.Abstracts
{
    public interface IPublisherRepository
    {
        IEnumerable<Publisher> GetAllPublishers();
        Publisher GetPublisherById(int Id);
        Publisher AddPublisher(Publisher publisher, Book book);
        void DeletePublisher(int Id);
        void UpdatePublisher(Publisher publisher);

    }
}
