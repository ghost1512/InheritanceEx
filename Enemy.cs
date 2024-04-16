public class Enemy
{
    private string mycolor = " ";
    public int attack = 0;
    public int health = 100;

    public Enemy(int attack, int health)
    {
        this.attack = attack;
        this.health = health;
    }

    public virtual void SetColor()
    {
        mycolor = "Yellow";
    }
}