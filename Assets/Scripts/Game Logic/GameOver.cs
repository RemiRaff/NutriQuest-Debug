using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Restarts the level when the player falls out the ground.
/// </summary>
public class GameOver : MonoBehaviour
{
    // Player is out
    public void OnPlayerExit()
    {
        // TODO reset score
        Debug.Log("Restart level");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
