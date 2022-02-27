using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private PlayerInput _input;
    private Rigidbody2D _rigidbody;

    void Start()
    {
        _input = GetComponent<PlayerInput>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector2(_input.horizontal, _input.vertical);
    }

}
