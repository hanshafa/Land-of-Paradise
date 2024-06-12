using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    FadeInOut fade;
    public void Start()
    {
        fade = FindObjectOfType<FadeInOut>();
    }


    public IEnumerator Next_Scene()
    {
        fade.FadeIn();
        yield return new WaitForSeconds(1);
        FindObjectOfType<ManageSceneAll>().ExitGame();
    }
    public void OnTriggerEnter2D()
    {

        StartCoroutine(Next_Scene());
    }
   
}
