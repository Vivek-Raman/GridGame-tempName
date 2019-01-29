using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellData : MonoBehaviour {

    //[HideInInspector]
    public float ContactTime = 0f; // TODO: HideInInspector

	// Use this for initialization
	void Start ()
    {
		
	}
	
	void Update ()
    {
        
	}

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            ContactTime += Time.deltaTime;
            Debug.Log("Cell " + ": " + ContactTime.ToString());
        }
    }
}
