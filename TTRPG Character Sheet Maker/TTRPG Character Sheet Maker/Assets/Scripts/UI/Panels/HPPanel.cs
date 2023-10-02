using UnityEngine;
using TMPro;
using TTRPG.Data;

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
        public void Initialize(VitalsDnD vitals)
            => Initialize(vitals.current_hp, vitals.max_hp, vitals.temporary_hp, vitals.hit_dice);

        public void Initialize(int currentHP, int maxHP, int? temporaryHP = null, string hitDice = null)
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
