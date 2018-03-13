using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelInMidell : MonoBehaviour {


    [Header("OBJ")]

    public Transform ThePanel;

    [Header("Positions")]

    public Transform startPosition;
    public Transform endPosition;
    public float lerpSpeed;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ThePanel.position = Vector3.Lerp(startPosition.position, endPosition.position, lerpSpeed);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            //transform.position = Vector3.Lerp(endPosition.position, startPosition.position, lerpSpeed);
            ThePanel.position = Vector3.Lerp(endPosition.position, startPosition.position, lerpSpeed);
        }
    }

}
