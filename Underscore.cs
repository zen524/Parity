using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Underscore : MonoBehaviour
{
    public float rate;
    public float flashWait;
    bool flashing = false;
    bool rising = true;

    CanvasGroup canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<CanvasGroup>();
        canvas.alpha = 0;
        Invoke("StartFlash", flashWait);
    }

    // Update is called once per frame
    void Update()
    {
        if (flashing)
        {
            if (rising)
            {
                canvas.alpha += Time.deltaTime * rate;
            }
            else
            {
                canvas.alpha -= Time.deltaTime * rate;
            }

            if(canvas.alpha >= 1 || canvas.alpha <= .1)
            {
                rising = !rising;
            }
        }
    }

    void StartFlash()
    {
        flashing = true;
        rising = true;
        canvas.alpha = .1f;
    }
}
