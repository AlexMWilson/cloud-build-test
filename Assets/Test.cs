using System.IO;
using UnityEditor.SceneManagement;
using UnityEngine;

public static class Test
{
    public static void PreBuildTest()
    {
        int x = 1;
        x = 2;
        // EditorSceneManager.OpenScene(Path.Combine(Application.dataPath, "test.unity"), OpenSceneMode.Single);
        // GameObject.Find("Text").GetComponent<Text>().text = "Hello";
        // EditorSceneManager.SaveOpenScenes();
    }
}
  