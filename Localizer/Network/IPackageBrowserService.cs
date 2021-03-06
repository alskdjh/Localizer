using System.Collections.Generic;
using Localizer.DataModel;

namespace Localizer.Network
{
    public interface IPackageBrowserService
    {
        ICollection<IPackage> GetList();

        int GetPageCount();

        ICollection<IPackage> GetListByPage(int i);

        string GetDownloadLinkOf(IPackage package);
    }
}
