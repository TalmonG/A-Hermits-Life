using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveFile : MonoBehaviour
{
    public int dayNumber;         //Current number of days



    void Start()
    {
        SaveFile mySaveFile = new SaveFile();

        dayNumber = mySaveFile.dayNumber;

       
    }



}
