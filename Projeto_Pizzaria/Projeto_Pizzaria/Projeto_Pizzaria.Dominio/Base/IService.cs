using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Dominio.Base
{
    public interface IService<T> where T : Entidade
    {
        T Add(T Object);
        void delete(T Object);
        void Update(T Object);
        T GetById(int Id);
        List<T> GetAll();
    }
}
