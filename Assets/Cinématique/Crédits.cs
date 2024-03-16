using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Crédits : MonoBehaviour
{
    [SerializeField] private GameObject textHolder;
    [SerializeField] private float speed = 1.0f;
    [SerializeField] private Material material;
    private RectTransform textHolderRectTransform;
    float timeCounter=0;

    // Update is called once per frame
    void Start()
    {
        textHolderRectTransform=textHolder.GetComponent<RectTransform>();
    }
    void Update()
    {
        timeCounter += Time.deltaTime;
        material.SetFloat("_Float", timeCounter);
        textHolderRectTransform.position += Vector3.up * speed * Time.deltaTime;
        if ( textHolderRectTransform.position.y > 2000)
        {
             textHolderRectTransform.position =new Vector3(  textHolderRectTransform.position.x,  -100,   textHolderRectTransform.position.z);
        }
    }
}
