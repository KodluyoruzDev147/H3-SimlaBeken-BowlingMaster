using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    [SerializeField] float speed, turnSpeed;


    private Rigidbody rb;
    private Vector3 firstPos, endPos;
    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {



        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //transform.Rotate( new Vector3(45, 45, 90) * Time.deltaTime);
        rb.AddForce(Vector3.forward * speed);

        //Swerwe
        if (Input.GetMouseButtonDown(0))
        {
            firstPos = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            endPos = Input.mousePosition;
            distance = endPos.x - firstPos.x;
            transform.Translate(distance * Time.deltaTime * turnSpeed / 100, 0, 0);

        }
    }
}
