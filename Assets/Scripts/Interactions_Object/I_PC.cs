using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class I_PC : Interactable_Object
{
    [SerializeField] private Text entry;
    [SerializeField] private GameObject msnUI;
    [SerializeField] private AudioManager audioManager;
    private bool gotPassword = false;
    private bool Looged = false;
    private bool isTyping = false;
    private string password="511369";

    void Start()
    {
        startSetup();
    }

    void Update()
    {
        updateSetup();

        if(isTyping)
        {
             if(Input.GetKeyDown(KeyCode.Return) &&  entry.text==password)
            {
                gotPassword = true;
                Interaction();
                entry.text = "";
            }
        }
        if (gotPassword && Input.GetKeyDown(KeyCode.E))
        {
            entry.text = "";
            msnUI.SetActive(false);
            gotPassword = false;
        }
    }
    protected override void Interaction()
    {
        if (!gotPassword)
        {
            GetComponent<InteracitveUI>().changeUIState();
            isTyping = !isTyping;
        }
        else
        {
            if (!Looged)
            {
                Looged = true;
                msnUI.SetActive(true);
                _gameManager.GetComponent<CurrentEnigme>().setCurrentEnigmeID(7);
                _gameManager.GetComponent<CurrentEnigme>().GO_PopUpSystem.GetComponent<PopUpSystem>().MessageList(7);
                audioManager.PlaySFX(2);
            }
        }
    }
}
