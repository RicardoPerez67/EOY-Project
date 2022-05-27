using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
   
    public Vector3 offset = new Vector3(0, 0, 180);
    public Vector3 offset2 = new Vector3(0, 0, 90);
    public Vector3 offsetpos = new Vector3(0, 5, 0);

    public bool isReset;
    public bool isReset2;

    // Start is called before the first frame update
    void Start()
    {
       // isReset = true;
    }
    

    // Update is called once per frame
    void Update()
    {
        isReset = Input.GetKey(KeyCode.R);
        if (isReset)
        {
           // Vector3 rotationToAdd = new Vector3(0, 90, 0);
            transform.Rotate(offset);
            transform.Translate(offsetpos);
        }
        isReset2 = Input.GetKey(KeyCode.Q);
        if (isReset2)
        {
            // Vector3 rotationToAdd = new Vector3(0, 90, 0);
            transform.Rotate(offset2);
        }

    }
}
