using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{

    Rigidbody rb;

    public Vector3 thrustForce = new Vector3(0, 0, 45f);   //45f is the speed of the car in the z direction i.e. forward
    public Vector3 rotateTorque = new Vector3(0f, 8f, 0f);    //8f as car will rotate according to the y direction...


    public bool controlsEnabled;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        controlsEnabled = false;

    }

    // Update is called once per frame
    void Update()
    {

        if(controlsEnabled)
        {
            //moving forward
            if (Input.GetKey("w"))
            {

                rb.AddRelativeForce(thrustForce);      //relativeForce is used as we want to move car only in a specific direcuin with key

            }

            //moving backward
            if (Input.GetKey("s"))
            {

                rb.AddRelativeForce(-thrustForce);

            }

            //moving left
            if (Input.GetKey("a"))
            {

                rb.AddRelativeTorque(-rotateTorque);

            }

            //moving right
            if (Input.GetKey("d"))
            {

                rb.AddRelativeTorque(rotateTorque);

            }


        }




        




    }
}
