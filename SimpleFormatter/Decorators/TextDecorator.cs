using SimpleFormatter.Components;
using System.Windows.Forms;

namespace SimpleFormatter.Decorators
{
    /// <summary>
    /// Base decorator
    /// </summary>
    abstract class TextDecorator : IFormatComponent
    {
        protected IFormatComponent _component = null;

        public TextDecorator(IFormatComponent component)
        {
            _component = component;
        }

        public abstract void Format(RichTextBox richTextBox);
    }
}
