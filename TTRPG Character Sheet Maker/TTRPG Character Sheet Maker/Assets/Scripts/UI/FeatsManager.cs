using System.Collections;
using System.Collections.Generic;
using TTRPG.Data;
using UnityEngine;

namespace TTRPG.UI
{
    public class FeatsManager : MonoBehaviour
    {
        [SerializeField] private FeatCard featCardPrefab;
        [SerializeField] private Transform cardsParent;

        public void SetFeats(Feat[] feats)
        {
            foreach (var feat in feats)
            {
                var card = Instantiate(featCardPrefab, cardsParent);
                card.Initialize(feat);
            }
        }
    }
}