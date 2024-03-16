using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testscriptDoor : MonoBehaviour
{
    Animator animations;

    private void Awake()
    {
        animations = GetComponent<Animator>();
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
           animations.Play("DoorOpen");
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            animations.Play("DoorTremble");
        }
    }
}
