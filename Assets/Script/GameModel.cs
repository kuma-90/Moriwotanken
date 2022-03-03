using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;


public class GameModel : MonoBehaviour
{
    public float Timer;
    public float MaxTime;

    private int AppleCounter = 0;
    private int HoneyCounter = 0;
    private int HoneyTrapCounter = 0;

    public IntEvent SendAppleCounter = new IntEvent();
    public IntEvent SendHoneyCounter = new IntEvent();
    public IntEvent SendHoneyTrapCounter = new IntEvent();


    public int _SendAppleCounter;
    public int _SendHoneyCounter;
    public int _SendHoneyTrapCounter;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AfterAppleTouch()
    {
        AppleCounter += 1;

    }

    public void AfterHoneyTouch()
    {
        HoneyCounter += 1;

    }

    public void AfterHoneyTrapTouch()
    {

    }


    public void SendApple(int Apple)
    {
        AppleCounter = Apple;
        SendAppleCounter.Invoke(_SendAppleCounter);
    }

    public void SendHoney(int Honey)
    {
        HoneyCounter = Honey;
        SendHoneyCounter.Invoke(_SendHoneyCounter);
    }

    public void SendHoneyTrap(int HoneyTrap)
    {
        HoneyTrapCounter = HoneyTrap;
        SendHoneyTrapCounter.Invoke(_SendHoneyTrapCounter);
    }
}
