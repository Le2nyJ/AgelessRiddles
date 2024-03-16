using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class BathroomFilthScript : Interactable_Object
{
    [SerializeField] private GameObject block;
    [SerializeField] private GameObject trash;


    [SerializeField]  private Material _materialCockRoach;
    [SerializeField]  private Material _materialFilth;

    void Start()
    {
        startSetup();
        _materialCockRoach.SetFloat("_alpha", 1);
        _materialFilth.SetFloat("_alpha", -2);
        GetComponent<MeshRenderer>().materials[1].SetFloat("_alpha", -2);
    }

    void Update()
    {
        updateSetup();        
    }

    protected override void Interaction()
    {
        if (_gameManager.GetComponent<CurrentEnigme>().isInChildWorld() && _gameManager.GetComponent<CurrentEnigme>().getCurrentEnigmeID() >= nbrEnigme)
        {
            _materialCockRoach.SetFloat("_alpha", 0);
            trash.SetActive(false);
            _materialFilth.SetFloat("_alpha", 1);
            GetComponent<MeshRenderer>().materials[1].SetFloat("_alpha", 1);
            block.SetActive(false);
            _gameManager.GetComponent<CurrentEnigme>().addCurrentEnigme();
        }
    }
}
