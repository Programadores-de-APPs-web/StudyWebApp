using Microsoft.AspNetCore.Mvc.ViewFeatures;
using StudyWebApp.Estudio.DataAccess.Configuracion.Context;
using StudyWebApp.Estudio.DataAccess.Interfaces;

namespace StudyWebApp.Estudio.DataAccess.Repositorios
{
    public class CEstudioRepository : IEstudioRepository
    {
        private EstudioContext _context;
        private readonly IConfiguration _configuration;
        public CEstudioRepository(EstudioContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
    }
}
