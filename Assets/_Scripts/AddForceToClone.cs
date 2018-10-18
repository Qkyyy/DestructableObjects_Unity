using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceToClone : MonoBehaviour {

    public float power = 1f;

    Vector3 direction;

    Rigidbody[] piecesOfObj;

    void Start ()
    {
        direction = -Camera.main.transform.position;
        piecesOfObj = new Rigidbody[transform.childCount];

        for (int i=0;i<transform.childCount;i++)
        {
            piecesOfObj[i] = transform.GetChild(i).GetComponent<Rigidbody>();
        }

        foreach (Rigidbody element in piecesOfObj)
        {
            element.AddForce(direction * power, ForceMode.Impulse);
        }
	}
	
}
