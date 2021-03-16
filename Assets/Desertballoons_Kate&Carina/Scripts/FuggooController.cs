using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuggooController : MonoBehaviour
{
   public GameObject explosion; // drag explosion prefab here
                                // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        void OnCollisionEnter()
        {
            GameObject collisionobject = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
            Destroy(gameObject); // destroy the balloon
            Destroy(collisionobject, 3); // delete the explosion after 3 seconds
        }
    }
}
