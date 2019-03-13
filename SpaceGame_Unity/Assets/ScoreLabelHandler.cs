using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreLabelHandler : MonoBehaviour {

	public string ScoreFormat = "Score: {0}";
	public Text TextField;

	void Start () {
		uint score = 999999;
		var gameStateController = GameStateController.Instance;
		if (gameStateController) {
			score = gameStateController.GetScore ();
		}
		TextField.text = string.Format (ScoreFormat, score);
	}
}
