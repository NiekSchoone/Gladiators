using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Health : MonoBehaviour 
{
	private float maxHealth;
	private float currentHealth;
	private float calcHealth;

	public GameObject healthBar;

	void Start () 
	{
		maxHealth = 200;
		currentHealth = maxHealth;
	}

	public void HealthDecrease(int damage)
	{
		currentHealth -= damage;
		calcHealth = currentHealth / maxHealth;
		SetHealthBar(calcHealth);
		Death();
	}

	public void Death()
	{
		if(currentHealth <= 0)
		{
			Destroy(this.gameObject);
			if(this.gameObject.tag == "Player")
			{

			}
		}
	}

	public void SetHealthBar(float myHealth)
	{
		healthBar.transform.localScale = new Vector3(myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
	}
}
