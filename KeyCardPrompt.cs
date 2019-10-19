using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCardPrompt : MonoBehaviour
{
    public CanvasGroup pickupPrompt;
    // Start is called before the first frame update
    private void Start()
    {
        pickupPrompt = GameObject.FindGameObjectWithTag("InteractPrompt").GetComponent<CanvasGroup>();
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            pickupPrompt.alpha = 1f;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E) && other.tag == "Player")
        { 
            pickupPrompt.alpha = 0;
            Security_Clearance.Clearance_Raise(other.GetComponent<Security_Clearance>(), GetComponent<Security_Clearance>());
            Destroy(transform.parent.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            pickupPrompt.alpha = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
