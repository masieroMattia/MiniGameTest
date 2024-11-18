using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class OrbitCamera : MonoBehaviour
{
    #region Public Variables
    [Header("Settings")]
    [Range(3.0f, 10.0f)]
    public float targetDistance = 5.0f;
    public Transform target;
    [SerializeField]
    public Vector3 targetOffset = new Vector3(0.0f, 0.5f, 0.0f);
    [Range(0.0f, 1.0f)]
    public float interpolationFactor = 0.5f;
    #endregion

    #region Private Variables
    private Vector3 lookDirection;
    private Quaternion lookRotation;

    private float maxVerticalAngle = 90.0f;
    private float minVerticalAngle = -40.0f;
    #endregion

    #region Lifecycle

    void LateUpdate()
    {
        Vector3 focus = target.position;
        Vector3 camPosition = transform.position;

        lookDirection = (focus - camPosition + targetOffset).normalized;
        lookRotation = Quaternion.LookRotation(lookDirection, Vector3.up);
        transform.rotation = lookRotation;

        float horizontalMovement = Input.GetAxis("Mouse X");
        float verticalMovement = Mathf.Clamp(Input.GetAxis("Mouse Y"), minVerticalAngle, maxVerticalAngle);
        Vector3 nextPosition = new Vector3(camPosition.x + horizontalMovement, camPosition.y + verticalMovement, targetDistance);

        transform.position = Vector3.Lerp(camPosition, nextPosition, interpolationFactor);

    }
    #endregion
}
