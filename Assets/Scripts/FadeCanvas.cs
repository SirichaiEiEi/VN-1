using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeCanvas : MonoBehaviour
{
    public CanvasGroup myUIGroup;
    bool fadeIn = false;
    bool fadeOut = false;

    void ShowUI()
    {
        fadeIn = true;
    }

    void HideUI()
    {
        fadeOut = true;
    }

    void Update()
    {
        if (fadeIn)
        {
            if (myUIGroup.alpha < 1)
            {
                myUIGroup.alpha += Time.deltaTime / 1.5f;
                if (myUIGroup.alpha >= 1)
                {
                    fadeIn = false;
                }
            } 
        }

        if (fadeOut)
        {
            if (myUIGroup.alpha > 0)
            {
                myUIGroup.alpha -= Time.deltaTime / 2f;
                if (myUIGroup.alpha == 0)
                {
                    fadeOut = false;
                }
            }
        }

    }
}
