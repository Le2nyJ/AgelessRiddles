using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinématicMaterials : MonoBehaviour
{
    [SerializeField] private List<Material> materials;
    float timeCounter = 0;
    [SerializeField] private float multiplier = 1;
    private float value = 0.02f;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        timeCounter += Time.fixedDeltaTime;
        if (timeCounter>=0.2)
        {
            foreach (Material mat in materials)
            {
                mat.SetFloat("_Color_Percentage", Mathf.Clamp(value, 0, 4));
            }
            timeCounter = 0;
        }
        
        value += multiplier;
        
    }
}
