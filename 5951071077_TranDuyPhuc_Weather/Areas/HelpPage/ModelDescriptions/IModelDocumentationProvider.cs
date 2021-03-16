using System;
using System.Reflection;

namespace _5951071077_TranDuyPhuc_Weather.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}