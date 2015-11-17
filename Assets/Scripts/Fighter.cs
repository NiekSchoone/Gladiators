using UnityEngine;
using System.Collections;
using System;

public class Fighter : MonoBehaviour
{
	public string fighterName;
	public Type type;
	public Sprite look;
	public int favour;

	private SpriteRenderer sprtRenderer;

	void Start()
	{
		sprtRenderer = GetComponent<SpriteRenderer>();
		RenderNewLook();
	}

	public void AssignStats(Type newType, string newName, Sprite newLook, int newFavour)
	{
		type = newType;
		fighterName = newName;
		look = newLook;
		favour = newFavour;
	}

	void RenderNewLook()
	{
		sprtRenderer.sprite = look;
	}
}
public enum Type
{
	ROMAN,
	GREEK,
	GERMANIC
}