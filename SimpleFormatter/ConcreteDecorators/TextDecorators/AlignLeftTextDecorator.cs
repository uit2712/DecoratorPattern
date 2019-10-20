using SimpleFormatter.ConcreteComponents;
using SimpleFormatter.Decorators;
using System.Windows.Forms;

namespace SimpleFormatter.ConcreteDecorators.TextDecorators
{
    /// <summary>
    /// Concrete Decorator
    /// </summary>
    class AlignLeftTextDecorator : TextDecorator
    {
        public AlignLeftTextDecorator(CustomRichTextBox richTextBox)
            : base(richTextBox)
        {

        }

        public override void Format()
        {
            if (_richTextBox == null)
                return;

            _richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            _richTextBox.Focus();
        }
    }
}
