using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public float x = 17;
    public float y = 2;
    public float z = 30;
    Vector3 respawn;

    void Start()
    {
        respawn = new Vector3(x, y, z);
    }
    void OnTriggerEnter(Collider other)
    {
        //print("Something fell");
        if (other.tag == "Player")
        {
            GameObject victim = other.transform.parent.gameObject;
            victim.transform.localPosition = respawn;
            //print("Player fell out of the map");
        }
    }
}
