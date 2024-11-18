using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class SpawnHandler : MonoBehaviour
{
    #region Public Variables
    public OrbitCamera cameraPrefab;
    #endregion
    #region Private Variables
    private OrbitCamera cameraInstance;
    private CharacterController characterInstance;
    #endregion
    #region Lifecycle
    private void Start()
    {
        CharacterController characterPrefab = CharacterSelection.selectedCharacter;
        characterInstance = Instantiate <CharacterController> (characterPrefab);
        cameraInstance = Instantiate <OrbitCamera> (cameraPrefab);
        cameraInstance.target = characterInstance.transform;
    }
    #endregion
}
