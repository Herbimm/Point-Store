using PointStore.Domain.Entity;
using PointStore.Domain.Enum;
using PointStore.Domain.Interface.IService;
using PointStore.Domain.Interface.Repository;

namespace PointStore.Service.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuariosRepository _usuarioRepository;

        public UsuarioService(IUsuariosRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }       
        public async Task<Usuario> ValidarUsuarioAsync(Guid id)
        {
            var verificaSeJaExiste = await _usuarioRepository.ValidarUsuarioAsync(id);                      
            return verificaSeJaExiste;            
        }        
    }
}
