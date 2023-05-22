using UnityEngine;

namespace TTRPG.UI.Fields
{
    public class AbilityScoreDnDField : AbilityScoreField
    {
        public override int ModifierScore => Mathf.FloorToInt((AbilityScore / 2) - 5);

        protected override void OnEndEdit(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                SetAbilityScore(0);
            modifierText.SetText(ModifierScore.ToString());
        }
    }
}