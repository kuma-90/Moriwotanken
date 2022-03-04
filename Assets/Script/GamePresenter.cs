using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePresenter : MonoBehaviour
{
    [SerializeField] private BearGameModel _bear;
    [SerializeField] private AppleGameModel _apple;
    [SerializeField] private HoneyGameModel _honey;
    [SerializeField] private HoneyTrapGameModel _honeytrap;
    [SerializeField] private GameView _view;
    [SerializeField] private GameModel _model;
    // Start is called before the first frame update
    void Start()
    {

        _view.Mae.AddListener(() => _bear.MaeStraight());
        _view.Ushiro.AddListener(() => _bear.UshiroStraight());
        _view.Migi.AddListener(() => _bear.MigiStraight());
        _view.Hidari.AddListener(() => _bear.HidariStraight());
        _view.UseApple.AddListener(() => _model.UseAppleCounter());
        _view.UseHoney.AddListener(() => _model.UseHoneyCDounter());

        _apple.AppleTouch.AddListener(() => _model.AfterAppleTouch());


        _honey.HoneyTouch.AddListener(() => _model.AfterHoneyTouch());


        _honeytrap.HoneyTrapTouch.AddListener(() => _model.AfterHoneyTrapTouch());


        _model.SendAppleCounter.AddListener((Apple) => _view.SetAppleCounter(Apple));
        _model.SendHoneyCounter.AddListener((Honey) => _view.SetHoneyCounter(Honey));
        _model.SendHoneyTrapCounter.AddListener((HoneyTrap) => _view.SetHoneyTrapCounter(HoneyTrap));

    }
}
