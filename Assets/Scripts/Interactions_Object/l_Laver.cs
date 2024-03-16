using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l_Laver : Interactable_Object
{
    void Start()
    {
        startSetup();
    }

    void Update()
    {
        updateSetup();
    }

    protected override void Interaction()
    {
        if (!_gameManager.GetComponent<CurrentEnigme>().isInChildWorld() && _gameManager.GetComponent<CurrentEnigme>().getCurrentEnigmeID() == nbrEnigme)
        {
            _gameManager.GetComponent<CurrentEnigme>().addCurrentEnigme();
            Img.gameObject.SetActive(false);
            ClearAdditionalMaterial();
            isShowingButton = false;
            isOnTrigger = false;
            this.GetComponent<l_Javel>().enabled = false;
        }
    }
}
