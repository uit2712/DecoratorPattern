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
        public ItalicTextDecorator(RichTextBox richTextBox)
            : base(richTextBox)
        {

        }

        public override void Format()
        {
            if (_richTextBox == null
                || _richTextBox.SelectionLength == 0)
                return;

            int selectionStart = _richTextBox.SelectionStart;
            int selectionLength = _richTextBox.SelectionLength;

            _richTextBox.SelectionFont = new Font(_richTextBox.SelectionFont, _richTextBox.SelectionFont.Style ^ FontStyle.Italic);
            _richTextBox.Focus();
        }
    }
}
