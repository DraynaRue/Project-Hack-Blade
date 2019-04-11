using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour 
{

    public GameObject player;       //Public variable to store a reference to the player game object


    //private Vector3 offset;         //Private variable to store the offset distance between the player and camera

    // Use this for initialization
    void Start () 
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        //offset = new Vector3(0, );
        if (Application.platform == RuntimePlatform.WindowsPlayer)
        {
            GameObject[] _goa;
            _goa = GameObject.FindGameObjectsWithTag("MobileOnly");
            for (int i = 0; i < _goa.Length; i++)
            {
                _goa[i].SetActive(false);
            }
        }
    }
    
    // LateUpdate is called after Update each frame
    void LateUpdate () 
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
    }
}