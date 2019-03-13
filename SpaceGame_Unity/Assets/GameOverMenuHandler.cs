using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenuHandler : MonoBehaviour {
	public string MainScene = "Main";
	public void OnRestart()
	{
		SceneManager.LoadScene(MainScene);
		GameStateController.Instance.ResetScore ();
	}

	public void OnQuit()
	{
		Application.Quit();
	}

}
