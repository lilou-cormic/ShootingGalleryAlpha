using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMovement : MonoBehaviour
{
    public float speed = 0.5f;

    //int multiplier = 1;

    // Update is called once per frame
    void Update()
    {
        //if (transform.position.x > 0.5f)
        //    multiplier = -1;

        //if (transform.position.x < -0.5f)
        //    multiplier = 1;

        //transform.Translate(Vector3.right * multiplier * Time.deltaTime * speed);

        transform.position = new Vector3(Mathf.Cos(Time.time), Mathf.Sin(Time.time)) * speed;
    }
}
