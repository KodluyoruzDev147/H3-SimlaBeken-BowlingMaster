using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    private int score = 0;
    [SerializeField] private Text txt;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Pin")
        {

            score += 1;
            txt.text = score.ToString();
            //Debug.Log(score);
            Handheld.Vibrate();

        }
    }
}
