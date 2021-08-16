using System;
using System.Threading.Tasks;
using Dev.Business.Models;

namespace Dev.Business.Interfaces
{
    public interface IFornecedorService
    {
        Task Adicionar(Fornecedor fornecedor);
        Task Atualizar(Fornecedor fornecedor);
        Task Adicionar(Guid id);
        Task AtualizarEndereco(Endereco endereco);
    }
}