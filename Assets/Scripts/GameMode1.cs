using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.PlayerLoop;
using UnityEngine.UIElements;

public class GameMode1 : MonoBehaviour
{
    public int red;
    public int yellow;
    public int green;
    public int blue;
    FindMatches findMatches;

    public GameObject next;
    public string nextScene;
    private void Update()
    {
        findMatches = GameObject.FindObjectOfType<FindMatches>();
        if (findMatches != null)
        {
            red = findMatches.redDotMatches;
            yellow = findMatches.yellowDotMatches;
            blue = findMatches.blueDotMatches;
            green = findMatches.greenDotMatches;
        }
        else
        {
            Debug.LogWarning("FindMatches object not found in the scene.");
        }
        if (yellow < 0 && red < 0)
        {
            next.SetActive(true); // Show the button
        }
        else
        {
            next.SetActive(false); // Hide the button
        }
    }

    public void NextScene()
    {
        SceneManager.LoadScene(nextScene);
    }
}
