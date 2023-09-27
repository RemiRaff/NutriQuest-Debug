using UnityEngine;
using UnityEngine.SceneManagement;
using TNRD;

/// <summary>
/// Restarts the level when the player falls out the ground.
/// </summary>
public class GameOver : MonoBehaviour
{
    [Header("Data")]
    [SerializeField] private SerializableInterface<IReset> _scoreResetSerialized;

    // Properties for the interfaces
    private IReset _scoreReset => _scoreResetSerialized.Value;

    // Player is out
    public void OnPlayerExit()
    {
        // Reset the score
        _scoreReset.Reset();

        Debug.Log("Restart level");        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
