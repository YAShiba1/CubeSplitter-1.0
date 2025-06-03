using UnityEngine;

public class CubeSplitter : MonoBehaviour
{
    [SerializeField] private CubeSpawner _cubeSpawner;
    [SerializeField] private CubeRayDetector _cubeRayDetector;

    private void Update()
    {
        TrySplit();
    }

    private void TrySplit()
    {
        if (_cubeRayDetector.IsCubeHitted)
        {
            Cube cube = _cubeRayDetector.HittedCube;

            float chanceOfSplit = cube.transform.localScale.x;

            if (Random.value < chanceOfSplit)
            {
                _cubeSpawner.RandomSpawnOfReducedCubes(cube.transform, cube.transform.localScale);
                cube.Explosion(_cubeSpawner.GetListOfSpawnedCubes(), cube.transform.position);
            }

            cube.SelfDestroy();
            _cubeSpawner.ClearSpawnedCubeList();
        }
    }
}
