using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GoalScript blue, green, red, orange;
    private bool isGameOver = true;

    // For a Timer
    private float elapsedTime = 0;
    private bool isRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0;
        isRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        // If all four goals are solved then the game is over
        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved;
        if(isRunning)
        {
            elapsedTime = elapsedTime + Time.deltaTime;
        }
    }


    void OnGUI()
    {
        if (isGameOver)
        {
            isRunning = false;
            Rect rect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
            GUI.Box(rect, "Game Over");
            Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
            GUI.Label(rect2, "Good Job!");
            Rect rect3 = new Rect(Screen.width / 2 - 50, Screen.height / 2, 125, 50);
            GUI.Label(rect3, "Your Time Was: " + ((int)elapsedTime).ToString());
        }
    }
}
