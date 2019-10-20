using SimpleFormatter.AbstractFactories;
using SimpleFormatter.Components;
using SimpleFormatter.ConcreteComponents;
using SimpleFormatter.ConcreteDecorators.TextDecorators;
using SimpleFormatter.Decorators;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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

        public TextDecorator GetTextDecorator(Type type, IFormatComponent component)
        {
            if (type == null || !type.IsSubclassOf(typeof(TextDecorator)))
                return null;

            if (type == typeof(BoldTextDecorator))
            {
                if (!_textDecorators.ContainsKey(type))
                    _textDecorators[type] = new BoldTextDecorator(component);

                return _textDecorators[type];
            }

            if (type == typeof(ItalicTextDecorator))
            {
                if (!_textDecorators.ContainsKey(type))
                    _textDecorators[type] = new ItalicTextDecorator(component);

                return _textDecorators[type];
            }

            if (type == typeof(UnderlineTextDecorator))
            {
                if (!_textDecorators.ContainsKey(type))
                    _textDecorators[type] = new UnderlineTextDecorator(component);

                return _textDecorators[type];
            }

            if (type == typeof(AlignLeftTextDecorator))
            {
                if (!_textDecorators.ContainsKey(type))
                    _textDecorators[type] = new AlignLeftTextDecorator(component);

                return _textDecorators[type];
            }

            if (type == typeof(AlignRightTextDecorator))
            {
                if (!_textDecorators.ContainsKey(type))
                    _textDecorators[type] = new AlignRightTextDecorator(component);

                return _textDecorators[type];
            }

            if (type == typeof(AlignCenterTextDecorator))
            {
                if (!_textDecorators.ContainsKey(type))
                    _textDecorators[type] = new AlignCenterTextDecorator(component);

                return _textDecorators[type];
            }

            return null;
        }
    }
}
