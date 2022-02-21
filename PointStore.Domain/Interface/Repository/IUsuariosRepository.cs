using PointStore.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointStore.Domain.Interface.Repository
{
    public interface IUsuariosRepository
    {
        /// <summary>
        /// Validação do usuário Cognito => Banco de Dados
        /// </summary>
        /// <param name="userName"></param>
        /// <returns>Retorna usuário cadastrado no Banco de dados</returns>
        Task<Usuario> ValidarUsuarioAsync(string userName);

        /// <summary>
        /// Insere no banco de dados o usuário validado com os parametros do Cognito
        /// </summary>
        /// <param name="novoUsuario"></param>        
        Task InserirUsuarioAsync(Usuario novoUsuario);
    }
}
