using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class CharacterController : MonoBehaviour
{
    #region Public Variables
    [Header("Settings")]
    [Range(5.0f, 10.0f)]
    public float movementSpeed = 5.0f;
    [Range(0.1f, 1.0f)]
    public float InterpolationFactor = 1.0f;

    #endregion

    #region Private Variables
    Vector3 currentPosition;
    Vector3 FinalPosition;
    Transform characterTransform;
    #endregion

    #region Lifecycle
    void Start()
    {
        characterTransform = transform;
        currentPosition = characterTransform.position;
        FinalPosition = currentPosition;
    }

    void Update()
    {
        currentPosition = characterTransform.position;
        FinalPosition.x += Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        FinalPosition.z += Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        characterTransform.position = Vector3.Lerp(currentPosition, FinalPosition, InterpolationFactor);
    }
    #endregion

}
