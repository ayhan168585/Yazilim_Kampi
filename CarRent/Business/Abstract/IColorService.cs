using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll(Expression<Func<Color, bool>> filter = null);
        Color Get(int id);
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
    }
}
