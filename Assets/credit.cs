using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class credit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioManager>().playSongs(0); 
    }
}
