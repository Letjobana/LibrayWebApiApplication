using LibraryManagementApp.Models;
using LibraryManagementApp.Repository.Abstracts;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementApp.Repository.Concretes
{
    public class AuthorRepository : IAuthourRepository
    {
        private readonly BookStoreDBContext context;

        public AuthorRepository(BookStoreDBContext context)
        {
            this.context = context;
        }
        public Author Author(Author author)
        {
            var addAuthour = context.Authors.Add(author);
            return addAuthour.Entity;
        }

        public void DeleteAuthor(int Id)
        {
            var deleteAuthor = context.Authors.FirstOrDefault(x => x.AuthorId == Id);
            if (deleteAuthor != null)
            {
                context.Remove(deleteAuthor);
                context.SaveChanges();
            }
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            return context.Authors.ToList();
        }

        public Author GetAuthorById(int id)
        {
            return context.Authors.Find(id);
        }

        public void Update(Author author)
        {
            var updateAuthor = context.Authors.FirstOrDefault(x => x.AuthorId == author.AuthorId);
            if (updateAuthor != null)
            {
                updateAuthor.LastName = author.LastName;
                updateAuthor.FirstName = author.FirstName;
                updateAuthor.Phone = author.Phone;
                updateAuthor.Address = author.Address;
                updateAuthor.City = author.City;
                updateAuthor.State = author.State;
                updateAuthor.Zip = author.Zip;
                updateAuthor.EmailAddress = author.EmailAddress;
                context.SaveChanges();
            }
        }
    }
}
