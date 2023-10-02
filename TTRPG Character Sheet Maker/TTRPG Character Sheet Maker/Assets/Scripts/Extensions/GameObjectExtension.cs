using UnityEngine;

namespace TTRPG.Extensions
{
    public static class GameObjectExtension
    {
        public static GameObject GetParentRoot(this GameObject child) => 
            child.transform.parent == null ? child : GetParentRoot(child.transform.parent.gameObject);
    }
}
