using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueEnemyScript : MonoBehaviour
{
    public GameObject ExplosionBlue;
    public float flashtime = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Bullet"){
                GameObject f = Instantiate(ExplosionBlue) as GameObject;
                f.transform.position = transform.position;
                Destroy(other.gameObject);
                Destroy(this.gameObject);
                Destroy(f.gameObject, flashtime);
         }
    }
}


