using TauCode.Dev.Data;
using TauCode.Extensions;

namespace TauCode.Dev;

internal static class Helper
{
    internal static bool IsProjectTypeGuid(this Guid guid)
    {
        return guid.IsIn(
            ProjectType.DotNetCore.Guid,
            ProjectType.CSharp.Guid);
    }

    internal static string ToSolutionString(this Guid guid) => $"{guid.ToString("B").ToUpperInvariant()}";
}