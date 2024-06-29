using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characterSelection : MonoBehaviour
{

    public GameObject[] characters;
    public int currentCharacter;
    void Start()
    {
        currentCharacter = 0;
        foreach (GameObject character in characters)
        {
            character.SetActive(false);
        }
        characters[currentCharacter].SetActive(true);
    }

    public void NextCharacter()
    {
        characters[currentCharacter].SetActive(false);
        if (currentCharacter >= characters.Length - 1)
        {
            currentCharacter = 0;
        }
        else
        {
            currentCharacter++;

        }
        characters[currentCharacter].SetActive(true);

    }

    public void PreviousCharacter()
    {
        characters[currentCharacter].SetActive(false);
        if (currentCharacter <= 0)
        {
            currentCharacter = characters.Length - 1;
        }
        else
        {

            currentCharacter--;
        }
        characters[currentCharacter].SetActive(true);

    }


}