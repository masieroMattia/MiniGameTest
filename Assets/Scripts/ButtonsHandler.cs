using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class SceneHandler : MonoBehaviour
{
    #region Public Variables
    public string sceneToLoad = "Playground";
    public LoadSceneMode loadSceneMode = LoadSceneMode.Additive;
    [SerializeField]
    Button marioButton;
    [SerializeField]
    Button mariaButton;
    #endregion

    #region Private Variables
    AsyncOperation currentSceneLoad = null;
    #endregion
        
    #region Lifecycle
    private void Update()
    {
        if (currentSceneLoad != null)
        {
            float progress = currentSceneLoad.progress;
        }
    }
    #endregion

    #region
    #endregion
}
