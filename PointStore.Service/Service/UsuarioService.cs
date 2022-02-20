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
        public async Task<Usuario> ValidarUsuarioAsync(string userName , string guid, string grupoUsuarioCognito)
        {
            var verificaSeJaExiste = await _usuarioRepository.ValidarUsuarioAsync(userName);
            if (verificaSeJaExiste == null)
            {
                await CadastrarUsuarioAsync(userName, guid, grupoUsuarioCognito);
            }            
            return verificaSeJaExiste;            
        }
        public async Task CadastrarUsuarioAsync(string userName, string guid, string grupoUsuarioCognito)
        {
            Guid newGuid = Guid.Parse(guid); 
            TipoUsuario validaTipoUsuario = (TipoUsuario)Enum.Parse(typeof(TipoUsuario), grupoUsuarioCognito);
            Usuario novoUsuario = new Usuario
            {
                Login = userName,
                Id = newGuid,
                TipoUsuario = validaTipoUsuario,
            };
            await _usuarioRepository.CadastrarUsuarioAsync(novoUsuario);
        }
    }
}
