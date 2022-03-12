using LibraryManagementApp.Models;
using LibraryManagementApp.Repository.Abstracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LibraryManagementApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthourRepository authourRepository;

        public AuthorsController(IAuthourRepository authourRepository)
        {
            this.authourRepository = authourRepository;
        }
        [HttpGet]
        public IEnumerable<Author> GetAuthors()
        {
            try
            {
                return authourRepository.GetAllAuthors();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
