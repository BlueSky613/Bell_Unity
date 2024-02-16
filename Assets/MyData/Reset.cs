using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using Unity.XR;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Management;
public class Reset : MonoBehaviour
{

    public Vector3 resetPosition;

    public float x = 286.5875f, y=-120.865f,z=-476.1098f;
    public GameObject XrRigCamera, ResetObject;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {

        
        // XrRigCamera.transform.position = ResetObject.transform.position;
        XrRigCamera.transform.position = new Vector3(x,y,z);
        // XrRigCamera.transform.Rotate(0,20.0f * Time.deltaTime, 0.0f);
        // RecenterVR();
        
        Debug.Log("Reset");
        // XROrigin.Move

    }


    [System.Obsolete]
    public void RecenterVR()
    {
        // Recenter the VR headset.

        var XRSet = XRGeneralSettings.Instance;
        var XRManager = XRSet.Manager;
        var XRLoader = XRManager.activeLoader;
        var XRInput = XRLoader.GetLoadedSubsystem<XRInputSubsystem>();
        XRInput.TryRecenter();



        // UnityEngine.XR.InputTracking.Recenter();

    }

    // private async void MoveCamera(Vector3 targetPos)
    // {
    //         var heightAdjustment = xrOrigin.Origin.transform.up * xrOrigin.CameraInOriginSpaceHeight;
    //         var cameraDestination = targetPos + heightAdjustment;
    //         xrOrigin.MoveCameraToWorldLocation(cameraDestination);

    // }
}
