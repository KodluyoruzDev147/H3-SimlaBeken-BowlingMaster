using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonControl : MonoBehaviour
{

    [SerializeField] private GameObject startUI;
    [SerializeField] private GameObject tryAgainUI;
    [SerializeField] private GameObject player;

    private PlayerControl playerControl ;
    private void Start()
    {
        
    }


    public void StartGame()
    {
        playerControl = player.GetComponent<PlayerControl>();
        startUI.SetActive(false);
        playerControl.enabled = true;


    }

}
