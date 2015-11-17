using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour 
{
	public GameObject weapon;

	void Start () 
	{

	}
	
	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			weapon.GetComponent<Animation>().Play();
		}
	}
}
