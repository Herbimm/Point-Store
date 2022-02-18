namespace PointStore.Domain.Entity
{
    public class Campanha
    {
        /// <summary>
        /// Id da campanha
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome campanha
        /// </summary>
        public string? Nome { get; set; }

        /// <summary>
        /// Data e hora do Cadastro da campanha
        /// </summary>
        public DateTime DataCadastro { get; set; }

        /// <summary>
        /// Data do Termínimo da campanha
        /// </summary>
        public DateTime DataTermino { get; set; }

        /// <summary>
        /// Usuario digitador da campanha
        /// </summary>
        public int UsuarioDigitador { get; set; }

        /// <summary>
        /// Id da empresa da campanha
        /// </summary>
        public int EmpresaId { get; set; }
    }
}
