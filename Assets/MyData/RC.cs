using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RC : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 resetPosition;
    public float x = 286.5875f, y=-120.865f,z=-476.1098f;
    private void Awake()
    {
        // create a new object and make it parent of this object
        // var parent = new GameObject("CameraParent").transform;
        // GameObject.Find("CameraParent").transform.position = new Vector3(x,y,z);
        // parent = GameObject.Find("CameraParent").transform;
        resetPosition = new Vector3(x,y,z);

        // transform.SetParent(parent);
    }

    // You should use LateUpdate
    // because afaik the oculus position is updated in the normal
    // Update so you are sure it is already done for this frame
    private void LateUpdate()
    {
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
            Debug.Log("pressed");

            // reset parent objects position
            transform.position = resetPosition;
        // }
    }
}
