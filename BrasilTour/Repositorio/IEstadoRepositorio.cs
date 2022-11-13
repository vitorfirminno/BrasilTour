using BrasilTour.Models;
using System.Collections.Generic;

namespace BrasilTour.Repositorio {
    public interface IEstadoRepositorio {

        List<EstadosModel> BuscarTodos();
        EstadosModel Adicionar(EstadosModel estados);
    }
}
