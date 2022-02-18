using PointStore.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointStore.Domain.Interface.IRepository
{
    public interface ICadastroRepository
    {
        Task<DadosUsuario> VerificarSeExisteCadastro(string userName);
    }
}
