using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyButtonScript : MonoBehaviour {

	public delegate void ButtonPressAction(int buttonNumber);
	public static event ButtonPressAction OnButtonPress;

	public int buttonNumber;

	private void OnMouseDown() { //REPLACE WITH BUTTON TRIGGER EVENT
		
		switch (gameObject.tag)
		{
			case "Button1":
				buttonNumber = 1;
				break;
			case "Button2":
				buttonNumber = 2;
				break;
			case "Button3":
				buttonNumber = 3;
				break;
			case "Button4":
				buttonNumber = 4;
				break;
			default:
				break;
		}

	OnButtonPress(buttonNumber);
	Debug.Log("Button pressed: " + buttonNumber);
}


}
