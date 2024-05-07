# Design Patterns

Os padrões de projeto tem como objetivo padronizar e facilitar a comunicação e o desenvolvimento durante os processos do construção de software.

São dividídos em 3 tipos:

**Criacional**: Trabalham com a criação de objetos flexíveis e reutilizáveis
    -   Factory Method
    -   Abstract Factory
    -   Builder
    -   Prototype
    -   Singleton
    
**Estrutural:** Definem como trabalhar com objetos e classes em estruturas maiores e complexas, e ainda assim flexíveis e eficientes
    -   Adapter
    -   Bridge
    -   Composite
    -   Decorator
    -   Facade
    -   Flyweigth
    -   Proxi
    
**Comportamental:** Trabalham com a comunicação eficiente e designam as responsabilidades comuns aos objetos
    -   Chain of responsability
    -   Command
    -   Iterator
    -   Mediator
    -   Momento
    -   Observer
    -   State
    -   Strategy
    -   Template Method
    -   Visitor

## Factory Method
Fornece uma interface para a criação de objetos em uma superclasse, mas permite que as subclasses alterem o tipo dos objetos que vão ser criados 
No exemplo:
- Temos uma fábrica de transportes que fornece a base para a criação de diversos tipos de veículos.
