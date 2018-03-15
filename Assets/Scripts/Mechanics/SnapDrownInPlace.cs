using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapDrownInPlace : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        Transform DrownEnter;

        DrownEnter = other.transform;

        if (other.tag == "Drown")
        {
            other.transform.position = transform.position;

        }
    }

}
