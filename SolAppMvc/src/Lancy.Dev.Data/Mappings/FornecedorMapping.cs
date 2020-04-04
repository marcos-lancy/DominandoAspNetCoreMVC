using Lancy.Dev.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lancy.Dev.Data.Mappings
{
    public class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
    {
        //A classe que possui as filhas é que recebe o mapeamento/a configuração
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(f => f.Id);

            builder.Property(f => f.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(f => f.Documento)
                .IsRequired()
                .HasColumnType("varchar(14)");

            //1 para 1 = > Fornecedor para Endereco
            builder.HasOne(f => f.Endereco) //=> Fornecedor tem um Endereço
                .WithOne(e => e.Fornecedor);//=> Endereço tem um Fornecedor

            //1 para N = > Fornecedor N Produtos
            builder.HasMany(f => f.Produtos)        //=> Fornecedor tem N Produtos
                .WithOne(p => p.Fornecedor)         //=> Produto tem 1 Fornecedor
                .HasForeignKey(p => p.FornecedorId);//=> Produto tem a Chave FK do Fornecedor

            builder.ToTable("Fornecedores");
        }
    }
}
