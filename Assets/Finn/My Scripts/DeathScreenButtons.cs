using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreenButtons : MonoBehaviour
{
    public void ChangeSceneButtonMain()
    {
        SceneManager.LoadScene("Main");
        Debug.Log("Change Scenes");
    }
    public void ChangeSceneButtonMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("loadscene1");
    }
    public void QuitButton()
    {
        Debug.Log("Quit!");
        Application.Quit();

    }
}
