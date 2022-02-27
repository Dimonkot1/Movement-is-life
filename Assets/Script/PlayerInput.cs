using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private float _vertical;
    private float _horizontal;

    public float Vertical { get => _vertical; }
    public float Horizontal { get => _horizontal; }

    void Update()
    {
        _vertical = Input.GetAxisRaw("Vertical") ;
        _horizontal = Input.GetAxisRaw("Horizontal");
    } 

}
