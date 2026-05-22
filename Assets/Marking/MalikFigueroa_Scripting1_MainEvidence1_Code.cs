using UnityEngine;
using System;
using System.Collections.Generic;

public class Grid : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Storing the grid as a 2D string array
        string[,] grid = {
            { "1", "2", "3" },
            { "4", "5", "6" },
            { "7", "8", "9" }
        };

        //Assigning string names to match each grid position. 
        // This will help us display the paths more neatly.
        string G1 = grid[0,0]; string G2 = grid[0,1]; string G3 = grid[0,2];
        string G4 = grid[1,0]; string G5 = grid[1,1]; string G6 = grid[1,2];
        string G7 = grid[2,0]; string G8 = grid[2,1]; string G9 = grid[2,2];

        //Using the two axes of the two dimensional array to represent the X and Y coordinates of the grid, 
        // then using those coordinates to get the values of the starting and ending row (y-axis) and column (x-axis) positions on the grid.
        int startR = 0; int startC = 0;
        int endR = 2; int endC = 2;

        int deltaRow = endR - startR;
        int deltaCol = endC - startC;
        int totalSteps = deltaRow + deltaCol;

        Debug.Log($"The start point at the top left of the grid is at this cell: ({startR}, {startC})");
        Debug.Log($"The end point at the bottom right of the grid is at this cell: ({endR}, {endC})");
        Debug.Log($"The number of steps I need to take in the X direction is: {deltaCol} steps to the right");
        Debug.Log($"The number of steps I need to take in the Y direction is: {deltaRow} steps downwards");
        Debug.Log($"The number of steps I need to take in each of the shortest possible paths is: {totalSteps}");
        Debug.Log("Each of the possible paths we can take are as follows: ");

        //For loop that loops through each of the 6 possible paths and prints all of them in the console. I hardcoded each possible path as cases in a switch statement.
        for (int pathNumber = 1; pathNumber <= 6; pathNumber++)
        {
            switch (pathNumber)
            {
                case 1:
                print("G1 -> G4 -> G7 -> G8 -> G9");
                break;

                case 2:
                print("G1 -> G4 -> G5 -> G8 -> G9");
                break;

                case 3:
                print("G1 -> G4 -> G5 -> G6 -> G9");
                break;

                case 4:
                print("G1 -> G2 -> G5 -> G8 -> G9");
                break;

                case 5:
                print("G1 -> G2 -> G5 -> G6 -> G9");
                break;

                case 6:
                print("G1 -> G2 -> G3 -> G6 -> G9");
                break;

                default:
                print("You are not on the shortest path");
                break;
            }

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
