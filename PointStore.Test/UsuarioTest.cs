using PointStore.Domain.Entity;
using PointStore.Domain.Enum;
using System;
using Xunit;

namespace PointStore.Test
{
    public class UsuarioTest
    {
        [Fact]
        public void ValidacaoUsuario() 
        {            
            var userIdCognito = "d54bbb7d-21c9-46fb-bec0-213d5a43f9f6";
            var tipoUsuario = "Membro";
            TipoUsuario validaTipoUsuario = (TipoUsuario)Enum.Parse(typeof(TipoUsuario), tipoUsuario);
            Guid newGuid = Guid.Parse(userIdCognito);

            Assert.Equal(userIdCognito, newGuid.ToString()) ;
            Assert.Equal(validaTipoUsuario.ToString(), tipoUsuario) ;
        }

        [Fact]
        public void CadastrarUsuario()
        {
            var userName = "herbertzin";
            var userIdCognito = "d54bbb7d-21c9-46fb-bec0-213d5a43f9f6";
            var tipoUsuario = "Membro";
            TipoUsuario validaTipoUsuario = (TipoUsuario)Enum.Parse(typeof(TipoUsuario), tipoUsuario);
            Guid newGuid = Guid.Parse(userIdCognito);

            Usuario novoUsuario = new Usuario();
            novoUsuario.Login = userName;
            novoUsuario.Id = newGuid;
            novoUsuario.TipoUsuario = validaTipoUsuario;

            Assert.Equal(novoUsuario.Login, userName);
            Assert.Equal(novoUsuario.TipoUsuario.ToString(), tipoUsuario);
            Assert.Equal(novoUsuario.Id.ToString(), newGuid.ToString());

        }
    }
}
