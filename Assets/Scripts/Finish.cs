﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private PlayerControl playerControl;

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Çarpışma algılandı.");

        playerControl = player.GetComponent<PlayerControl>();
        playerControl.enabled = false;

    }
}
