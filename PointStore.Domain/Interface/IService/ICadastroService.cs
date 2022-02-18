using PointStore.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointStore.Domain.Interface.IService
{
    public interface ICadastroService
    {
        Task<DadosUsuario> VerificarSeExisteCadastro(string userName);
    }
}
