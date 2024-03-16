using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class I_Code : Interactable_Object
{

    void Start()
    {
        startSetup();
    }
    private void Update()
    {
        updateSetup();
    }
    protected override void Interaction()
    {
        GetComponent<InteracitveUI>().changeUIState();
    }
    

}
