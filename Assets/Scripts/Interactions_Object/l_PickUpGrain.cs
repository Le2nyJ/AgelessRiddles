using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l_PickUpGrain : Interactable_Object
{
    protected InteracitveUI InteracitveUI;
    void Start()
    {
        startSetup();
        InteracitveUI = GetComponent<InteracitveUI>();
    }

    void Update()
    {
        updateSetup();
    }

    protected override void Interaction()
    {
        if (_gameManager.GetComponent<CurrentEnigme>().isInChildWorld() && _gameManager.GetComponent<CurrentEnigme>().getCurrentEnigmeID() == nbrEnigme)
        {
            _gameManager.GetComponent<CurrentEnigme>().addCurrentEnigme();
            Img.gameObject.SetActive(false);
            ClearAdditionalMaterial();
            isShowingButton = false;
            isOnTrigger = false;
            InteracitveUI.changeUIState();
            StartCoroutine("DestroyGrain");
           
        }
        else
            Debug.Log("sac pas la");
    }
    
    IEnumerator DestroyGrain()
    {
        yield return new WaitForSeconds(2);
        InteracitveUI.changeUIState();
        Destroy(gameObject);
    }
}
