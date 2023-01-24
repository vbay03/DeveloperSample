using System;
using System.Collections.Generic;

namespace DeveloperSample.Container
{
    public class Container
    {
        private Dictionary<Type, Type> mapping = new();

        public void Bind(Type interfaceType, Type implementationType) => mapping[interfaceType] = implementationType;
        public T Get<T>() => (T)Activator.CreateInstance(mapping[typeof(T)]);
    }
}