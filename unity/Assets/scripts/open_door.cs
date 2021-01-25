using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_door : MonoBehaviour
{
    int i = 0;
    // private float moveSpeed = 7f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            if (i == 0)
            {
                i++;
                // transform.position = new Vector3(-22.29f, 0.1280379f, 0.13f);
                Vector3 temp = new Vector3(1.2618f, 0, 1.413275f);
				transform.position += temp;
                // transform.rotation = Quaternion.Euler(0, -3.539f, 0);
       //          int _rotationSpeed = -2000;
    			transform.Rotate(0.0f, -75.539f, 0.0f, Space.World);
            }
        }
    }
}
