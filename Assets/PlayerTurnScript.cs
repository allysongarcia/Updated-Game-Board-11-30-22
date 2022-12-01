using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTurnScript : MonoBehaviour
{
    public Text playerText;
    public int Player;
    public int numPlayers = 4;

    public void firstTurn()
    {
	Player = 1;
	playerText.text = "It is Player " + Player + "'s turn!";
	Player++;
    }

    public void printPlayerTurn()
    {
	playerText.text = "It is Player " + Player + "'s turn!";
	if(Player == numPlayers) Player = 1;
	else Player++;
    }
}
