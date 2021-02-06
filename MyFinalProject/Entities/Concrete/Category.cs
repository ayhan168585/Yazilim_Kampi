using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    //Çıplak class kalmasın
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
