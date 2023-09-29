using NUnit.Framework;
using UnityEngine;

public class TestFood
{
    // Player prefab with "Player" tag
    [Test]
    public void TestPlayerTag()
    {
        // ARRANGE
        var goArray = GameObject.FindObjectsOfType<FoodCollectible>();

        // ACT

        // ASSERT
        Assert.IsTrue(goArray.Length > 0);
        TestContext.WriteLine($"{goArray.Length} food(s) found.");
    }
}
