using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    FadeInOut fadeIn;

    private void Start()
    {
        fadeIn = GetComponent<FadeInOut>();
        fadeIn.FadeOut();

    }
}
