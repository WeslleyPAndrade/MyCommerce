using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeslleyAndrade.Business.Core.Data;

namespace WeslleyAndrade.Business.Models.Fornecedores
{
    public interface IFornecedorRepository: IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFornecedorEndereco(Guid id);
        Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id);
    }
}
