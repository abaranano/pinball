using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public string SceneName;

    public void SceneChange()
    {
        SceneManager.LoadScene(SceneName);
    }
}
