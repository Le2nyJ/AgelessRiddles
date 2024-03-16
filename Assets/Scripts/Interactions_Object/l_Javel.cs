using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l_Javel : Interactable_Object
{
    protected InteracitveUI interacitveUI;
    void Start()
    {
        startSetup();
        interacitveUI = GetComponent<InteracitveUI>();
    }

    void Update()
    {
        updateSetup();
    }

    protected override void Interaction()
    {
        if (_gameManager.GetComponent<CurrentEnigme>().isInChildWorld() && _gameManager.GetComponent<CurrentEnigme>().getCurrentEnigmeID() == 9)
        {
            _gameManager.GetComponent<CurrentEnigme>().addCurrentEnigme();
            Img.gameObject.SetActive(false);
            ClearAdditionalMaterial();
            isShowingButton = false;
            isOnTrigger = false;
        }
        if (_gameManager.GetComponent<CurrentEnigme>().isInChildWorld() && _gameManager.GetComponent<CurrentEnigme>().getCurrentEnigmeID() == 12)
        {
            _gameManager.GetComponent<CurrentEnigme>().addCurrentEnigme();
            Img.gameObject.SetActive(false);
            ClearAdditionalMaterial();
            isShowingButton = false;
            isOnTrigger = false;
            interacitveUI.changeUIState();
            StartCoroutine("HideUI");
            
        }

    }

    IEnumerator HideUI()
    {
        Debug.Log("in");
        yield return new WaitForSeconds(2);
        Debug.Log("out");
        interacitveUI.changeUIState();
        this.GetComponent<l_Javel>().enabled = false;
    }
}
