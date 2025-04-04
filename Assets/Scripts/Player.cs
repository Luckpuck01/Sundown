using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plyer : MonoBehaviour
{
    private string playerName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private string GetPlayerName()
    {
        return playerName;
    }

    private void SetPlayerName(string newName)
    {
        playerName = newName;
    }
}
