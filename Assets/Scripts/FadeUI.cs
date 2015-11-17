using UnityEngine;
using System.Collections;

public class FadeUI : MonoBehaviour 
{
	public void FadeThis()
	{
		StartCoroutine(Fading());
	}

	IEnumerator Fading()
	{
		CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
		while(canvasGroup.alpha>0)
		{
			canvasGroup.alpha -= Time.deltaTime;
			yield return null;
		}
		canvasGroup.interactable = false;
		yield return null;
	}
}
