// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using mediator.Clases;
class Program { 
static void Main()
{
    
    Button button = new Button();
    TextBox textBox = new TextBox();
    ListBox listBox = new ListBox();

    
    ConcreteMediator mediator = new ConcreteMediator(button, textBox, listBox);

    
    textBox.Type("Hola Mundo");
    button.Click();
    textBox.Type("Patrón Mediator en C#");
    button.Click();
}
}





