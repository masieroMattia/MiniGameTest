using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

[DisallowMultipleComponent]
public class ButtonSceneHandler : MonoBehaviour
{
    #region Public Variables
    public string sceneToLoad = "ProgressBar";
    public LoadSceneMode loadSceneMode = LoadSceneMode.Single;
    #endregion

    #region Public Methods
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad, loadSceneMode);
    }
    #endregion
}