using System;

/*Даний інтерфейс поганий тим, що він включає занадто багато методів.
 А що, якщо наш клас товарів не може мати знижок або промокодом, або для нього немає сенсу встановлювати матеріал з 
 якого зроблений (наприклад, для книг). Таким чином, щоб не реалізовувати в кожному класі невикористовувані в ньому методи, краще 
розбити інтерфейс на кілька дрібних і кожним конкретним класом реалізовувати потрібні інтерфейси.
Перепишіть, розбивши інтерфейс на декілька інтерфейсів, керуючись принципом розділення інтерфейсу. 
Опишіть класи книжки (розмір та колір не потрібні, але потрібна ціна та знижки) та верхній одяг (колір, розмір, ціна знижка),
які реалізують притаманні їм інтерфейси.*/

//ISP

interface IItemDiscount
{
    void ApplyDiscount(String discount);
}

interface IItemPromocode
{
    void ApplyPromocode(String promocode);
}

interface IItemProperties
{
    void SetColor(byte color);
    void SetSize(byte size);
}

interface IItemPrice
{
    void SetPrice(double price);

}

class Book : IItemDiscount, IItemPrice
{
    public void ApplyDiscount(String discount) { }
    public void ApplyPromocode(String promocode) { }
    public void SetPrice(double price) { }
}

class Clothes : IItemProperties, IItemDiscount, IItemPromocode, IItemPrice
{
    public void ApplyDiscount(String discount) { }
    public void SetColor(byte color) { }
    public void SetSize(byte size) { }
    public void ApplyPromocode(String promocode) { }
    public void SetPrice(double price) { }

}

interface IItem
{
    void ApplyDiscount(String discount);
    void ApplyPromocode(String promocode);

    void SetColor(byte color);
    void SetSize(byte size);

    void SetPrice(double price);
}

class Program
{
    static void Main(string[] args)
    {
    }
}