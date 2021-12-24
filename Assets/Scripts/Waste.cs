using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waste : MonoBehaviour
{
    [SerializeField] private GameObject game;



    //To finish the game when it touches the grooves on the right and left of the bowling alley.
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Gutter")
        {

            game.SetActive(false);

        }
    }
}
