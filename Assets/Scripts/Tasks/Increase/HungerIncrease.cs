using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungerIncrease: MonoBehaviour
{
    public HungerBar hungerBar;

    public int maxHunger = 20;
    public int currentHunger;

    // Start is called before the first frame update
    void Start()
    {
        currentHunger = maxHunger;
        hungerBar.SetMaxHunger(maxHunger);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void increaseHunger(int increase)
    {
        Debug.Log("Hunger Increased");
        currentHunger += increase;
        hungerBar.SetHunger(currentHunger);
    }

}
