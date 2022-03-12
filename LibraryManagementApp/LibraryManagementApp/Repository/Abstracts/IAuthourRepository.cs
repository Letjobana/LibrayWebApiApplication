using LibraryManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementApp.Repository.Abstracts
{
    public interface IAuthourRepository
    {
        IEnumerable<Author> GetAllAuthors();
        Author GetAuthorById(int id);
        Author Author(Author author);
        void DeleteAuthor(int Id);
        void Update(Author author);
    }
}
