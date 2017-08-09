using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class Control : MonoBehaviour
{
	public string NextScene = "(CaseSensitive)";
	public string PrevScene = "(CaseSensitive)";



	public void Next(string nextScene)
	{
		NextScene = nextScene;

	}

	public void Prev(string prevScene)
	{
		PrevScene = prevScene;

	}

	public void loadNext()
	{
		SceneManager.LoadScene(NextScene);
	}
	public void loadprev()
	{
		SceneManager.LoadScene(PrevScene);
	}
}