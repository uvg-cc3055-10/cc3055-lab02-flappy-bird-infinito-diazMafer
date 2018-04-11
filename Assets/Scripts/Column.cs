using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour {
    public GameObject column;

    private float scrollingSpeed = 2f;
    private float spawnTime = 4f;
    private float elapsedTime = 0f;

    void Start () {
		
	}
	
	void Update () {
        if (GameContro.instance.gameOver == false)
        {
            transform.Translate(Vector3.left * scrollingSpeed * Time.deltaTime);
            if (transform.position.x < -10)
            {
                Destroy(gameObject);
            }
            if (elapsedTime < spawnTime)
            {
                elapsedTime += Time.deltaTime;
            }
            else
            {
                float random = Random.Range(-0.5f, 0.5f);
                Instantiate(column, new Vector3(8, random, 0), Quaternion.identity);
                elapsedTime = 0;
            }
        }

    }
}
