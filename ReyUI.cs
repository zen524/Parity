using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReyUI : MonoBehaviour
{

    CanvasGroup cg;
    CanvasGroup mmg;
    CameraController camcam;
    bool isUp = false;
    public Rail activeRail; // If ActiveRail is 0, close the 
    // Start is called before the first frame update
    void Start()
    {
        activeRail = null;
        camcam = GameObject.FindGameObjectWithTag("CamController").GetComponent<CameraController>();
        cg = GetComponent<CanvasGroup>();
        mmg = GameObject.FindGameObjectWithTag("Multimeter").GetComponent<CanvasGroup>();
        cg.alpha = 0;
        cg.blocksRaycasts = false;
        mmg.alpha = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (isUp == false && activeRail != null)//Brings the UI up 
        {
            cg.alpha = 1f;
            cg.blocksRaycasts = true;
            mmg.alpha = 1f;
            isUp = true;
            camcam.OpenUI();
        }
        else if(isUp == true && activeRail == null)              //Closes the UI
        {
            cg.alpha = 0;
            cg.blocksRaycasts = false;
            mmg.alpha = 0;
            isUp = false;
            camcam.CloseUI();
        }
    }

    public void OpenRail(Rail rayal)
    {
        activeRail = rayal;
    }
    public void CloseRail()
    {
        activeRail = null;
    }
}
