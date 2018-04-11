using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {
    public float scrollingSpeed = 5f;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameContro.instance.gameOver == false)
        {
            transform.Translate(new Vector3(1, 0, 0) * scrollingSpeed * Time.deltaTime * -1);
            if (transform.position.x < -19f)
            {
                transform.position = new Vector3(19f, transform.position.y, transform.position.z);
            }
        }



    }
}
