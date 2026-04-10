using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;

IPizza pizza = new Pizza();

Console.WriteLine(pizza.Opcionais());
Console.WriteLine($"Preco R$ {pizza.Preco()}\n");
Console.WriteLine($"Tecle algo para aplicar o padrão Decorator");
Console.ReadKey();

Console.WriteLine("------------------- Aplicando o Decorator -----------------------------");

IPizza pizza2 = new Pizza();
IPizza massaEspecialDecorator = new MassaEspecialDecorator(pizza2);
IPizza baconDecorator = new BaconDecorator(massaEspecialDecorator);
IPizza bordaDecorator =  new BordaRecheadaDecorator(baconDecorator);

Console.WriteLine(bordaDecorator.Opcionais());
Console.WriteLine($"Preço total R$: {bordaDecorator.Preco()}\n");
Console.ReadKey();