using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_health : MonoBehaviour
{
    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite full_Heart;
    public Sprite empty_Heart;

    public void TakeDamage(int amount)
    {
        health -= amount;
    }
  
    public void gainHealth (int amount)
    {
        health += amount;
    }

    public int getHealth()
    {
        return health;
    }

    // Update is called once per frame
    void Update()
    {
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = full_Heart;
            } else
            {
                hearts[i].sprite = empty_Heart;
            }

            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
        }
    }
}
