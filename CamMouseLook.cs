using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMouseLook : MonoBehaviour
{
    [SerializeField] private float mouseSensitivity;
    [SerializeField] private string LookX, LookY;

    [SerializeField] private Transform playerBody;

    private float xAxisClamp;

    void Awake()
    {
        xAxisClamp = 0.0f;
    }

    void Update()
    {
        RotateCamera();
    }

    // Update is called once per frame
    void RotateCamera()
    {
        float mouseX = Input.GetAxisRaw(LookX) * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxisRaw(LookY) * mouseSensitivity * Time.deltaTime;

        xAxisClamp += mouseY;

        if (xAxisClamp > 90.0f)
        {
            xAxisClamp = 90.0f;
            mouseY = 0.0f;
            ClampXAxisRotationToValue(270.0f);
        }

        else if (xAxisClamp < -90.0f)
        {
            xAxisClamp = -90.0f;
            mouseY = 0.0f;
            ClampXAxisRotationToValue(90.0f);
        }

        transform.Rotate(Vector3.left * mouseY);
        playerBody.Rotate(Vector3.up * mouseX);
    }
    void ClampXAxisRotationToValue(float value)
    {
        Vector3 eulerRotation = transform.eulerAngles;
        eulerRotation.x = value;
        transform.eulerAngles = eulerRotation;
    }
}
