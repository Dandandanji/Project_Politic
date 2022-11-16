using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public enum Scene
    {
        MainScene,
        BattleScene,
    }

    [SerializeField] private Scene _currentScene = Scene.MainScene;

    public void SceneChange(Scene nextName)
    {
        string next = "Scenes/" + nextName.ToString();
        StartCoroutine(WaitForSceneChange(next));
        _currentScene = nextName;
    }

    IEnumerator WaitForSceneChange(string next)
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(next);
    }

    // �ӽ÷� �Ѿ�� ��ư�� ���
    public void OnclickButton()
    {
        SceneChange(Scene.BattleScene);
    }
}
