using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleTrigger : MonoBehaviour {

	public LightPuzzle _PuzzleOwner;

    public bool _triggered;

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
			//Listen for input

            //Puzzle specific conditions
            if (_triggered == false)
            {
                _triggered = true;
                _PuzzleOwner.TriggerActive();
            }
        }

    }
}
