using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   public void LoadSceneByName()
    {
        SceneManager.LoadScene("scenenamehere");
    }

    public void LoadNextInBuild()
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1)%3);
    }
}
