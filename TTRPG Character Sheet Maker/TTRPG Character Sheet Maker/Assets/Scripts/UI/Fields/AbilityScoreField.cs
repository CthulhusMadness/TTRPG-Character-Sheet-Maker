using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

namespace TTRPG.UI.Fields
{
    public class AbilityScoreField : MonoBehaviour
    {
        public int AbilityScore => string.IsNullOrWhiteSpace(scoreField.text) ? 0 : Int16.Parse(scoreField.text);
        public virtual int ModifierScore { get; }

        [SerializeField] protected TMP_InputField scoreField;
        [SerializeField] protected TMP_Text modifierText;

        protected virtual void Start()
        {
            scoreField.onEndEdit.AddListener(OnEndEdit);
        }

        protected virtual void OnDestroy()
        {
            scoreField.onEndEdit.RemoveListener(OnEndEdit);
        }

        protected virtual void OnEndEdit(string text) { }

        public void SetAbilityScore(int value)
        {
            scoreField.text = value.ToString();
            scoreField.onEndEdit.Invoke(AbilityScore.ToString());
        }
    }
}