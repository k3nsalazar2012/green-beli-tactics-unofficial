using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GBTactics.CardTracker
{
    public class CardManager : MonoBehaviour
    {
        [SerializeField] private Card[] cards = null;

        public void ResetCards()
        {
            foreach (var card in cards)
            {
                card.Reset();
            }
        }

        public void Exit() => Application.Quit();
    }
}