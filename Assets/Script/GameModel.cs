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
        SendApple(AppleCounter);
    }

    public void AfterHoneyTouch()
    {
        HoneyCounter += 1;
        SendHoney(HoneyCounter);
    }

    public void AfterHoneyTrapTouch()
    {
        HoneyTrapCounter += 1;
        SendHoneyTrap(HoneyTrapCounter);
    }

    public void UseAppleCounter()
    {
        if (AppleCounter >= 1)
        {
            AppleCounter -= 1;
            SendApple(AppleCounter);
        }

    }

    public void UseHoneyCDounter()
    {
        if (HoneyCounter >= 1)
        {
            HoneyCounter -= 1;
            SendHoney(HoneyCounter);
        }
    }

    public void SendApple(int Apple)
    {

        SendAppleCounter.Invoke(Apple);
    }

    public void SendHoney(int Honey)
    {

        SendHoneyCounter.Invoke(Honey);
    }

    public void SendHoneyTrap(int HoneyTrap)
    {

        SendHoneyTrapCounter.Invoke(HoneyTrap);
    }


}
