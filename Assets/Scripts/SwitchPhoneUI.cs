using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPhoneUi : MonoBehaviour
{
    private I_Phone phone;
    private InteracitveUI interacitveUI;
    [SerializeField] const int ContactNumEnigme = 8;
    [SerializeField] private GameObject ContactinteractiveUI;
    [SerializeField] const int LeaNumEnigme = 7;
    [SerializeField] private GameObject LeainteractiveUI;
    [SerializeField] const int MomNumEnigme = 10;
    [SerializeField] private GameObject MominteractiveUI;
    protected GameObject _gameManager;
    // Start is called before the first frame update
    void Start()
    {
        phone = GetComponent<I_Phone>();
        interacitveUI = GetComponent<InteracitveUI>();
        _gameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        if (!interacitveUI.isMoving)
            interacitveUI.interactiveUI.SetActive(false);
        switch (_gameManager.GetComponent<CurrentEnigme>().getCurrentEnigmeID())
        {
            case MomNumEnigme:
                interacitveUI.SetInteractiveUI(MominteractiveUI);
                break;
            case LeaNumEnigme:
                interacitveUI.SetInteractiveUI(LeainteractiveUI);
                break;
            case int n when n >= ContactNumEnigme:
                interacitveUI.SetInteractiveUI(ContactinteractiveUI);
                break;
        }
    }
}
