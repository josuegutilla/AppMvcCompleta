using GutillaDev.Business.Interfaces;
using GutillaDev.Business.Models;
using GutillaDev.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace GutillaDev.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(MeuDbContext db) : base(db)
        {
        }

        public Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            return Db.Fornecedores.AsNoTracking()
                .Include(f => f.Endereco)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        {
            return Db.Fornecedores.AsNoTracking()
                .Include(f=>f.Produtos)
                .Include(f=>f.Endereco)
                .FirstOrDefaultAsync(f=>f.Id == id);
        }
    }
}
