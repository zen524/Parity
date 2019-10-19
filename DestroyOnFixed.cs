using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnFixed : MonoBehaviour
{
    // Start is called before the first frame update
    public Rail triggerRail;

    // Update is called once per frame
    void Update()
    {
        if(triggerRail.Fixed)
        {
            Destroy(transform.gameObject);
        }
    }
}
