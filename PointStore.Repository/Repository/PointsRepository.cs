using PointStore.Domain.Interface.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointStore.Repository.Repository
{
    public class PointsRepository : IPointsRepository
    {
        public Task<decimal> ConsultarPontosAsync(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
