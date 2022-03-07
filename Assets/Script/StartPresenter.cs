using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StartPresenter : MonoBehaviour

{
    [SerializeField] private StartModel _model;
    [SerializeField] private StageSelectView _view;
    [SerializeField] private StageSelectBearModel _bear;

    // Start is called before the first frame update
    void Start()
    {

        _model.StartButton.AddListener(() => _view.ChangeScene());

        _view.Mae.AddListener(() => _bear.MaeStraight());
        _view.Ushiro.AddListener(() => _bear.UshiroStraight());
        _view.Migi.AddListener(() => _bear.MigiStraight());
        _view.Hidari.AddListener(() => _bear.HidariStraight());
    }

    // Update is called once per frame
    void Update()
    {

    }
}

