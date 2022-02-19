using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// Quantiade do Produto
        /// </summary>
        public int Quantidade { get; set; }
        /// <summary>
        /// Valor do Produto
        /// </summary>
        public decimal Valor { get; set; }
        /// <summary>
        /// Descrição do Produto
        /// </summary>
        public string Descricao { get; set; }
    }
}
