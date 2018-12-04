using System;

using ODataTestApp.DomainCommon.Models;
using ODataTestApp.DomainCommon.Repositories;

namespace ODataTestApp.DomainCommon
{
    public interface IUnitOfWork: IDisposable
    {
        IBaseRepository<BaseModel> Repository { get; set; }

        void Save();
    }
}