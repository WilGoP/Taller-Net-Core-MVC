using Sol.TallerNetCoreMVC.Service.Objects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sol.TallerNetCoreMVC.Service.Domain.Perfil
{
    public class PerfilServiceMemoria : IPerfilService
    {
        List<tb_PerfilEntity> _lista = new List<tb_PerfilEntity>();

        public PerfilServiceMemoria()
        {
            _lista.Add(new tb_PerfilEntity() { IdPerfil = 1, Nombre = "SUPER ADMINISTRADOR" });
            _lista.Add(new tb_PerfilEntity() { IdPerfil = 2, Nombre = "ADMINISTRADOR" });
            _lista.Add(new tb_PerfilEntity() { IdPerfil = 3, Nombre = "AUDITOR" });
            _lista.Add(new tb_PerfilEntity() { IdPerfil = 4, Nombre = "OPERADOR" });
            _lista.Add(new tb_PerfilEntity() { IdPerfil = 5, Nombre = "SOPORTE" });
        }

        public tb_PerfilEntity Actualizar(tb_PerfilEntity tb_Perfil)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(int IdPerfil)
        {
            throw new NotImplementedException();
        }

        public tb_PerfilEntity Insertar(tb_PerfilEntity tb_Perfil)
        {
            throw new NotImplementedException();
        }

        public List<tb_PerfilEntity> Listar()
        {
            return _lista;
        }

        public tb_PerfilEntity Recuperar(int IdPerfil)
        {
            //Forma 01:
            tb_PerfilEntity perfilEntity;

            //foreach (var item in _lista)
            //{
            //    if (item.IdPerfil == IdPerfil)
            //    {
            //        perfilEntity = item;
            //    }
            //}

            //Forma 02: Linq to Entities
            //perfilEntity = (from x in _lista where x.IdPerfil == IdPerfil select x).FirstOrDefault();

            //Forma 03: Lambda expressions
            perfilEntity = _lista.FirstOrDefault(x => x.IdPerfil == IdPerfil);
            //perfilEntity = _lista.Where(x => x.IdPerfil == IdPerfil).FirstOrDefault();

            return perfilEntity;
        }
    }
}
