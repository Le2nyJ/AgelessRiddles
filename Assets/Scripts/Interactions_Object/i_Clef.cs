using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class i_Clef : Interactable_Object
{
    [SerializeField] AudioManager audioManager;
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
        if (_gameManager.GetComponent<CurrentEnigme>().isInChildWorld() && _gameManager.GetComponent<CurrentEnigme>().getCurrentEnigmeID() == nbrEnigme)
        {
            interacitveUI.changeUIState();
            StartCoroutine("HideUI");
            _gameManager.GetComponent<CurrentEnigme>().addCurrentEnigme();
            Img.gameObject.SetActive(false);
            ClearAdditionalMaterial();
            isShowingButton = false;
            isOnTrigger = false;
            
            audioManager.PlaySFX(1);
        }
    }

    IEnumerator HideUI()
    {
        yield return new WaitForSeconds(2);
        interacitveUI.changeUIState();
        Destroy(gameObject);
    }
}
