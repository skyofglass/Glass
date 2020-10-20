using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody2D rb;
    public GameObject explosion;
    private Vector3 AimPoint;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * speed, ForceMode2D.Impulse);
       AimPoint = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position);
       AimPoint.z = 0;
       AimPoint.Normalize();
        

    }

    // Update is called once per frame

    void Update()
    {
    transform.position = transform.position + AimPoint * speed* Time.deltaTime;
    Destroy(gameObject, 10);
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "enemy"){
                GameObject e = Instantiate(explosion) as GameObject;
                e.transform.position = transform.position;
                Destroy(other.gameObject);
                Destroy(this.gameObject);

                

        }
    }
}
