using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthIncrease: MonoBehaviour
{
    public HealthBar healthBar;

    public int maxHealth = 20;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void incsreaseHealth(int increase)
    {
        Debug.Log("Health Increased");
        currentHealth += increase;
        healthBar.SetHealth(currentHealth);
    }

}
