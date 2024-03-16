using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    [SerializeField] private Camera adultCam;
    [SerializeField] private KeyCode switchKey;
    [SerializeField] private AnimationClip switchAnim;
    [SerializeField] private bool havingChololate;

    [SerializeField] private GameObject nteractibleKid;
    [SerializeField] private GameObject nteractibleAdult;
    [SerializeField] AudioManager audioManager;
    private Animator animator;
    private int adultCullingMask = 190, childCullingMask = 126;


    void Start()
    {
        animator = GetComponent<Animator>();
        audioManager.playSongs(0);
        adultCam.cullingMask = childCullingMask;
        havingChololate = true;
    }


    void Update()
    {
    }
    public void WorldSwitch()
    {
        if (havingChololate)
        {
            foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Interactable"))
            {
                Debug.Log("force exit ");
                obj.GetComponent<Interactable_Object>().forceExit();
            }

            if (adultCam.cullingMask == childCullingMask)
            {
                audioManager.playSongs(1);
                adultCam.cullingMask = adultCullingMask;
            }
            else
            {
                audioManager.playSongs(0);
                adultCam.cullingMask = childCullingMask;
            }
        }
    }
    public void triggerAnim()
    {
        if (!animator.GetCurrentAnimatorStateInfo(0).IsName(switchAnim.name))
        {
            animator.SetTrigger("switchWorld");
        }         
    }
}
