using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour 
{
	[HideInInspector]public string playerName;
	[HideInInspector]public int playerNumber;
	[HideInInspector]public int hitPoints = 2;
	[HideInInspector]public int storedMoney = 0;
	[HideInInspector]public int currentMoney = 0;
	[HideInInspector]public int moneyGiven = 0;
	[HideInInspector]public List<string> items = new List<string>();
	public GameManager game;
	
	void Update () 
	{
		if(hitPoints == 0)
		{
			Death ();
		}
	}

	void Death()
	{
		currentMoney = 0;
		game.playersRemaining--;
	}

	void Stop()
	{
		storedMoney += (currentMoney + game.commonMoney);
		game.commonMoney = 0;
		currentMoney = 0;
		game.playersRemaining--;
	}
}
