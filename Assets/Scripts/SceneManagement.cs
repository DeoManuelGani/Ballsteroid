using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeScene (string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    // Update is called once per frame
    public void QuitApp()
    {
        Application.Quit();
    }
}
