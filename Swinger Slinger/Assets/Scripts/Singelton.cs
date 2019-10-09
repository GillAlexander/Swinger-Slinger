using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Don't forget to set the instance in start!
/// </summary>
/// 
public class Singelton<T> : MonoBehaviour where T : MonoBehaviour
{

    private static T instance;

    public static T GetInstance()
    {
        if (instance == null)
        {
            instance = FindObjectOfType<T>();
            if (instance == null)
            {
                Debug.LogError($"An instance of {typeof(T)} " +
                    $"is needed in the scene, bet there is none.");
                throw new System.NullReferenceException();
            }
        }
        return instance;
    }

    public static bool SetInstance(T _object, bool destroyDuplicates = true)
    {
        if (instance == null)
        {
            instance = _object;
            return true;
        }
        else
        {
            if (destroyDuplicates)
            {
                Debug.LogWarning($"Trying to assign{_object.name}" +
                    $"as an instance of {typeof(T)} but one already exist" +
                    $"in the scene, destroeying instance on {_object.name}.");
            }
            else
            {
                Debug.LogWarning($"Trying to assign{_object.name} as an instance of {typeof(T)}" +
                    $"but one already exist in the scene, returning...");
            }
            return false;
        }
    }
}
