using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScriptOrangeDis : MonoBehaviour
{
    public GameObject otherPlayer;

    void OnMouseDown()
    {
        otherPlayer.GetComponent<PlayerMovement>().enabled = false;
        GetComponent<PlayerMovement>().enabled = true;
    }
}
