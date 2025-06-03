using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private Cube _cubePrefab;
    [SerializeField] private Transform[] _spawnPoints;

    private List<Cube> _spawnedCubes;

    private void Start()
    {
        _spawnedCubes = new List<Cube>();
        SpawnStartingCubes();
    }

    public void ClearSpawnedCubeList()
    {
        _spawnedCubes.Clear();
    }

    public List<Cube> GetListOfSpawnedCubes()
    {
        return _spawnedCubes;
    }

    public void RandomSpawnOfReducedCubes(Transform spawnPoimt, Vector3 scaleOfHittedCube)
    {
        int minRandomNumber = 2;
        int maxnRandomNumber = 7;

        int randomNumberOfCubes = Random.Range(minRandomNumber, maxnRandomNumber);

        for (int i = 0; i < randomNumberOfCubes; i++)
        {
            Cube newCube = CreateCube(spawnPoimt);
            newCube.ReduceScale(scaleOfHittedCube);

            _spawnedCubes.Add(newCube);
        }
    }

    private Cube CreateCube(Transform spawnPoint)
    {
        return Instantiate(_cubePrefab, spawnPoint.position, Quaternion.identity);
    }

    private void SpawnStartingCubes()
    {
        if (_spawnPoints.Length > 0)
        {
            for (int i = 0; i < _spawnPoints.Length; i++)
            {
                CreateCube(_spawnPoints[i]);
            }
        }
        else
        {
            Debug.Log($"{nameof(_spawnPoints)} - пуст.");
        }
    }
}
