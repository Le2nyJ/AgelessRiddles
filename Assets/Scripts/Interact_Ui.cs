using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Interact_Ui : MonoBehaviour
{
    [SerializeField] CurrentEnigme m_currentEnigme;
    [SerializeField] TMP_FontAsset childFont;
    [SerializeField] TMP_FontAsset adultFont;
    [SerializeField] TMP_Text m_text;
    

    // Update is called once per frame
    void Update()
    {
        check();
    }
    void check()
    {
        if (m_currentEnigme.isInChildWorld())
        {
            m_text.font = childFont;
        }
        else
        {
            m_text.font = adultFont;
        }
    }
}
