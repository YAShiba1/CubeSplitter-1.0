using System.Collections.Generic;
using UnityEngine;

public class CubeSplitter : MonoBehaviour
{
    [SerializeField] private CubeSpawner _cubeSpawner;
    [SerializeField] private CubeRayDetector _cubeRayDetector;
    [SerializeField] private CubeExploder _cubeExploder;

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
                List<Cube> spawnedCubes = _cubeSpawner.CreateReducedCubes(cube.transform, cube.transform.localScale);

                _cubeExploder.Explosion(spawnedCubes, cube.transform.position);
            }

            cube.SelfDestroy();
        }
    }
}
