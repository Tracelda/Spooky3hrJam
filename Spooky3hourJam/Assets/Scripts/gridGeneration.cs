using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridGeneration : MonoBehaviour {

    public GameObject[,] pumpKingBoard;
    public GameObject pumpkingSpawner;
    public int gridDimentions;
	// Use this for initialization
	void Start () {
        setupBoard(gridDimentions);
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void setupBoard(int gridDimentions)
    {
        pumpKingBoard = new GameObject[gridDimentions, gridDimentions];
        for (int x = 0; x < gridDimentions; x++)
        {
            for (int y = 0; y < gridDimentions; y++)
            {
                pumpKingBoard[x, y] = Instantiate(pumpkingSpawner, new Vector3(x, 0, y), Quaternion.identity) as GameObject;
                pumpKingBoard[x, y].transform.parent = transform;
            }
        }
    }
}
