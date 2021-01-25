using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vaza : MonoBehaviour
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
        if (Input.GetKeyUp(KeyCode.R))
        {
            if (i == 0)
            {
                i++;
                transform.position = transform.position + new Vector3(25.82547f-24.86f, -2.558712f+0.485f, 4.511356f-1.951f);
                // transform.rotation = Quaternion.Euler(-20, 0, -70);
                
            }
        }
    }
}
