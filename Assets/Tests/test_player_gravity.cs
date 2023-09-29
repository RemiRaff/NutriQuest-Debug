using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

// Le personnage ne tombe pas
// Comportement attendu :
// Lorsque le joueur marche sur un emplacement vide, il devrait tomber et un game over devrait se déclencher pour recommencer le niveau.
// Comportement actuel :
// Le joueur flotte sur les emplacements vides lorsqu’il marche dessus et ne tombe pas.

public class test_player_gravity
{
    // A Test behaves as an ordinary method
    [Test]
    public void test_player_gravitySimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // Test if gravity makes the player falling...
    [UnityTest]
    public IEnumerator test_player_gravity_gravity_makes_player_falling()
    {
        // ARRANGE
        SceneManager.LoadScene(1); // scene added to "Scenes in build", TestingEmptyScene
        yield return new WaitForSeconds(0.2f); // have to wait for loading
        GameObject playerInScene = GameObject.Find("Player");
        Rigidbody rb = playerInScene.GetComponent<Rigidbody>();

        // ACT
        yield return new WaitForSeconds(1.0f); // have to wait for mechanics update

        // ASSERT
        Assert.IsTrue(rb.velocity.y < 0); // player falls
        Assert.IsTrue(rb.position.y < 0.0f);
        Debug.Log($"y velocity: {rb.velocity.y}, y pos: {rb.position.y}.");
    }
}
