using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScreenFader : MonoBehaviour
{
	public Image FadeImg, FadeImg2;
	public float fadeSpeed = 1.5f;
	public bool sceneStarting = true;

	void Update()
	{
		// If the scene is starting...
		if (sceneStarting)
			// ... call the StartScene function.
			FadeToClear();
	}


	void FadeToClear()
	{
		// Lerp the colour of the image between itself and transparent.
		FadeImg.color = Color.Lerp(FadeImg.color, Color.clear, fadeSpeed * Time.deltaTime);
		FadeImg2.color = Color.Lerp(FadeImg2.color, Color.clear, fadeSpeed * Time.deltaTime);
		if(FadeImg.color.a <= 0.05f){
			FadeImg.color = Color.clear;
			sceneStarting = false;
			FadeImg.enabled = false;
		}
		if(FadeImg2.color.a <= 0.05f){
			FadeImg2.color = Color.clear;
			sceneStarting = false;
			FadeImg2.enabled = false;
		}
	}

	public void EndScene(int SceneNumber)
	{
		// Make sure the RawImage is enabled.
		FadeImg.enabled = true;
		FadeImg2.enabled = true;

		FadeImg.color = Color.Lerp(FadeImg.color, Color.black, fadeSpeed * Time.deltaTime);
		FadeImg2.color = Color.Lerp(FadeImg2.color, Color.black, fadeSpeed * Time.deltaTime);

		// If the screen is almost black...
		if (FadeImg.color.a >= 0.95f)
			// ... reload the level
			SceneManager.LoadScene(SceneNumber);
	}

}   