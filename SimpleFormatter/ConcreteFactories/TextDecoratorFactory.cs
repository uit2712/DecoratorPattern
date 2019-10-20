using SimpleFormatter.AbstractFactories;
using SimpleFormatter.ConcreteComponents;
using SimpleFormatter.ConcreteDecorators.TextDecorators;
using SimpleFormatter.Decorators;
using System;
using System.Collections.Generic;

namespace SimpleFormatter.ConcreteFactories
{
    /// <summary>
    /// Concrete Factory
    /// </summary>
    class TextDecoratorFactory : ITextDecoratorAbstractFactory
    {
        private Dictionary<Type, TextDecorator> _textDecorators = new Dictionary<Type, TextDecorator>();
        private static TextDecoratorFactory _instance = null;

        private TextDecoratorFactory()
        {

        }

        public static TextDecoratorFactory Instance()
        {
            if (_instance == null)
                _instance = new TextDecoratorFactory();

            return _instance;
        }

        public TextDecorator GetTextDecorator(Type type, CustomRichTextBox richTextBox)
        {
            if (type == null || !type.IsSubclassOf(typeof(TextDecorator)))
                return null;

            if (type == typeof(BoldTextDecorator))
            {
                if (!_textDecorators.ContainsKey(type))
                    _textDecorators[type] = new BoldTextDecorator(richTextBox);

                return _textDecorators[type];
            }

            if (type == typeof(ItalicTextDecorator))
            {
                if (!_textDecorators.ContainsKey(type))
                    _textDecorators[type] = new ItalicTextDecorator(richTextBox);

                return _textDecorators[type];
            }

            if (type == typeof(UnderlineTextDecorator))
            {
                if (!_textDecorators.ContainsKey(type))
                    _textDecorators[type] = new UnderlineTextDecorator(richTextBox);

                return _textDecorators[type];
            }

            if (type == typeof(AlignLeftTextDecorator))
            {
                if (!_textDecorators.ContainsKey(type))
                    _textDecorators[type] = new AlignLeftTextDecorator(richTextBox);

                return _textDecorators[type];
            }

            if (type == typeof(AlignRightTextDecorator))
            {
                if (!_textDecorators.ContainsKey(type))
                    _textDecorators[type] = new AlignRightTextDecorator(richTextBox);

                return _textDecorators[type];
            }

            if (type == typeof(AlignCenterTextDecorator))
            {
                if (!_textDecorators.ContainsKey(type))
                    _textDecorators[type] = new AlignCenterTextDecorator(richTextBox);

                return _textDecorators[type];
            }

            return null;
        }
    }
}
