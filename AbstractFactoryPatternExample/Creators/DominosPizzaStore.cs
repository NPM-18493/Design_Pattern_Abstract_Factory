public class DominosPizzaSore : PizzaStore
{
    protected override Pizza CreatePizza(PizzaType pizzaType)
    {
        IPizzaIngredientFactory ingredientFactory = new DominosPizzaIngredientFactory();

        switch(pizzaType){
            case PizzaType.Cheese: return new DominosCheesePizza(ingredientFactory);
            case PizzaType.Veggie: return new DominosVeggiePizza(ingredientFactory);
            default: return null;
        }
    }
}