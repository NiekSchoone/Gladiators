using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerCreator : MonoBehaviour 
{
	private int slotPosition;
	private int id;
	private Sprite playerSprite;
	private string playerName;

	public Image selectionImage;
	public InputField nameField;
	public GetLook getLook;
	public GameObject playerPrefab;
	public GameObject creationWindow;

	void Start()
	{
		slotPosition = 0;
		changeSprite();
	}

	public void GetIdInt(int newId)
	{
		id = newId;
	}

	public void RightSelection()
	{
		if(slotPosition < getLook.spriteList.Count - 1)
		{
			slotPosition++;
			changeSprite();
		}else
		{
			slotPosition = 0;
			changeSprite();
		}
	}

	public void LeftSelection()
	{
		if(slotPosition > 0)
		{
			slotPosition--;
			changeSprite();
		}else
		{
			slotPosition = getLook.spriteList.Count -1;
			changeSprite();
		}
	}

	public void InputName()
	{
		playerName = nameField.text;
	}

	public void FinaliseCreation()
	{
		if(playerName == null)
		{
			playerName = "The nameless";
		}
		if(playerName != null && playerSprite != null)
		{
			GameObject newPlayer = Instantiate(playerPrefab, transform.position, Quaternion.identity) as GameObject;
			newPlayer.GetComponent<Fighter>().AssignStats((Type)id, playerName, playerSprite, 50);
			newPlayer.name = playerName;
			DisableCreationWindow();
		}
	}

	public void DisableCreationWindow()
	{
		creationWindow.SetActive(false);
	}

	void changeSprite()
	{
		selectionImage.sprite = getLook.spriteList[slotPosition];
		playerSprite = getLook.spriteList[slotPosition];
	}
}
