using mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator.Clases
{
    public class ListBox
    {
        private IMediator _mediator;
        private List<string> _items = new List<string>();
        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
        public void AddItem(string item)
        {
            _items.Add(item);
            Console.WriteLine($"Elemento agregado a la lista: {item}");
        }
    }
}
