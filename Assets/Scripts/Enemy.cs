using UnityEngine;

public class Enemy : Character
{
    public Enemy(string name, int health) : base(name, health){}

    public void Attack(Character character,int amount) 
    {
        Debug.Log("Damage amount is : " + amount);
        if (amount > 0)
        {
            Debug.Log("Previous Health is : " + character.GetHeath());
            if (character.GetHeath()-amount < 0)
            {
                character.SetHealth(0);
            }
            else
            {
                character.SetHealth(character.GetHeath() - amount);
            }
            Debug.Log("Current Health is : " + character.GetHeath());
        }
        else
        {
            Debug.Log("Wrong Damage Amount || Health hasn't decreased : " + character.GetHeath());
        }
    }
}
