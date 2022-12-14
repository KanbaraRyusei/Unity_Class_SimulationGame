using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBase : MonoBehaviour, IDamage
{
    public Vector2 MyPosition => _myPosition;
    public int HP => _hp;
    public bool WasMove => _wasMove;

    [SerializeField]
    [Header("動ける歩数")]
    int _moveNum = 3;

    [SerializeField]
    [Header("最初に沸く位置")]
    Vector2 _startPosition;

    [SerializeField]
    [Header("HP")]
    int _hp;

    [SerializeField]
    [Header("攻撃力")]
    int _power;

    Vector2 _myPosition;
    bool _wasMove = false;

    private void Start()
    {
        _myPosition = _startPosition;
    }

    public virtual void Move()
    {
        _wasMove = true;
        //gameObject.transform.position = 
    }

    public void StartMyTurn()
    {
        _wasMove = false;
    }

    public void OnDamage(int damage)
    {
        _hp -= damage;
        if(_hp <= 0)
        {
            Debug.Log("Die");
        }
    }
}
