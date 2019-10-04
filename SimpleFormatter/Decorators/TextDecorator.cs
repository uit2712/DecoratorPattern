using System.Windows.Forms;

namespace SimpleFormatter.Decorators
{
    /// <summary>
    /// Base decorator
    /// </summary>
    abstract class TextDecorator : RichTextBox
    {
        protected RichTextBox _richTextBox = null;

        public TextDecorator(RichTextBox richTextBox)
        {
            _richTextBox = richTextBox;
        }

        public abstract void Format();
    }
}
