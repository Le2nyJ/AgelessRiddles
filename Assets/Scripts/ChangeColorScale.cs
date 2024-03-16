using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeColorScale : MonoBehaviour
{
    [SerializeField] private List<Material> material;


    void Start()
    { 
        if(SceneManager.GetActiveScene().buildIndex==1)
        {
            SetAllColorScale(0.02f);
        }
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            SetAllColorScale(10f);
        }


    }
    private void Update()
    {
    }
    public void SetColorScale(int index, float value) 
    {
        if (material.Count - 1 >= index)
        {
            material[index].SetFloat("_Color_Percentage", value);
        }
        else
        {
            Debug.LogWarning("Exceeded materials list lenght");
        }
    }
    public void SetAllColorScale(float value)
    {
        foreach(Material mat in material)
        {
            mat.SetFloat("_Color_Percentage", value);
        }
    }
}
