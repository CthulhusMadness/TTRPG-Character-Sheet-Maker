using TMPro;
using UnityEngine;

namespace TTRPG.UI.Panels
{
    public class HPPanel : MonoBehaviour
    {
        #region Fields
        [SerializeField] private TMP_InputField currentHPField;
        [SerializeField] private TMP_InputField maxHPField;
        [SerializeField] private TMP_InputField temporaryHPField;
        [SerializeField] private TMP_InputField hitDiceField;
        #endregion Fields

        #region Methods
        public void Initalize(int currentHP, int maxHP, int? temporaryHP = null, string hitDice = null)
        {
            currentHPField.SetTextWithoutNotify(currentHP.ToString());
            maxHPField.SetTextWithoutNotify(maxHP.ToString());
            if (temporaryHP != null)
                temporaryHPField.SetTextWithoutNotify(temporaryHP.ToString());
            if (string.IsNullOrEmpty(hitDice))
                hitDiceField.SetTextWithoutNotify(hitDice);
        }
        #endregion Methods
    }
}
