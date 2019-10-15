using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteSelfTimer : MonoBehaviour
{
    /// <Author>
    /// Jonathan Aronsson Olsson
    /// </Author>
    /// <Summary>
    ///	The object this script is attached to will destroy itself with a timer when initiated 
    /// </Summary

    float timer = 0;

    private void Start()
    {
        
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0.6f)
        {
            Destroy(gameObject);
            Destroy(this);
        }
    }
}
