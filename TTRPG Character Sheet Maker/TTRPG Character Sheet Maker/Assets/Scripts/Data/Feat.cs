using System;

namespace TTRPG.Data
{
    [Serializable]
    public class Feat
    {
        public string title;
        public string feat_source;
        public string description;

        public Feat() { }

        public Feat(string title, string featSource, string description)
        {
            this.title = title;
            this.feat_source = featSource;
            this.description = description;
        }
    }
}