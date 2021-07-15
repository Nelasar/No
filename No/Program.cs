abstract class Delivery
{
    public string Address;
    public string DeliveryDate;
    public abstract void SendProduct();
}
class HomeDelivery : Delivery
{
    public override void SendProduct()
    {
        Console.WriteLine("Курьер доставит ваш заказ по адресу {0}", Address);
    }
    Courier courier = new Courier("Иван", 24, "88005553535");
    public void SendWithDeliverService()
    {
        Console.WriteLine(" Слуба доставки доставит ваш заказ по адресу {0}", Address);
    }
}
class PickPointDelivery : Delivery
{
    public override void SendProduct()
    {
        Console.WriteLine("Курьер доставит ваш заказ в пункт по адресу {0}", Address);
    }
    private void ProductStorage()
    {
        int shelf_life = 14;
        Console.WriteLine("Срок хранения товаров в пункте выдачи составляет {0} дней.", shelf_life);
    }
}
class ShopDelivery : Delivery
{
    public override void SendProduct()
    {
        Console.WriteLine("Курьер доставит ваш заказ в магазин по адресу {0}", Address);
    }
}

class Pickup : Delivery
{
    string[] pickpoints = new string[7];
    public override void SendProduct()
    {

    }

}
class Order<TDelivery,
TStruct> where TDelivery : Delivery
{
    public TDelivery Delivery;
    public int Number;
    public string Description;
    public void DisplayAddress()
    {
        Console.WriteLine(Delivery.Address);
    }

}
abstract class Payment
{
    public int Sum;
}
abstract class Person
{
    protected string name;
    protected int age;
    protected string phone_number;
}
class Courier : Person
{
    public Courier(string Name, int age, string phone_number)
    {
        this.Name = Name;
        this.age = age;
        this.phone_number = phone_number;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public new int age
    {
        get { return age; }
        set { age = value; }
    }
    public new string phone_number
    {
        get { return phone_number; }
        set { phone_number = value; }
    }
}