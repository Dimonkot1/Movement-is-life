using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    private bool _facingLeft;

    private PlayerInput _input;
    private Rigidbody2D _rigidbody;

    //(��������� ���� �����)��� ����������� ��� ������ ����
    void Start()
    {
        //�������� ������ � ����������� �����������
        _input = GetComponent<PlayerInput>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    //(��������� ���� �����)��� ���������� ������ ������������� ������
    private void FixedUpdate()
    {
        //������� ���������
        Move();
    }

    //����� ������������ ���������
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
