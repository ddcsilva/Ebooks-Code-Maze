using FuncionariosCompanhia.Contracts;

namespace FuncionariosCompanhia.Contracts
{
    public interface IRepositoryManager
    {
        ICompanhiaRepository Companhia { get; }
        IFuncionarioRepository Funcionario { get; }
        void Salvar();
    }
}
