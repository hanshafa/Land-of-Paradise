using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    public bool questCompleted;

    public GameObject tandaTanya;


    public void CompleteQuest()
    {
        if(questCompleted)
        {
            tandaTanya.SetActive(false);
        }
    }
   


  
}
