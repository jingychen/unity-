using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotate : MonoBehaviour
{
    public Vector3 pinPoint;
    public Vector3 axis;

    void Start()
    {

        pinPoint = new Vector3(5, 5, 1);
        axis = new Vector3(0, 1, 0);
    }





    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(new Vector3(0,10,0) * Time.deltaTime);
        transform.RotateAround(pinPoint, axis, 20 * Time.deltaTime);

    }
}
