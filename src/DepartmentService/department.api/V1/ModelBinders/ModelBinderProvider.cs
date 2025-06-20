using department.models.V1.Dto;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace department.api.V1.ModelBinders;

internal class ModelBinderProvider : IModelBinderProvider
{
    public IModelBinder GetBinder(ModelBinderProviderContext context)
    {
        if (context == null)
        {
            throw new ArgumentNullException(nameof(context));
        }

        if (context.Metadata.ModelType == typeof(UpdateDepartmentRequestDto))
        {
            return new BinderTypeModelBinder(typeof(UpdateDepartmentDtoModelBinder));
        }
        return null!;
    }
}
