using System.Linq;
using System.Reflection;

namespace Trello.Helpers.Attributes
{
    public static class CustomAttributesExtensions
    {
        public static string GetRelativeUrlAttribute(this MemberInfo memberInfo)
        {
            return memberInfo.GetCustomAttributes<RelativeUrlAttribute>(false).FirstOrDefault()?.RelativeUrl;
        }
    }
}
