using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Razor;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FeatureFolderWebApplication.Features.FeatureFolders
{
    public class FeatureViewLocationExpander : IViewLocationExpander
    {
        private const string _valueKey = nameof(FeatureViewLocationExpander);

        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            if (!context.Values.TryGetValue(_valueKey, out var feature))
            {
                return viewLocations;
            }

            return (new[] { $"/Features/{feature}/{{0}}.cshtml", $"/Features/{feature}/Views/{{0}}.cshtml" })
                .Union(viewLocations);
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
            var actionDescriptor = context.ActionContext.ActionDescriptor as ControllerActionDescriptor;
            if (actionDescriptor == null)
            {
                return;
            }

            var controller = actionDescriptor.ControllerTypeInfo;
            var feature = controller.GetCustomAttribute<FeatureAttribute>();
            if (feature == null)
            {
                return;
            }

            context.Values[_valueKey] = feature.Name;
        }
    }
}
