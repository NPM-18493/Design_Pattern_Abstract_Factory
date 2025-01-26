public class DominosPizzaIngredientFactory : IPizzaIngredientFactory
{
    public ICheese GetCheese()
    {
        return new ReggianoCheese();
    }

    public IDough GetDough()
    {
        return new ThinCrustDough();
    }

    public ISauce GetSauce()
    {
        return new MarinaraSauce();
    }
}