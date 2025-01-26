public class DominosVeggiePizza : Pizza
{

private IPizzaIngredientFactory dominosPizzaIngredientFactory;
    public DominosVeggiePizza(IPizzaIngredientFactory pizzaIngredientFactory){
        this.dominosPizzaIngredientFactory = pizzaIngredientFactory;
    }

    public override void Bake()
    {
        Console.WriteLine("Baking Dominos Veggie Pizza!");
    }

    public override void Box()
    {
        Console.WriteLine("Boxing Dominos Veggie Pizza!");
    }

    public override void Prepare()
    {
        Console.WriteLine("Preparing Dominos Veggie Pizza!");
        Console.WriteLine(string.Concat("Using ", dominosPizzaIngredientFactory.GetCheese(), ", " , dominosPizzaIngredientFactory.GetDough(), ", ", dominosPizzaIngredientFactory.GetSauce()));
    }

    public override void Slice()
    {
        Console.WriteLine("Slicing Dominos Veggie Pizza!");
    }
}