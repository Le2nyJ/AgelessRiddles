using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Interactable_Object : MonoBehaviour
{
    [SerializeField] protected RawImage Img;
    [SerializeField] protected bool isOnTrigger;
    [SerializeField] KeyCode keyName=KeyCode.E;
    [SerializeField] public Material outlineMat;
    protected GameObject _gameManager;
    protected GameObject _audioManager;
    [SerializeField] protected int nbrEnigme = 0;
    [SerializeField] protected bool isShowingButton = false;
    [SerializeField] protected bool alwaysInteractable = false;
    bool isPressed = false;

    protected void startSetup()
    {
        isOnTrigger = false;
        _gameManager = GameObject.Find("GameManager");
        _audioManager = GameObject.Find("AudioManager");
        Img = _gameManager.GetComponent<CurrentEnigme>().Img;

        StartCoroutine("fdp");
    }

    IEnumerator fdp()
    {
        yield return new WaitForSeconds(1);
        forceExit();
    }

    protected void updateSetup()
    {
        if (WhoIsEnigme(nbrEnigme) == _gameManager.GetComponent<CurrentEnigme>().isInChildWorld())
        {
            if (isOnTrigger)
            {
                if (!isShowingButton) { 
                    Img.gameObject.SetActive(true);
                    SetAdditionalMaterial(outlineMat);
                    isShowingButton = true;
                }
                if (Input.GetKeyDown(keyName) )
                {
                    if(_gameManager.GetComponent<CurrentEnigme>().getCurrentEnigmeID() >= nbrEnigme || alwaysInteractable)
                    {
                        Interaction();

                    }
                    else
                    {
                        int i = Random.Range(1, 4);
                        _gameManager.GetComponent<CurrentEnigme>().GO_PopUpSystem.GetComponent<PopUpSystem>().ErrorMessage(i);
                        _audioManager.GetComponent<AudioManager>().PlaySFX(5);
                        StartCoroutine("ShowIndice");
                    }
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.layer == 6 && _gameManager.GetComponent<CurrentEnigme>().isInChildWorld()  || gameObject.layer == 7 && !_gameManager.GetComponent<CurrentEnigme>().isInChildWorld())
        {
            Debug.Log("Enter");
            Img.gameObject.GetComponentInChildren<TextMeshProUGUI>().SetText("Press " + keyName.ToString());
            isOnTrigger = true;
        }
    }

    public void forceExit()
    {
        if (isShowingButton)
        {
            Img.gameObject.SetActive(false);
            ClearAdditionalMaterial();
            isShowingButton = false;
            isOnTrigger = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (isShowingButton)
        {
            Img.gameObject.SetActive(false);
            ClearAdditionalMaterial();
            isShowingButton = false;
            isOnTrigger = false;            
        }
    }

    protected virtual void Interaction()
    {
    }

    public void SetAdditionalMaterial(Material newMaterial)
    {
        Material[] materialsArray = new Material[(this.GetComponent<Renderer>().materials.Length + 1)];
        this.GetComponent<Renderer>().materials.CopyTo(materialsArray, 0);
        materialsArray[materialsArray.Length - 1] = newMaterial;
        this.GetComponent<Renderer>().materials = materialsArray;
    }

    public void ClearAdditionalMaterial()
    {
        Material[] materialsArray = new Material[(this.GetComponent<Renderer>().materials.Length - 1)];
        for (int i = 0; i < this.GetComponent<Renderer>().materials.Length - 1; i++)
        {
            materialsArray[i] = this.GetComponent<Renderer>().materials[i];
        }
        this.GetComponent<Renderer>().materials = materialsArray;
    }

    public bool WhoIsEnigme(int nbr)
    {
        switch (nbr)
        {
            case 0:
            case 1:
            case 4:
            case 6:
            case 9:
            case 11:
            case 12:
            case 13:
                return true;
            default:
                return false;
        }
    }

    IEnumerator ShowIndice()
    {
        yield return new WaitForSeconds(2);
        _gameManager.GetComponent<CurrentEnigme>().GO_PopUpSystem.GetComponent<PopUpSystem>().MessageList(_gameManager.GetComponent<CurrentEnigme>().getCurrentEnigmeID());
    }
}
