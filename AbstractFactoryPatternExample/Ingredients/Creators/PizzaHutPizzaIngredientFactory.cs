public class PizzaHutPizzaIngredientFactory : IPizzaIngredientFactory
{
    public ICheese GetCheese()
    {
        return new MozzarellaCheese();
    }

    public IDough GetDough()
    {
        return new ThickCrustDough();
    }

    public ISauce GetSauce()
    {
        return new PlumTomatoSauce();
    }
}