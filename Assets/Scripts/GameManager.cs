using UnityEngine;

public class GameManager : MonoBehaviour
{
    Player player = new Player("Batman", 50);
    Enemy enemy = new Enemy("Joker", 20);
    void Start() 
    {
        player.Heal(20);
        enemy.Attack(player,10);

        player.Heal(200);
        enemy.Attack(player,5000);

        player.Heal(-200);
        enemy.Attack(player,-2000);
    }
}
