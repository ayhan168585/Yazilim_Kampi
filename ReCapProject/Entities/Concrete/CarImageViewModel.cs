using System;
using Core.Entities;
using Microsoft.AspNetCore.Http;

namespace Entities.Concrete
{
    public class CarImageViewModel : IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public IFormFile ImagePicture { get; set; }
        public DateTime Date { get; set; }
    }
}