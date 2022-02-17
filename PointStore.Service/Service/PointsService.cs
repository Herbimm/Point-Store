using PointStore.Domain.Interface.IRepository;
using PointStore.Domain.Interface.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointStore.Service.Service
{
    public class PointsService : IPointsService
    {
        private readonly IPointsRepository _pointsRepository;

        public PointsService(IPointsRepository pointsRepository)
        {
            _pointsRepository = pointsRepository;
        }
        public Task<decimal> ConsultarPontosAsync(string userName)
        {
            var obterPontosUsuario = _pointsRepository.ConsultarPontosAsync(userName);
            return obterPontosUsuario;
        }
    }
}
