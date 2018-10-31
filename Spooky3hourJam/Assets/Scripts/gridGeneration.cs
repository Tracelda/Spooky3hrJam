using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridGeneration : MonoBehaviour {

    public GameObject[,] pumpKingBoard;
    public GameObject pumpkingSpawner;
    public int gridDimentions;
    public int maxNPumpkins;
    private int currentNPumpkins;

    public List<PumpkinBlopper> CurrentActive = new List<PumpkinBlopper>();
	// Use this for initialization
	void Start () {
        setupBoard(gridDimentions);
	}
	
	// Update is called once per frame
	void Update () {
        enablePumpkings();
        checkNActive();
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

    public void enablePumpkings()
    {
        for (int x = 0; x < pumpKingBoard.GetLength(0); x++)
        {
            for (int y = 0; y < pumpKingBoard.GetLength(1); y++)
            {
                if( pumpKingBoard[x, y].GetComponent<PumpkinBlopper>().isActive == false)
                {
                    if (currentNPumpkins < maxNPumpkins)
                    {
                        if (Random.Range(0, 100) < 5)
                        {

                            pumpKingBoard[x, y].GetComponent<PumpkinBlopper>().activate();
                            CurrentActive.Add(pumpKingBoard[x, y].GetComponent<PumpkinBlopper>());
                            currentNPumpkins++;
                            break;
                        }
                    }
                }
            }
        }
    }

    public void checkNActive()
    {
        for (int i = 0; i < CurrentActive.Count-1; i++)
        {
            if(CurrentActive[i].isActive != true)
            {
                CurrentActive.RemoveAt(i);
                currentNPumpkins--;
            }
        }
    }
}
