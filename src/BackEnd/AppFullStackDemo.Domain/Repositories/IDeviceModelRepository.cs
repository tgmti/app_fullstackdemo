using System;
using System.Collections.Generic;
using AppFullStackDemo.Domain.Commands.DeviceModel;
using AppFullStackDemo.Domain.Entities;

namespace AppFullStackDemo.Domain.Repositories
{
    public interface IDeviceModelRepository
    {
        void Create(DeviceModel deviceModel);
        void Update(DeviceModel deviceModel);
        GetDeviceModelResult GetDeviceModel(Guid id);
        IEnumerable<GetDeviceModelResult> GetDeviceModels();
        DeviceModel GetById(Guid id);
    }
}