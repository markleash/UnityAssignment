using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    private static TurnManager instance;
    [SerializeField] private PlayerTurn playerOne;
    [SerializeField] private PlayerTurn playerTwo;
    //[SerializeField] private gameObject camera1;
    // [SerializeField] private PlayerTurn playerTwo; CAMERA2
    [SerializeField] private float timeBetweenTurns;
   // private GameManager gm;
    
    public static int currentPlayerIndex;
    private bool waitingForNextTurn;
    private float turnDelay;
    private static Timer timer;

    private void Awake() 
    {
        if (instance == null)
        {
            instance = this;
            currentPlayerIndex = 1;
            playerOne.SetPlayerTurn(1);
            playerTwo.SetPlayerTurn(2);
           // gm = transform.GetComponent<GameManager>();
            // make the first camera be the one who's awake at first
        }

    }

    private void Update() 
    {
        if (waitingForNextTurn)
        {
            turnDelay += Time.deltaTime;
            if (turnDelay >= timeBetweenTurns)
            {
                turnDelay = 0;
                waitingForNextTurn = false;
                ChangeTurn();
            }
        }    
    }

    public bool IsItPlayerTurn(int index)
    {
        if(waitingForNextTurn)
        {
            return false;
        }

        return index == currentPlayerIndex;
    }

    public static TurnManager GetInstance()
    {
        return instance;
    }

    public void TriggerChangeTurn()
    {
        waitingForNextTurn = true;
    }

    public static void ChangeTurn()
    {
        if (currentPlayerIndex == 1)
        {
            currentPlayerIndex = 2;
           // camera1.GameObject(SetActive) = false;
        }

        else if (currentPlayerIndex == 2)
        {
            currentPlayerIndex = 1;
        }

        //gm.ChangeTurn();
    }
}
