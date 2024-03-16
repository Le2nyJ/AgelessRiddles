using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class I_Gateau : Interactable_Object
{
    private InteracitveUI interacitveUI;
    private bool added = false;
    // Start is called before the first frame update
    void Start()
    {
        startSetup();
        interacitveUI = GetComponent<InteracitveUI>();
    }

    // Update is called once per frame
    void Update()
    {
        updateSetup();
    }
    protected override void Interaction()
    {
        interacitveUI.changeUIState();
        if(!added && _gameManager.GetComponent<CurrentEnigme>().getCurrentEnigmeID()>=nbrEnigme) 
        {
            _gameManager.GetComponent<CurrentEnigme>().setCurrentEnigmeID(16);
            _gameManager.GetComponent<CurrentEnigme>().GO_PopUpSystem.GetComponent<PopUpSystem>().MessageList(16);
            added = true;
        }
        
    }
}
