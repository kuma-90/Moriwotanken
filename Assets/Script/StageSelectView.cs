using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.UI;

public class StageSelectView : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame



    public void ChangeScene()
    {
        SceneManager.LoadScene("StageSelect");
    }

    public void OnClickChangeStage1()
    {
        SceneManager.LoadScene("Stage1");
    }

}
