using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittleBluRayThequeProject.Helpers
{
    public interface IApplicationHelper
    {
        void EnsureDirectoriesExist(List<string> directories);
    }
}
