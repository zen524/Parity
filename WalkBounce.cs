using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkBounce : MonoBehaviour
{
    public float bounceHeight = 4;
    Rigidbody player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((player.transform.localPosition.y < 1.88f) && Input.GetKey(KeyCode.W))
        {
            player.AddForce(0, bounceHeight * 100f, 0, ForceMode.Impulse);
        }
    }
}