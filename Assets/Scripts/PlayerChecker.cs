using UnityEngine;

public class PlayerChecker : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Player _player;

    public Player PlayerFound { get; private set; }

    private SpriteRenderer _spriteRenderer;
    private float _distance = 3f;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Vector3 target = transform.right; 

        if (_spriteRenderer.flipX == true)
        {
            target = transform.right * -1;
        }

        RaycastHit2D[] playerFound = Physics2D.RaycastAll(transform.position, target, _distance);

        Debug.DrawRay(transform.position, target * _distance, Color.red);

        foreach (var player in playerFound)
        {
            if (player.collider.gameObject.GetComponent<Player>())
            {
                PlayerFound = player.collider.gameObject.GetComponent<Player>();

                break;
            }
            
            PlayerFound = null;
        }
    }
}
