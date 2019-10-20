using SimpleFormatter.Components;
using SimpleFormatter.Decorators;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleFormatter.ConcreteDecorators.TextDecorators
{
    /// <summary>
    /// Concrete Decorator
    /// </summary>
    class ItalicTextDecorator : TextDecorator
    {
        public ItalicTextDecorator(IFormatComponent component)
            : base(component)
        {

        }

        public override void Format(RichTextBox richTextBox)
        {
            SetTextItalic(richTextBox);
            _component?.Format(richTextBox);
        }

        private void SetTextItalic(RichTextBox richTextBox)
        {
            if (richTextBox == null)
                return;

            int selectionStart = richTextBox.SelectionStart;
            int selectionLength = richTextBox.SelectionLength;

            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, richTextBox.SelectionFont.Style ^ FontStyle.Italic);
            richTextBox.Focus();
        }
    }
}
