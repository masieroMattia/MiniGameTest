using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotation : MonoBehaviour
{
    #region Public Variables
    // Settable rotation velocity of the character displayed
    [Range(20.0f, 40.0f)]
    public float rotationVelocity = 20.0f;
    #endregion
    #region Private Variables
    // Constant rotation value of rotation
    private const float rotationDistance = 1.0f;
    Transform characterTransform;
    #endregion
    #region Lifecycle
    void Start()
    {
        characterTransform = transform;
    }

    void Update()
    {
        // Calculating the character rotation around the y axis
        Quaternion currentRotation = characterTransform.rotation;
        float rotation = rotationDistance * rotationVelocity * Time.deltaTime;
        characterTransform.Rotate(Vector3.up, rotation);
    }
    #endregion
}
