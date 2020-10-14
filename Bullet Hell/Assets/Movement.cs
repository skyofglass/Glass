using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Border
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -5.75f, 5.75f),
       Mathf.Clamp(transform.position.y, -1f,7.75f),transform.position.z);    

        //Movement
        if (Input.GetKey (KeyCode.W))   {transform.Translate (0.0f, 0.15f, 0.0f);
        }
        if (Input.GetKey (KeyCode.S))   {transform.Translate (0.0f, -0.15f,0.0f);
        }
        if (Input.GetKey (KeyCode.D))   {transform.Translate (0.15f, 0.0f, 0.0f);
        }
        if (Input.GetKey (KeyCode.A))   {transform.Translate (-0.15f, 0.0f, 0.0f);
        }
        
    }
}
