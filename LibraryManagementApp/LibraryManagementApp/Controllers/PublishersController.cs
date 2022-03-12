using LibraryManagementApp.Models;
using LibraryManagementApp.Repository.Abstracts;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LibraryManagementApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private readonly IPublisherRepository publisherRepository;

        public PublishersController(IPublisherRepository publisherRepository)
        {
            this.publisherRepository = publisherRepository;
        }
        [HttpGet]
        public Publisher GetPublisherDetails(int Id)
        {
            try
            {
                return publisherRepository.GetPublisherById(Id);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
