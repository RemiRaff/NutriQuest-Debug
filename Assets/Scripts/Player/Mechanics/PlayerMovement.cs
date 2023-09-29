using UnityEngine;

/// <summary>
/// Makes the player move with the physics engine.
/// </summary>
public class PlayerMovement : MonoBehaviour, IMove
{
    [Header("Components")]
    [SerializeField] private Rigidbody _rb;

    [Header("Parameters")]
    [SerializeField] private float _speed = 5f;

    [Header("Animations")]
    [SerializeField] private PlayerAnimations _animations;

    private Vector2 _movement;

    /// <summary>
    /// Moves the player with the physics engine based on the given movement.
    /// The x component moves the player on the x axis, the y component moves the player on the z axis.
    /// </summary>
    /// <param name="movement">The input movement (for example, from an input controller)</param>
    public void Move(Vector2 movement)
    {
        _movement = movement;
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector3(_movement.x * _speed, _rb.velocity.y, _movement.y * _speed);
        // _rb.position = new Vector3(_rb.position.x, 1, _rb.position.z); // force y position to 1 for positive gravity

        // Another way to make movement but player goes up (y increases)
        // Vector3 m_Input = new Vector3(_movement.x, 0, _movement.y);
        // _rb.MovePosition(transform.position + m_Input * Time.deltaTime * _speed);
        _animations?.Move(_movement.sqrMagnitude); // test if animation is null for testing

        // Rotate the player to the direction of _movement
        if (_movement != Vector2.zero)
        {
            _rb.rotation = Quaternion.LookRotation(new Vector3(_movement.x, 0f, _movement.y));
        }
    }
}
