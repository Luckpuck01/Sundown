using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LetterTile : MonoBehaviour
{
    public TextMeshProUGUI letterText;
    public string letter;
    public bool isWrong;

    public void OnPressed()
    {
        if (isWrong)
        {
            Destroy(gameObject); // or animate away
            GameManager.Instance.OnWrongLetterRemoved();
        }
        else
        {
            GameManager.Instance.OnCorrectLetterTouched();
        }
    }
}

