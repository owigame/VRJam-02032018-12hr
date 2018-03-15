using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWindowDoor : MonoBehaviour {

    [Header("OBJ")]

    public Transform TheDoor;

    [Header("Positions")]

    public Transform startPosition;
    public Transform endPosition;
    public float lerpSpeed;

    bool OpenDoor = false;

    private void Start()
    {
        StartCoroutine(MoveToPosition(TheDoor.position, startPosition.position));
    }

    public void OpenBigDoor()
    {
        StartCoroutine(MoveToPosition(TheDoor.position, endPosition.position));
    }

    IEnumerator MoveToPosition(Vector3 startPos, Vector3 endPos)
    {
        WaitForEndOfFrame _wait = new WaitForEndOfFrame();

       if (OpenDoor == true)
          {
            OpenDoor = false;
            yield return _wait;
          }
     
     //    Debug.Log("Starting move panel");
        OpenDoor = true;
        float lerpProgress = 0;

        while (TheDoor.position != endPos && OpenDoor == true)
        {
            lerpProgress = Mathf.Clamp(lerpProgress + (Time.deltaTime * lerpSpeed), 0, 1);
            TheDoor.position = Vector3.Lerp(startPos, endPos, lerpProgress);
            yield return _wait;
        }
     //   Debug.Log("Finished move panel");
    }

}
