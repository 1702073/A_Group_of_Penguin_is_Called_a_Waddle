using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public string sceneName;
    public string sceneName2;
    public GameObject PauseMenuUI;
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
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneName);
    }
    public void LoadMenu2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneName2);
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game, bruh did you seriously click this button?");
        Application.Quit();
    }
}


