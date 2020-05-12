using System.Collections.Generic;

namespace ApiGateway.Core.Contracts.Exposers
{
    public interface IExposerManager
    {
        IList<ExposerDto> GetAll();
        ExposerDto GetExposerById(ExposerIdDto dto);
        void Insert(InsertExposerDto dto);
        void UpdateExposer(ExposerDto dto);
        void DeleteExposer(ExposerIdDto dto);
        ExposerResultDto ExecuteExposer(ExecuteExposerDto dto);
    }
}