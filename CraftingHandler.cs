using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingHandler : MonoBehaviour
{
    Inventory_Controller invCon;
    Inventory inv;

    public void Start()
    {
        inv = GameObject.FindGameObjectWithTag("EventController").GetComponent<Inventory>();
        invCon = GameObject.FindGameObjectWithTag("EventController").GetComponentInChildren<Inventory_Controller>();
    }
    // Update is called once per frame
    public void CraftLo(int sze)
    {
        Debug.Log("Crafting Low-Pass of size " + sze);
        invCon.Low_Pass(true, sze);
    }
    public void BreakLo(int sze)
    {
        Debug.Log("Disassembling Low-Pass of size " + sze);
        invCon.Low_Pass(false, sze);
    }

    public void CraftHi(int sze)
    {
        Debug.Log("Crafting High-Pass of size " + sze);
        invCon.High_Pass(true, sze);
    }
    public void BreakHi(int sze)
    {
        Debug.Log("Disassembling High-Pass of size " + sze);
        invCon.High_Pass(false, sze);
    }

    public void CraftBand(int sze)
    {
        Debug.Log("Crafting Band-Pass of size " + sze);
        invCon.Band_Pass(true, sze);
    }
    public void BreakBand(int sze)
    {
        Debug.Log("Disassembling Band-Pass of size " + sze);
        invCon.Band_Pass(false, sze);
    }
}
