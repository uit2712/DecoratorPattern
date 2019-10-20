using SimpleFormatter.ConcreteComponents;
using SimpleFormatter.Decorators;
using System.Windows.Forms;

namespace SimpleFormatter.ConcreteDecorators.TextDecorators
{
    /// <summary>
    /// Concrete Decorator
    /// </summary>
    class AlignRightTextDecorator : TextDecorator
    {
        public AlignRightTextDecorator(CustomRichTextBox richTextBox)
            : base(richTextBox)
        {

        }

        public override void Format()
        {
            if (_richTextBox == null)
                return;

            if (_richTextBox.SelectionAlignment != HorizontalAlignment.Right)
                _richTextBox.SelectionAlignment = HorizontalAlignment.Right;
            else _richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            _richTextBox.Focus();
        }
    }
}
