using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrackGlass : MonoBehaviour
{
    public Transform BrokenGlass;
    public float objectMoveToBrakeSpeed;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > objectMoveToBrakeSpeed)
        {
            Destroy(gameObject);
            Instantiate(BrokenGlass, transform.position, transform.rotation);
            BrokenGlass.localScale = transform.localScale;
        }
    }

}
