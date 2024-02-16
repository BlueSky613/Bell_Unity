using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BellSound : MonoBehaviour
{
    
    public GameObject elevator, wooder, xrRig, bell;
    

    
    private AudioSource HitSource;


    // Start is called before the first frame update
    void Start()
    {
        HitSource = GameObject.Find("GroundTrigger").GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        
        
        // HitSource.Play();
            Debug.Log("XR Rig Ground");
        
            Debug.Log("XDSS");
            
            
            
           
            Debug.Log(bell.transform.position.y);
            // xrRig.transform.position = new Vector3(xrRig.transform.position.x, -120.77f, xrRig.transform.position.z);
            // xrRig.transform.position = new Vector3(287.7815f, -120.77f, -476.5647f);
            
        
        
        
        
 
        
    }

    
}
