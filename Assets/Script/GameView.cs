using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameView : MonoBehaviour
{
    public UnityEvent Mae = new UnityEvent();
    public UnityEvent Ushiro = new UnityEvent();
    public UnityEvent Hidari = new UnityEvent();
    public UnityEvent Migi = new UnityEvent();
    public UnityEvent UseApple = new UnityEvent();
    public UnityEvent UseHoney = new UnityEvent();


    public Text Time;
    public Text Apple;
    public Text Honey;
    public Text HoneyTrap;

    private int AppleCount;
    private int HoneyCount;
    private int HoneyTrapCount;
    //private int Minutes;

    private float Timer;

    [SerializeField]
    private GameObject gameClearPauseUI;
    [SerializeField]
    private GameObject gameOverPauseUI;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Mae.Invoke();
        }

        if (Input.GetKey(KeyCode.S))
        {
            Ushiro.Invoke();
        }

        if (Input.GetKey(KeyCode.A))
        {
            Hidari.Invoke();
        }

        if (Input.GetKey(KeyCode.D))
        {
            Migi.Invoke();
        }

        if (Input.GetKey(KeyCode.F))
        {
            UseApple.Invoke();
        }

        if (Input.GetKey(KeyCode.C))
        {
            UseHoney.Invoke();
        }

        Apple.text = "もってるりんご:" + AppleCount.ToString();
        Honey.text = "もってるはちみつ:" + HoneyCount.ToString();
        HoneyTrap.text = "もってる罠:" + HoneyTrapCount.ToString();
        Time.text = "残りの時間" + Timer.ToString("F1");
    }


    public void GameOverPause()
    {

        gameOverPauseUI.SetActive(true);
        StartCoroutine("ChangeSelectScene");
    }


    IEnumerator ChangeSelectScene()
    {
        yield return new WaitForSeconds(3);

        SceneManager.LoadScene("StageSelect");
        yield break;
    }


    public void SetAppleCounter(int Apple)
    {
        AppleCount = Apple;//エネミーのまっくすHPをセットする

    }

    public void SetHoneyCounter(int Honey)
    {
        HoneyCount = Honey;//エネミーのまっくすHPをセットする
    }

    public void SetHoneyTrapCounter(int HoneyTrap)
    {
        HoneyTrapCount = HoneyTrap;//エネミーのまっくすHPをセットする
    }

    public void SetTimer(float Time)
    {
        Timer = Time;
    }

    //public void SetMinute(int Minute)
    //{
    //    Minutes = Minute;
    //}

}
