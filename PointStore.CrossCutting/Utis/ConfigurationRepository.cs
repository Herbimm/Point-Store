using System.ComponentModel.DataAnnotations;

namespace PointStore.CrossCutting.Utis
{
    public class ConfigurationRepository
    {
        [Required]
        public string? ConnectionString { get; set; }
    }
}
