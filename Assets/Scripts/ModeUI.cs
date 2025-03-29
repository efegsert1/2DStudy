using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ModeUI : MonoBehaviour
{
    [SerializeField]
    Button _timeAttackButton;

    [SerializeField]
    Button _stageModeButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        _timeAttackButton.onClick.AddListener(OnclickTimeAttackMode);
        _stageModeButton.onClick.AddListener(OnclickStageMode);
    }

    private void OnclickTimeAttackMode()
    {
        Debug.Log("OnclickTimeAttackMode");
        SceneManager.LoadScene("GameScene");
    }

    private void OnclickStageMode()
    {

    }
}
