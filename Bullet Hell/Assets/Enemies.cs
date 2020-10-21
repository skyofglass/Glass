using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour{
public GameObject BlueEnemy;
public GameObject RedEnemy;
public GameObject WhiteEnemy;
public float respawnTime= 1.0f;
private Vector2 screenBounds;


    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(4, 5, Camera.main.transform.position.z));
        StartCoroutine(StarField());
        
    }
    private void spawnEnemy(){
        GameObject BNME = Instantiate(BlueEnemy) as GameObject;
        BNME.transform.position = new Vector2(screenBounds.x * -2, Random.Range(-screenBounds.y, screenBounds.y));
        GameObject RNME = Instantiate(RedEnemy) as GameObject;
        RNME.transform.position = new Vector2(screenBounds.y * -2, Random.Range(-screenBounds.x, screenBounds.x));
        GameObject WNME = Instantiate(WhiteEnemy) as GameObject;
        WNME.transform.position = new Vector2(screenBounds.x * 2, Random.Range(-screenBounds.y, screenBounds.y));

    }

    IEnumerator StarField(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
