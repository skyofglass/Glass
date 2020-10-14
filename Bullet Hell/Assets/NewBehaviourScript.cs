using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{private Vector3 mouse_pos;
        public Transform target;
        private Vector3 object_pos;
        private float angle;
        public bool isLocal;
    // Start is called before the first frame update
    void Start()
{

}
    

    // Update is called once per frame
    void Update()
    {
//Borders       
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -4.75f, 4.75f), 
        Mathf.Clamp(transform.position.y, -3.75f, 3.75f), transform.position.z);
//Movement
        if (Input.GetKey (KeyCode.W))   {transform.Translate (0.0f, 0.05f, 0.0f);
        }
        if (Input.GetKey (KeyCode.S))   {transform.Translate (0.0f, -0.05f,0.0f);
        }
        if (Input.GetKey (KeyCode.D))   {transform.Translate (0.05f, 0.0f, 0.0f);
        }
        if (Input.GetKey (KeyCode.A))   {transform.Translate (-0.05f, 0.0f, 0.0f);
        }
        {
//Rotation
            if(isLocal)
            mouse_pos =Input.mousePosition;
            mouse_pos.z = -20;
            object_pos = Camera.main.WorldToScreenPoint(target.position);
            mouse_pos.x = mouse_pos.x - object_pos.x;
            mouse_pos.y = mouse_pos.y - object_pos.y;
            angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, angle);
            }
    }
}

