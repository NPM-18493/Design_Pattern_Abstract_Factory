public class PizzaHutPizzaSore : PizzaStore
{
 protected override Pizza CreatePizza(PizzaType pizzaType)
    {
        IPizzaIngredientFactory pizzaIngredientFactory = new PizzaHutPizzaIngredientFactory();

        switch(pizzaType){
            case PizzaType.Cheese: return new PizzaHutCheesePizza(pizzaIngredientFactory);
            case PizzaType.Veggie: return new PizzaHutVeggiePizza(pizzaIngredientFactory);
            default: return null;
        }
    }
}