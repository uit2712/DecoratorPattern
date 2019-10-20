using SimpleFormatter.Components;
using SimpleFormatter.Decorators;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleFormatter.ConcreteDecorators.TextDecorators
{
    /// <summary>
    /// Concrete Decorator
    /// </summary>
    class UnderlineTextDecorator : TextDecorator
    {
        public UnderlineTextDecorator(IFormatComponent component)
            : base(component)
        {

        }

        public override void Format(RichTextBox richTextBox)
        {
            SetTextUnderline(richTextBox);
            _component?.Format(richTextBox);
        }

        private void SetTextUnderline(RichTextBox richTextBox)
        {
            if (richTextBox == null)
                return;

            int selectionStart = richTextBox.SelectionStart;
            int selectionLength = richTextBox.SelectionLength;

            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, richTextBox.SelectionFont.Style ^ FontStyle.Underline);
            richTextBox.Focus();
        }
    }
}
