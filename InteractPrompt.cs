using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractPrompt : MonoBehaviour
{

    Inventory_Controller invCon;
    CanvasGroup pickupPrompt;

    [SerializeField]
    int pickupType;
    [SerializeField]
    int pickupSize;
    public int securityRequired;
    // Start is called before the first frame update
    private void Start()
    {
        invCon = GameObject.FindGameObjectWithTag("EventController").GetComponent<Inventory_Controller>();
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
            //What to do when this object is interacted with:
            if (GetComponentInParent<Component>() == true)
            {
                pickupPrompt.alpha = 0;
                Component parentComp = GetComponentInParent<Component>();
                invCon.Add(parentComp);
                Destroy(transform.parent.gameObject);


                //Destroy(this.gameObject);
            }
            else if(GetComponentInParent<Component>() == false)
            {
                if (GameObject.FindGameObjectWithTag("Player").GetComponent<Security_Clearance>().Clearance_Level >= securityRequired)
                {
                    pickupPrompt.alpha = 0;
                    Destroy(transform.parent.gameObject);
                }
            }
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
