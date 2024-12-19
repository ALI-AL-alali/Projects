public class Meal
{
    public int MealID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Meal() { }
    public Meal(int MealID , string Name , decimal Price)
    {
        this.MealID = MealID;
        this.Name = Name;
        this.Price = Price;
    }
}
