using SimpleFormatter.Components;
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
        public AlignLeftTextDecorator(IFormatComponent component)
            : base(component)
        {

        }

        public override void Format(RichTextBox richTextBox)
        {
            AlignLeft(richTextBox);
            _component?.Format(richTextBox);
        }

        private void AlignLeft(RichTextBox richTextBox)
        {
            if (richTextBox == null)
                return;

            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox.Focus();
        }
    }
}
