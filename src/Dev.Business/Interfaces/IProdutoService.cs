using System;
using System.Threading.Tasks;
using Dev.Business.Models;

namespace Dev.Business.Intefaces
{
    public interface IProdutoService
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}