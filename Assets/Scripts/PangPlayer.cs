using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PangPlayer : MonoBehaviour
{
    public enum STATE
    {
        IDLE,
        MOVE,
        HITTED,
    }

    [SerializeField]
    private Sprite[] idleSprites;

    [SerializeField]
    private Sprite[] WalkSprites;

    private STATE _currentState;

    private float _speed = 3;
    void Awake()
    {
        Debug.Log("PangPlayerCreated");
        _currentState = STATE.IDLE;
    }

    private void IDLE_Action()
    {

    }

    private void MOVE_Action()
    {
        Debug.Log()
    }
    private void HITTED_Action()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch(_currentState)
        {
            case STATE.IDLE:
                IDLE_Action();
                break;
            case STATE.MOVE:
                Move_Action();
                break;
            case STATE.HITTED();
                break;
        }

        if(Input.GetMouseButtonDown(0))
        {
            _currentState = STATE.MOVE;
        }

        if (Input.GetMouseButtonDown(1))
        {
            _currentState = STATE.HITTED;
        }
    }
}
