using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float vertical;
    public float horizontal;


    void Update()
    {
        vertical = Input.GetAxisRaw("Vertical") ;
        horizontal = Input.GetAxisRaw("Horizontal");
    } 

}
