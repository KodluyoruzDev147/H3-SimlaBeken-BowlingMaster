using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Waste : MonoBehaviour
{
    [SerializeField] private GameObject UI;

    //To finish the game when it touches the grooves on the right and left of the bowling alley.
    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "Gutter")
        {
            SceneManager.LoadScene("SampleScene");
            UI.SetActive(true);

        }
    }
}
