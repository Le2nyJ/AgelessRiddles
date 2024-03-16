using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ExampleUI : MonoBehaviour
{
    [SerializeField] private List<Image> images=new List<Image>();


    // CECI EST UN CODE DEGEULASSE DE TEST FAIT A 5H DU MAT REALISE PAR UN PROFESSIONNEL VEUILLEZ NE PAS REPRODUIRE CHEZ VOUS
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            foreach(Image image in images) 
            {
                image.enabled = false;
            }
            images[0].enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            foreach (Image image in images)
            {
                image.enabled = false;
            }
            images[1].enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            foreach (Image image in images)
            {
                image.enabled = false;
            }
            images[2].enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            foreach (Image image in images)
            {
                image.enabled = false;
            }
            images[3].enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            foreach (Image image in images)
            {
                image.enabled = false;
            }
            images[4].enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            foreach (Image image in images)
            {
                image.enabled = false;
            }
            images[5].enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            foreach (Image image in images)
            {
                image.enabled = false;
            }
            images[6].enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            foreach (Image image in images)
            {
                image.enabled = false;
            }
            images[7].enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            foreach (Image image in images)
            {
                image.enabled = false;
            }
            images[8].enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            foreach (Image image in images)
            {
                image.enabled = false;
            }
            images[9].enabled = true;
        }
    }
}
