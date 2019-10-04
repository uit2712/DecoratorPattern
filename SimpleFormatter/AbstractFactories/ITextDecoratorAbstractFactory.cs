using SimpleFormatter.Decorators;
using System;
using System.Windows.Forms;

namespace SimpleFormatter.AbstractFactories
{
    /// <summary>
    /// Abstract Factory
    /// </summary>
    interface ITextDecoratorAbstractFactory
    {
        TextDecorator GetTextDecorator(Type type, RichTextBox richTextBox);
    }
}
