using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeSceneButton : MonoBehaviour
{
    public MainMenu menu;

    public void ChangeScene(string SceneName)
    {
        menu.OpenCloseMenu(false);
        SceneManager.LoadSceneAsync(SceneName);
    }
}
