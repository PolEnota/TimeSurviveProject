using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SuriviveProject
{
    public class Grid : MonoBehaviour
    {
        public Vector2Int Center
        {
            get; private set;
        }
        private Vector2 gridScale = Vector2.one;

        public Vector2 GridScale
        {
            get => gridScale;
        }
        [SerializeField]
        private Vector2Int gridSize;

        private List<Cell> cells = new();

        [SerializeField]
        private GameObject exampleCell;

        private GridSpawner gridSpawner;


        public GridSpawner InitGrid(Vector2Int center)
        {
            gridSpawner = new(this);

            Center = center;

            cells = new List<Cell>();
            for (int x = center.x - gridSize.x / 2; x < center.x + gridSize.x / 2; x++)
            {
                for (int y = center.y - gridSize.y / 2; y < center.y + gridSize.y / 2; y++)
                {
                    gridSpawner.Instantiate(new Vector2Int(x,y), exampleCell);
                }
            }

            return gridSpawner;
        }
    }
}
