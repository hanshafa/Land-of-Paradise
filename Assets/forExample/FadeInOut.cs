using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInOut : MonoBehaviour
{

    public CanvasGroup cavasgroup;
    public bool fadein = false;
    public bool fadeout = false;

    public float TimeToFade;


    // Update is called once per frame
    void Update()
    {
        if(fadein == true)
        {
            if(cavasgroup.alpha < 1)
            {
                cavasgroup.alpha += TimeToFade * Time.deltaTime;
                if(cavasgroup.alpha >= 1)
                {
                    fadein = false;
                }
            }
        }
        if (fadeout == true)
        {
            if (cavasgroup.alpha >= 0)
            {
                cavasgroup.alpha -= TimeToFade * Time.deltaTime;
                if (cavasgroup.alpha == 0)
                {
                    fadeout = false;
                }
            }
        }
    }

    public void FadeIn()
    {
        fadein = true;
    }
    public void FadeOut()
    {
        fadeout = true;
    }

}
