using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenuUI.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false); 
        Time.timeScale = 1f;          
        GameIsPaused = false;
        Debug.Log("Game resumed");
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);  
        Time.timeScale = 0f;          
        GameIsPaused = true;
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game quitted");
    }
}
