using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CurrentEnigme : MonoBehaviour
{
    [SerializeField] private int currentEnigmeID = 0;
    [SerializeField] int totalEnigme = 0;
    [SerializeField] bool isChild = false;
    [SerializeField] public RawImage Img;
    [SerializeField] public GameObject GO_PopUpSystem;
    [SerializeField] public GameObject Player;
    private Camera mainCam;
    private ChangeColorScale changeColorScript;
    private int adultCullingMask = 190, childCullingMask = 126;


    private void Start()
    {
        mainCam = Camera.main;
        changeColorScript=GetComponent<ChangeColorScale>();
        changeColorScript.SetAllColorScale(0.02f);
        GO_PopUpSystem.GetComponent<PopUpSystem>().MessageList(0);
    }
    private void Update()
    {
      
        
    }
    public int getCurrentEnigmeID()
    {
        return (currentEnigmeID);
    }

    public void setCurrentEnigmeID(int newID)
    {
        currentEnigmeID = newID;
    }
    public void addCurrentEnigme()
    {
        currentEnigmeID++;
        if (currentEnigmeID < totalEnigme)
        {
            GO_PopUpSystem.GetComponent<PopUpSystem>().MessageList(currentEnigmeID);
            changeColorScript.SetAllColorScale(((float)currentEnigmeID / (float)totalEnigme) * 8f);
        }
        else
            changeColorScript.SetAllColorScale(8f);
        CheckEnd();
    }

    public int getTotalEnigme()
    {
        return (totalEnigme);
    }

    private void CheckEnd()
    {
        Debug.Log("c'est fini");
    }
    public bool isInChildWorld()
    {
        if (mainCam.cullingMask == adultCullingMask)
            return false;
        return true;
    }

    
}
