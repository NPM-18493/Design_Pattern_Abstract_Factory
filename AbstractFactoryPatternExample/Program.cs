// See https://aka.ms/new-console-template for more information

Console.WriteLine("*******Dominos Pizza********");

PizzaStore dominosPizzaStore = new DominosPizzaSore();
dominosPizzaStore.OrderPizza(PizzaType.Cheese);

Console.WriteLine("*******Pizza Hut Pizza********");

PizzaStore pizzaHutPizzaStore = new PizzaHutPizzaSore();
pizzaHutPizzaStore.OrderPizza(PizzaType.Veggie);
