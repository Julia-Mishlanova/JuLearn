public class Player
{
    private int health = 100;
    public int Health
    {
        get
        {
            return this.health;
        }
        set
        {
            health = value;
        }
    }
  
    public Player()
    {}
  
    //FIXME: This method won't compile for some reason! :(
    public bool CheckAlive()
    {
        if (this.Health < 0)
        {
            return false;
        }
        else if (this.Health > 0)
        {
            return true;
        }
        return false;
    }
}