using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;


public class GameModel : MonoBehaviour
{

    private float countdown = 2.0f;
    private int minute;

    private int AppleCounter = 0;
    private int HoneyCounter = 0;
    private int HoneyTrapCounter = 0;

    public IntEvent SendAppleCounter = new IntEvent();
    public IntEvent SendHoneyCounter = new IntEvent();
    public IntEvent SendHoneyTrapCounter = new IntEvent();
    public IntEvent SendMinuteTime = new IntEvent();

    public FloatEvent SendTimer = new FloatEvent();

    public UnityEvent GameOverBool = new UnityEvent();


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;

        //if (countdown  60f)
        //{
        //    minute += 1;
        //    countdown = 60.0f;
        //}
        SendTime(countdown);
        if (countdown <= 0)
        {
            countdown = 0;
            GameOverBool.Invoke();
        }
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

    public void SendTime(float Time)
    {
        SendTimer.Invoke(Time);
    }

    public void SendMinute(int MinuteTime)
    {
        SendMinuteTime.Invoke(MinuteTime);
    }



}
