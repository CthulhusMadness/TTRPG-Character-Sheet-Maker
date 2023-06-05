using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using TTRPG.Data;

namespace TTRPG.UI
{
    public class FeatCard : MonoBehaviour
    {
        #region Fields & Properties
        public Feat Value;

        [SerializeField] private TMP_Text title;
        [SerializeField] private TMP_Text subtitle;
        [SerializeField] private Button button;

        public event Action<FeatCard> OnButtonClicked;
        #endregion Fields & Properties

        #region UnityCallbacks
        private void Start() => button.onClick.AddListener(OnButtonClick);
        private void OnDestroy() => button.onClick.RemoveListener(OnButtonClick);
        #endregion UnityCallbacks

        #region Methods
        public void Initialize(Feat value)
        {
            Value = value;
            title.SetText(Value.title);
            subtitle.SetText(Value.feat_source);
        }

        private void OnButtonClick() => OnButtonClicked?.Invoke(this);
        #endregion Methods
    }
}