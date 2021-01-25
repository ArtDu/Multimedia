using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tv : MonoBehaviour
{   private bool q = false;
    public Material newMaterial;
    public Material oldMaterial;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (q == true)
                q = false;
            else
                q = true;
        }
        if (q == true)
            gameObject.GetComponent<Renderer>().material = newMaterial;
        if (q == false)
            gameObject.GetComponent<Renderer>().material = oldMaterial;

    }
}
