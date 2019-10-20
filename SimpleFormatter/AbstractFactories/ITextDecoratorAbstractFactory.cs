using SimpleFormatter.Components;
using SimpleFormatter.Decorators;
using System;

namespace SimpleFormatter.AbstractFactories
{
    /// <summary>
    /// Abstract Factory
    /// </summary>
    interface ITextDecoratorAbstractFactory
    {
        TextDecorator GetTextDecorator(Type type, IFormatComponent component);
    }
}
