using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    public GameObject EarthPop;
    public GameObject SunPop;

    void Start()
    {

    }
    void updated()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed primary button.");

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit,100))
            {
                Debug.Log("hit");
                Debug.Log(hit.transform.name +" : " + hit.transform.tag);

                if(hit.transform.tag == "Earth")
                {
                    Vector3 pos =hit.point;
                    pos.z += 0.25f;
                    pos.y += 0.025f;
                    Instantiate(EarthPop, pos, transform.rotation);
                }
                if(hit.transform.tag == "Sun")
                {
                    Vector3 pos =hit.point;
                    pos.z += 0.25f;
                    pos.y += 0.025f;
                    Instantiate(EarthPop, pos, transform.rotation);
                }

                if(hit.transform.tag == "earth")
                {
                    Destroy(hit.transform.gameObject);
                }
                
                if(hit.transform.tag == "sun")
                {
                    Destroy(hit.transform.gameObject);
                }

            }
        }
    }
}
