using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class keepHeight : MonoBehaviour
{
    [SerializeField] float yValue;
    [SerializeField] private GameObject chocolate;
    [SerializeField] private Transform parentTransform;
    [SerializeField] private bool isWorldScale = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isWorldScale)
        {
            transform.position = new Vector3(transform.position.x, yValue, transform.position.z);
        }
        else
        {
            transform.localPosition = new Vector3(transform.localPosition.x, yValue, transform.localPosition.z);
        }
        
    }
    public void GrabChocolate()
    {
        chocolate.transform.parent= parentTransform;
        chocolate.transform.localPosition = Vector3.zero;
    }

}
