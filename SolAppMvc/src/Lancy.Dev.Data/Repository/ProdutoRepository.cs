using Lancy.Dev.Business.Interfaces;
using Lancy.Dev.Business.Models;
using Lancy.Dev.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lancy.Dev.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {

        public ProdutoRepository(MeuDbContext context) : base(context) { }

        public async Task<Produto> ObterprodutoFornecedor(Guid id)
        {
            return await Db.Produtos.AsNoTracking()
                .Include(f => f.Fornecedor)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Produto>> ObterProdutoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Produtos.AsNoTracking()
                .Include(f => f.Fornecedor)
                .OrderBy(p => p.Nome).ToListAsync();
                
        }

        public async Task<IEnumerable<Produto>> ObterProdutosFornecedores(Guid fornecedorId)
        {
            return await Buscar(p => p.FornecedorId == fornecedorId);
        }
    }
}
