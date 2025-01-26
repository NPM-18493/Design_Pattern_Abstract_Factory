public class PizzaHutVeggiePizza : Pizza
{
    private IPizzaIngredientFactory pizzaHutPizzaIngredientFactory;

    public PizzaHutVeggiePizza(IPizzaIngredientFactory pizzaIngredientFactory){
        this.pizzaHutPizzaIngredientFactory = pizzaIngredientFactory;
    }
    public override void Bake()
    {
        Console.WriteLine("Baking Pizza Hut Veggie Pizza!");
    }

    public override void Box()
    {
        Console.WriteLine("Boxing Pizza Hut Veggie Pizza!");
    }

    public override void Prepare()
    {
        Console.WriteLine("Preparing Pizza Hut Veggie Pizza!");
        Console.WriteLine(string.Concat("Using ", pizzaHutPizzaIngredientFactory.GetCheese(), ", " , pizzaHutPizzaIngredientFactory.GetDough(), ", ", pizzaHutPizzaIngredientFactory.GetSauce()));
    }

    public override void Slice()
    {
        Console.WriteLine("Slicing Pizza Hut Veggie Pizza!");
    }
}