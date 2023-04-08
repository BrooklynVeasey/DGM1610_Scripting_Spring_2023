using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Add UI library namespace

public class Health : MonoBehaviour
{

    public int maxHealth = 10;

    public int currentHealth;

    public int numberOfHearts;
    public Image[] hearts;
    public Sprite heartSprite_Full;
    public Sprite heartSprite_Empty;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        currentHealth = maxHealth;
    }

    void Update()
    {
        //currentHealth no more than number of hearts
        if(currentHealth > numberOfHearts)
        {
            currentHealth = numberOfHearts;
        }
        //populate hearts and manage on HUD UI
        for(int i =0; i < hearts.Length; i++)
        {
            if(i < currentHealth)
            {
                hearts[i].sprite = heartSprite_Full;
            }
            else
            {
                hearts[i].sprite = heartSprite_Empty;
            }
            if(i < numberOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }

    public void TakeDamage(int dmgAmount)
    {
        currentHealth -= dmgAmount;
        Debug.Log("Player Health = "+ currentHealth);

        if(currentHealth <=0)
        {
            Debug.Log("You are dead! Game Over!");
            Time.timeScale = 0; //freeze game
        }
    }

    public void AddHealth(int healAmount)
    {
        currentHealth += healAmount;

        if(currentHealth >= maxHealth) //max health cap
        {
            currentHealth = maxHealth;
        }
    }

}
