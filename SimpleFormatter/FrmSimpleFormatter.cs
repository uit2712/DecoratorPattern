using SimpleFormatter.ConcreteDecorators.TextDecorators;
using SimpleFormatter.ConcreteFactories;
using SimpleFormatter.Decorators;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleFormatter
{
    public partial class FrmSimpleFormatter : Form
    {
        public FrmSimpleFormatter()
        {
            InitializeComponent();
            InitFonts();
        }

        private void InitFonts()
        {
            List<string> fonts = new List<string>();

            foreach (FontFamily font in FontFamily.Families)
                cbbFont.Items.Add(font.Name);

            cbbFont.Text = "Arial";
        }

        private void rtxtSimpleText_SelectionChanged(object sender, System.EventArgs e)
        {
            RichTextBox richTextBox = sender as RichTextBox;

            ChangeFormatEffect(richTextBox, btnBold, FontStyle.Bold);
            ChangeFormatEffect(richTextBox, btnItalic, FontStyle.Italic);
            ChangeFormatEffect(richTextBox, btnUnderline, FontStyle.Underline);
        }

        private void btnBold_Click(object sender, System.EventArgs e)
        {
            TextDecorator textDecorator = TextDecoratorFactory.Instance().GetTextDecorator(typeof(BoldTextDecorator), rtxtSimpleText);
            textDecorator?.Format();

            Button button = sender as Button;
            ChangeFormatEffect(rtxtSimpleText, button, FontStyle.Bold);
        }

        private void btnItalic_Click(object sender, System.EventArgs e)
        {
            TextDecorator textDecorator = TextDecoratorFactory.Instance().GetTextDecorator(typeof(ItalicTextDecorator), rtxtSimpleText);
            textDecorator?.Format();

            Button button = sender as Button;
            ChangeFormatEffect(rtxtSimpleText, button, FontStyle.Italic);
        }

        private void btnUnderline_Click(object sender, System.EventArgs e)
        {
            TextDecorator textDecorator = TextDecoratorFactory.Instance().GetTextDecorator(typeof(UnderlineTextDecorator), rtxtSimpleText);
            textDecorator?.Format();

            Button button = sender as Button;
            ChangeFormatEffect(rtxtSimpleText, button, FontStyle.Underline);
        }

        private void ChangeFormatEffect(RichTextBox richTextBox, Button button, FontStyle fontStyle)
        {
            Font selectionFont = richTextBox.SelectionFont;
            if (selectionFont.Style.HasFlag(fontStyle) && richTextBox.SelectionLength > 0)
                button.Font = new Font(button.Font, button.Font.Style | fontStyle);
            else button.Font = new Font(button.Font, button.Font.Style & ~fontStyle);
        }

        private void btnAlignLeft_Click(object sender, System.EventArgs e)
        {
            TextDecorator textDecorator = TextDecoratorFactory.Instance().GetTextDecorator(typeof(AlignLeftTextDecorator), rtxtSimpleText);
            textDecorator?.Format();
        }

        private void btnAlignCenter_Click(object sender, System.EventArgs e)
        {
            TextDecorator textDecorator = TextDecoratorFactory.Instance().GetTextDecorator(typeof(AlignCenterTextDecorator), rtxtSimpleText);
            textDecorator?.Format();
        }

        private void btnAlignRight_Click(object sender, System.EventArgs e)
        {
            TextDecorator textDecorator = TextDecoratorFactory.Instance().GetTextDecorator(typeof(AlignRightTextDecorator), rtxtSimpleText);
            textDecorator?.Format();
        }
    }
}
