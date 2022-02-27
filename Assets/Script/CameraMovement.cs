using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float _dampTime = 0.4f;
    [SerializeField] private Transform _player;

    private Transform _cameraTarget;
    private Vector3 _cameraPos;
    private Vector3 _velocity = Vector3.zero;

    private Transform _transform;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }

    private void Start()
    {
        _cameraTarget = _player;
    }

    private void Update()
    {
        _cameraPos = new Vector3(_cameraTarget.position.x, _cameraTarget.position.y, -60f);
        _transform.position = Vector3.SmoothDamp(_transform.position, _cameraPos, ref _velocity, _dampTime);
    }

    public void SetTarget(Transform target)
    {
        _cameraTarget = target;
    }

    public void ReturnToPlayer()
    {
        _cameraTarget = _player;
    }
}
