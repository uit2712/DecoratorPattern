using SimpleFormatter.Components;
using SimpleFormatter.Decorators;
using System.Windows.Forms;

namespace SimpleFormatter.ConcreteDecorators.TextDecorators
{
    /// <summary>
    /// Concrete Decorator
    /// </summary>
    class AlignCenterTextDecorator : TextDecorator
    {
        public AlignCenterTextDecorator(IFormatComponent component)
            : base(component)
        {

        }

        public override void Format(RichTextBox richTextBox)
        {
            AlignCenter(richTextBox);
            _component?.Format(richTextBox);
        }

        private void AlignCenter(RichTextBox richTextBox)
        {
            if (richTextBox == null)
                return;

            if (richTextBox.SelectionAlignment != HorizontalAlignment.Center)
                richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            else richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox.Focus();
        }
    }
}
