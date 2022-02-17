using PointStore.Domain.Entity.Cadastro;
using PointStore.Domain.Interface.IRepository;
using PointStore.Domain.Interface.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointStore.Service.Service
{
    public class CadastroService : ICadastroService
    {
        private readonly ICadastroRepository _cadastroRepository;

        public CadastroService(ICadastroRepository cadastroRepository)
        {
            _cadastroRepository = cadastroRepository;
        }
        public async Task<DadosUsuario> VerificarSeExisteCadastro(string userName)
        {
            var verificarUsuario = await _cadastroRepository.VerificarSeExisteCadastro(userName);
            return verificarUsuario;
        }
    }
}
