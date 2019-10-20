using SimpleFormatter.Components;
using SimpleFormatter.ConcreteComponents;

namespace SimpleFormatter.Decorators
{
    /// <summary>
    /// Base decorator
    /// </summary>
    abstract class TextDecorator : IFormatComponent
    {
        protected CustomRichTextBox _richTextBox = null;

        public TextDecorator(CustomRichTextBox richTextBox)
        {
            _richTextBox = richTextBox;
        }

        public abstract void Format();
    }
}
