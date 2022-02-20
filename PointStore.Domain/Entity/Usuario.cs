using PointStore.Domain.Enum;

namespace PointStore.Domain.Entity
{
    public class Usuario
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
        /// Nome do usuário
        /// </summary>
        public string? Nome { get; set; }

        /// <summary>
        /// Tipo de usuário
        /// 1 - Membro
        /// 2 - Gerente
        /// 3 - Administrador
        /// </summary>
        public TipoUsuario TipoUsuario { get; set; }

        /// <summary>
        /// Id da Empresa que o usuário pertence 
        /// </summary>
        public int EmpresaId { get; set; }
    }
}
