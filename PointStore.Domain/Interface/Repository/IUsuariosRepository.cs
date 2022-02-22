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
        /// Verifica se o usuário atravez do seu id Cognito já possui cadastro no banco de dados.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna os dados do usuário</returns>
        Task<Usuario> LocalizarUsuarioPorIdAsync(Guid id);
    }
}
