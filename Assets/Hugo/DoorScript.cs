using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : Interactable_Object
{
    bool IsOpen = false;
    Animator animations;
    [SerializeField] private GameObject roof;
    [SerializeField] private GameObject otherSideDoor;
    [SerializeField] private GameObject otherSideRoof;
    [SerializeField] private AudioManager audioManager;

    private void Awake()
    {
        animations = GetComponent<Animator>();
    }
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
        if (!IsOpen && !_gameManager.GetComponent<CurrentEnigme>().isInChildWorld() && _gameManager.GetComponent<CurrentEnigme>().getCurrentEnigmeID() >= nbrEnigme)
        {
            animations.Play("DoorOpen");
            otherSideDoor.GetComponent<Animator>().Play("DoorOpen");
            _gameManager.GetComponent<CurrentEnigme>().addCurrentEnigme();
            roof.SetActive(false);
            otherSideRoof.SetActive(false);
            this.GetComponent<DoorScript>().enabled = false;
            if(_gameManager.GetComponent<CurrentEnigme>().getCurrentEnigmeID() > 4 )
            {
                audioManager.PlaySFX(0);
            }
            else
            {
                audioManager.PlaySFX(4);
            }
        }
        else
        {
            if (!IsOpen)
            {
                animations.Play("DoorTremble");
            }
        }
    }
}
