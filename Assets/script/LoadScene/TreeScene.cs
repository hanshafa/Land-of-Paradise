using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TreeScene : MonoBehaviour
{
    FadeInOut fade;
    private void Start()
    {
        fade = FindObjectOfType<FadeInOut>();
    }

    public IEnumerator Tree_Scene()
    {
        fade.FadeIn();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("A1");

    }
    private void OnTriggerEnter2D()
    {
        StartCoroutine(Tree_Scene());
    }
}
