using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class diceRollScript : MonoBehaviour
{
    public Text number;
    public int DiceValue;

    public void diceRoll( ) 
    {       
           DiceValue = Random.Range(1, 7);
           number.text = "You rolled " + DiceValue + "!";
           //Debug.Log("Rolled: " + DiceValue);
    }
}