using System.Linq;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject letterTilePrefab;
    public Transform letterParent;

    public string correctWord = "apple";
    public string currentDisplay = "aplqple"; // with an extra 'q'

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        SpawnLetters();
    }

    void SpawnLetters()
    {
        foreach (char c in currentDisplay)
        {
            GameObject go = Instantiate(letterTilePrefab, letterParent);
            LetterTile tile = go.GetComponent<LetterTile>();

            tile.letter = c.ToString();
            tile.letterText.text = c.ToString();
            tile.isWrong = !correctWord.Contains(c);
        }
    }

    public void OnWrongLetterRemoved()
    {
        // Optionally check win condition here
        Debug.Log("Wrong letter removed!");

        if (AllWrongLettersRemoved())
        {
            Debug.Log("✅ Word fixed!");
        }
    }

    public void OnCorrectLetterTouched()
    {
        Debug.Log("Oops! That letter belongs in the word.");
    }

    bool AllWrongLettersRemoved()
    {
        LetterTile[] remaining = letterParent.GetComponentsInChildren<LetterTile>();
        return remaining.All(tile => !tile.isWrong);
    }
}
