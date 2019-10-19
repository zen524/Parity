using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    public float rate = 1;
    public float titleWait = 2;
    bool rising = false;

    CanvasGroup titleText;

    void Start()
    {
        titleText = GetComponent<CanvasGroup>();
        titleText.alpha = 0;
        Invoke("StartFade", titleWait);
    }

    // Update is called once per frame
    void Update()
    {
        if (rising && titleText.alpha < 1)
        {
            titleText.alpha += Time.deltaTime * rate;
        }
    }
    void StartFade()
    {
        rising = true;
    }
}
