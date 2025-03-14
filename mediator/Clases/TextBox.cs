using mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator.Clases
{
    public class TextBox
    {
        private IMediator _mediator;
        private string _text;
        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
        public void Type(string text)
        {
            _text = text;
            Console.WriteLine($"Texto ingresado: {text}");
        }
        public string GetText()
        {
            return _text;
        }
        public void Clear()
        {
            _text = "";
            Console.WriteLine("Campo de texto limpiado.");
        }
    }


}

