using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeyUI : MonoBehaviour
{

    CanvasGroup cg;
    CameraController camcam;
    bool isUp = false;
    // Start is called before the first frame update
    void Start()
    {
        camcam = GameObject.FindGameObjectWithTag("CamController").GetComponent<CameraController>();
        cg = GetComponent<CanvasGroup>();
        cg.blocksRaycasts = false;
        cg.alpha = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            if (isUp == false)//Brings the UI up 
            {
                cg.alpha = 1f;
                cg.blocksRaycasts = true;
                isUp = true;
                camcam.OpenUI();
            }
            else              //Closes the UI
            {
                cg.alpha = 0;
                cg.blocksRaycasts = false;
                isUp = false;
                camcam.CloseUI();
            }
        }
    }
}
