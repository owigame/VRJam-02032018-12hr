using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternPuzzle : PuzzleObject {

	// Use this for initialization

int[] pattern = new int[6];

int patternStep = 0;//?

private void OnEnable() {
	DummyButtonScript.OnButtonPress += CheckAgainstPattern;
}

private void OnDisable() {
	DummyButtonScript.OnButtonPress -= CheckAgainstPattern;
}

private void Start() { //REPLACE WITH ON PUZZLE START
	NewPattern();	
}
	
void NewPattern()
{
	for (int i=0; i < 6; i++)
	{
		pattern[i] = Random.Range(1, 5);
		Debug.Log("Pattern_" + pattern[i] );
	}
}

void CheckAgainstPattern(int buttonNumberPressed)
{
	if (buttonNumberPressed == pattern[patternStep])//?-1
	{
		Debug.Log("Dis hom.");
		patternStep++;
	}else{
		patternStep = 0;//?
		Debug.Log("wrong");
		NewPattern();
	}

	if (patternStep == pattern.Length)//+1
	{
		//puzzle completed
		Debug.Log("Puzzle complete!");
	}
}
	
	// private void OnTriggerEnter(Collider other) 
	// {
				
	// }
}
