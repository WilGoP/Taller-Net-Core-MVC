using Sol.TallerNetCoreMVC.Service.Objects.Entities;
using System.Collections.Generic;

namespace Sol.TallerNetCoreMVC.Service.Domain.Perfil
{
    public interface IPerfilService
    {
        List<tb_PerfilEntity> Listar();
        tb_PerfilEntity Recuperar(int IdPerfil);
        tb_PerfilEntity Insertar(tb_PerfilEntity tb_Perfil);
        tb_PerfilEntity Actualizar(tb_PerfilEntity tb_Perfil);
        bool Eliminar(int IdPerfil);
    }
}
