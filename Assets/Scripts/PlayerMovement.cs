using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;

    public GameObject playerGameObject;
    private void Start()
    {
        playerGameObject = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            
        }
    }
}
