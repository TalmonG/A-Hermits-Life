using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PromptBox : MonoBehaviour
{
    public GameObject UiObject;
    // Start is called before the first frame update
    void Start()
    {
        UiObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PromptShow()
    {
        UiObject.SetActive(true);
    }

    public void PromptClose()
    {
        UiObject.SetActive(false);
    }
}
