using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void LoadSceneByName(string Game)
    {
        SceneManager.LoadScene(Game);
    }

}