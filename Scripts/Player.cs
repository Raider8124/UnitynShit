using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // variables
    public float maxHealth, maxThirst, maxHunger;
    public float thirstIncreaseRate, hungerIncreaseRate;
    private float health, thirst, hunger;

    public bool dead;

    // functions
    public void Start()
    {
        health = maxHealth;
    }

    public void Update()
    {
        
        // thirst and hunger increase
        if (!dead)
        {
            hunger += hungerIncreaseRate * Time.deltaTime;
            thirst += thirstIncreaseRate * Time.deltaTime;
        }

        if (thirst >= maxThirst)
            Die();
        if (hunger >= maxHunger)
            Die();
    }

    public void Die()
    {
        dead = true;
        print("Player Has Died");
    }
}
