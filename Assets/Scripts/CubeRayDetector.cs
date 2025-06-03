using UnityEngine;

public class CubeRayDetector : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private LayerMask _cubeLayerMask;

    public bool IsCubeHitted { get; private set; }

    public Cube HittedCube { get; private set; }

    private void Update()
    {
        DetectCube();
    }

    private void DetectCube()
    {
        IsCubeHitted = false;

        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, _cubeLayerMask))
            {
                if (hit.collider.gameObject.TryGetComponent(out Cube cube))
                {
                    IsCubeHitted = true;
                    HittedCube = cube;
                }
            }
        }
    }
}
