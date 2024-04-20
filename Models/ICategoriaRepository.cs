using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface ICategoriaRepository
    {
        void Add(CategoriaModel categoriaModel);
        void Edit(CategoriaModel categoriaModel);
        void Delete(int id);
        IEnumerable<CategoriaModel> GetAll();
        IEnumerable<CategoriaModel> GetByValue(string value);
    }
}
