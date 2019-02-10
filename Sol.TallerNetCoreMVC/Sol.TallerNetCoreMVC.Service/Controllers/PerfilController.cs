using Microsoft.AspNetCore.Mvc;
using Sol.TallerNetCoreMVC.Service.Domain.Perfil;
using Sol.TallerNetCoreMVC.Service.Objects.Entities;
using System.Collections.Generic;

namespace Sol.TallerNetCoreMVC.Service.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PerfilController : ControllerBase
    {
        private IPerfilService _perfilService;

        public PerfilController(IPerfilService perfilService)
        {
            _perfilService = perfilService;
        }

        public List<tb_PerfilEntity> Listar()
        {
            return _perfilService.Listar();
        }
    }
}