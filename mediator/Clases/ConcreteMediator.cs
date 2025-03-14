using mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator.Clases
{
    public class ConcreteMediator : IMediator
    {
        private Button _button;
        private TextBox _textBox;
        private ListBox _listBox;

        public ConcreteMediator(Button button, TextBox textBox, ListBox listBox)
        {
            _button = button;
            _textBox = textBox;
            _listBox = listBox;
            _button.SetMediator(this);
            _textBox.SetMediator(this);
            _listBox.SetMediator(this);
        }
        public void Notify(object sender, string eventCode)
        {
            if (eventCode == "click")
            {
                if (!string.IsNullOrWhiteSpace(_textBox.GetText()))
                {
                    _listBox.AddItem(_textBox.GetText());
                    _textBox.Clear();
                }
            }
        }
    }


}

