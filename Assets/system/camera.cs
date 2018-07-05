﻿using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

    public GameObject player;       //Public variable to store a reference to the player game object
    public float shakeAmt;
    public Camera mainCamera;
    private Vector3 offset;         //Private variable to store the offset distance between the player and camera
    Vector3 originalCameraPosition;


    // Use this for initialization
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - player.transform.position;
    }
    
    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        transform.position = player.transform.position + offset;
    }
}
