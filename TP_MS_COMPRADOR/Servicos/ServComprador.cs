using DTO;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Servicos;
using TP_MS_COMPRADOR;

namespace Servicos
{
    public interface IServComprador
    {
        void Inserir(InserirCompradorDTO inserirCompradorDto);
        public void Cancelar(int id, Boolean CancelarComprador);
        List<EntidadeComprador> BuscarTodos();
    }

    public class ServComprador : IServComprador
    {
        private DataContext _dataContext;

        public ServComprador(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Inserir(InserirCompradorDTO inserirCompradorDto)
        {
            EntidadeComprador comprador = new EntidadeComprador()
            {
                Nome = inserirCompradorDto.Nome,
                CPF = inserirCompradorDto.CPF,
                Sexo = inserirCompradorDto.Sexo
            };

            _dataContext.Add(comprador);

            _dataContext.SaveChanges();
        }

        public void Cancelar(int id, Boolean CancelarComprador)
        {
            var compradorExistente = _dataContext.Comprador.FirstOrDefault(comprador => comprador.Id == id); 

            compradorExistente.Cancelado = CancelarComprador;

            _dataContext.Update(compradorExistente);

            _dataContext.SaveChanges();
        }

        public List<EntidadeComprador> BuscarTodos()
        {
            var comprador = _dataContext.Comprador.ToList();

            return comprador;
        }
    }
}
