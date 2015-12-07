using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FighterCreator : MonoBehaviour 
{
	[SerializeField]
	public List<GameObject> fighterList = new List<GameObject>();
	public GetName getName;
	public GetLook getLook;
	public GameObject fighterPrefab;

	private string generatedName;
	private Sprite generatedLook;

	private int generatedFavour;
	private int id;
	private int oponentAmount;
	private int lookGenInt;

	private List<int> takenLooks = new List<int>();

	void Start ()
	{
		oponentAmount = 5;

		for (int i = 0; i < oponentAmount; i++) 
		{
			GenerateFighter();
		}

		takenLooks.Clear();
	}

	private void GenerateFighter()
	{
		id = Random.Range(0,3);

		generatedName = getName.nameList[id][Random.Range(0, getName.nameList[id].Count - 1)];

		while (true)
		{			
			lookGenInt = Random.Range(0,getLook.spriteList.Count);
			
			if(!takenLooks.Contains(lookGenInt))
			{
				generatedLook = getLook.spriteList[lookGenInt];
				takenLooks.Add(lookGenInt);
				break;
			}
		}
		generatedFavour = Random.Range(0, 100);
		
		GameObject newFighter = Instantiate(fighterPrefab, transform.position, Quaternion.identity) as GameObject;
		
		newFighter.GetComponent<Fighter>().AssignStats((Type)id, generatedName, generatedLook, generatedFavour);

		newFighter.name = "Fighter" + " " + generatedName;

		fighterList.Add(newFighter);
	}
}
