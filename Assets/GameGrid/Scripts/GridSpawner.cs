using UnityEngine;

namespace SuriviveProject
{
    public class GridSpawner
    {
        private readonly Grid grid;

        private Vector2 GridScale => grid.GridScale;


        public GridSpawner(Grid grid)
        {
            this.grid = grid;
        }

        public void SetPosition(Vector2Int gridPosition, GameObject instantiatedObject)
        {
            Vector2 delta = GridToWorldPosition(gridPosition) - instantiatedObject.transform.position.ToVector2();
            instantiatedObject.transform.Translate(delta, Space.World);
        }

        public GameObject Instantiate(Vector2Int gridPosition, GameObject prefab)
        {
            GameObject spawnedCell = GameObject.Instantiate(prefab, grid.transform);
            spawnedCell.transform.Translate(GridToWorldPosition(gridPosition).ToVector3(), Space.World);
            return spawnedCell;
        }

        private Vector2 GridToWorldPosition(Vector2Int gridPosition)
        {
            return (gridPosition * GridScale);
        }
    }
}
