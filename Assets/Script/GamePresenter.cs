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
    [SerializeField] private GameCameraView _camera;

    // Start is called before the first frame update
    void Start()
    {


        _view.Mae.AddListener(() => _bear.MaeStraight());
        _view.Ushiro.AddListener(() => _bear.UshiroStraight());
        _view.Migi.AddListener(() => _bear.MigiStraight());
        _view.Hidari.AddListener(() => _bear.HidariStraight());
        _view.UseApple.AddListener(() => _model.UseAppleCounter());
        _view.UseHoney.AddListener(() => _model.UseHoneyCounter());

        _apple.AppleTouch.AddListener(() => _model.AfterAppleTouch());


        _honey.HoneyTouch.AddListener(() => _model.AfterHoneyTouch());


        _honeytrap.HoneyTrapTouch.AddListener(() => _model.AfterHoneyTrapTouch());


        _model.SendAppleCounter.AddListener((Apple) => _view.SetAppleCounter(Apple));
        _model.SendHoneyCounter.AddListener((Honey) => _view.SetHoneyCounter(Honey));
        _model.SendHoneyTrapCounter.AddListener((HoneyTrap) => _view.SetHoneyTrapCounter(HoneyTrap));
        _model.SendTimer.AddListener((Time) => _view.SetTimer(Time));
        _model.GameOverBool.AddListener(() => _view.GameOverPause());
        _model.GameClearBool.AddListener(() => _view.GameClearPause());
        _model.StoryBoardBoolTrue.AddListener(() => _view.StoryBoolTrue());
        _model.StoryBoardBoolFalse.AddListener(() => _view.StoryBoolFalse());
        _model.SpeedChange.AddListener(() => _bear.SpeedChange());

        _view.ChangeCamera.AddListener(() => _camera.CameraChange());

    }
}
