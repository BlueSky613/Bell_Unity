using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
// using UnityEngine.InputSystem.commonUsages;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class NewControllForStaff : MonoBehaviour
{
    // private XRController leftController;

    private void Start()
    {
        // Find the left XR controller in the scene
        // leftController = FindObjectOfType<XRController>();

        // if (leftController == null)
        // {
        //     Debug.LogError("Could not find XR Controller in the scene.");
        //     return;
        // }
    }

    private void Update()
    {
        // // Check if the primary button is pressed
        // bool primaryButtonPressed = leftController.inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue) && primaryButtonValue;

        // if (primaryButtonPressed)
        // {
        //     Debug.Log("Primary Button Pressed");
        // }

        // // Check if the secondary button is pressed
        // bool secondaryButtonPressed = leftController.inputDevice.TryGetFeatureValue(CommonUsages.secondaryButton, out bool secondaryButtonValue) && secondaryButtonValue;

        // if (secondaryButtonPressed)
        // {
        //     Debug.Log("Secondary Button Pressed");
        // }
    }
}
