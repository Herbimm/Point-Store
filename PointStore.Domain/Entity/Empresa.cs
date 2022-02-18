namespace PointStore.Domain.Entity
{
    public  class Empresa
    {
        /// <summary>
        /// Id da empresa
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Cnpj da empresa
        /// </summary>
        public string? Cnpj { get; set; }

        /// <summary>
        /// Nome da empresa
        /// </summary>
        public string? Nome { get; set; }
    }
}
