using PointStore.Domain.Enum;

namespace PointStore.Domain.Entity
{
    public class Usuario : UsuarioCognito
    {
        /// <summary>
        /// Nome do usuário
        /// </summary>
        public string? Nome { get; set; }       

        /// <summary>
        /// Id da Empresa que o usuário pertence 
        /// </summary>
        public int EmpresaId { get; set; }
    }
}
