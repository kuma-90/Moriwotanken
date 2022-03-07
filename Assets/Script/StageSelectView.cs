using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.UI;


public class StageSelectView : MonoBehaviour
{

    public UnityEvent Mae = new UnityEvent();
    public UnityEvent Ushiro = new UnityEvent();
    public UnityEvent Hidari = new UnityEvent();
    public UnityEvent Migi = new UnityEvent();


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
    }


    public void ChangeScene()
    {
        SceneManager.LoadScene("StageSelect");
    }

    public void OnClickChangeStage1()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void OnClickChangeStage2()
    {
        SceneManager.LoadScene("Stage2");
    }
}
