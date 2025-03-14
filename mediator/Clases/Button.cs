using mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator.Clases
{
    public class Button
    {
        private IMediator _mediator;
        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Click()
        {
            Console.WriteLine("Botón presionado.");
            _mediator.Notify(this, "click");
        }
    }
}
