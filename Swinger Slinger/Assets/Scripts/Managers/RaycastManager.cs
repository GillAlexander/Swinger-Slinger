using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastManager : Singelton<RaycastManager>
{
    public Camera playerCamera;
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(transform.position, Vector3.forward, Color.blue, 2);

            if (Physics.Raycast(ray, out hit))
            {
                Vector2.Distance(hit.transform.gameObject.transform.position, ); 
                Debug.Log(hit.transform.gameObject);
            }
        }
    }
}
