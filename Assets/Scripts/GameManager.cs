using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Button _startButton;

    [SerializeField]
    private Transform _canvasTrens;
   
    void Start()
    {
        _startButton.onClick.AddListener(OnClickStartButton);
    }

    private void OnClickStartButton()
    {
        _startButton.gameObject.SetActive(false);

        Debug.Log("OnClickStartButton");


        GameObject resGO = Resources.Load<GameObject>("Prefab/ModeUI");
        Debug.Log("resGO : " + resGO);

        Instantiate(resGO,  _canvasTrens, false);

        GameObject sceanGO = Instantiate(resGO, _canvasTrens);
        ModeUI uiComp = sceanGO.GetComponent<ModeUI>();
        uiComp.AddTimeClickEvent("OnClickTimeAttackMode");
        uiComp.AddStageClickEvent("OnClickStageMode");
    }

    private void OnClickTimeAttackMode()
    {
        Debug.Log("OnClickTimeAtackMode");

    }
    private void OnClickStageMode()
    {

    }
    private IEnumerator LoadSceneAsync(string sceneName)
    {
        yield return SceneManager.LoadSceneAsync(sceneName);

        GameObject resGO = Resources.Load<GameObject>("Prefab/PangPlayer");
        Instantiate
    }
}
