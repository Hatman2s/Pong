using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausemenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseMenueUI;
    
    

    
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Itspaused();
            }
           
            else
            {
                Pause();
            }
           


        } 
    }
    public void Resume()
    {
        PauseMenueUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Pause()
    {
        PauseMenueUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void Itspaused()
    {

    }
}
