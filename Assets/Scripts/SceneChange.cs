using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string sceneName; // Name of the scene to be loaded

    // Function to change the scene by name
    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
