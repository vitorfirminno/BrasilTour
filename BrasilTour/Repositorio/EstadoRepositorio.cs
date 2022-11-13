using BrasilTour.Data;
using BrasilTour.Models;
using System.Collections.Generic;
using System.Linq;

namespace BrasilTour.Repositorio {
    public class EstadoRepositorio : IEstadoRepositorio {

        private readonly BancoContext _bancoContext;
        public EstadoRepositorio(BancoContext bancoContext) {
            _bancoContext = bancoContext;
        }

        public List<EstadosModel> BuscarTodos(){
        return _bancoContext.Estados.ToList();
        }

        public EstadosModel Adicionar(EstadosModel estados) {
           //gravar no banco de dados
           
            _bancoContext.Estados.Add(estados);
            _bancoContext.SaveChanges();
            return estados;
        }
    }
}

