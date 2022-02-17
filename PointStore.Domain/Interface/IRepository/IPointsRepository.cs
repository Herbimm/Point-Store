using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointStore.Domain.Interface.IRepository
{
    public interface IPointsRepository
    {
        Task<decimal> ConsultarPontosAsync(string userName);
    }
}
