using Microsoft.EntityFrameworkCore;
using PointStore.Domain.Entity;
using PointStore.Domain.Interface.Repository;
using PointStore.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointStore.Repository.Implementacao
{
    public class UsuarioRepository : IUsuariosRepository
    {
        private readonly MyContext _context;
        private DbSet<Usuario> _usuarioDb;

        public UsuarioRepository(MyContext context)
        {
            _context = context;
            _usuarioDb = context.Usuarios;
        }
        public async Task<Usuario> ValidarUsuarioAsync(Guid id)
        {
            var procuraUsuario = await _usuarioDb.FirstOrDefaultAsync(u => u.Id == id);
            return procuraUsuario;
        }        
    }
}
