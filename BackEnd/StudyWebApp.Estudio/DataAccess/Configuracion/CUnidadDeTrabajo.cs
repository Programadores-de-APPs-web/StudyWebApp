using Microsoft.AspNetCore.Mvc.ViewFeatures;
using StudyWebApp.Estudio.DataAccess.Configuracion.Context;
using StudyWebApp.Estudio.DataAccess.Interfaces;
using StudyWebApp.Estudio.DataAccess.Repositorios;

namespace StudyWebApp.Estudio.DataAccess.Configuracion
{
    public class CUnidadDeTrabajo : IUnidadDeTrabajo
    {
        private EstudioContext _context = new EstudioContext();
        private readonly IConfiguration _configuration;
        private readonly IEstudioRepository _RepositoryEstudio;
        public CUnidadDeTrabajo(EstudioContext context, IConfiguration configuration)
        {
            if (context == null)
            {
                throw new ArgumentNullException("Context argument cannot be null in UnitOfWork.");
            }
            _context = context;
            _configuration = configuration; 
        }

        public IEstudioRepository RepositoryEstudio => _RepositoryEstudio ?? new CEstudioRepository(_context, _configuration);

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
