using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiWaivePoints : MonoBehaviour {

    public static Transform[] MovePoints;

    private void Awake()
    {
        MovePoints = new Transform[transform.childCount];

        for (int i = 0; i < MovePoints.Length; i++)
        {
            MovePoints[i] = transform.GetChild(i);
        }

    }
}
