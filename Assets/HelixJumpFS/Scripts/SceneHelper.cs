using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHelper : MonoBehaviour
{
    public void RestatrLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadLevel(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
