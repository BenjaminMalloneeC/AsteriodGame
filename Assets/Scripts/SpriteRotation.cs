using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRotation : MonoBehaviour
{
    //Create a variable for our transform compenent
    private Transform tf;

    //Create a variabe for the degree we rotate in one frame draw
    public float turnSpeed;
    // Start is called before the first frame update
    void Start()
    {
        //Load our transform component into our variable
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            tf.Rotate(0, 0, +turnSpeed);
        }
    }
}
