using ApiGateway.Core.Contracts.Exposers;
using ApiGateway.Core.Exposers.Mappers;
using ApiGateway.Core.Exposers.Model;
using ApiGateway.Core.Exposers.Repositories;
using ApiGateway.Core.RestServices.Executors;
using System.Collections.Generic;

namespace ApiGateway.Core.Exposers.Managers
{
    public class ExposerManager : IExposerManager
    {
        private readonly IExposerRepository _exposerRepository;
        private readonly IRestServiceExecutor _restServiceExecutor;

        public ExposerManager(IExposerRepository exposerRepository)
        {
            _exposerRepository = exposerRepository;
        }

        public IList<ExposerDto> GetAllExposers()
        {
            IList<Exposer> exposers = _exposerRepository.GetAll();
            return exposers.ToDto();
        }

        public ExposerDto GetExposerById(ExposerIdDto dto)
        {
            Exposer exposer = _exposerRepository.Get(dto.Id);
            return exposer.ToDto();
        }

        public void AddExposer(AddExposerDto dto)
        {
            Exposer exposer = new Exposer(dto.Name, dto.Path);
            _exposerRepository.Insert(exposer);
        }

        public void UpdateExposer(ExposerDto dto)
        {
            Exposer exposer = _exposerRepository.Get(dto.Id);
            exposer.Name = dto.Name;
            exposer.Path = dto.Path;

            _exposerRepository.Update(exposer);
        }

        public void DeleteExposer(ExposerIdDto dto)
        {
            _exposerRepository.Delete(dto.Id);
        }

        public ExposerResultDto ExecuteExposer(ExecuteExposerDto dto)
        {
            //Exposer exposer = _exposerRepository.GetByPath(dto.Path);

            //if (exposer.RestService == null) throw new System.Exception();
            throw new System.NotImplementedException();

        }
    }
}