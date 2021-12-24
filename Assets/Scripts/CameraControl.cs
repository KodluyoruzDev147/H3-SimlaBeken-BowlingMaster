using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private GameObject player;


    private Vector3 offset = new Vector3(0, 6, -13);

    //for the camera to follow the player
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
