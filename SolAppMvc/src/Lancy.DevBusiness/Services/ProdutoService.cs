using Lancy.Dev.Business.Interfaces;
using Lancy.Dev.Business.Models;
using Lancy.Dev.Business.Models.Validations.Documentos;
using System;
using System.Threading.Tasks;

namespace Lancy.Dev.Business.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        public async Task Adicionar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;
        }

        public async Task Atualizar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
