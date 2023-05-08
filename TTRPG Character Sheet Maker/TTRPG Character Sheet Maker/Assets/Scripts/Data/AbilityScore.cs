using System;
using UnityEngine;

namespace TTRPG.Data
{
    [Serializable]
    public class AbilityScore
    {
        public int score;

        public virtual int Modifier { get => score / 2; }
    }

    [Serializable]
    public class AbilityScoreDnD : AbilityScore
    {
        public override int Modifier { get => Mathf.FloorToInt((score - 10) / 2f); }
    }
}