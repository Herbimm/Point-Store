using PointStore.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointStore.Domain.Entity
{
    public class UsuarioCognito
    {
        /// <summary>
        /// Id do usuário
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Login do usuário
        /// </summary>
        public string? Login { get; set; }

        /// <summary>
        /// Tipo de usuário
        /// 1 - Membro
        /// 2 - Gerente
        /// 3 - Administrador
        /// </summary>
        public TipoUsuario TipoUsuario { get; set; }
    }
}
