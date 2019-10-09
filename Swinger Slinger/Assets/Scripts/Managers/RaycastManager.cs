using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastManager : Singelton<RaycastManager>
{
    public Camera playerCamera;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(transform.position, Vector3.forward, Color.blue, 2);

            if (Physics.Raycast(ray, out hit))
            {
                hit.transform.gameObject.GetComponent<Rigidbody>().velocity += new Vector3(0,3,0);
                Debug.Log(hit.transform.gameObject);
            }
        }
    }
}
