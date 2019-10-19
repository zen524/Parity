using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    public Rail railCheck;
    private void Update()
    {
        if(railCheck.Fixed == true)
        {
            GetComponent<Light>().color = Color.green;
        }
    }
}
