using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class I_Phone : Interactable_Object
{
    private InteracitveUI interactiveUI;

    // Start is called before the first frame update
    void Start()
    {
        startSetup();
        interactiveUI = GetComponent<InteracitveUI>();
    }

    // Update is called once per frame
    void Update()
    {
        updateSetup();
    }

    protected override void Interaction()
    {
        interactiveUI.changeUIState();
        switch (_gameManager.GetComponent<CurrentEnigme>().getCurrentEnigmeID())
        {
            case 7:
            case 10:
                _gameManager.GetComponent<CurrentEnigme>().addCurrentEnigme();
                break;
        }
    }

}
