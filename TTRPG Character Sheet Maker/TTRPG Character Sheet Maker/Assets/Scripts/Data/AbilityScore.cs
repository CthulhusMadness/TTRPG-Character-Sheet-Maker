using System;
using UnityEngine;

namespace TTRPG.Data
{
    [Serializable]
    public class AbilityScore
    {
        public virtual int Modifier { get => score / 2; }

        public int score;

        public AbilityScore (int score) => this.score = score;
    }

    [Serializable]
    public class AbilityScoreDnD : AbilityScore
    {
        public override int Modifier { get => Mathf.FloorToInt((score - 10) / 2f); }

        public AbilityScoreDnD(int score) : base(score) {}
    }
}