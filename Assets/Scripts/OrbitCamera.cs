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
    [Range(5.0f, 10.0f)]
    public float targetDistance = 5.0f;
    public Transform target;
    [SerializeField]
    public Vector3 targetOffset = new Vector3(0.0f, 1.0f, 0.0f);
    public float mouseSensitivity = 5.0f;
    #endregion

    #region Private Variables
    private Vector3 lookDirection;

    private float horizontalAngle = 0.0f;
    private float verticalAngle = 0.0f;

    private float maxVerticalAngle = 70.0f;
    private float minVerticalAngle = -30.0f;

    private Vector3 focus;
    private float nearTargetDistance = 2.0f;
    private Vector3 nearTargetOffset = new Vector3(0.0f, 2.0f, 0.0f);
    #endregion
    #region Lifecycle
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void LateUpdate()
    {
        focus = target.position + targetOffset;

        horizontalAngle += Input.GetAxis("Mouse X") * mouseSensitivity;
        horizontalAngle = (horizontalAngle + 360) % 360;

        verticalAngle += Input.GetAxis("Mouse Y") * mouseSensitivity;
        verticalAngle = Mathf.Clamp(verticalAngle, minVerticalAngle, maxVerticalAngle);

        // Debug.Log(verticalAngle);

        lookDirection = Quaternion.AngleAxis(horizontalAngle, Vector3.up) * Quaternion.AngleAxis(verticalAngle,Vector3.right) * Vector3.forward;

        transform.rotation = Quaternion.LookRotation(lookDirection, Vector3.up);

        transform.position = focus - lookDirection * targetDistance;
    }
    #endregion
}
