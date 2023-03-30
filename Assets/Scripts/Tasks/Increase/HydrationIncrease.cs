using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HydrationIncrease: MonoBehaviour
{
    public HydrationBar hydrationBar;

    public int maxHydration = 20;
    public int currentHydration;

    // Start is called before the first frame update
    void Start()
    {
        currentHydration = maxHydration;
        hydrationBar.SetMaxHydration(maxHydration);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void increaseHydration(int increase)
    {
        Debug.Log("Hydration Increased");
        currentHydration += increase;
        hydrationBar.SetHydration(currentHydration);
    }

}
