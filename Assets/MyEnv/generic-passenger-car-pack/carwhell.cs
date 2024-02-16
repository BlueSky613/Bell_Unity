using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carwhell : MonoBehaviour
{
    public GameObject wheel1;
    public GameObject wheel2;
    public GameObject wheel3;
    public GameObject wheel4;
    public int d;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        wheel1.transform.Rotate(Time.deltaTime*d, 0, 0, Space.Self);
        wheel2.transform.Rotate(Time.deltaTime*d, 0, 0, Space.Self);
        wheel3.transform.Rotate(Time.deltaTime*d, 0, 0, Space.Self);
        wheel4.transform.Rotate(Time.deltaTime*d, 0, 0, Space.Self);
    }
}
