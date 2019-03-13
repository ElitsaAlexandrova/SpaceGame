using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameStateController : MonoBehaviour {

	public string GameOverScene = "GameOver";
	public float GameOverDelay = 0.8f;
	private uint Score = 0;
	public static GameStateController Instance { get; private set; }
	public void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
			DontDestroyOnLoad (gameObject);
		}
		else
		{
			Destroy (gameObject);
		}
	}

	public void OnPlayerDestroyed()
	{
		Invoke ("ShowGameOverScreen", GameOverDelay);
	}

	public uint GetScore() {
		return Score;
	}
	public void ResetScore() {
		Score = 0;
	}

	public void IncrementScore(uint scoreToAdd){
		Score += scoreToAdd;
	}

	private void ShowGameOverScreen()
	{
		SceneManager.LoadScene(GameOverScene);
	}
}
