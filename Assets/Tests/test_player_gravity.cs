using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

// Le personnage ne tombe pas
// Comportement attendu :
// Lorsque le joueur marche sur un emplacement vide, il devrait tomber et un game over devrait se d�clencher pour recommencer le niveau.
// Comportement actuel :
// Le joueur flotte sur les emplacements vides lorsqu�il marche dessus et ne tombe pas.

public class test_player_gravity
{
    // Test if gravity makes the player falling...
    [UnityTest]
    public IEnumerator test_player_gravity_gravity_makes_player_falling()
    {
        // ARRANGE
        SceneManager.LoadScene("Scenes/TestingEmptyScene");
        yield return new WaitForSeconds(0.2f); // have to wait for loading
        GameObject playerInScene = GameObject.Find("Player");
        Rigidbody rb = playerInScene.GetComponent<Rigidbody>();

        // ACT
        yield return new WaitForSeconds(1.0f); // have to wait for mechanics update

        // ASSERT
        Assert.IsTrue(rb.velocity.y < 0); // player falls
        Assert.IsTrue(rb.position.y < 0.0f);
        yield return null;
        TestContext.WriteLine($"Rigidbody y velocity: {rb.velocity.y}, Rigidbody y pos: {rb.position.y}.");
    }
}
