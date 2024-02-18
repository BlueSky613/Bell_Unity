using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
// using UnityEngine.Rendering;

public class elevatorControl : MonoBehaviour
{
    // Start is called before the first frame update

    private AudioSource FallingSource;


    private AudioSource HitSource;
    public GameObject teleport;
    public GameObject wooder;
    public GameObject bell;
    public Animator elevatorCont;
    public GameObject xr;
    public Image img;

    public int hitGround , hitaudioIndex;

    public int IsfallingFlag;
    public float opacity;
    public float xrrigposition = 0;
    public bool upFlag = false;
    public float starttime;
    public int k, splash;
    void Start()
    {
        FallingSource = GameObject.Find("fallingsound").GetComponent<AudioSource>();
        HitSource = GameObject.Find("HitGround").GetComponent<AudioSource>();

        FallingSource.Stop();
        HitSource.Stop();
        IsfallingFlag = 0;
        hitGround = 0; 
        hitaudioIndex = 0;
        wooder.SetActive(false);
        bell.SetActive(false);
        elevatorCont.SetInteger("OpenFlag", 0);
        k = 0; opacity = 0.0f; splash = 0;
        img.color = new Color(255, 255, 255, opacity);
    }

    // Update is called once per frame
    void Update()
    {


        

        if ((Time.time - starttime) > 7.0f)
        {
            elevatorGo();
        }



        if (teleport.transform.position.y > 287 && upFlag == false)
        {
            wooder.SetActive(true);
            bell.SetActive(true);
            IsfallingFlag = 1;
            elevatorCont.SetInteger("OpenFlag", 0);
            // Debug.Log(xr.transform.position.y);
            if (xr.transform.position.y < (-95.0f))
            {
                hitGround = 1;
                if (hitaudioIndex == 0) { Debug.Log("hit-audioStart"); HitSource.Play(); hitaudioIndex = 1;}
            }

            if (xr.transform.position.y < (-120.0f))
            {
                // Debug.Log("white");
                // opacity = 1.0f;
                // img.color = new Color(255, 255, 255, opacity);

                // hitGround = 1;
                // if (HitSource.isPlaying == false) { Debug.Log("hit-audioStart"); HitSource.Play();}

                if (splash == 0) imgsplashInc();
                if (splash == 1) imgsplashDec();
            }


        }

        if (IsfallingFlag == 1)
        {
            if (hitGround == 0)
            {
                if (FallingSource.isPlaying == false){
                    Debug.Log("windfallingSound-start");
                    FallingSource.Play();
                }

            }

            else { 
                if (FallingSource.isPlaying == true ) {
                    Debug.Log("windfallingSound-stop"); FallingSource.Stop();
                }
            }

        }

        // if (xr.transform.position.y < (-180.0f)) 
        // {
        //     hitGround = 1;
        //     HitSource.Play();
        // }






    }

    private void elevatorGo()
    {

        if (teleport.transform.position.y < 287)
        {
            teleport.transform.Translate(0.0f, 28.0f * Time.deltaTime, 0.0f, Space.World);
            upFlag = true;
        }
        else
        {
            upFlag = false;

        }
    }

    


}
