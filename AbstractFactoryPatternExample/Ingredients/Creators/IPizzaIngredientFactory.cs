public interface IPizzaIngredientFactory
{
    IDough GetDough();

    ICheese GetCheese();

    ISauce GetSauce();
}