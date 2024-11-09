public abstract class Character
{
    string name;
    public string GetName() { return name; }
    public void SetName(string name) { this.name = name; }
    
    int health;
    public int GetHeath() { return health; }
    public void SetHealth(int health) { this.health = health; }

    public Character(string name,int health) 
    {
        this.name = name;
        if (health>100)
        {
            health = 100;
        }
        else if (health<0)
        {
            health = 0;
        }
        this.health = health; 
    }
}
