using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;

    private float _scaleDivider = 2f;

    public Rigidbody RigidBody => _rigidbody;

    public void ReduceScale(Vector3 scale)
    {
        transform.localScale = scale / _scaleDivider;
    }

    public void SelfDestroy()
    {
        Destroy(gameObject);
    }
}
