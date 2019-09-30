using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
	#region Editor Variables
	[SerializeField]
	[Tooltip("Player's starting health. ")]
	private int m_MaxHealth;
	#endregion

	#region Private Variables
	private float p_CurHealth;
	public float currentHealth
	{
		get
		{
			return p_CurHealth;
		}
	}
	
	#endregion

	#region Initialization
	// Start is called before the first frame update
	void Awake()
	{
		p_CurHealth = m_MaxHealth;
	}

	void Start()
	{

	}
	#endregion

	// Update is called once per frame
	#region Health Methods
	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Enemy")
		{
			p_CurHealth -= 1;
			if (p_CurHealth <= 0)
			{
				// death method
				SceneManager.LoadScene("GameOver");
			}
		}
	}

	#endregion
}
