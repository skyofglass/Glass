using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandRotation : MonoBehaviour
{
    public GameObject StarProjectile;
    private Vector3 mouse_pos;
    public Transform target;
    private Vector3 object_pos;
    private float angle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotation
        mouse_pos = Input.mousePosition;
        object_pos = Camera.main.WorldToScreenPoint(target.position);
        mouse_pos.z = mouse_pos.z - object_pos.z;
        mouse_pos.x = mouse_pos.x - object_pos.x;
        mouse_pos.y = mouse_pos.y - object_pos.y;
        angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg-90;
        transform.rotation = Quaternion.Euler(0,0,angle);

        //Instantiate
        if (Input.GetMouseButtonDown(0)){
        shootStar();
        }
    }
        public void shootStar(){
        GameObject b=Instantiate(StarProjectile) as GameObject;
        b.transform.position = target.transform.position;
        
    }
}
