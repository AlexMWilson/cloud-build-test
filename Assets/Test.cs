using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public static class Test
{
    public static void PreBuildTest()
    {
        EditorSceneManager.OpenScene(Path.Combine(Application.dataPath, "test.unity"), OpenSceneMode.Single);
        GameObject.Find("Text").GetComponent<Text>().text = "Hello";
        EditorSceneManager.SaveOpenScenes();
    }
}
  