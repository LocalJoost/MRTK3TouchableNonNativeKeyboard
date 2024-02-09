﻿using Microsoft.MixedReality.GraphicsTools;
using UnityEngine;
using UnityEngine.UI;

namespace MRTKExtensions.Keyboard
{
    public class NonNativeKeyboardTouchAdapter : MonoBehaviour
    {
        private void Start()
        {
            var defaultAudioComponent = GetComponent<AudioSource>();
            defaultAudioComponent.playOnAwake = false;
            defaultAudioComponent.spatialize = false;
            
            var buttons = GetComponentsInChildren<Button>(true);
            foreach (var button in buttons)
            {
                // The search box has an incorrect collider and should not act as a button anyway
                if (button.gameObject.name != "search")
                {
                    button.gameObject.EnsureComponent<NonNativeKeyTouchAdapter>();
                }
            }
        }
    }
}