using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public static Action OnMinuteChanged;
    public static Action OnHourChanged;

    public static int Minute { get; private set; }
    public static int Hour { get; private set; }

    private float minuteToRealTime = 5f;
    private float timer;

    public TextMeshProUGUI timeText;

    public Slider health;



    void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        Minute = 30;
        Hour = 7;
        timer = minuteToRealTime;
        Debug.Log("Time Updated4");
        timeText.text = $"{TimeManager.Hour:00}:{TimeManager.Minute:00}";
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer <=0)
        {
            Minute = Minute + 10;
            OnMinuteChanged?.Invoke();
            if(Minute >= 60)
            {
                Hour++;
                Minute = 0;
                OnHourChanged?.Invoke();
            }

            timer = minuteToRealTime;
        }

        if (Minute >= 60)
        {
            Hour++;
            Minute = 0;
            OnHourChanged?.Invoke();
        }

        if (Hour >= 24 && Minute >= 0)
        {
            Hour = 0;
            Minute = 0;
            timeText.text = $"{TimeManager.Hour:00}:{TimeManager.Minute:00}";

            
            Debug.Log("Time Updated");

        }

       

    }

    public void TenMinutes()
    {
        Minute = Minute + 10;
        timeText.text = $"{TimeManager.Hour:00}:{TimeManager.Minute:00}";
    }
    public void TwentyMinutes()
    {
        Minute = Minute + 20;
        timeText.text = $"{TimeManager.Hour:00}:{TimeManager.Minute:00}";
    }
    public void ThirtyMinutes()
    {
        Minute = Minute + 30;
        timeText.text = $"{TimeManager.Hour:00}:{TimeManager.Minute:00}";
    }
    public void OneHour()
    {
        Hour = Hour + 1;
        timeText.text = $"{TimeManager.Hour:00}:{TimeManager.Minute:00}";
    }
    public void TwoHour()
    {
        Hour = Hour + 2;
        timeText.text = $"{TimeManager.Hour:00}:{TimeManager.Minute:00}";
    }
}
