using UnityEngine;

namespace HSProject
{
    public class ProjectStarter : MonoBehaviour
    {
        [SerializeField]
        Grid mainGrid;

        public void Awake()
        {
            mainGrid.InitGrid(Vector2Int.zero);
        }
    }
}

