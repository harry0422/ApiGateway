using System.Collections.Generic;

namespace ApiGateway.Core.Contracts.Exposers
{
    public interface IExposerManager
    {
        IList<ExposerDto> GetAllExposers();
        ExposerDto GetExposerById(ExposerIdDto dto);
        void AddExposer(AddExposerDto dto);
        void UpdateExposer(ExposerDto dto);
        void DeleteExposer(ExposerIdDto dto);
        ExposerResultDto ExecuteExposer(ExecuteExposerDto dto);
    }
}