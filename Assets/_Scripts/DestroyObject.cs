using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

    public GameObject crackedObject;            //GameObject of the CrackedObject version 



    //Mouse click on the object
    private void OnMouseDown()
    {
        Instantiate(crackedObject, transform.position, transform.rotation);         //We replace original object with the cracked version
        Destroy(transform.gameObject);                                              //Destroy the original object
    }
}
