using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuggooController : MonoBehaviour
{
    //void OnTriggerEnter(Collider other)
    //{

    ////}
    void OnCollisionEnter(Collision collision)
    {
        foreach(ContactPoint contact in collision.contacts)
        {
            if(contact.otherCollider.tag == "pop")
            {
                // create new cacti on collision
                GameObject.Instantiate(contact.otherCollider.gameObject, contact.otherCollider.transform.position + new Vector3(0.5f, 0, 0), contact.otherCollider.transform.rotation);
                contact.otherCollider.tag = null;
            }
        }
    }
}
