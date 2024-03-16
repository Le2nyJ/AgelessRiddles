using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsUI : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    private void Start()
    {
        this.gameObject.SetActive(false);
    }

    public void SetMusic(float music)
    {
        audioMixer.SetFloat("Music", Mathf.Log10(music) * 20);

    }

    public void SetSfx(float sfx)
    {
        audioMixer.SetFloat("SFX", Mathf.Log10(sfx) * 20);
    }
    public void CloseWindow()
    {
        gameObject.SetActive(false);
    }
}
