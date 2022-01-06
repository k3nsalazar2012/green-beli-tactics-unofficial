using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace GBTactics.CardTracker
{
    public class Card : MonoBehaviour
    {
        [SerializeField] private Gradient gradientColor;

        const float ANIMATION_DURATION = 0.25f;
        const float ANIMATION_DELAY = 0.05f;

        private float _currentY = 0f;
        private bool _isSelected = false;
        private RectTransform _rectTransform = null;

        private Image _image = null;

        private void Awake() => _image = GetComponent<Image>();

        public void SelectCard()
        {           
            _isSelected = !_isSelected;

            if (_isSelected)
                _image.DOColor(gradientColor.Evaluate(1f), ANIMATION_DURATION);
            else
                _image.DOColor(gradientColor.Evaluate(0f), ANIMATION_DURATION);
        }

        public void Reset()
        {
            _isSelected = false;
            _image.DOColor(gradientColor.Evaluate(0f), ANIMATION_DURATION);
        }        
    }
}