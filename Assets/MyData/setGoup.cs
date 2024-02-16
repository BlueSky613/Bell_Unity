using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setGoup : MonoBehaviour
{
    // Start is called before the first frame update
    public bool elevator_Go_up = false; 
    public GameObject elevator;
    
    

    void Start(){

        // elevator_Go_up = true;
        // Debug.Log("Go up!");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (elevator.transform.position.y < 237 )
        {
            elevator_Go_up = true;
            
        }
        else elevator_Go_up = false;
    }
}
