using UnityEngine;

public class UIManager : MonoSingletone<UIManager>
{
    private Transform _canvasTrasn; 

    private void Awake()
    {
        _canvasTrasn = transform;
    }

    public void CreateStartUI()
    {
        // ModeUI �������� ���ҽ��� �ε��ؼ�, Instantiate�Ѵ�. 
        GameObject resGO = Resources.Load<GameObject>("Prefab/StartUI");
        GameObject sceanGO = Instantiate(resGO, _canvasTrasn, false);
        
    }

    //��� UI����� �ڵ带 �ۼ��ؼ� StartUI��ư�� ��������
    // ȣ���غ��� 

    public void CreateModeUI()
    {
        // ���ӸŴ����� ModUI������ְ� �־��µ� 
        GameObject resGO = Resources.Load<GameObject>("Prefab/ModeUI");       

        GameObject sceanGO = Instantiate(resGO, _canvasTrasn, false);
        ModeUI uiComp = sceanGO.GetComponent<ModeUI>();
    }


}
