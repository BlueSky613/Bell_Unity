using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BellSound1 : MonoBehaviour
{
    
    // public GameObject elevator, wooder, xrRig, bell;
    

    // Quaternion currentRotation;
    private AudioSource HitSource;


    // Start is called before the first frame update
    void Start()
    {
        HitSource = GameObject.Find("GroundTrigger (1)").GetComponent<AudioSource>();
        // currentRotation.eulerAngles = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        
          HitSource.Play();
        // Debug.Log("XR Rig Ground");
        // if (other.gameObject.name == "GroundTrigger")
        // Debug.Log("XD");
        // elevator.transform.position = new Vector3(elevator.transform.position.x, -120.77f, elevator.transform.position.z);
        
        
        // bell.transform.position = new Vector3(287.394f, 238.723f, -473.847f);
        // Debug.Log(bell.transform.position.y);
        // xrRig.transform.position = new Vector3(xrRig.transform.position.x, -120.77f, xrRig.transform.position.z);
        // wooder.SetActive(false);
        // bell.SetActive(false);
        // bell.transform.rotation = currentRotation;
        
        
 
        
    }

    
}
