using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InputManager : MonoBehaviour {

    public Text outText;
    public InputField textIn;
    public Button enterButton;

        // Use this for initialization
        void Start () {
        outText.text = "";
	}
	
	public void EnterPress ()
    {
        outText.text = Utilities.ProcessText(textIn.text);
    }
}
