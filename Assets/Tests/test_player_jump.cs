using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using NSubstitute;
using UnityEngine.SceneManagement;

// Impossible de sauter
// Comportement attendu:
// Lorsque l'on appuie sur la barre espace du clavier, le personnage joueur est censé pouvoir sauter.
// Comportement actuel :
// Le joueur ne saute pas en appuyant sur la touche correspondante.

public class test_player_jump
{
    // Test jump() call
    [Test]
    public void test_player_jump_call_Jump()
    {
        // ARRANGE
        GameObject go = new GameObject();
        PlayerController controller = go.AddComponent<PlayerController>();
        IJump jump = Substitute.For<IJump>();
        controller.Initialize(jump);

        // ACT
        controller.JumpControlActivated();

        // ASSERT
        jump.Received().Jump();
    }

    // Test player position.y for jumping (try without scene but issue with PlayerController.PlayerMovement l.17)
    [UnityTest]
    public IEnumerator test_player_jump_Jumping_goes_up()
    {
        // ARRANGE
        SceneManager.LoadScene("Scenes/GameScene"); // scene added to "Scenes in build" can be call with 0
        yield return new WaitForSeconds(1.0f); // have to wait for loading
        GameObject playerInScene = GameObject.Find("Player");
        PlayerJump playerJump = playerInScene.GetComponentInChildren<PlayerJump>();
        Rigidbody rb = playerInScene.GetComponent<Rigidbody>();

        // ACT
        playerJump.Jump();
        yield return new WaitForSeconds(0.2f); // have to wait for mechanics update

        // ASSERT
        Assert.IsTrue(rb.velocity.y > 0);
        Assert.IsTrue(rb.position.y > 0.5f);
        yield return null;
    }
}
