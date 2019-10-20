using SimpleFormatter.Components;
using SimpleFormatter.ConcreteComponents;
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

            TextDecorator boldAndItalicDecorator
                = new BoldTextDecorator(new ItalicTextDecorator(_component));
            boldAndItalicDecorator.Format(rtxtSimpleText);
        }

        private IFormatComponent _component = new CustomRichTextBox();

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
            TextDecorator textDecorator = TextDecoratorFactory.Instance().GetTextDecorator(typeof(BoldTextDecorator), _component);
            textDecorator?.Format(rtxtSimpleText);

            Button button = sender as Button;
            ChangeFormatEffect(rtxtSimpleText, button, FontStyle.Bold);
        }

        private void btnItalic_Click(object sender, System.EventArgs e)
        {
            TextDecorator textDecorator = TextDecoratorFactory.Instance().GetTextDecorator(typeof(ItalicTextDecorator), _component);
            textDecorator?.Format(rtxtSimpleText);

            Button button = sender as Button;
            ChangeFormatEffect(rtxtSimpleText, button, FontStyle.Italic);
        }

        private void btnUnderline_Click(object sender, System.EventArgs e)
        {
            TextDecorator textDecorator = TextDecoratorFactory.Instance().GetTextDecorator(typeof(UnderlineTextDecorator), _component);
            textDecorator?.Format(rtxtSimpleText);

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
            TextDecorator textDecorator = TextDecoratorFactory.Instance().GetTextDecorator(typeof(AlignLeftTextDecorator), _component);
            textDecorator?.Format(rtxtSimpleText);
        }

        private void btnAlignCenter_Click(object sender, System.EventArgs e)
        {
            TextDecorator textDecorator = TextDecoratorFactory.Instance().GetTextDecorator(typeof(AlignCenterTextDecorator), _component);
            textDecorator?.Format(rtxtSimpleText);
        }

        private void btnAlignRight_Click(object sender, System.EventArgs e)
        {
            TextDecorator textDecorator = TextDecoratorFactory.Instance().GetTextDecorator(typeof(AlignRightTextDecorator), _component);
            textDecorator?.Format(rtxtSimpleText);
        }
    }
}
