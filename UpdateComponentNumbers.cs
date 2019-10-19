using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateComponentNumbers : MonoBehaviour
{

    Inventory inv;
    Text text;
    public int componentType;
    public int componentSize;
    // Start is called before the first frame update
    void Start()
    {
        inv = GameObject.FindGameObjectWithTag("EventController").GetComponent<Inventory>();
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = inv.Inventory_Array[componentType, componentSize].ToString();
    }
}
