public class Mosgain : Enemy
{
    int valueTemp = 3;
    public Mosgain(int attack, int health) : base(attack, health)
    {

    }
    public override void SetColor()
    {
        base.SetColor();
        Console.WriteLine("Gia tri nay la mau mac dinh", valueTemp.ToString());
    }
}