using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(SpriteRenderer))]

public class WayPointMovement : MonoBehaviour
{
    [SerializeField] private Transform _path;
    [SerializeField] private float _speed;

    private Transform[] _points;
    private SpriteRenderer _spriteRenderer;
    private PlayerChecker _playerChecker;
    private int _currentPoint;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _playerChecker = GetComponent<PlayerChecker>();
    }

    private void Start()
    {
        _points = new Transform[_path.childCount];

        for (int i = 0; i < _path.childCount; i++)
        {
            _points[i] = _path.GetChild(i);
        }
    }

    private void Update()
    {
        Transform target = _points[_currentPoint];

        if (_playerChecker.PlayerFound != null)
        {
            target = _playerChecker.PlayerFound.transform;
        }

        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

        if (transform.position == target.position)
        { 
            _currentPoint++;
            _spriteRenderer.flipX = true;

            if ( _currentPoint >= _points.Length)
            {
                _currentPoint = 0;
                _spriteRenderer.flipX = false;
            }
        }
    }
}
