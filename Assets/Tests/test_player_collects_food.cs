using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

// Les aliments ne sont pas ramassés
// Comportement attendu:
// Lorsque le joueur marche sur un des aliments, celui-ci doit disparaître et le score doit être modifié en fonction.
// Comportement actuel?:
// Lorsque le joueur marche sur un des aliments, rien ne se passe.

public class test_player_collects_food
{
    // Player falls to apple score + 20.
    [UnityTest]
    public IEnumerator test_player_collects_foodWithEnumeratorPasses()
    {
        // ARRANGE
        SceneManager.LoadScene("Scenes/TestingSimpleScene");
        yield return null; // wait first frame
        FoodCollectible[] result = GameObject.FindObjectsOfType<FoodCollectible>();

        // ACT
        yield return new WaitForSeconds(2.2f); // player falls on food (apple)
        FoodCollectible[] result2 = GameObject.FindObjectsOfType<FoodCollectible>();
        yield return null;

        // ASSERT
        TestContext.WriteLine($"Food is visible. Scene starts. {result[0].isActiveAndEnabled}.");
        Assert.IsTrue(result[0].isActiveAndEnabled);
        
        TestContext.WriteLine($"Food must be eat, not visible. Player is on it. {result2[0].isActiveAndEnabled}.");
        Assert.IsFalse(result2[0].isActiveAndEnabled);
    }
}
