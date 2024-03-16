using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class I_Graine : Interactable_Object
{
    [SerializeField] GameObject VaseVide;

    [SerializeField] GameObject Plants;
    //[SerializeField] GameObject Arbre;

    void Start()
    {
        //Arbre.SetActive(false);
        startSetup();        
    }

    void Update()
    {
        updateSetup();
    }

    protected override void Interaction()
    {
        if (_gameManager.GetComponent<CurrentEnigme>().isInChildWorld() && _gameManager.GetComponent<CurrentEnigme>().getCurrentEnigmeID() == nbrEnigme)
        {
            VaseVide.SetActive(false);
            Plants.SetActive(true);
            ///Arbre.SetActive(true);
            _gameManager.GetComponent<CurrentEnigme>().addCurrentEnigme();
            Img.gameObject.SetActive(false);
            ClearAdditionalMaterial();
            isShowingButton = false;
            isOnTrigger = false;
            this.GetComponent<I_Graine>().enabled = false;
        }
    }
}
