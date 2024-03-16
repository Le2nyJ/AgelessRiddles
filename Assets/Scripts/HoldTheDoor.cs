using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldTheDoor : MonoBehaviour
{
    protected GameObject _gameManager;
    private bool Block = true;
    [SerializeField] int questIndex;
    // Start is called before the first frame update
    void Start()
    {
        _gameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        if (Block)
        {
            if(_gameManager.GetComponent<CurrentEnigme>().getCurrentEnigmeID() >= questIndex) 
            { 
                GetComponent<BoxCollider>().enabled = false;
            }
        }
    }
}
