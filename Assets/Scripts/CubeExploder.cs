using System.Collections.Generic;
using UnityEngine;

public class CubeExploder : MonoBehaviour
{
    [SerializeField] private float _explosionForce;
    [SerializeField] private float _explosionRadius;

    public void Explosion(List<Cube> spawnedCubes, Vector3 explosionPosition)
    {
        foreach (Cube cube in spawnedCubes)
        {
            cube.RigidBody.AddExplosionForce(_explosionForce, explosionPosition, _explosionRadius);
        }
    }
}
