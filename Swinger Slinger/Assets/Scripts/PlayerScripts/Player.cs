using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /// <Author>
    /// Jonathan Aronsson Olsson
    /// </Author>
    /// <Summary>
    ///	Class that hold information about the player
    /// </Summary

    [SerializeField] private int playerHealth;

    public int PlayerHealth { get => playerHealth; set => playerHealth = value; }

    private void Awake()
    {
        PlayerHealth = 10;
    }

    private void Start()
    {
        playerHealth = 20;
    }

    private void Update()
    {
        
    }
}
