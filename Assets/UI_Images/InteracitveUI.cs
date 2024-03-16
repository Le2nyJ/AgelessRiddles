using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InteracitveUI : MonoBehaviour
{
    public GameObject interactiveUI;
    protected GameObject _gameManager;
    public bool isMoving = false;
    private void Start()
    {
        interactiveUI.SetActive(false);
        _gameManager = GameObject.Find("GameManager");
    }
    public void changeUIState()
    {
        if(!isMoving)
        {
            _gameManager.GetComponent<CurrentEnigme>().Player.GetComponent<CharacterController>().StopMouvInteract();
             isMoving = true;
            interactiveUI.SetActive(true);
        }
        else
        {
            _gameManager.GetComponent<CurrentEnigme>().Player.GetComponent<CharacterController>().StartMouvInteract();
            isMoving = false;
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("UIMerde"))
            {
                go.SetActive(false);
            }
        }
    }
    public void SetInteractiveUI( GameObject newUI)
    {

        interactiveUI = newUI;
    }
}
