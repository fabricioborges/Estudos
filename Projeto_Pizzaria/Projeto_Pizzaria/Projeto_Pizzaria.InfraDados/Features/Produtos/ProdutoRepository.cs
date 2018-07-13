using Projeto_Pizzaria.Dominio.Features.Produtos;
using Projeto_Pizzaria.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.InfraDados.Features.Produtos
{
    public class ProdutoRepository : IProdutoRepository
    {
        PizzariaContext _context;

        public ProdutoRepository(PizzariaContext context)
        {
            _context = context;
        }

        public Produto Add(Produto entity)
        {
            _context.Produto.Add(entity);
            _context.SaveChanges();

            return entity;
        }

        public void Delete(Produto entity)
        {
            DbEntityEntry dbEntityEntry = _context.Entry(entity);

            if (dbEntityEntry.State == EntityState.Detached)
            {
                _context.Produto.Attach(entity);
            }

            _context.Produto.Remove(entity);

            _context.SaveChanges();
        }

        public List<Produto> GetAll()
        {
            return _context.Produto.ToList();
        }
        public List<Produto> GetAllPizza()
        {
            return _context.Produto.Where(p => p.TipoDoProduto == ProdutoEnum.Pizza).ToList();
        }
        public List<Produto> GetAllBebida()
        {
            return _context.Produto.Where(p => p.TipoDoProduto == ProdutoEnum.Bebida).ToList();
        }
        public List<Produto> GetAllAdicional()
        {
            return _context.Produto.Where(p => p.TipoDoProduto == ProdutoEnum.Adicional).ToList();
        }
        public List<Produto> GetAllCalzone()
        {
            return _context.Produto.Where(p => p.TipoDoProduto == ProdutoEnum.Calzone).ToList();
        }
        public Produto GetById(int Id)
        {
            return _context.Produto.Find(Id);
        }

        public void Update(Produto entity)
        {
            DbEntityEntry dbEntityEntry = _context.Entry(entity);

            if (dbEntityEntry.State == EntityState.Detached)
            {
                _context.Produto.Attach(entity);
            }

            _context.SaveChanges();
        }
    }
}
