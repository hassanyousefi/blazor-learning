﻿using System.Reflection;

namespace ToDo.Shared.Resources;

public static class StringLocalizerProvider
{
    public static IStringLocalizer ProvideLocalizer(Type dtoType, IStringLocalizerFactory factory)
    {
        return factory.Create(dtoType.GetCustomAttribute<DtoResourceTypeAttribute>()?.ResourceType ?? typeof(AppStrings));
    }
}
