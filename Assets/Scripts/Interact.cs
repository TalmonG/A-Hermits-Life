using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    public Text score;
    private int scoreAmount;
    // Start is called before the first frame update

    public void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        score.text = scoreAmount.ToString();
    }   
    public void PlusOneDay()
    {
        score = GetComponent<Text>();
        scoreAmount += 1;
        Debug.Log("Next Day");
    }


}
