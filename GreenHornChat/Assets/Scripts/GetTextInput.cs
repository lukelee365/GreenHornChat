using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class QA{
	public string[] Typed;
	public string Reply;
}

public class GetTextInput : MonoBehaviour {
	public InputField mainFiedInput;
	public Text textPanel;
	public QA[] ReplyWithAnswer;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Post(){
		textPanel.text = textPanel.text+"\n"+"<color=Blue>"+mainFiedInput.text+"</color>";
		Match ();
	    mainFiedInput.text = "";
	}

	public void Match()
	{
		string inputText = mainFiedInput.text;
		for (int i = 0; i < ReplyWithAnswer.Length; i++) {
			int matchcount = 0;
			for (int j = 0; j < ReplyWithAnswer [i].Typed.Length; j++) {
				if (inputText.Contains (ReplyWithAnswer [i].Typed [j])) {
					matchcount++;
				}

			}
			if (matchcount == ReplyWithAnswer [i].Typed.Length ) {
				textPanel.text = textPanel.text+"\n"+"<color=Red>"+ReplyWithAnswer[i].Reply+"</color>";
			}
		}
	}

}
