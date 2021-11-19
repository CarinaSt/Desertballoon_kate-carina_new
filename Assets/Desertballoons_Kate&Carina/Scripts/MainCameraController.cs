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
        if (Physics.Raycast(ray, out hit, 5000))
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
                    // Entfernung Raduis Balloon to Raycast Hit Point on th platforms
                    if ((hit.point - balloon.transform.position).magnitude < 50)
                    {
                        // Vector of Direction Balloon Force -> Hitpoint to Center Platform + additional height
                        Vector3 direction = hit.point - centerObject.position + new Vector3(0, 2, 0);
                        balloon.GetComponent<Rigidbody>().AddForce(direction.normalized * Time.deltaTime * 1000, ForceMode.Force);
                    }
                    
                }
               
               

    

            }
        }
    }
}