using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSpeed : MonoBehaviour
{
    GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("GoodBoy");
    }
    void Update()
    {
        Vector3 velo = player.GetComponent<Rigidbody>().velocity;

        Debug.Log(velo.ToString());
    }
}
