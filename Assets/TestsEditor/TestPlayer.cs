using NUnit.Framework;
using UnityEditor;
using UnityEngine;

public class TestPlayer
{
    // Player prefab with "Player" tag
    [Test]
    public void TestPlayerTag()
    {
        // ARRANGE
        // GameObject player = MonoBehaviour.Instantiate(Resources.Load<GameObject>("/Assets/Prefabs/Player")); // not in Resources folder
        GameObject player = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/Player.prefab");

        // ACT
        int result = string.Compare(player.tag, "Player");

        // ASSERT
        Assert.That<int>(result, Is.EqualTo(0));
        TestContext.WriteLine($"Comparaison result: {result}.");
    }
}
