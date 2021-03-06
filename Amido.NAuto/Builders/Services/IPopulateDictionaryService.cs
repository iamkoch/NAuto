﻿using System;
using System.Reflection;

namespace Amido.NAuto.Builders.Services
{
    public interface IPopulateDictionaryService
    {
        void SetAutoBuilderConfiguration(AutoBuilderConfiguration autoBuilderConfiguration);

        object Populate(
            string propertyName, 
            Type propertyType, 
            object currentValue, 
            int depth, 
            Func<int, string, Type, object, PropertyInfo, object> populateKey, 
            Func<int, string, Type, object, PropertyInfo, object> populateValue);
    }
}