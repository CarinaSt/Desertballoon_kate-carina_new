using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class empty_2 : MonoBehaviour
{
    MeshCollider me;
    MeshRenderer me2;

    public int Score2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        me = GetComponent<MeshCollider>();
        me2 = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)

    {

        if (col.tag == "jumpy")

        {
            me.enabled = false;
            me2.enabled = false;
            Score2++;

        }

    }

}
