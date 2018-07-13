using Projeto_Pizzaria.Dominio.Base;
using Projeto_Pizzaria.Dominio.Features.Pedidos;
using Projeto_Pizzaria.Dominio.Features.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Aplicacao.Features.Produtos
{
    public class ProdutoService : IService<Produto>
    {
        IProdutoRepository _ProdutoRepository;
        public ProdutoService(IProdutoRepository ProdutoRepository)
        {
            _ProdutoRepository = ProdutoRepository;
        }
        public Produto Add(Produto cliente)
        {
            cliente.Validar();
            return _ProdutoRepository.Add(cliente);
        }

        public void delete(Produto cliente)
        {
            _ProdutoRepository.Delete(cliente);
        }

        public List<Produto> GetAll()
        {
            return _ProdutoRepository.GetAll();
        }
        public List<Produto> GetAllAdicional()
        {
            return _ProdutoRepository.GetAllAdicional();
        }
        public List<Produto> GetAllBebida()
        {
            return _ProdutoRepository.GetAllBebida();
        }
        public List<Produto> GetAllCalzone()
        {
            return _ProdutoRepository.GetAllCalzone();
        }
        public List<Produto> GetAllPizza()
        {
            return _ProdutoRepository.GetAllPizza();
        }

        public Produto GetById(int id)
        {
            return _ProdutoRepository.GetById(id);
        }

        public void Update(Produto cliente)
        {
            cliente.Validar();
            _ProdutoRepository.Update(cliente);
        }
      
    }
}
