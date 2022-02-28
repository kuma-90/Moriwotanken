using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelectView : MonoBehaviour
{
    [SerializeField] private StartModel _model;
    [SerializeField] private StartPresenter _presenter;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _model.StartButton.AddListener(() => _presenter.ChangeScene());
    }
}
