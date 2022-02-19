namespace PointStore.Domain.Entity
{
    public class Produto
    {
        /// <summary>
        /// Id do Produto
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nome do Produto
        /// </summary>        
        public string Nome { get; set; }
        /// <summary>
        /// Quantidade do Produto
        /// </summary>
        public int Quantidade { get; set; }
        /// <summary>
        /// Valor do Produto
        /// </summary>
        public int Valor { get; set; }
        /// <summary>
        /// Descrição do Produto
        /// </summary>
        public string Descricao { get; set; }
        /// <summary>
        /// Id da empresa
        /// </summary>
        public int IdEmpresa  { get; set; }
    }
}
