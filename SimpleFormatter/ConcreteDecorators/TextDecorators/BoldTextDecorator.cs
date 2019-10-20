using SimpleFormatter.Components;
using SimpleFormatter.Decorators;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleFormatter.ConcreteDecorators.TextDecorators
{
    /// <summary>
    /// Concrete Decorator
    /// </summary>
    class BoldTextDecorator : TextDecorator
    {
        public BoldTextDecorator(IFormatComponent component)
            : base(component)
        {

        }

        public override void Format(RichTextBox richTextBox)
        {
            SetTextBold(richTextBox);
            _component?.Format(richTextBox);
        }

        private void SetTextBold(RichTextBox richTextBox)
        {
            if (richTextBox == null)
                return;

            int selectionStart = richTextBox.SelectionStart;
            int selectionLength = richTextBox.SelectionLength;

            if (!richTextBox.SelectionFont.Bold)
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, richTextBox.SelectionFont.Style | FontStyle.Bold);
            else richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, richTextBox.SelectionFont.Style & ~FontStyle.Bold);

            richTextBox.Focus();
        }
    }
}
