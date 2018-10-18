using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceToClone : MonoBehaviour {

    public float power = 5f;                //amount of power added to the parts of destructed objects

    Vector3 direction;                      //direction in which parts of destructed objects will go

    Rigidbody[] piecesOfObj;                //Array of Rigidbodies of the smaller parts of the object

    void Start ()
    {
        direction = -Camera.main.transform.position;        //direction is the camera.position inverse

        piecesOfObj = new Rigidbody[transform.childCount]; // we set the array size to match the count of smaller parts


        //we attribute all of the parts to the array
        for (int i=0;i<transform.childCount;i++)
        {
            piecesOfObj[i] = transform.GetChild(i).GetComponent<Rigidbody>();
        }


        //for each part in the array, we add force to it
        foreach (Rigidbody element in piecesOfObj)
        {
            element.AddForce(direction * power, ForceMode.Impulse);
        }
	}
	
}
