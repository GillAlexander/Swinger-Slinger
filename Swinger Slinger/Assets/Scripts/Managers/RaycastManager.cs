using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastManager : Singelton<RaycastManager>
{
    public Camera playerCamera;
    private RaycastHit raycastHit;
    private Ray rayCastRay;
    public GameObject player;
    private LayerMask rayMask;
    public GameObject raycastTest;
    private GameObject clone;
    private List<GameObject> objectList = new List<GameObject>();
    private void Start()
    {
        rayMask = LayerMask.GetMask("raycastLayer");
    }
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            rayCastRay = playerCamera.ScreenPointToRay(Input.mousePosition);
            
            if (Physics.Raycast(rayCastRay, out raycastHit, Mathf.Infinity, rayMask))
            {
                Debug.Log(raycastHit.transform.gameObject.name);
                objectList.Add(clone = Instantiate(raycastTest, raycastHit.point, Quaternion.identity));
                var distance = Vector3.Distance(raycastHit.transform.position, player.transform.position);
                Debug.Log(distance);
                if (distance < 2)
                {
                    Debug.Log($"Player is within bound of {raycastHit.transform.gameObject} object");
                    //Väja det objekt du har träffat med din raycast. Se till att objektet hamlar i en lista och 
                    //gör sen så att du kan snurra runt spelaren
                }
            }
        }
    }
}
