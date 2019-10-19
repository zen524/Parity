using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InventoryDisplay : MonoBehaviour
{
    public Text sResUI;
    public Text mResUI;
    public Text lResUI;

    public Text sCapUI;
    public Text mCapUI;
    public Text lCapUI;

    public Text sIndUI;
    public Text mIndUI;
    public Text lIndUI;

    public Text sLo;
    public Text mLo;
    public Text lLo;

    public Text sHi;
    public Text mHi;
    public Text lHi;

    public Text sBand;
    public Text mBand;
    public Text lBand;

    Inventory inv;

    // Start is called before the first frame update
    void Start()
    {
        inv = GetComponent<Inventory>();
    }
    // Update is called once per frame
    void Update()
    { 
        sResUI.text = inv.Inventory_Array[1, 1].ToString();
        mResUI.text = inv.Inventory_Array[1, 2].ToString();
        lResUI.text = inv.Inventory_Array[1, 3].ToString();

        sCapUI.text = inv.Inventory_Array[2, 1].ToString();
        mCapUI.text = inv.Inventory_Array[2, 2].ToString();
        lCapUI.text = inv.Inventory_Array[2, 3].ToString();

        sIndUI.text = inv.Inventory_Array[3, 1].ToString();
        mIndUI.text = inv.Inventory_Array[3, 2].ToString();
        lIndUI.text = inv.Inventory_Array[3, 3].ToString();

        sLo.text = inv.Inventory_Array[4, 1].ToString();
        mLo.text = inv.Inventory_Array[4, 2].ToString();
        lLo.text = inv.Inventory_Array[4, 3].ToString();

        sHi.text = inv.Inventory_Array[5, 1].ToString();
        mHi.text = inv.Inventory_Array[5, 2].ToString();
        lHi.text = inv.Inventory_Array[5, 3].ToString();

        sBand.text = inv.Inventory_Array[6, 1].ToString();
        mBand.text = inv.Inventory_Array[6, 2].ToString();
        lBand.text = inv.Inventory_Array[6, 3].ToString();
    }
}
