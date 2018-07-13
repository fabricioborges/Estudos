using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Dominio.Base
{
    public interface IRepository<T> where T : Entidade
    {
        T Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetById(int Id);
        List<T> GetAll();
    }
}
