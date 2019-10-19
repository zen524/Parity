using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Public Vars
    public float minimumX = -60f;
    public float maximumX = 60f;

    public float sensitivity = 15f;
    public GameObject bigOrb;
    public float camDistModifier = 4f;

    public float minDistance=0;
    public float maxDistance=10f;
    
    // public Camera cam;
    public Camera cam;
    //Private Vars
    float rotationX = 0f;
    float rotationY = 0f;
    bool UIOpen = false;
    int numThingsOpen;


// Start is called before the first frame update
void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (!UIOpen)
        {
            camDistModifier -= 3f * Input.GetAxisRaw("Mouse ScrollWheel");
            camDistModifier = Mathf.Clamp(camDistModifier, minDistance, maxDistance);

            /*if (!GetComponentInChildren<CameraCollision>().IsCollision())
            {
                Vector3 vec = new Vector3(0, 1 * camDistModifier, -3 * camDistModifier);
                cam.transform.localPosition = vec;
            }*/

            rotationY += Input.GetAxis("Mouse X") * sensitivity;
            rotationX += Input.GetAxis("Mouse Y") * sensitivity;

            rotationX = Mathf.Clamp(rotationX, minimumX, maximumX);

        }
            bigOrb.transform.localEulerAngles = new Vector3(0, rotationY, 0);
            transform.localEulerAngles = new Vector3(-rotationX, 0, 0);
        
    }

    public void OpenUI()
    {
        numThingsOpen++;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        UIOpen = true;
    }
    public void CloseUI()
    {
        numThingsOpen--;
        if (numThingsOpen < 1)
        {
            Cursor.lockState = CursorLockMode.Locked;
            UIOpen = false;
        }
    }

    public float GetDistance()
    {
        return (camDistModifier);
    }

}
