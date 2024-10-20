using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechanger : MonoBehaviour
{
    //name of the scene to load 
    public string sceneName;

    public void OnMouseDown()
    {
        //load scene
        SceneManager.LoadScene(sceneName);
    }
}
