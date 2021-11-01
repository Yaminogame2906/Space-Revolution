using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int maxHealth = 1000;
    public int playerHealth;

    public void Start()
    {
        playerHealth = maxHealth;
    }

    public void PlayerTakeDamage(int damage)
    {
        playerHealth = playerHealth - damage;
    }
    
    
    
    
    
    
    
    /*private int health
    public HealthSystem(int health)
    {
        this.health = health;
    }
    public int GetHealth()
    {
        return health;
    }*/
    
}
