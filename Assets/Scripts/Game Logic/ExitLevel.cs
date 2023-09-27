using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Exits the level when the player reaches the end.
/// </summary>
public class ExitLevel : MonoBehaviour
{
    public void Exit()
    {
        // TODO : Exit the level
        Debug.Log("Exit level");
        // Reload current level, TODO : create new level and load it (Fade sceen)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
