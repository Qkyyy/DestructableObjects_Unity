using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

    public GameObject crackedObject;


    private void OnMouseDown()
    {
        Instantiate(crackedObject, transform.position, transform.rotation);
        Destroy(transform.gameObject);
    }
}
