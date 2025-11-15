using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagementUtils : MonoBehaviour
{
    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Single);
    }
}
