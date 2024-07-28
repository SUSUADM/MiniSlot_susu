﻿using JGM.Game.Audio;
using JGM.Game.Events;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using DG.Tweening;

namespace JGM.Game.UI
{
    [RequireComponent(typeof(Button))]
    public class SpinButton : MonoBehaviour
    {
        [Inject] private IAudioService _audioService;
        [Inject] private IEventTriggerService _eventTriggerService;
        public RectTransform startGameTxt;

        private Button _spinButton;

        private void Awake()
        {
            _spinButton = GetComponent<Button>();
        }

        public void TriggerStartSpinEvent() 
        {
            //_audioService.Play("Press Button");
            StartCoroutine(SendStartSpinEventAfterAudioFinishedPlaying());
        }

        private IEnumerator SendStartSpinEventAfterAudioFinishedPlaying()
        {
            yield return new WaitWhile(() => _audioService.IsPlaying("Press Button"));
            startGameTxt.DOLocalMoveY(-8.00f, 0.1f).SetEase(Ease.InBounce);           
            yield return new WaitForSeconds(1f);
            startGameTxt.DOLocalMoveY(530f, 0.1f).SetEase(Ease.InBounce);
            yield return new WaitForSeconds(0.9f);
            _eventTriggerService.Trigger("Start Spin");
        }

        public void SetButtonInteraction(bool makeInteractable)
        {
            _spinButton.interactable = makeInteractable;
        }
    }
}