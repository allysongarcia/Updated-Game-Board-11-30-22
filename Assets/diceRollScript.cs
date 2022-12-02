using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class diceRollScript : MonoBehaviour
{
    public Text number;
    public Text total;
    public int DiceValue;
    public int DiceValue2;
    public int DiceTotal;

    public void diceRoll( ) 
    {       
           DiceValue = Random.Range(1, 7);
           DiceValue2 = Random.Range(1,7);
           DiceTotal = DiceValue + DiceValue2;
           number.text = "You rolled " + DiceValue + " and " + DiceValue2 + "!\nMove " + DiceTotal + " spaces!";
           //Debug.Log("Rolled: " + DiceValue);
    }

    public void getTotal( )
    {
    	total.text = "Spaces to Move: " + DiceTotal;
    }
}