using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadMenuToQuiz : MonoBehaviour
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
        FindObjectOfType<gameManager>().LoadMenuToQuiz();
    }
    public void OnTriggerEnter2D()
    {
        StartCoroutine(Next_Scene());
    }
}