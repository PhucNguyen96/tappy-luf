using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class HighscoreText : MonoBehaviour 
{

	Text score;

	// use void OnEnable instead Start
	// this text needs to be refreshed everytime the start page is activated
	void OnEnable() 
	{
		score = GetComponent<Text>();
		score.text = "High Score: " + PlayerPrefs.GetInt("HighScore").ToString();
	}
}
