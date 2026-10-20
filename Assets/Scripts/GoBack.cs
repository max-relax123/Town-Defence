using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBack : MonoBehaviour
{
   public void Back()
    {
        SceneManager.LoadScene("StartMenu");

    }
}
