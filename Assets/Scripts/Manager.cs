using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Manager : MonoBehaviour
{

    bool Bedroom = false;
    bool HallwayOne = false;


    //////////////////////////////





    ////////////////////////////////
    public Text DayCount;

    static public float Day = 1;



    bool taskUIIsOpen = false;

    

    public GameObject BedPrompt;
    public GameObject TaskPrompt;
    public GameObject BedSelected;
    public GameObject GameComplete;
    public GameObject TimeCount;

    public GameObject deskSelected;


    // Start is called before the first frame update
    void Start()
    {
        
        

        BedPrompt.SetActive(false);
        TaskPrompt.SetActive(false);
        BedSelected.SetActive(false);
        GameComplete.SetActive(false);
        taskUIIsOpen = false;

        deskSelected.SetActive(false);

    }

    public void DeskSelected()
    {
        FindObjectOfType<AudioManager>().Play("Select");
        deskSelected.SetActive(true);
        TaskPrompt.SetActive(false);
        taskUIIsOpen = false;
    }

    public void DeskTask()
    {
        FindObjectOfType<AudioManager>().Play("Select");
        deskSelected.SetActive(false);
        
    }








    public void BedPromptShow()
    {
        FindObjectOfType<AudioManager>().Play("Select");
        BedPrompt.SetActive(true);
    }

    public void BedPromptCloseYes()
    {
        FindObjectOfType<AudioManager>().Play("Select");
        BedPrompt.SetActive(false);
        Day++;
        DayCount.text = Day.ToString("Day " + Day);
        Debug.Log("Next Day");
        BedSelected.SetActive(false);

        

        if (Day == 3)
        {
            GameComplete.SetActive(true);
        }


    }

    public void BedPromptCloseNo()
    {
        FindObjectOfType<AudioManager>().Play("Select");
        BedPrompt.SetActive(false);
    }

    public void TaskPromptShow()
    {
        if (taskUIIsOpen == false)
        {
            FindObjectOfType<AudioManager>().Play("Select");
            TaskPrompt.SetActive(true);
            taskUIIsOpen = true;
        }else
        {
            FindObjectOfType<AudioManager>().Play("Select");
            TaskPrompt.SetActive(false);
            taskUIIsOpen = false;
        }

    }

    public void TaskPromptClose()
    {
        if (taskUIIsOpen == true)
        {
            FindObjectOfType<AudioManager>().Play("Select");
            TaskPrompt.SetActive(false);
            taskUIIsOpen = false;
            
        }

    }


    //Tasks

    public void SleepTask()
    {
        FindObjectOfType<AudioManager>().Play("Select");
        TaskPrompt.SetActive(false);
        BedSelected.SetActive(true);
        taskUIIsOpen = false;

    }

    public void BeanBagTask()
    {
        FindObjectOfType<AudioManager>().Play("Select");
        TaskPrompt.SetActive(false);
        BedSelected.SetActive(true);
        taskUIIsOpen = false;
    }

    public void SaveGame()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/MySaveData.dat");
        Data data = new Data();

        Debug.Log(Application.persistentDataPath);

        data.dayNumber = Day;

        bf.Serialize(file, data);
        file.Close();
        

    }

    public void LoadGame()
    {
        if (File.Exists(Application.persistentDataPath + "/MySaveData.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/MySaveData.dat", FileMode.Open);
            Data data = (Data)bf.Deserialize(file);

            Day = data.dayNumber;


            Debug.Log(data.dayNumber);
            DayCount.text = Day.ToString("Day " + Day);
        } 
        else
        {
            Day = 1f;
            DayCount.text = Day.ToString("Day " + Day);
        }

    }

    public void NewGame()
    {
        Day = 1f;
        DayCount.text = Day.ToString("Day " + Day);

        SaveGame();
    }

    

  

    public void Update()
    {
        
    }




 
}
