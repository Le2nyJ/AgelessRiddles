using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seethroug : MonoBehaviour
{
    [SerializeField] private Material WallMat;
    [SerializeField] private Camera MainCamera;
    [SerializeField] private LayerMask WallLayer;



    void Update()
    {
        var dir = MainCamera.transform.position - transform.position;
        var ray = new Ray(transform.position, dir.normalized);

        if ( Physics.Raycast(ray,3000,WallLayer))
            WallMat.SetFloat("_Size", 1f);
        else             
            WallMat.SetFloat("_Size", 0f);
        var view = Camera.main.WorldToViewportPoint(transform.position);
        WallMat.SetVector("_Position", view);
    }
}
