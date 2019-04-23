using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCrudWinForms.Model.Interfaces
{
    public interface IProdutosDAO
    {
        void InserirRegistro(string descricao,int data_insercao);
        List<Produtos> BuscaProdutos { get; }
        void DeletaRegistro(int id);
        void AtualizaRegistro(int id, string descricao);
    }
}
