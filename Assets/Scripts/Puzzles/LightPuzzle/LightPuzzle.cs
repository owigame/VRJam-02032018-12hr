using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPuzzle : PuzzleObject
{

	public List<GameObject> _triggers = new List<GameObject>();
	int triggered = 0;

    void Start()
    {
    }

    public void TriggerActive()
    {
		triggered ++;
		if (triggered == _triggers.Count){
			_complete = true;
		}
    }
}
