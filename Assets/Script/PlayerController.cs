using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    private bool _facingLeft;

    private PlayerInput _input;
    private Rigidbody2D _rigidbody;

    //(жизненный цикл юнити)это запускается при старте игры
    void Start()
    {
        //получаем доступ к необходимым компонентам
        _input = GetComponent<PlayerInput>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    //(жизненный цикл юнити)это происходит каждый фиксированный апдейт
    private void FixedUpdate()
    {
        //двигаем персонажа
        Move();
    }

    //метод передвижения персонажа
    private void Move()
    {
        _rigidbody.velocity = new Vector2(_input.Horizontal, _input.Vertical) * _speed;
        
        if (_input.Horizontal > 0 && _facingLeft)
        {
            Flip();
        }
        else if (_input.Horizontal < 0 && !_facingLeft)
        {
            Flip();
        }
    }
      
    private void Flip()
    {
        _facingLeft = !_facingLeft;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }       
}
