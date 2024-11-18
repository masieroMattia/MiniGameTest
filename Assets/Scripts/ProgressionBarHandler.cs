using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ProgressionBarHandler : MonoBehaviour
{
    #region Public Variables
    public string sceneToLoad = "Playground";
    public LoadSceneMode loadSceneMode = LoadSceneMode.Single;
    #endregion
    #region Private variables
    AsyncOperation currentSceneLoad = null;
    [SerializeField]
    Scrollbar progressBar;
    [SerializeField]
    TextMeshProUGUI progressText = null;
    #endregion
    #region Lifecycle
    private void Start()
    {
        LoadScene();
        progressText.text = "0%";
    }

    void Update()
    {
        float progress = (currentSceneLoad.progress / 0.9f);
        progressBar.size = progress;
        progressText.text = $"{progress * 100}%";

        if (progress > 0.9f && Input.anyKeyDown)
            currentSceneLoad.allowSceneActivation = true;
    }
    #endregion
    public void LoadScene()
    {
        currentSceneLoad = SceneManager.LoadSceneAsync(sceneToLoad, loadSceneMode);
        currentSceneLoad.allowSceneActivation = false;
    }
}
