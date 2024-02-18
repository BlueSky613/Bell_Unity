using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using Unity.VisualScripting;
using UnityEngine.XR;

public class elevatorNewControl : MonoBehaviour
{
 
    // Start is called before the first frame update
    public AudioSource HitSource, windSound;
    public GameObject elevator, xrRig;
    public Animator ele_animator;
    public GameObject script;
    
    public bool elevatorGoUp = false;
    private float t = 0;
    public GameObject bell, wooder;

    public Image img;
    public int splash, endup, hitsound_Int;
    private float opacity;
    public Vector3 initialPosition;

    /// <summary>
    /// Used to customize synchronization of variables in a script watched by a network view.
    /// </summary>


    Quaternion currentRotation;
    void Start()
    {


        wooder.SetActive(false);
        bell.SetActive(false);
        t = 0;
        endup = 0;
        hitsound_Int = 0;
        splash = 0; 
        opacity = 0.0f;
        img.color = new Color(255, 255, 255, opacity);       
        // bellinitposition = bell.transform;
        currentRotation.eulerAngles = new Vector3(0, 0, 0);
        
        HitSource = GameObject.Find("GroundTrigger").GetComponent<AudioSource>();
        windSound = GameObject.Find("fallingSound").GetComponent<AudioSource>();

        initialPosition = xrRig.transform.position;
    }

    // Update is called once per frame






    void Update()
    {  
        

        

       
        if (xrRig.transform.position.y < -119.0f && endup == 1)
        {
                elevator.transform.position = new Vector3(elevator.transform.position.x, -120.77f, elevator.transform.position.z);
                bell.transform.position = new Vector3(287.394f, 238.248f, -473.847f);
                wooder.SetActive(false);
            // bell.SetActive(false);
                bell.transform.rotation = currentRotation;


                windSound.volume = 0.3f;
                
                
        }

        if (xrRig.transform.position.y < 235.0f && xrRig.transform.position.y > -119.0f && endup == 1){
            windSound.volume = 1.0f;
        }
        

    }

    void elevatorGo()
    {

        if (elevator.transform.position.y < 237 )
        {
            elevator.transform.Translate(0.0f, 28.5f * Time.deltaTime, 0.0f, Space.World);
            
            xrRig.transform.Translate(0.0f, 28.6f * Time.deltaTime, 0.0f, Space.World);
            wooder.SetActive(false);
            // bell.SetActive(false);
        }

        if (elevator.transform.position.y > 237 )
        {
            endup = 1; 
            hitsound_Int = 0;
            bell.transform.position = new Vector3(287.394f, 238.248f, -473.847f);
            bell.transform.rotation = currentRotation;
            script.GetComponent<setGoup>().elevator_Go_up = false;
            script.GetComponent<setGoup>().enabled = false;
            ele_animator.SetInteger("goup", 2);
            wooder.SetActive(true);
            bell.SetActive(true);
            t = 0;
        }



    }

    


    
    

}



