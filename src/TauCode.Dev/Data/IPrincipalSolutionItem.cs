using System;
using TauCode.Dev.Data.SolutionItems;

namespace TauCode.Dev.Data
{
    public interface IPrincipalSolutionItem
    {
        Guid TypeGuid{ get; }
        string Name{ get; }
        Guid Guid { get; }
        SolutionFolder ParentSolutionFolder { get; }
    }
}
