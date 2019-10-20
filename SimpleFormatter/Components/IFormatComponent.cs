using System.Windows.Forms;

namespace SimpleFormatter.Components
{
    interface IFormatComponent
    {
        void Format(RichTextBox richTextBox);
    }
}
