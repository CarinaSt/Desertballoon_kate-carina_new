using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    public Transform centerObject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;     //variable
        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition); // we create a ray
        if (Physics.Raycast(ray, out hit, 50000))
        {       //put it into information with physics and give information
            //if (hit.collider.tag == "jumpy")
            //{
                //hit.rigidbody.AddForce(Vector3.up, ForceMode.Impulse);
               // hit.rigidbody.AddForce(Vector3.up, ForceMode.Impulse);
            //}
            if (hit.collider.tag == "floor")
            {
                foreach(GameObject balloon in GameObject.FindGameObjectsWithTag("jumpy"))
                {
                    Debug.Log("huhu");
                    Vector3 direction = hit.point - centerObject.position;
                    balloon.GetComponent<Rigidbody>().AddForce(direction*Time.deltaTime*15, ForceMode.Force);
                }
               
               

    

            }
        }
    }
}