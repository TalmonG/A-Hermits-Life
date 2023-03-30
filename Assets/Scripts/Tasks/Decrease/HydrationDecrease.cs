using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HydrationDecrease: MonoBehaviour
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

    public void decreaseHydration(int decrease)
    {
        currentHydration -= decrease;
        hydrationBar.SetHydration(currentHydration);
    }

}
