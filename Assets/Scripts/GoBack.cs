using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBack : MonoBehaviour
{
    public void GoBacking()
    {
        SceneManager.LoadScene("StartMenu");

    }
}
