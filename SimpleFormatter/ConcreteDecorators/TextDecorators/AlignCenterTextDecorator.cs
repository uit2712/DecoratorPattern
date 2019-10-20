using SimpleFormatter.ConcreteComponents;
using SimpleFormatter.Decorators;
using System.Windows.Forms;

namespace SimpleFormatter.ConcreteDecorators.TextDecorators
{
    /// <summary>
    /// Concrete Decorator
    /// </summary>
    class AlignCenterTextDecorator : TextDecorator
    {
        public AlignCenterTextDecorator(CustomRichTextBox richTextBox)
            : base(richTextBox)
        {

        }

        public override void Format()
        {
            if (_richTextBox == null)
                return;

            if (_richTextBox.SelectionAlignment != HorizontalAlignment.Center)
                _richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            else _richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            _richTextBox.Focus();
        }
    }
}
