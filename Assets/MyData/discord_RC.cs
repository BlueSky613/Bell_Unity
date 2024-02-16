using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using Unity.XR.CoreUtils;

public class discord_RC : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform TargetTransform;
    [SerializeField] Transform rigTransform;
    [SerializeField] Transform cameraTransform;

    public XROrigin xrOrigin;
    
    //Drop this script on your XR Origin
    public Transform ResetPositionObject; //You can use that to just make empty object in scene and use it as a reset position
    public float x = 286.5875f, y=-60.865f,z=-476.1098f;
    public int k = 0;
    public Vector3 VectorPosition; //Or you can use this to manually set values for position
    
    void Start()
    {
        VectorPosition = new Vector3(x,y,z);
        xrOrigin = transform.GetComponent<XROrigin>();
        k = 0;
        // HandleReposition();
        // HandleRerotation();
    }


    // Update is called once per frame
    void Update()
    {
        // if (k == 0) 
            {
                Debug.Log("reset");
                ResetPositionMethod();
                // HandleReposition();
                // HandleRerotation();
                k = 1;
            }
    }

    public void ResetPositionMethod()//Call this method to reset position
    {
        // Time.timeScale = 0;
        // if (ResetPositionObject != null) transform.position = VectorPosition;
        // else if (VectorPosition != null) transform.position = VectorPosition;
        // else Debug.Log("None position is set");

        if (ResetPositionObject != null)
        {
            // transform.position = ResetPositionObject.position;
            xrOrigin.MoveCameraToWorldLocation(ResetPositionObject.position);
            xrOrigin.MatchOriginUpCameraForward(ResetPositionObject.rotation* Vector3.up, ResetPositionObject.rotation* Vector3.forward); 
            // xrOrigin.MatchOriginUpCameraForward( Vector3.up,  Vector3.forward); 
        

            Debug.Log("position reseted-ResetPositionObject "); 

        }
    }

    // private void HandleReposition()
    // {
    //     Vector3 cameraPositionXZ = new Vector3(cameraTransform.position.x, 0, cameraTransform.position.z);
    //     Vector3 difference = TargetTransform.position - cameraPositionXZ;
    //     rigTransform.position += difference;
    // }

    // private void HandleRerotation()
    // {
    //     float yaw = TargetTransform.eulerAngles.y - cameraTransform.eulerAngles.y;
    //     rigTransform.RotateAround(cameraTransform.position, Vector3.up, yaw);
    // }

    // private void OnAnimatorIK(int layerIndex) {
        
    // }
}
