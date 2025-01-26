public class PizzaHutCheesePizza : Pizza
{
    private IPizzaIngredientFactory pizzaHutPizzaIngredientFactory;

    public PizzaHutCheesePizza(IPizzaIngredientFactory pizzaIngredientFactory){
        this.pizzaHutPizzaIngredientFactory = pizzaIngredientFactory;
    }


    public override void Bake()
    {
        Console.WriteLine("Baking Pizza Hut Cheese Pizza!");
    }

    public override void Box()
    {
        Console.WriteLine("Boxing Pizza Hut Cheese Pizza!");
    }

    public override void Prepare()
    {
        Console.WriteLine("Preparing Pizza Hut Cheese Pizza!");
        Console.WriteLine(string.Concat("Using ", pizzaHutPizzaIngredientFactory.GetCheese(), ", " , pizzaHutPizzaIngredientFactory.GetDough(), ", ", pizzaHutPizzaIngredientFactory.GetSauce()));
    }

    public override void Slice()
    {
        Console.WriteLine("Slicing Pizza Hut Cheese Pizza!");
    }
}