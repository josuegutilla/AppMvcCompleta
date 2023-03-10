using GutillaDev.Business.Interfaces;
using GutillaDev.Business.Models;
using GutillaDev.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace GutillaDev.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext db) : base(db)
        {
        }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(f=>f.FornecedorId == fornecedorId);
        }
    }
}
