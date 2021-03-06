using System.Collections.Generic;
using Localizer.DataModel;

namespace Localizer.Package
{
    public interface IPackageManageService
    {
        /// <summary>
        ///     All added packages sorted by mod.
        /// </summary>
        ICollection<IPackageGroup> PackageGroups { get; set; }

        /// <summary>
        ///     Add a package.
        /// </summary>
        /// <param name="package"></param>
        void AddPackage(IPackage package);

        /// <summary>
        ///     Remove a package.
        /// </summary>
        /// <param name="package"></param>
        void RemovePackage(IPackage package);

        /// <summary>
        ///     Load saved package state.
        /// </summary>
        void LoadState();

        /// <summary>
        ///     Save the package state.
        /// </summary>
        void SaveState();
    }
}
