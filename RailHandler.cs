using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailHandler : MonoBehaviour
{
    Rail currentRail;
    public Component comp;
    Inventory inv;

    private void Start()
    {
        comp = GetComponent<Component>();
        inv = GameObject.FindGameObjectWithTag("EventController").GetComponent<Inventory>();
    }
    public void AddComponent()
    {
        if(inv.Inventory_Array[comp.Component_Type,comp.Component_Size] > 0)
        { 
        GetComponent<ReyUI>().activeRail.Test1(comp);
            // comp.Component_Type = 0;
            // comp.Component_Size = 0;
        }
    }

    public void setType(int wynaut)
    {
        comp.Component_Type = wynaut;
    }
    public void setSize(int wobuffet)
    {
        comp.Component_Size = wobuffet;
    }
}
