using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using static System.TimeZoneInfo;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;

    public float transitionTime = 1f;
    public Animator transition;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
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
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void LoadMenu(string sceneName)
    {
        Time.timeScale = 1f;
        FindFirstObjectByType<LevelLoaderTemplate>().LoadLevelByName(sceneName);
    }
    public void QuitGame()
    {
        Debug.Log("Quitting game, bruh did you seriously click this button?");
        Application.Quit();
    }
}


