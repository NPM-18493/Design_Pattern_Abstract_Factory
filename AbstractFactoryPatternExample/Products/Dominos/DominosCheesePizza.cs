public class DominosCheesePizza : Pizza
{

    private IPizzaIngredientFactory dominosPizzaIngredientFactory;

    public DominosCheesePizza(IPizzaIngredientFactory pizzaIngredientFactory){
        this.dominosPizzaIngredientFactory = pizzaIngredientFactory;
    }

    public override void Bake()
    {
        Console.WriteLine("Baking Dominos Cheese Pizza!");
    }

    public override void Box()
    {
        Console.WriteLine("Boxing Dominos Cheese Pizza!");
    }

    public override void Prepare()
    {
        Console.WriteLine("Preparing Dominos Cheese Pizza!");
        Console.WriteLine(string.Concat("Using ", dominosPizzaIngredientFactory.GetCheese(), ", " , dominosPizzaIngredientFactory.GetDough(), ", ", dominosPizzaIngredientFactory.GetSauce()));
    }

    public override void Slice()
    {
        Console.WriteLine("Slicing Dominos Cheese Pizza!");
    }
}