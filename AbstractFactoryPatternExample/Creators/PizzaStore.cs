public abstract class PizzaStore
{
    public void OrderPizza(PizzaType pizzaType){
        Pizza pizza = CreatePizza(pizzaType);

        pizza.Prepare();
        pizza.Bake();
        pizza.Slice();
        pizza.Box();
    }

    protected abstract Pizza CreatePizza(PizzaType pizzaType);
}