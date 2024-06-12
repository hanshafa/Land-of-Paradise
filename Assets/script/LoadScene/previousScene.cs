using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class previousScene : MonoBehaviour
{
    FadeInOut fade;
    private void Start()
    {
        fade = FindObjectOfType<FadeInOut>();
    }

    public IEnumerator Previous_Scene()
    {
        fade.FadeIn();
        yield return new WaitForSeconds(1);
        FindObjectOfType<gameManager>().LoadPreviousScene();

    }
    private void OnTriggerEnter2D()
    {
        StartCoroutine(Previous_Scene());
    }
}
