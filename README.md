🍕 Pizza Decorator Pattern - C#
Este repositório contém uma implementação prática do padrão de projeto Decorator, utilizando o clássico exemplo de uma montagem de pizza para demonstrar como adicionar responsabilidades a objetos de forma dinâmica.

📌 Sobre o Padrão Decorator
Diferente da herança, onde o comportamento é definido em tempo de compilação, o Decorator utiliza a composição para estender as funcionalidades em tempo de execução.
Isso evita a "explosão de subclasses" quando temos muitas combinações de opcionais.


🛠️ Implementação do Exemplo
No código deste projeto, a interface principal é a IPizza. Uma pizza simples tem um nome e um preço base, mas o cliente pode querer customizá-la.

Componentes:

- Componente (IPizza): Interface que define os métodos Opcionais() e Preco().
- Componente Concreto (Pizza): A implementação básica (ex: Pizza padrão de R$ 10,00).
- Base Decorator (PizzaDecorator): Classe abstrata que mantém uma referência para um objeto IPizza e delega as chamadas para ele.
- Decoradores Concretos:
   -    BaconDecorator: Adiciona bacon e aumenta o preço em R$ 4,00.
   -    BordaRecheadaDecorator: Adiciona borda e aumenta o preço em R$ 3,00.
   -    MassaEspecialDecorator: Adiciona massa especial e aumenta o preço em R$ 2,50.
 
🚀 Vantagens desta Abordagem
- Princípio do Aberto/Fechado (OCP): Podemos introduzir novos ingredientes sem alterar as classes de pizza existentes.
- Flexibilidade: Podemos combinar 10 ingredientes diferentes sem precisar criar centenas de classes (PizzaComBacon, PizzaComBorda, PizzaComBaconEBorda, etc).
- Responsabilidade Única (SRP): Cada decorador cuida apenas da sua funcionalidade específica.

  
