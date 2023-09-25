using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

// Impossible de sauter
// Comportement attendu:
// Lorsque l'on appuie sur la barre espace du clavier, le personnage joueur est censé pouvoir sauter.
// Comportement actuel :
// Le joueur ne saute pas en appuyant sur la touche correspondante.

public class test_player_jump
{
    // A Test behaves as an ordinary method
    [Test]
    public void test_player_jumpSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator test_player_jumpWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
