using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseUi : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject settingsMenu;

    private void Start()
    {
        pauseMenu.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseMenu.activeSelf)
            {
                pauseMenu.SetActive(false);
            } else
            {
                pauseMenu.SetActive(true);
            }
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void Settings()
    {
        settingsMenu.SetActive(true);
    }

    public void Back()
    {
        pauseMenu.SetActive(false);
    }
}
