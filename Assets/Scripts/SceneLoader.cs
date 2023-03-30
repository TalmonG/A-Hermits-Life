using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SceneLoader : MonoBehaviour
{

    public GameObject PauseUI;
    public Text DayCount;
    float Day;



    void Start()
    {
        PauseUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            FindObjectOfType<AudioManager>().Play("Select");
            PauseUI.gameObject.SetActive(!PauseUI.gameObject.activeSelf);
        }

    }


    public void QuitButton()
    {
        FindObjectOfType<AudioManager>().Play("RoomToRoom");
        Application.Quit();
        Debug.Log("Application Quit");
    }

    public void MainMenu()
    {
        FindObjectOfType<AudioManager>().Play("RoomToRoom");
        SceneManager.LoadScene(0);
    }

    public void CreditsScene()
    {
        FindObjectOfType<AudioManager>().Play("RoomToRoom");
        SceneManager.LoadScene(1);
    }

    public void CutScene()
    {
        FindObjectOfType<AudioManager>().Play("RoomToRoom");
        SceneManager.LoadScene(2);
    }

    public void BedRoom()
    {
        FindObjectOfType<AudioManager>().Play("RoomToRoom");
        SceneManager.LoadScene(3);
    }

    public void HallwayOne()
    {
        FindObjectOfType<AudioManager>().Play("RoomToRoom");
        SceneManager.LoadScene(4);
    }

    public void HallwayTwo()
    {
        FindObjectOfType<AudioManager>().Play("RoomToRoom");
        SceneManager.LoadScene(5);
    }

    public void StorageRoom()
    {
        FindObjectOfType<AudioManager>().Play("RoomToRoom");
        SceneManager.LoadScene(6);
    }

    public void Kitchen()
    {
        FindObjectOfType<AudioManager>().Play("RoomToRoom");
        SceneManager.LoadScene(7);
    }

    public void Bathroom()
    {
        FindObjectOfType<AudioManager>().Play("RoomToRoom");
        SceneManager.LoadScene(8);
    }
    public void LivingRoom()
    {
        FindObjectOfType<AudioManager>().Play("RoomToRoom");
        SceneManager.LoadScene(9);
    }
    public void DialogueScene()
    {
        FindObjectOfType<AudioManager>().Play("RoomToRoom");
        SceneManager.LoadScene(10);
    }
    
}
