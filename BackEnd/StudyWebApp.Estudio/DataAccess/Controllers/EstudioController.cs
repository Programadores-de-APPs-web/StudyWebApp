using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudyWebApp.Estudio.DataAccess.Configuracion;

namespace StudyWebApp.Estudio.DataAccess.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class EstudioController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IUnidadDeTrabajo _UnidadDeTrabajoRepository;

        public EstudioController(IConfiguration configuration, IUnidadDeTrabajo unidadDeTrabajoRepository)
        {
            _configuration = configuration;
            _UnidadDeTrabajoRepository = unidadDeTrabajoRepository;
        }
    }
}
