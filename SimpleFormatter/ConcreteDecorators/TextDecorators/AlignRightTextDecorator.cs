using SimpleFormatter.Components;
using SimpleFormatter.Decorators;
using System.Windows.Forms;

namespace SimpleFormatter.ConcreteDecorators.TextDecorators
{
    /// <summary>
    /// Concrete Decorator
    /// </summary>
    class AlignRightTextDecorator : TextDecorator
    {
        public AlignRightTextDecorator(IFormatComponent component)
            : base(component)
        {

        }

        public override void Format(RichTextBox richTextBox)
        {
            AlignRight(richTextBox);
            _component?.Format(richTextBox);
        }

        private void AlignRight(RichTextBox richTextBox)
        {
            if (richTextBox == null)
                return;

            if (richTextBox.SelectionAlignment != HorizontalAlignment.Right)
                richTextBox.SelectionAlignment = HorizontalAlignment.Right;
            else richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox.Focus();
        }
    }
}
