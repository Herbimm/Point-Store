using PointStore.Domain.Entity;
using PointStore.Domain.Interface.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointStore.Repository.Repository
{
    public class CadastroRepository : ICadastroRepository
    {
        public Task<DadosUsuario> VerificarSeExisteCadastro(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
