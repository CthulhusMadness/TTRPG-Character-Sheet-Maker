using UnityEngine;
using TTRPG.Data;
using TTRPG.Managers;

namespace TTRPG.UI.Panels
{
    public class FeatsPanel : MonoBehaviour
    {
        [SerializeField] private FeatCard featCardPrefab;
        [SerializeField] private Transform cardsParent;

        public void SetFeats(Feat[] feats)
        {
            foreach (var feat in feats)
            {
                var card = Instantiate(featCardPrefab, cardsParent);
                card.Initialize(feat);
                var uiManager = MainManager.Instance.GetUIManager<UIDnDManager>();
                card.OnButtonClicked += uiManager.PanelFeatInfo.Initialize;
            }
        }
    }
}