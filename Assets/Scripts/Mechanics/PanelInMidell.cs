using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelInMidell : MonoBehaviour {

    [Header ("OBJ")]

    public Transform ThePanel;

    [Header ("Positions")]

    public Transform startPosition;
    public Transform endPosition;
    public float lerpSpeed;

    bool movingPanel = false;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }

    private void OnTriggerEnter (Collider other) {
        if (other.tag == "Player") {

            StartCoroutine (MoveToPosition (ThePanel.position, endPosition.position));
        }
    }

    private void OnTriggerExit (Collider other) {
        if (other.tag == "Player") {
            StartCoroutine (MoveToPosition (ThePanel.position, startPosition.position));
        }
    }

    IEnumerator MoveToPosition (Vector3 startPos, Vector3 endPos) {
        WaitForEndOfFrame _wait = new WaitForEndOfFrame ();

        if (movingPanel == true) {
            movingPanel = false;
            yield return _wait;
        }

        Debug.Log("Starting move panel");
        movingPanel = true;
        float lerpProgress = 0;

        while (ThePanel.position != endPos && movingPanel == true) {
            lerpProgress = Mathf.Clamp (lerpProgress + (Time.deltaTime * lerpSpeed), 0, 1);
            ThePanel.position = Vector3.Lerp (startPos, endPos, lerpProgress);
            yield return _wait;
        }
        Debug.Log("Finished move panel");
    }

}