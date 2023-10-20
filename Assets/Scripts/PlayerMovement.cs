using UnityEngine;

[RequireComponent(typeof(SpriteRenderer), typeof(Animator))]

public class PlayerMovement : MonoBehaviour
{
    private const string Speed = "Speed";
    private const string Jump = "Jump";

    [SerializeField] private float _speed;

    private Animator _animator;
    private SpriteRenderer _spriteRenderer;
    private float _jumpForce = 10f;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        _animator.SetFloat(Speed, 0);

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);

            _spriteRenderer.flipX = false;
            _animator.SetFloat(Speed, 1);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(_speed * Time.deltaTime * -1, 0, 0);

            _spriteRenderer.flipX = true;
            _animator.SetFloat(Speed, 1);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0, _jumpForce * Time.deltaTime, 0);

            _animator.SetTrigger(Jump);
        }
    }
}
