using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class l_Arbre : Interactable_Object
{
    protected InteracitveUI interacitveUI;
    private void Start()
    {
        startSetup();
        interacitveUI = GetComponent<InteracitveUI>();
    }
    private void Update()
    {
        updateSetup();
    }
    protected override void Interaction()
    {
        bool isTime = false;        
        if (!_gameManager.GetComponent<CurrentEnigme>().isInChildWorld() && _gameManager.GetComponent<CurrentEnigme>().getCurrentEnigmeID() == nbrEnigme)
        {
            DonneLaClef();
        }
    }
    private void DonneLaClef()
    {
            interacitveUI.changeUIState();
            StartCoroutine("HideUI");
            _gameManager.GetComponent<CurrentEnigme>().addCurrentEnigme();
            Img.gameObject.SetActive(false);
            ClearAdditionalMaterial();
            isShowingButton = false;
            isOnTrigger = false;
            this.GetComponent<l_Arbre>().enabled = false;
    }

    IEnumerator HideUI()
    {
        yield return new WaitForSeconds(2);
        interacitveUI.changeUIState();
    }
}
