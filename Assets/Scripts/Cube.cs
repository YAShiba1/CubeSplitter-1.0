using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _explosionForce;
    [SerializeField] private float _explosionRadius;

    private float _scaleDivider = 2f;

    public void Explosion(List<Cube> spawnedCubes, Vector3 explosionPosition)
    {
        foreach(Cube cube in spawnedCubes)
        {
            cube.GetRigidbody().AddExplosionForce(_explosionForce, explosionPosition, _explosionRadius);
        }
    }

    public Rigidbody GetRigidbody()
    {
        return _rigidbody;
    }

    public void ReduceScale(Vector3 scale)
    {
        transform.localScale = scale / _scaleDivider;
    }

    public void SelfDestroy()
    {
        Destroy(gameObject);
    }
}
