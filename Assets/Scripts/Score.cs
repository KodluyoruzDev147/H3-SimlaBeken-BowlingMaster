using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    private int score = 0;

    private void OnCollisionEnter(Collision collision)
    {
       
            if (collision.gameObject.tag == "Pin")
            {

                score += 1;
                Debug.Log(score);
                Handheld.Vibrate();

            }        
    }
}
