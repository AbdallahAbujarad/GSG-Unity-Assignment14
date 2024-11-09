using UnityEngine;

public class Player : Character
{
    public Player(string name, int health) : base(name, health) { }
    public void Heal(int amount) 
    {
        Debug.Log("Heal amount is : " + amount);
        if (amount > 0) 
        {
            Debug.Log("Previous Health is : " + GetHeath());
            if (GetHeath()+amount > 100)
            {
                SetHealth(100);
            }
            else
            {
                SetHealth(GetHeath()+amount);
            }
            Debug.Log("Current Health is : " + GetHeath());
        }
        else
        {
            Debug.Log("Wrong Heal Amount || Health hasn't increased : " + GetHeath());
        }
    }
}
