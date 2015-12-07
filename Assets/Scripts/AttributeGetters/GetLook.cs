using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using System.Linq;
using System.IO;

public class GetLook : MonoBehaviour 
{
	public List<Sprite> spriteList = new List<Sprite>();

	void Awake()
	{
		foreach (Sprite s in Resources.LoadAll("Fighters", typeof(Sprite))) 
		{
			spriteList.Add(s);
		}
	}
}
