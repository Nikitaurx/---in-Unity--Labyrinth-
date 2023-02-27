using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenu;
    private Reference _reference;
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }
    void Awake()
    {
        _reference = new Reference();
    }

    // Update is called once per frame
    void Update()
    {
        // if (isPaused)
        // {
        //     Cursor.lockState = CursorLockMode.None;
        // }
        // else Cursor.lockState = CursorLockMode.Locked;
        // if (Input.GetKeyDown(KeyCode.Escape))
        // {
        //     if (isPaused)
        //     {
        //         Resume();
        //     }
        //     else
        //     {
        //         Pause();
        //     }
        // }
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void ResumeButton()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //_reference.FinishScreen.gameObject.SetActive(false);
        //_reference.FinishScreen.gameObject.Destroy();
        Destroy(_reference.FinishScreen.gameObject);
        Destroy(_reference.LoseScreen.gameObject);
    }
    public void ExitButton()
    {
        Application.Quit();
    }
}
