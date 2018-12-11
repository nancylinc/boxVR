using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (collision.globalStreaks >= 30)
        {
            transform.position += Time.deltaTime * transform.right * 20;
        }
        else
            transform.position += Time.deltaTime * transform.right * 10;
    }
}
