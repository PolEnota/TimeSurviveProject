using UnityEngine;

namespace HSProject
{
    public class GridSpawner
    {
        private readonly Grid grid;

        private Vector2 GridScale => grid.GridScale;


        public GridSpawner(Grid grid)
        {
            this.grid = grid;
        }

        public GameObject Instantiate(Vector2Int gridPosition, GameObject prefab)
        {
            GameObject spawnedCell = GameObject.Instantiate(prefab, grid.transform);
            spawnedCell.transform.Translate(GridToWorldPosition(gridPosition).Vector2ToVector3(), Space.World);
            return spawnedCell;
        }

        private Vector2 GridToWorldPosition(Vector2Int gridPosition)
        {
            return (gridPosition * GridScale);
        }
    }
}
